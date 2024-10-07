using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer_Loding.Start();
        }

        int startPoint = 0;
        private void timer_Loding_Tick(object sender, EventArgs e)
        {
            startPoint++;
            if (startPoint > 20)
            {
                timer_Loding.Stop();
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }
    }
}
