using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginScreens
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            
            if(usernameIn.Text == Form1.correctUsername && passwordIn.Text == Form1.correctPassword)
            {
                wrongLoginLabel.Visible = false;
                Form f = this.FindForm();
                f.Location = new Point((this.Width - f.Width) / 2, (this.Height - f.Height) / 2);
                f.Controls.Remove(this);

                logOut ps = new logOut();
                f.Controls.Add(ps);
            }
            else { wrongLoginLabel.Visible = true; }
            
        }
    }
}
