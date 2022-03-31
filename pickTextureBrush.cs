using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4Draft
{
    public partial class pickTextureBrush : Form
    {
       public string fileName="";
       public int wrapMode=1;
        public pickTextureBrush()
        {
            InitializeComponent();
         //   pickedColor = SystemColors.ButtonFace;
        }

        private void pickTextureBrush_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectImage  = new OpenFileDialog();
            if (selectImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = selectImage.FileName;
                MessageBox.Show(fileName);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                wrapMode = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                wrapMode = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                wrapMode = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                wrapMode = 4;
        }

        private void ok_Click(object sender, EventArgs e)
        {

        }
    }
}
