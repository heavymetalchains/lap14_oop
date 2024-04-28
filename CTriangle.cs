using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap14_oop
{
    public class CTriangle
    {
        // Поля
        private Graphics graphics;
        private int _size; // Підтримуюче поле для властивості Size

        // Властивості
        public int X { get; set; } // Координата X вершини трикутника
        public int Y { get; set; } // Координата Y вершини трикутника
        public int Size
        {
            // Розмір трикутника
            get
            {
                return _size;
            }
            set
            {
                _size = value >= 200 ? 200 : (value <= 5 ? 5 : value);
            }
        }

        // Конструктор, створює об'єкт трикутника (для заданої поверхні
        // малювання GDI+) з заданими координатами.
        // Розмір трикутника приймається за замовчуванням
        public CTriangle(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Size = 50; // Припустиме значення за замовчуванням
        }

        // Конструктор, створює об'єкт трикутника (для заданої поверхні
        // малювання GDI+) з заданими координатами та розміром
        public CTriangle(Graphics graphics, int X, int Y, int Size)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Size = Size;
        }

        // Малює трикутник на поверхні малювання GDI+.
        // Параметри трикутника задає перо pen
        private void Draw(Pen pen)
        {
            Point point1 = new Point(X, Y - Size / 2);
            Point point2 = new Point(X - Size / 2, Y + Size / 2);
            Point point3 = new Point(X + Size / 2, Y + Size / 2);
            Point[] points = { point1, point2, point3 };
            graphics.DrawPolygon(pen, points);
        }

        // Показує трикутник (малює на поверхні малювання GDI+ кольором
        // переднього плану)
        public void Show()
        {
            Draw(Pens.Red);
        }

        // Приховує трикутник (малює на поверхні малювання GDI+ кольором фону)
        public void Hide()
        {
            Draw(Pens.White);
        }

        // Розширює трикутник: збільшує розмір на один піксель
        public void Expand()
        {
            Hide();
            Size++;
            Show();
        }

        // Розширює трикутник: збільшує розмір на dSize пікселів
        public void Expand(int dSize)
        {
            Hide();
            Size = Size + dSize;
            Show();
        }

        // Стискає трикутник: зменшує розмір на один піксель
        public void Collapse()
        {
            Hide();
            Size--;
            Show();
        }

        // Стискає трикутник: зменшує розмір на dSize пікселів
        public void Collapse(int dSize)
        {
            Hide();
            Size = Size - dSize;
            Show();
        }

        // Переміщує трикутник
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}
