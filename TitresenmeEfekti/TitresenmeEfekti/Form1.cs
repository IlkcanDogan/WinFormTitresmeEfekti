using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitresenmeEfekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTitrestir_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Point lokasyon = this.Location;

            int c = 0;
            while(c< 800)
            {
                int x = random.Next(1, 10);
                int y = random.Next(1, 10);

                this.Location = new Point(lokasyon.X + x, lokasyon.Y + y);
             
                c++;
            }
            this.Location = lokasyon;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
