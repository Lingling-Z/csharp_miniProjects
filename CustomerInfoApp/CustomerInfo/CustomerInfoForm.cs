using CustomerInfoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInfo
{
    public partial class CustomerInfoForm : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses= new BindingList<AddressModel>();
        public CustomerInfoForm()
        {
            InitializeComponent();
            addressListBox.DataSource = addresses;
            addressListBox.DisplayMember = nameof(AddressModel.FullAddress);
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(this);
            addressForm.Show();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                AddressList = addresses.ToList()
            };

        }
    }
}
