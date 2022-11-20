using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace DelegateLab002
{
    public class Rectangle
    {
        static int X, Y;
        public static void rectangleFirst(int x)
        {
            X = x;
        }
        public static void rectangleSecond(int y)
        {
            Y = y;
        }
        private static int Square()
        {
            var actualSize = SystemInformation.PrimaryMonitorSize;
            // Не уверен что правильно посчитал площадь.
            int squareOfRectangle = Math.Abs(actualSize.Width - X) * Math.Abs(actualSize.Height - Y);
            return squareOfRectangle;
        }
        public static void SaveCoordinate()
        {
            string date = DateTime.Now.ToString();
            MessageBox.Show($"Площадь прямоугольника {date}, c точками:\nх - {X}, у - {Y} = {Square()} пикселей.\n\n");           
            var fileContent = string.Empty;
            var filePath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.Write($"Площадь прямоугольника {date}, c точками:\nх - {X}, у - {Y} = {Square()} пикселей.\n\n");
                sw.Close();
            }
        }
    }
}
