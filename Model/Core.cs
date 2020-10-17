using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpriteSheetMaker {
    public class Core {
        public static int PatternX { get; set; }
        public static int PatternY { get; set; }
        public static int PatternZ { get; set; }
        public static int Frames { get; set; }
        public static int Layers { get; set; }
        public static bool RefreshPendent { get; internal set; }

        public static uint GetTextureIndex(int l, int x, int y, int z, int frame) {
            return (uint)((((l * Core.PatternZ + z)
                                 * Core.PatternY + y)
                                * Core.PatternX + x)
                               * Core.Frames + frame);
        }
    }
}
