using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreKernels.Graphics
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel3B
    {
        [FieldOffset(0)]
        public fixed byte Data[3];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel4B
    {
        [FieldOffset(0)]
        public fixed byte Data[4];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel3U
    {
        [FieldOffset(0)]
        public fixed ushort Data[3];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel4U
    {
        [FieldOffset(0)]
        public fixed ushort Data[4];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel3H
    {
        [FieldOffset(0)]
        public fixed ushort Data[3];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel4H
    {
        [FieldOffset(0)]
        public fixed ushort Data[4];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel3F
    {
        [FieldOffset(0)]
        public fixed float Data[3];
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Pixel4F
    {
        [FieldOffset(0)]
        public fixed float Data[4];
    }
}
