using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audio_Processing
{
    public partial class volumControl : UserControl
    {
        public volumControl()
        {
            InitializeComponent();
            this.Size = new Size(350, 30);
            this.BackColor = Color.Black;
            DoubleBuffered = true;
        }
        int pb_value = 40, pb_min = 0, pb_max = 100;
        public int max { get { return pb_max; } set { pb_max = value; Invalidate(); } }
        public int min { get { return pb_min; } set { pb_min = value; Invalidate(); } }
        public int value { get { return pb_value; } set { pb_value = value; Invalidate(); } }


        private void volumControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
