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
    public partial class AddressForm : Form
    {
        ISaveAddress _parent;
        public AddressForm(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                Street = streetText.Text,
                Suburb = suburbText.Text,
                City = cityText.Text,
                ZipCode= zipCodeText.Text,
            };

            _parent.SaveAddress(address);
            this.Close();
        }
    }
}
