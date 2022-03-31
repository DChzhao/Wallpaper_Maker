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
    public partial class pickHatchBrush : Form
    {
        public Color pickedColor, backgrColor;
        public HatchBrush brush;
        public pickHatchBrush()
        {
            InitializeComponent();
           // pickedColor = SystemColors.ButtonFace;
          var hs = (HatchStyle[])Enum.GetValues(typeof(HatchStyle));
            for (int i = 0; i < hs.Length; i++)
                listBox1.Items.Add(hs[i]);
        }

        private void pickHatchBrush_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                pickedColor = colorDialog1.Color;
            pickedColor = Color.FromArgb((byte)255, pickedColor.R, pickedColor.G, pickedColor.B);       
            pictureBox1.BackColor = colorDialog1.Color;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
              return;
            brush = new HatchBrush((HatchStyle)listBox1.SelectedItem, pickedColor, backgrColor);
        }

        private void backColor_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
                backgrColor = colorDialog1.Color;
            backgrColor = Color.FromArgb((byte)255, backgrColor.R, backgrColor.G, backgrColor.B);
            pictureBox2.BackColor = colorDialog1.Color;
           
        }
    }
}
