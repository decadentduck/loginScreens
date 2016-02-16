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
    public partial class logOut : UserControl
    {
        public logOut()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Location = new Point((this.Width - f.Width) / 2, (this.Height - f.Height) / 2);
            f.Controls.Remove(this);

            LogIn ps = new LogIn();
            f.Controls.Add(ps);
        }
    }
}
