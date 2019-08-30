// Building blocks
// https://www.codewars.com/kata/55b75fcf67e558d3750000a3

namespace codewars.com.Kata._7_kyu.Building_blocks
{
    class Block
    {
        private int width, length, height;

        public Block(int[] arr)
        {
            width = arr[0];
            length = arr[1];
            height = arr[2];
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetVolume()
        {
            return width * length * height;
        }

        public int GetSurfaceArea()
        {
            return (width * length + length * height + height * width) * 2;
        }
    }
}