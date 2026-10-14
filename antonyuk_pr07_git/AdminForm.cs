using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antonyuk_pr07_git
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += (s, e) => UpdateDateTime();
            timer1.Start();
            UpdateDateTime();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        private void UpdateDateTime()
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТВОЁ ФИО", "Информация");
        }
    }
}
