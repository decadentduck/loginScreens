using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginScreens
{
    public partial class Form1 : Form
    {
        public static string correctUsername = "duck";
        public static string correctPassword = "123";
        public Form1()
        {
            InitializeComponent();
            LogIn li = new LogIn();
            this.Controls.Add(li);
        } 
    }
}
