using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpriteSheetMaker {
    public class Sprite {
        public Bitmap Bitmap { get; set; }
        public int PattX {get;set;}
        public int PattY { get; set; }
        public int PattZ { get; set; }
        public int Frame { get; set; }
        public int Layer { get; set; }
        public uint Index { get; internal set; }

        public Sprite() {

        }

        public uint GetTextureIndex() {
            return (uint)((((Layer * Core.PatternZ + PattZ)
                                 * Core.PatternY + PattY)
                                * Core.PatternX + PattX)
                               * Core.Frames + Frame - 1);
        }
    }
}
