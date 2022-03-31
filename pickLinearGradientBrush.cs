using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class pickLinearGradientBrush : Form
    {
        public LinearGradientBrush lBrush;
        public Rectangle rectangle;    
        public Color sColor, eColor;
        public pickLinearGradientBrush()
        {
            InitializeComponent();
          
        }

        private void pickLinearGradientBrush_Load(object sender, EventArgs e)
        {

        }

        private void end_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                eColor = colorDialog1.Color;
            eColor = Color.FromArgb((byte)255, eColor.R, eColor.G, eColor.B);
            pictureBox2.BackColor = colorDialog1.Color;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            rectangle = new Rectangle((int)X.Value, (int)Y.Value, (int)width.Value, (int)height.Value);

            if (radioButton1.Checked)
            {
                lBrush = new LinearGradientBrush(rectangle, sColor, eColor, LinearGradientMode.Horizontal);
            }
            if (radioButton2.Checked)
            {
                lBrush = new LinearGradientBrush(rectangle, sColor, eColor, LinearGradientMode.Vertical);
            }
        
            if (radioButton3.Checked)
            {
                lBrush = new LinearGradientBrush(rectangle, sColor, eColor, LinearGradientMode.ForwardDiagonal);
            }
            if (radioButton4.Checked)
            {
                lBrush = new LinearGradientBrush(rectangle, sColor, eColor, LinearGradientMode.BackwardDiagonal);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                sColor = colorDialog1.Color;
            sColor = Color.FromArgb((byte)255, sColor.R, sColor.G, sColor.B);
            pictureBox1.BackColor = colorDialog1.Color;
        }
    }
}
