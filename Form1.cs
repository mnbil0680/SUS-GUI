using Problem9.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 600, 300, 1250, 300);
            e.Graphics.DrawLine(whitePen, 600, 460, 1250, 460);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 810, 140, 810, 620);
            e.Graphics.DrawLine(whitePen, 1040, 140, 1040, 620);

        }
        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                if (label7.Text == "Player S")
                {
                    btn.Image = Resources.S_letter;
                    btn.Tag = "S";
                    label7.Text = "Player U";
                }
                else
                {
                    btn.Image = Resources.U_letter;
                    btn.Tag = "U";
                    label7.Text = "Player S";
                }

            }
            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
    }
}
