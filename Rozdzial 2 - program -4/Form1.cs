using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdzial_2___program__4
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

        private void ChangeText_Click(object sender, EventArgs e)
        {
            if (enableCheckBox.Checked == true)
            {
                if (labelToChange.Text=="Z prawej")
                {
                    labelToChange.Text = "Z lewej";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    labelToChange.Text = "Z prawej";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
                
            }
            else
            {
                labelToChange.Text = "Mozliwosc zmiany teksty zostala wylaczona";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }    
        }
    }
}
