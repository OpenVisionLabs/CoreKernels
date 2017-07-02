using System;
using System.Runtime.InteropServices;
using CoreKernels.Graphics;
using Xunit;

namespace Graphics.Tests
{
    public class ColorSpaceTests
    {
        private unsafe void GenerateRandomBuffer(IntPtr buffer, int length)
        {
            Random rnd = new Random(DateTime.UtcNow.Ticks.GetHashCode());
            int index = length / 4;
            int reminder = length % 4;
            int* pBuffer = (int*)buffer;
            for(int i = 0; i < index; i++)
                pBuffer[i] = rnd.Next();

            if (reminder > 0)
            {
                byte* pbBuffer = (byte*)buffer;
                for (int i = length - reminder; i < length; i++)
                    pbBuffer[i] = (byte) rnd.Next(0, 255);
            }
        }

        [Fact]
        public void Rgb2YCbCr()
        {
            Pixel3B[] buffer = new Pixel3B[1920 * 1080];
            GCHandle hBuffer = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            IntPtr pBuffer = hBuffer.AddrOfPinnedObject();
            GenerateRandomBuffer(pBuffer, buffer.Length * Marshal.SizeOf<Pixel3B>());

            IntPtr result = ColorSpace.Rgb2YCbCr(pBuffer, PixelFormat.BGR24);

            if (hBuffer.IsAllocated)
                hBuffer.Free();
        }
    }
}
