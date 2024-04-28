using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap14_oop
{
    public partial class fMain : Form
    {
        CCircle[] circles;
        CSquare[] squares; // Додано масив для квадратів
        CTriangle[] triangles; // Додано масив для трикутників
        int CurrentCircleIndex;
        int CurrentSquareIndex; // Додано змінну для індексу поточного квадрата
        int CurrentTriangleIndex; // Додано змінну для індексу поточного трикутника
        int CircleCount = 0;
        int SquareCount = 0; // Додано лічильник квадратів
        int TriangleCount = 0; // Додано лічильник трикутників
        public fMain()
        {
            InitializeComponent();
            
            circles = new CCircle[100];
            squares = new CSquare[100]; // Ініціалізовано масив квадратів
            triangles = new CTriangle[100]; // Ініціалізовано масив трикутників
        }

        // Приховати обраний об'єкт
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Hide();
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Hide();
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Hide();
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Move(0, -10);
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Move(0, -10);
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Move(0, -10);
                }
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        circles[selectedIndex].Move(1, 0);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        squares[selectedIndex].Move(1, 0);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        triangles[selectedIndex].Move(1, 0);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }

        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Expand(5);
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Expand(5);
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Expand(5);
                }
            }
        }


        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (CircleCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentCircleIndex = CircleCount;

            // Створення нового об'єкта - екземпляра класу CCircle     
            circles[CurrentCircleIndex] = new CCircle(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);

            // Додати цей рядок, щоб показати коло після його створення
            circles[CurrentCircleIndex].Show();

            CircleCount++;

            cbCircles.Items.Add("Коло №" + (CircleCount - 1).ToString());
            cbCircles.SelectedIndex = CircleCount - 1;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Show();
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Show();
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Show();
                }
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Collapse(5);
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Collapse(5);
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Collapse(5);
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Move(0, 10);
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Move(0, 10);
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Move(0, 10);
                }
            }
        }

        private void brnRight_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Move(10, 0);
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Move(10, 0);
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Move(10, 0);
                }
            }
        }


        // Перемістити обрану фігуру дуже вгору
        private void btnUpFar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        circles[selectedIndex].Move(0, -1);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        squares[selectedIndex].Move(0, -1);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        triangles[selectedIndex].Move(0, -1);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    circles[selectedIndex].Move(-10, 0);
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    squares[selectedIndex].Move(-10, 0);
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    triangles[selectedIndex].Move(-10, 0);
                }
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        circles[selectedIndex].Move(0, 1);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        squares[selectedIndex].Move(0, 1);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        triangles[selectedIndex].Move(0, 1);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
        }

        // Перемістити обрану фігуру дуже вліво
        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) // Керування кругами
            {
                if (cbCircles.SelectedIndex != -1)
                {
                    int selectedIndex = cbCircles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        circles[selectedIndex].Move(-1, 0);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 1) // Керування квадратами
            {
                if (cbSquares.SelectedIndex != -1)
                {
                    int selectedIndex = cbSquares.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        squares[selectedIndex].Move(-1, 0);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 2) // Керування трикутниками
            {
                if (cbTriangles.SelectedIndex != -1)
                {
                    int selectedIndex = cbTriangles.SelectedIndex;
                    for (int i = 0; i < 100; i++)
                    {
                        triangles[selectedIndex].Move(-1, 0);
                        System.Threading.Thread.Sleep(5);
                    }
                }
            }
        }
        private void btnCreateNewSquare_Click_1(object sender, EventArgs e)
        {
            if (SquareCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentSquareIndex = SquareCount;

            // Створення нового об'єкта - екземпляра класу CSquare
            squares[CurrentSquareIndex] = new CSquare(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);

            // Додати цей рядок, щоб показати квадрат після його створення
            squares[CurrentSquareIndex].Show();

            SquareCount++;

            cbSquares.Items.Add("Квадрат №" + (SquareCount - 1).ToString());
            cbSquares.SelectedIndex = SquareCount - 1;
        }

        private void btnCreateNewTriangle_Click_1(object sender, EventArgs e)
        {
            if (TriangleCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів!");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentTriangleIndex = TriangleCount;

            // Створення нового об'єкта - екземпляра класу CTriangle
            triangles[CurrentTriangleIndex] = new CTriangle(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);

            // Додати цей рядок, щоб показати трикутник після його створення
            triangles[CurrentTriangleIndex].Show();

            TriangleCount++;

            cbTriangles.Items.Add("Трикутник №" + (TriangleCount - 1).ToString());
            cbTriangles.SelectedIndex = TriangleCount - 1;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
