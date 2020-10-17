using System.Drawing;

namespace SpriteSheetMaker {
    public class SpriteImage {
        public Bitmap Bitmap { get; set; }
        public bool IsLayer { get; set; }
        public bool IsMount { get; set; }
        public int Frame { get; set; }
        public int Addon { get; set; }
        public bool IsNorth { get; set; }
        public string FileName { get; internal set; }
        public bool IsReady { get; set; }

        public SpriteImage() {
            IsLayer = IsMount = IsNorth = IsReady = false;
            Frame = 1;
            Addon = 0;
            Bitmap = null;
        }
    }
}
