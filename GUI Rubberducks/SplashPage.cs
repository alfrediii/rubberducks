using RubberDucksLoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Registration_p1
{
    public partial class SplashPage : Form
    {
        public SplashPage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if(panel1.Width >= 850)
            {
                timer1.Stop();
                EmployeeLoginForm login = new EmployeeLoginForm();
                this.Hide();
                login.Show();
            }
        }
    }
}
