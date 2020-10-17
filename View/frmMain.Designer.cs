namespace SpriteSheetMaker {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pboxSpriteSheet = new System.Windows.Forms.PictureBox();
            this.nupPatternX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupPatternY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nupFrames = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nupWidth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nupHeight = new System.Windows.Forms.NumericUpDown();
            this.panelSpriteSheet = new System.Windows.Forms.Panel();
            this.panelSpriteList = new System.Windows.Forms.Panel();
            this.lviewSpriteList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListSprites = new System.Windows.Forms.ImageList(this.components);
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnLoadSprites = new System.Windows.Forms.Button();
            this.btnClearSprites = new System.Windows.Forms.Button();
            this.chboxSpriteIsLayer = new System.Windows.Forms.CheckBox();
            this.nupSpriteHeight = new System.Windows.Forms.NumericUpDown();
            this.nupSpriteWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.chboxSpriteIsMount = new System.Windows.Forms.CheckBox();
            this.chboxSpriteIsNorth = new System.Windows.Forms.CheckBox();
            this.nupSpriteFrame = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nupSpriteAddon = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chboxMasks = new System.Windows.Forms.CheckBox();
            this.chboxMount = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpriteSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatternX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatternY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFrames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).BeginInit();
            this.panelSpriteSheet.SuspendLayout();
            this.panelSpriteList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteAddon)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxSpriteSheet
            // 
            this.pboxSpriteSheet.BackColor = System.Drawing.Color.Transparent;
            this.pboxSpriteSheet.Location = new System.Drawing.Point(0, 0);
            this.pboxSpriteSheet.Name = "pboxSpriteSheet";
            this.pboxSpriteSheet.Size = new System.Drawing.Size(381, 426);
            this.pboxSpriteSheet.TabIndex = 0;
            this.pboxSpriteSheet.TabStop = false;
            this.pboxSpriteSheet.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxSpriteSheet_Paint);
            // 
            // nupPatternX
            // 
            this.nupPatternX.Location = new System.Drawing.Point(60, 12);
            this.nupPatternX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPatternX.Name = "nupPatternX";
            this.nupPatternX.Size = new System.Drawing.Size(56, 20);
            this.nupPatternX.TabIndex = 1;
            this.nupPatternX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Addons";
            // 
            // nupPatternY
            // 
            this.nupPatternY.Location = new System.Drawing.Point(60, 38);
            this.nupPatternY.Name = "nupPatternY";
            this.nupPatternY.Size = new System.Drawing.Size(56, 20);
            this.nupPatternY.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Frames";
            // 
            // nupFrames
            // 
            this.nupFrames.Location = new System.Drawing.Point(60, 64);
            this.nupFrames.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFrames.Name = "nupFrames";
            this.nupFrames.Size = new System.Drawing.Size(56, 20);
            this.nupFrames.TabIndex = 7;
            this.nupFrames.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 194);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Width";
            // 
            // nupWidth
            // 
            this.nupWidth.Location = new System.Drawing.Point(60, 90);
            this.nupWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupWidth.Name = "nupWidth";
            this.nupWidth.Size = new System.Drawing.Size(56, 20);
            this.nupWidth.TabIndex = 12;
            this.nupWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Height";
            // 
            // nupHeight
            // 
            this.nupHeight.Location = new System.Drawing.Point(60, 116);
            this.nupHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupHeight.Name = "nupHeight";
            this.nupHeight.Size = new System.Drawing.Size(56, 20);
            this.nupHeight.TabIndex = 14;
            this.nupHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelSpriteSheet
            // 
            this.panelSpriteSheet.BackColor = System.Drawing.Color.White;
            this.panelSpriteSheet.Controls.Add(this.pboxSpriteSheet);
            this.panelSpriteSheet.Location = new System.Drawing.Point(122, 12);
            this.panelSpriteSheet.Name = "panelSpriteSheet";
            this.panelSpriteSheet.Size = new System.Drawing.Size(381, 426);
            this.panelSpriteSheet.TabIndex = 16;
            // 
            // panelSpriteList
            // 
            this.panelSpriteList.BackColor = System.Drawing.Color.Transparent;
            this.panelSpriteList.Controls.Add(this.lviewSpriteList);
            this.panelSpriteList.Location = new System.Drawing.Point(509, 10);
            this.panelSpriteList.Name = "panelSpriteList";
            this.panelSpriteList.Size = new System.Drawing.Size(401, 426);
            this.panelSpriteList.TabIndex = 17;
            // 
            // lviewSpriteList
            // 
            this.lviewSpriteList.BackColor = System.Drawing.SystemColors.Control;
            this.lviewSpriteList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lviewSpriteList.HideSelection = false;
            this.lviewSpriteList.LargeImageList = this.imgListSprites;
            this.lviewSpriteList.Location = new System.Drawing.Point(0, 0);
            this.lviewSpriteList.MultiSelect = false;
            this.lviewSpriteList.Name = "lviewSpriteList";
            this.lviewSpriteList.Size = new System.Drawing.Size(401, 426);
            this.lviewSpriteList.TabIndex = 0;
            this.lviewSpriteList.UseCompatibleStateImageBehavior = false;
            this.lviewSpriteList.SelectedIndexChanged += new System.EventHandler(this.lviewSpriteList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sprite";
            // 
            // imgListSprites
            // 
            this.imgListSprites.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListSprites.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListSprites.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(9, 223);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(107, 23);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnLoadSprites
            // 
            this.btnLoadSprites.Location = new System.Drawing.Point(690, 442);
            this.btnLoadSprites.Name = "btnLoadSprites";
            this.btnLoadSprites.Size = new System.Drawing.Size(107, 23);
            this.btnLoadSprites.TabIndex = 19;
            this.btnLoadSprites.Text = "Load";
            this.btnLoadSprites.UseVisualStyleBackColor = true;
            this.btnLoadSprites.Click += new System.EventHandler(this.btnLoadSprites_Click);
            // 
            // btnClearSprites
            // 
            this.btnClearSprites.Location = new System.Drawing.Point(803, 442);
            this.btnClearSprites.Name = "btnClearSprites";
            this.btnClearSprites.Size = new System.Drawing.Size(107, 23);
            this.btnClearSprites.TabIndex = 20;
            this.btnClearSprites.Text = "Clear";
            this.btnClearSprites.UseVisualStyleBackColor = true;
            this.btnClearSprites.Click += new System.EventHandler(this.btnClearSprites_Click);
            // 
            // chboxSpriteIsLayer
            // 
            this.chboxSpriteIsLayer.AutoSize = true;
            this.chboxSpriteIsLayer.Location = new System.Drawing.Point(919, 14);
            this.chboxSpriteIsLayer.Name = "chboxSpriteIsLayer";
            this.chboxSpriteIsLayer.Size = new System.Drawing.Size(52, 17);
            this.chboxSpriteIsLayer.TabIndex = 21;
            this.chboxSpriteIsLayer.Text = "Layer";
            this.chboxSpriteIsLayer.UseVisualStyleBackColor = true;
            // 
            // nupSpriteHeight
            // 
            this.nupSpriteHeight.Enabled = false;
            this.nupSpriteHeight.Location = new System.Drawing.Point(958, 420);
            this.nupSpriteHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSpriteHeight.Name = "nupSpriteHeight";
            this.nupSpriteHeight.Size = new System.Drawing.Size(56, 20);
            this.nupSpriteHeight.TabIndex = 23;
            this.nupSpriteHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupSpriteWidth
            // 
            this.nupSpriteWidth.Enabled = false;
            this.nupSpriteWidth.Location = new System.Drawing.Point(957, 393);
            this.nupSpriteWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSpriteWidth.Name = "nupSpriteWidth";
            this.nupSpriteWidth.Size = new System.Drawing.Size(56, 20);
            this.nupSpriteWidth.TabIndex = 22;
            this.nupSpriteWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(916, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(916, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Width";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(916, 132);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(107, 23);
            this.btnApply.TabIndex = 34;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chboxSpriteIsMount
            // 
            this.chboxSpriteIsMount.AutoSize = true;
            this.chboxSpriteIsMount.Location = new System.Drawing.Point(919, 37);
            this.chboxSpriteIsMount.Name = "chboxSpriteIsMount";
            this.chboxSpriteIsMount.Size = new System.Drawing.Size(56, 17);
            this.chboxSpriteIsMount.TabIndex = 36;
            this.chboxSpriteIsMount.Text = "Mount";
            this.chboxSpriteIsMount.UseVisualStyleBackColor = true;
            // 
            // chboxSpriteIsNorth
            // 
            this.chboxSpriteIsNorth.AutoSize = true;
            this.chboxSpriteIsNorth.Location = new System.Drawing.Point(919, 60);
            this.chboxSpriteIsNorth.Name = "chboxSpriteIsNorth";
            this.chboxSpriteIsNorth.Size = new System.Drawing.Size(52, 17);
            this.chboxSpriteIsNorth.TabIndex = 37;
            this.chboxSpriteIsNorth.Text = "North";
            this.chboxSpriteIsNorth.UseVisualStyleBackColor = true;
            // 
            // nupSpriteFrame
            // 
            this.nupSpriteFrame.Location = new System.Drawing.Point(966, 105);
            this.nupSpriteFrame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSpriteFrame.Name = "nupSpriteFrame";
            this.nupSpriteFrame.Size = new System.Drawing.Size(56, 20);
            this.nupSpriteFrame.TabIndex = 38;
            this.nupSpriteFrame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(916, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Frame";
            // 
            // nupSpriteAddon
            // 
            this.nupSpriteAddon.Location = new System.Drawing.Point(966, 79);
            this.nupSpriteAddon.Name = "nupSpriteAddon";
            this.nupSpriteAddon.Size = new System.Drawing.Size(56, 20);
            this.nupSpriteAddon.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(916, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Addon";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chboxMasks
            // 
            this.chboxMasks.AutoSize = true;
            this.chboxMasks.Location = new System.Drawing.Point(59, 142);
            this.chboxMasks.Name = "chboxMasks";
            this.chboxMasks.Size = new System.Drawing.Size(57, 17);
            this.chboxMasks.TabIndex = 43;
            this.chboxMasks.Text = "Masks";
            this.chboxMasks.UseVisualStyleBackColor = true;
            // 
            // chboxMount
            // 
            this.chboxMount.AutoSize = true;
            this.chboxMount.Location = new System.Drawing.Point(59, 165);
            this.chboxMount.Name = "chboxMount";
            this.chboxMount.Size = new System.Drawing.Size(56, 17);
            this.chboxMount.TabIndex = 44;
            this.chboxMount.Text = "Mount";
            this.chboxMount.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 482);
            this.Controls.Add(this.chboxMount);
            this.Controls.Add(this.chboxMasks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nupSpriteAddon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nupSpriteFrame);
            this.Controls.Add(this.chboxSpriteIsNorth);
            this.Controls.Add(this.chboxSpriteIsMount);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nupSpriteHeight);
            this.Controls.Add(this.nupSpriteWidth);
            this.Controls.Add(this.chboxSpriteIsLayer);
            this.Controls.Add(this.btnClearSprites);
            this.Controls.Add(this.btnLoadSprites);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panelSpriteSheet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nupWidth);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nupFrames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupPatternY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupPatternX);
            this.Controls.Add(this.panelSpriteList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "SpriteSheetMaker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSpriteSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatternX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatternY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFrames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).EndInit();
            this.panelSpriteSheet.ResumeLayout(false);
            this.panelSpriteList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSpriteAddon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxSpriteSheet;
        private System.Windows.Forms.NumericUpDown nupPatternX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupPatternY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupFrames;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nupHeight;
        private System.Windows.Forms.Panel panelSpriteSheet;
        private System.Windows.Forms.Panel panelSpriteList;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoadSprites;
        private System.Windows.Forms.Button btnClearSprites;
        private System.Windows.Forms.ListView lviewSpriteList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imgListSprites;
        private System.Windows.Forms.CheckBox chboxSpriteIsLayer;
        private System.Windows.Forms.NumericUpDown nupSpriteHeight;
        private System.Windows.Forms.NumericUpDown nupSpriteWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chboxSpriteIsMount;
        private System.Windows.Forms.CheckBox chboxSpriteIsNorth;
        private System.Windows.Forms.NumericUpDown nupSpriteFrame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupSpriteAddon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chboxMasks;
        private System.Windows.Forms.CheckBox chboxMount;
    }
}

