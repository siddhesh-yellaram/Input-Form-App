
using System.Drawing;
using System.Windows.Forms;

namespace InputFormApp
{
    class InputForm: Form
    {
        public InputForm()
        {
            this.ClientSize = new Size(439, 393);
            this.Text = "Siddhesh";
            Label name = new Label();
            name.Text = "Enter Your Name: ";
            name.Location = new Point(80, 80);
            name.AutoSize = true;
            name.Font = new Font("Calibri", 14);
            TextBox myName = new TextBox();
            myName.Location = new Point(250, 80);
            myName.Font = new Font("Calibri", 14);
            Button btn = new Button();
            btn.Location = new Point(150, 150);
            btn.Text = "Submit";
            btn.Font = new Font("Calibri", 14);
            btn.Click += (sender, e) =>
            {
                string txt = myName.Text;
                Form2 f2 = new Form2(txt);
                f2.Show();
            };
            this.Controls.Add(name);
            this.Controls.Add(myName);
            this.Controls.Add(btn);
        }
    }
}

