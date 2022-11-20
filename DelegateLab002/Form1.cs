using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DelegateLab002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            int x = location.X;
            Rectangle.rectangleFirst(x);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            int y = location.Y;
            Rectangle.rectangleSecond(y);
            Rectangle.SaveCoordinate();          
        }
       

       

        
        
    }
}
