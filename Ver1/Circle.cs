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
    class Circle
    {
        // Thuộc tính
        private Point location;
        private Color color;
        private int radius;
        private const int MAXRADIUS = 100;
        private const int MINRADIUS = 50;
        public Point Location { get; set; }
        public Color Color { get; set; }
        

        // properties
        public int Radius
        {
            get { return radius; }
            set { if (value > 0) radius = value; }
        }
        // Phương thức
        // Constructor
        public Circle()
        { }
        public Circle(int maxX, int maxY)
        {
            Random r = new Random();  
            radius = r.Next(MINRADIUS, MAXRADIUS);
            int x = r.Next(0, maxX-2*radius);
            int y = r.Next(0, maxY-2*radius);
            color = Color.FromArgb(x % 255, y % 255, radius % 255);
            location = new Point(x, y);
        }
        // Giảm bán kính, dịch chuyển để tạo cảm giác thu vào tâm
        public void Update()
        {
            radius--;
            if (radius < 0)
                radius = 0;
            location = new Point(location.X + 1, location.Y + 1);
        }
        // vẽ đối tượng lên g
        public void Show(Graphics g)
        {
            Pen p = new Pen(color);
            g.FillEllipse(p.Brush, location.X, location.Y, radius*2, radius*2);
        }
        // đã biến mất
        public  bool hasGone()
        {
            return radius == 0;
        }
        // Chứa điểm p
        public bool Contains(Point p)
        {
            Point center = new Point((location.X + radius),(location.Y +  radius));
            return ((p.X - center.X) * (p.X - center.X) + (p.Y - center.Y) * (p.Y - center.Y)) <= radius * radius;
        }

    }
}
