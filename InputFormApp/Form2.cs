using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputFormApp
{
    class Form2:Form
    {
        public Form2(string txt)
        {
            this.ClientSize = new Size(439, 393);
            Label l1 = new Label();
            l1.Text = "Your Name is: ";
            l1.Location = new Point(80, 80);
            l1.AutoSize = true;
            l1.Font = new Font("Calibri", 14);
            Label lb = new Label();
            lb.Text = txt;
            lb.Location = new Point(200, 80);
            lb.Font = new Font("Calibri", 14);
            this.Controls.Add(l1);
            this.Controls.Add(lb);
        }
    }
}
