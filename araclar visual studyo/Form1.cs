using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araclar_visual_studyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value >= 1 && vScrollBar1.Value<=25)
            {
                BackColor = Color.Red;
         
            }
            if(vScrollBar1.Value>=26 && vScrollBar1.Value <= 50)
            {
                BackColor = Color.Blue;
            }
            if(vScrollBar1.Value>=51&& vScrollBar1.Value <= 75)
            {
                BackColor = Color.Pink;
            }
            if (vScrollBar1.Value >= 76 && vScrollBar1.Value <= 100)
            { 
                BackColor = Color.Black;
            }
        }

    }
}
