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
    public class Block
    {
        //Thuộc tính
        private Point locationMatrix;
        private Point locationCursor;
        private Color color;
        private Size size;
        private int[] x;
        private int[] y;
        private int count;
        public static Random r = new Random();
        
        //Phương thức
        // Constructor
        public Block()
        {
            color = BlockInfo.GetColor(r.Next(BlockInfo.NumColors));
            size = new Size(BlockInfo.SmallSize, BlockInfo.SmallSize);
            int index = r.Next(BlockInfo.KindMax );
            BlockInfo.GetBlock(index, out x, out y, out count);
            locationCursor = BlockInfo.GetLocation(index);
            locationMatrix = new Point();
        }

        // Có chứa điểm p hay không
        public bool Contains(Point p)
        {
            for (int i = 0; i < count; i++)
            {
                if (SquareContains(new Point(size.Width * x[i] + LocationCursor.X, size.Height * y[i] + locationCursor.Y), size.Width, p))
                    return true;
            }
            return false;
        }
        // Thay đổi kích thước theo x
        public void ChangeSize(int x)
        {
            size = new Size(x, x);
        }
        // tính toán tọa độ trên ma trận theo tọa độ Cursor
        public void CalculateMatrixLocation()
        {
            locationMatrix.X = locationCursor.X / size.Width;
            locationMatrix.Y = locationCursor.Y / size.Height;

        }
        // tính toán tọa độ Cursor theo tọa độ trên ma trận
        public void CalculateCursorLocation()
        {
            locationCursor.X = locationMatrix.X * size.Width;
            locationCursor.Y = locationMatrix.Y * size.Height;
        }
        // vẽ đối tượng lên g, nếu đang di chuyển vẽ khác, đứng yên vẽ khác
        public void Show(bool isMove, Graphics g)
        {
            Point realLocation = new Point();
            if (isMove)
            {
                realLocation.X = locationCursor.X;
                realLocation.Y = locationCursor.Y;
            }
            else
            {
                realLocation.X = locationMatrix.X * size.Width;
                realLocation.Y = locationMatrix.Y * size.Height;
            }
            Pen p = new Pen(color);
            for (int i = 0; i < count; i++)
            {
                g.FillRectangle(p.Brush, realLocation.X + (x[i] * size.Width)+2, realLocation.Y + (y[i] * size.Height)+2, size.Width - 4, size.Height - 4);
                g.DrawImage(Ver1.Properties.Resources.square100, realLocation.X + (x[i] * size.Width), realLocation.Y + (y[i] * size.Height), size.Width, size.Height);
            }
        }
        // đối tượng có đặt vừa được vào 1 ví trí nào đó trên ma trận
        public bool isFit(int[,] matrix)
        {
            for (int i = 0; i < BlockInfo.NUMMAX; i++)
                for (int j = 0; j < BlockInfo.NUMMAX; j++)
                    if (canDrop(matrix, i, j))
                        return true;
            return false;
        }
        // đối tượng có thể đặt vào vị trí x,y trên ma trận
        private bool canDrop(int[,] matrix, int x, int y)
        {
            for (int i = 0; i < count; i++)
            {
                int matrixX = x + this.x[i];
                int matrixY = y + this.y[i];
                if (matrixX > BlockInfo.NUMMAX - 1 || matrixY > BlockInfo.NUMMAX - 1 || matrixX < 0 || matrixY < 0)
                    return false;
                if (matrix[matrixX, matrixY] != 0)
                    return false;
            }
            return true;
        }
        // đối tượng có thể đặt vào ma trận theo matrixLocation
        public bool canDrop(int[,] matrix)
        {
            return canDrop(matrix, locationMatrix.X, LocationMatrix.Y);
        }
        // đặt đối tượng vào ma trận
        public void Drop(int[,] matrix)
        {
            for (int i = 0; i < count; i++)
                matrix[locationMatrix.X + x[i], locationMatrix.Y + y[i]] = 1;
        }
        // hình vuông bắt đầu tại pSquare, kích thước size có chứa điểm pIn hay không
        private static bool SquareContains(Point pSquare, int size, Point pIn)
        {
            return ((pIn.X >= pSquare.X) && (pIn.X <= pSquare.X + size) && (pIn.Y >= pSquare.Y) && (pIn.Y <= pSquare.Y + size));
        }
        // Nếu một phần của đói tượng bị mất thì xóa phần ra khỏi việc quản lý
        public void Update(int[,] matrix)
        {
            int i = 0;
            while (i < count)
                if (matrix[locationMatrix.X + x[i], locationMatrix.Y + y[i]] == 0)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        x[j] = x[j + 1];
                        y[j] = y[j + 1];
                    }
                    count--;
                }
                else
                    i++;
        }
        // Properties
        public Point LocationMatrix
        {
            get { return locationMatrix; }
            set { locationMatrix = value; }
        }
        public Point LocationCursor
        {
            get { return locationCursor; }
            set { locationCursor = value; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public int[] X
        {
            get { return x; }
        }
        public int[] Y
        {
            get { return y; }
        }
        public int Count
        {
            get { return count; }
        }
    }
}
