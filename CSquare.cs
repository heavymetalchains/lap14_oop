using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap14_oop
{
    public class CSquare
    {
        // Поля
        private Graphics graphics;
        private int _size; // Підтримуюче поле для властивості Size

        // Властивості
        public int X { get; set; } // Координата X верхнього лівого кута квадрата
        public int Y { get; set; } // Координата Y верхнього лівого кута квадрата
        public int Size
        {
            // Розмір квадрата
            get
            {
                return _size;
            }
            set
            {
                _size = value >= 200 ? 200 : (value <= 5 ? 5 : value);
            }
        }

        // Конструктор, створює об'єкт квадрата (для заданої поверхні
        // малювання GDI+) з заданими координатами.
        // Розмір квадрата приймається за замовчуванням
        public CSquare(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Size = 50; // Припустиме значення за замовчуванням
        }

        // Конструктор, створює об'єкт квадрата (для заданої поверхні
        // малювання GDI+) з заданими координатами та розміром
        public CSquare(Graphics graphics, int X, int Y, int Size)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Size = Size;
        }

        // Малює квадрат на поверхні малювання GDI+.
        // Параметри квадрата задає перо pen
        private void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X, Y, Size, Size);
            graphics.DrawRectangle(pen, rectangle);
        }

        // Показує квадрат (малює на поверхні малювання GDI+ кольором
        // переднього плану)
        public void Show()
        {
            Draw(Pens.Blue); // Припустимий колір для відображення
        }

        // Приховує квадрат (малює на поверхні малювання GDI+ кольором фону)
        public void Hide()
        {
            Draw(Pens.White); // Припустимий колір для приховування
        }

        // Розширює квадрат: збільшує розмір на один піксель
        public void Expand()
        {
            Hide();
            Size++;
            Show();
        }

        // Розширює квадрат: збільшує розмір на dSize пікселів
        public void Expand(int dSize)
        {
            Hide();
            Size = Size + dSize;
            Show();
        }

        // Стискає квадрат: зменшує розмір на один піксель
        public void Collapse()
        {
            Hide();
            Size--;
            Show();
        }

        // Стискає квадрат: зменшує розмір на dSize пікселів
        public void Collapse(int dSize)
        {
            Hide();
            Size = Size - dSize;
            Show();
        }

        // Переміщує квадрат
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}
