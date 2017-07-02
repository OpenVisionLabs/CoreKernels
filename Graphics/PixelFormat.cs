using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKernels.Graphics
{
    public enum PixelFormat
    {
        Unknown,
        RGB24 = 1,
        BGR24 = 2,
        ARGB32 = 3,
        BGRA32 = 4,
        RGB48U = 5,
        BGR48U = 6,
        RGB48H = 7,
        BGR48H = 8,
        RGBA64U = 9,
        BGRA64U = 10,
        RGBA64H = 11,
        BGRA64H = 12,
        RGB96F = 13,
        BGR96F = 14,
        RGBA128 = 15,
        BGRA128 = 16
    }
}
