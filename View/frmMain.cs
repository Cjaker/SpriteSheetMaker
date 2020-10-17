using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SpriteSheetMaker {
    public partial class frmMain : Form {
        private List<SpriteImage> sprites = new List<SpriteImage>();
        private Sprite[] spritesToDraw = null;
        private Bitmap bitmapSpriteSheet;

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            panelSpriteSheet.AutoScroll = true;
            panelSpriteList.AutoScroll = true;
            pboxSpriteSheet.SizeMode = PictureBoxSizeMode.AutoSize;

            if (!Directory.Exists(Environment.CurrentDirectory + "\\input"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\input");
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Refresh();

            // generate if have something
            GenerateSpriteSheet();
        }

        private void InitializeSpriteSheet(bool initializeArray = true) {
            var layers = ((chboxMasks.Checked) ? 2 : 1);
            var patternZ = ((chboxMount.Checked) ? 2 : 1);
            var addons = nupPatternY.Value + 1;
            var totalX = patternZ * nupPatternX.Value * layers;
            var totalY = nupFrames.Value * addons;
            var bitmapWidth = (totalX * nupWidth.Value) * Const.SpriteSize;
            var bitmapHeight = (totalY * nupHeight.Value) * Const.SpriteSize;

            if (initializeArray) {
                uint totalSprites = (uint)(layers * nupPatternX.Value * addons * patternZ *
                                       nupFrames.Value);

                spritesToDraw = new Sprite[totalSprites];
                bitmapSpriteSheet = new Bitmap((int)bitmapWidth, (int)bitmapHeight);
            }

            pboxSpriteSheet.Size = new Size((int)bitmapWidth + 1, (int)bitmapHeight + 1);
            pboxSpriteSheet.Invalidate();
        }

        private void Refresh() {
            var addons = nupPatternY.Value + 1;
            Core.RefreshPendent = false;
            Core.PatternX = (int)nupPatternX.Value;
            Core.PatternY = (int)addons;
            Core.PatternZ = (int)((chboxMount.Checked) ? 2 : 1);
            Core.Layers = (int)((chboxMasks.Checked) ? 2 : 1);
            Core.Frames = (int)nupFrames.Value;

            InitializeSpriteSheet();
        }

        private void Clear() {
            sprites.Clear();
            spritesToDraw = null;
            imgListSprites.Images.Clear();
            lviewSpriteList.Clear();
            Refresh();
        }

        private bool HasSpriteToDraw() {
            if (spritesToDraw == null)
                return false;

            if (spritesToDraw.Length == 0)
                return false;

            foreach (Sprite sprite in spritesToDraw) {
                if (sprite != null)
                    return true;
            }

            return false;
        }

        private void GenerateSpriteSheet() {
            if (Core.RefreshPendent) {
                MessageBox.Show(null, "Defina as propriedades do spritesheet antes de gerar!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (SpriteImage sprite in sprites) {
                if (!sprite.IsReady)
                    continue;

                if (sprite.IsNorth) { // rotate to west
                    // add north without changes
                    Sprite newSprite = new Sprite();
                    newSprite.Bitmap = sprite.Bitmap;
                    newSprite.Frame = sprite.Frame;
                    newSprite.PattX = (int)Enums.Directions.NORTH;
                    newSprite.PattY = (int)sprite.Addon;
                    newSprite.PattZ = (int)(sprite.IsMount ? 1 : 0);
                    newSprite.Layer = (int)(sprite.IsLayer ? 1 : 0);
                    newSprite.Index = newSprite.GetTextureIndex();
                    spritesToDraw[newSprite.Index] = newSprite;

                    // now rotate north to 90º and flip X
                    Bitmap rotatedBitmap = CopyBitmap(newSprite.Bitmap);
                    rotatedBitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                    newSprite = new Sprite();
                    newSprite.Bitmap = rotatedBitmap;
                    newSprite.Frame = sprite.Frame;
                    newSprite.PattX = (int)Enums.Directions.WEST;
                    newSprite.PattY = (int)sprite.Addon;
                    newSprite.PattZ = (int)(sprite.IsMount ? 1 : 0);
                    newSprite.Layer = (int)(sprite.IsLayer ? 1 : 0);
                    newSprite.Index = newSprite.GetTextureIndex();
                    spritesToDraw[newSprite.Index] = newSprite;
                } else { // rotate to east
                    // add south without changes
                    Sprite newSprite = new Sprite();
                    newSprite.Bitmap = sprite.Bitmap;
                    newSprite.Frame = sprite.Frame;
                    newSprite.PattX = (int)Enums.Directions.SOUTH;
                    newSprite.PattY = (int)sprite.Addon;
                    newSprite.PattZ = (int)(sprite.IsMount ? 1 : 0);
                    newSprite.Layer = (int)(sprite.IsLayer ? 1 : 0);
                    newSprite.Index = newSprite.GetTextureIndex();
                    spritesToDraw[newSprite.Index] = newSprite;

                    // now rotate south to 90º and flip X
                    Bitmap rotatedBitmap = CopyBitmap(newSprite.Bitmap);
                    rotatedBitmap.RotateFlip(RotateFlipType.Rotate90FlipX);
                    newSprite = new Sprite();
                    newSprite.Bitmap = rotatedBitmap;
                    newSprite.Frame = sprite.Frame;
                    newSprite.PattX = (int)Enums.Directions.EAST;
                    newSprite.PattY = (int)sprite.Addon;
                    newSprite.PattZ = (int)(sprite.IsMount ? 1 : 0);
                    newSprite.Layer = (int)(sprite.IsLayer ? 1 : 0);
                    newSprite.Index = newSprite.GetTextureIndex();
                    spritesToDraw[newSprite.Index] = newSprite;
                }
            }

            // refresh spritesheet image
            pboxSpriteSheet.Invalidate();
        }

        // draw spritesheet sprites / grid
        private void pboxSpriteSheet_Paint(object sender, PaintEventArgs e) {
            var addons = nupPatternY.Value + 1;
            var totalX = ((chboxMount.Checked) ? 2 : 1) * nupPatternX.Value * ((chboxMasks.Checked) ? 2 : 1);
            var totalY = nupFrames.Value * addons;
            int cellXSize = (int)(nupWidth.Value * Const.SpriteSize);
            int cellYSize = (int)(nupHeight.Value * Const.SpriteSize);

            Pen p = new Pen(Color.Black);
            Graphics g = e.Graphics;
            int indexSpriteSheet = 0;
            if (HasSpriteToDraw()) {
                for (int f = 0; f < Core.Frames; f++) {
                    for (int z = 0; z < Core.PatternZ; z++) {
                        for (int y = 0; y < Core.PatternY; y++) {
                            for (int x = 0; x < Core.PatternX; x++) {
                                for (int l = 0; l < Core.Layers; l++) {
                                    uint index = Core.GetTextureIndex(l, x, y, z, f);
                                    int fx = (int)((indexSpriteSheet % totalX) * cellXSize);
                                    int fy = (int)(Math.Floor(indexSpriteSheet / totalX) * cellYSize);
                                    int indexX = (int)(indexSpriteSheet % totalX);
                                    int indexY = (int)(indexSpriteSheet / totalX);
                                    indexSpriteSheet++;
                                    
                                    g.DrawRectangle(p, new Rectangle(fx, fy, cellXSize, cellYSize));
                                    if (spritesToDraw[index] == null) {
                                        
                                        SizeF fontSize = g.MeasureString(indexX + ":" + indexY, DefaultFont);
                                        g.DrawString(indexX + ":" + indexY, DefaultFont, Brushes.Black, fx + (cellXSize / 2) - fontSize.Width / 2,
                                            fy + (cellYSize / 2) - fontSize.Height / 2);
                                        continue;
                                    }

                                    Point toPoint = new Point(fx, fy);
                                    Graphics graphics = Graphics.FromImage(bitmapSpriteSheet);
                                    graphics.DrawImage(spritesToDraw[index].Bitmap, toPoint);
                                    g.DrawImage(spritesToDraw[index].Bitmap, toPoint);
                                }
                            }
                        }
                    }
                }

                return;
            }

            for (int y = 0; y < totalY; y++) {
                for (int x = 0; x < totalX; x++) {
                    int xLocation = x * cellXSize;
                    int yLocation = y * cellYSize;
                    SizeF fontSize = g.MeasureString(x + ":" + y, DefaultFont);
                    g.DrawString(x + ":" + y, DefaultFont, Brushes.Black, xLocation + (cellXSize / 2) - fontSize.Width/2, 
                        yLocation + (cellYSize / 2) - fontSize.Height / 2);
                    g.DrawRectangle(p, new Rectangle(xLocation, yLocation, cellXSize, cellYSize));
                }
            }
        }

        private void btnClearSprites_Click(object sender, EventArgs e) {
            Clear();
        }

        private void btnLoadSprites_Click(object sender, EventArgs e) {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\input")) {
                MessageBox.Show("Falha ao encontrar pasta input, crie uma e copie suas sprites pra pasta.");
                return;
            }

            Clear(); // clear before load

            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\input");
            Array.Sort(files, new AlphanumComparatorFast());
            int index = 0;
            foreach (string file in files) {
                // load sprite
                Bitmap bitmap = null;
                using (var fs = new System.IO.FileStream(file, System.IO.FileMode.Open)) {
                    bitmap = new Bitmap(fs);
                }

                if (sprites.Count == 0) {
                    nupSpriteWidth.Value = bitmap.Width / Const.SpriteSize;
                    nupSpriteHeight.Value = bitmap.Height / Const.SpriteSize;
                    nupWidth.Value = nupSpriteWidth.Value;
                    nupHeight.Value = nupSpriteHeight.Value;

                    InitializeSpriteSheet(false);

                    imgListSprites.ImageSize = new Size(bitmap.Width, bitmap.Height);
                }

                SpriteImage sprite = new SpriteImage();
                sprite.FileName = Path.GetFileName(file);
                sprite.Bitmap = bitmap;
                imgListSprites.Images.Add(bitmap);
                lviewSpriteList.Items.Add(new ListViewItem {
                    ImageIndex = index,
                    Text = index.ToString(),
                });

                index++;

                sprites.Add(sprite);
            }

            if (lviewSpriteList.Items.Count > 0)
                lviewSpriteList.Items[0].Selected = true;
        }

        private void lviewSpriteList_SelectedIndexChanged(object sender, EventArgs e) {
            if (lviewSpriteList.SelectedIndices.Count == 0)
                return;

            SpriteImage currentSprite = sprites[lviewSpriteList.SelectedIndices[0]];
            chboxSpriteIsLayer.Checked = currentSprite.IsLayer;
            nupSpriteAddon.Value = currentSprite.Addon;
            chboxSpriteIsNorth.Checked = currentSprite.IsNorth;
            chboxSpriteIsMount.Checked = currentSprite.IsMount;
            nupSpriteFrame.Value = currentSprite.Frame;
        }

        private void btnApply_Click(object sender, EventArgs e) {
            if (lviewSpriteList.SelectedIndices.Count == 0)
                return;

            int listSpriteListIndex = lviewSpriteList.SelectedIndices[0];
            SpriteImage currentSprite = sprites[lviewSpriteList.SelectedIndices[0]];
            currentSprite.IsLayer = chboxSpriteIsLayer.Checked;
            currentSprite.Addon = (int)nupSpriteAddon.Value;
            currentSprite.IsNorth = chboxSpriteIsNorth.Checked;
            currentSprite.IsMount = chboxSpriteIsMount.Checked;
            currentSprite.Frame = (int)nupSpriteFrame.Value;
            currentSprite.IsReady = true;
            GenerateSpriteSheet();

            // change to next index
            if (listSpriteListIndex + 1 >= lviewSpriteList.Items.Count)
                return;

            lviewSpriteList.Items[listSpriteListIndex + 1].Selected = true;
        }

        // custom method
        private Bitmap CopyBitmap(Bitmap originalBitmap) {
            Bitmap bitmapCopy = new Bitmap(originalBitmap.Width, originalBitmap.Height);
            for (int x = 0; x < originalBitmap.Width; x++) {
                for (int y = 0; y < originalBitmap.Height; y++) {
                    bitmapCopy.SetPixel(x, y, originalBitmap.GetPixel(x, y));
                }
            }

            return bitmapCopy;
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            GenerateSpriteSheet();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            bitmapSpriteSheet.Save("spritesheet.png", ImageFormat.Png);
            MessageBox.Show(null, "Spritesheet generated!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
