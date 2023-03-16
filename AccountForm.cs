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
    public partial class AccountForm : Form
    {
        private List<Account> accounts;
        public AccountForm()
        {
            InitializeComponent();
            accounts = new List<Account>();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            infoOutput.Text = account.GetIdInfo();
            accounts.Add(account);
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            double num = 0;
            try
            {
                num = Convert.ToDouble(getInput.Text);
                infoOutput.Text = accounts.FirstOrDefault().GetMoney(num);
            } catch(Exception ex)
            {
                ex.Source = "Error";
                infoOutput.Text = ex.Message;
            }
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            double num = 0;
            try
            {
                num = Convert.ToDouble(storeInput.Text);
                infoOutput.Text = accounts.FirstOrDefault().StoreMoney(num);
            }
            catch (Exception ex)
            {
                ex.Source = "Error";
                infoOutput.Text = ex.Message;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                infoOutput.Text = accounts.FirstOrDefault().GetFormatMoney();
            }
            catch (Exception ex)
            {
                ex.Source = "Error";
                infoOutput.Text = ex.Message;
            }
        }
    }
}
