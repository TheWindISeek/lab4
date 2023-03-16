using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class TimeForm : Form
    {
        private Time time;
        public TimeForm()
        {
            InitializeComponent();
            time = new Time();
            hourInput.Text = time.Hour.ToString();
            minuteInput.Text = time.Minute.ToString();
            secondInput.Text = time.Second.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            time.AddSecond(1);
            hourInput.Text = time.Hour.ToString();
            minuteInput.Text = time.Minute.ToString();
            secondInput.Text = time.Second.ToString();
        }
    }
}
