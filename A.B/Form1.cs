using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A.B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, temp;
            A = int.Parse(valorA.Text);
            B = int.Parse(valorB.Text);


            temp = A;
            A = B;
            B = temp;

           valorA.Text = A.ToString();
            valorB.Text = B.ToString();




        }
    }
}
