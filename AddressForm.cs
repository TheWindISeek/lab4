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
    public partial class AddressForm : Form
    {
        private List<Address> addresses;
        public AddressForm()
        {
            InitializeComponent();
            addresses = new List<Address>();
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string phone = phoneInput.Text;
            string email = emailInput.Text;
            Address address = new Address(name, phone, email);
            addresses.Add(address);
            infoOutput.Text = address.GetMessage();
        }
    }
}
