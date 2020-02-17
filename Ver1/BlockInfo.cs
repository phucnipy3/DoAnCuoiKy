//Người viết Nguyễn Huỳnh Phúc
//Ngày viết: 29/11/2018
//Chỉnh sửa lần cuối 10:00 PM 22/12/2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ver1
{
    public static class BlockInfo
    {
        // Thuộc tính
        public const int NUMMAX = 10;
        public static int KindMax = 28;
        public static int SmallSize = 20;
        public static int BigSize = 40;
        public static int NumColors = 12;
        public static Point Center = new Point(50, 50);
        public static Color[] Colors = new Color[12] {Color.FromArgb(255, 0, 0), Color.FromArgb(0, 255, 0), Color.FromArgb(0,0,255),
        Color.FromArgb(255, 0, 180),Color.FromArgb(180, 0, 255),Color.FromArgb( 0, 240,255),Color.FromArgb(222, 255, 0),Color.FromArgb(255, 150, 0),
        Color.FromArgb(0,91,150),Color.FromArgb(237,2,11),Color.FromArgb(244,101,40),Color.FromArgb(255,202,43)};
        public static int[,] ArrayX = new int[,] {{0,0,1,0}, {0,0,1,0}, {0,1,1,0}, {0,1,1,0}, {0,0,1,1}, {0,1,2,3}, {0,0,0,0}, {0,0,0,1}, {0,0,0,1}, {0,1,1,1}, {0,1,1,1}, {0,0,1,2}, {2,0,1,2}, {0,1,2,2}, {0,1,2,0}, {0,0,1,1}, {1,1,0,0}, {0,1,1,2}, {1,2,0,1},{0,1,1,1},{0,1,1,2},{0,1,1,2},{0,0,0,1},{0,0,0,0},{0,0,0,0},{0,1,0,0},{0,0,0,0},{0,1,2,0}};
        public static int[,] ArrayY = new int[,] {{0,1,1,0}, {0,1,0,0}, {0,0,1,0}, {1,0,1,0}, {0,1,0,1}, {0,0,0,0}, {0,1,2,3}, {0,1,2,2}, {0,1,2,0}, {0,0,1,2}, {2,0,1,2}, {0,1,1,1}, {0,1,1,1}, {0,0,0,1}, {0,0,0,1}, {0,1,1,2}, {0,1,1,2}, {0,0,1,1}, {0,0,1,1},{1,0,1,2},{0,0,1,0},{1,0,1,1},{0,1,2,1},{0,0,0,0},{0,1,0,0},{0,0,0,0},{0,1,2,0},{0,0,0,0}};
        public static int[] ArrayCount = new int[] { 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 1, 2, 2, 3, 3 };
        //Phương thức
        // lấy ra thông tin của 1 Block theo index truyền vào
        public static Color GetColor(int x)
        {
            return Colors[x];
        }
        public static void GetBlock(int index, out int[] X, out int[] Y, out int count)
        {
            count = ArrayCount[index];

            X = new int[count];
            Y = new int[count];

            for (int i = 0; i < count; i++)
            {
                X[i] = ArrayX[index, i];
                Y[i] = ArrayY[index, i];
            }
            count = ArrayCount[index];
        }
        // lấy ra vị trí nên đặt của một Block bất kì
        public static Point GetLocation(int index)
        {
            int count;
            int[] X;
            int[] Y;
            GetBlock(index, out X, out Y, out count);
            int x = Max(X, count);
            int y = Max(Y, count);
            int width = SmallSize * (x + 1);
            int height = SmallSize * (y + 1);
            return new Point(Center.X - width / 2, Center.Y - height / 2);
            //switch (index)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4: return new Point(30, 30);
            //    case 5: return new Point(10, 40);
            //    case 6: return new Point(40, 10);
            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10:
            //    case 15:
            //    case 16: return new Point(30, 20);
            //    case 11:
            //    case 12:
            //    case 13:
            //    case 14:
            //    case 17:
            //    case 18: return new Point(20, 30);
            //}
            //return new Point(0, 0);
        }
        public static int Max(int[] A,int n)
        {
            int max = A[0];
            for (int i = 1; i < n; i++)
                if (A[i] > max)
                    max = A[i];
            return max;
        }
    }
}
