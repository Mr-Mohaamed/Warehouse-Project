using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseProject2.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WarehouseProject2.Dialogs
{
    public partial class CustomerDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Update { get; set; } = false;
        public CustomerDialog()
        {
            InitializeComponent();
            var db = new EntityFW();
            UserComboBox.DataSource = db.Customers.ToList();
            UserComboBox.DisplayMember = "C_Name";
            UserComboBox.ValueMember = "C_ID";
            UserComboBox.SelectedIndex = -1;
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            MobileTextBox.Text = "";
            FaxTextBox.Text = "";
            SiteTextBox.Text = "";
        }
        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new EntityFW();

            var selectedCustomer = UserComboBox.SelectedItem as Customer;

            if (selectedCustomer != null)
            {
                // Find the customer by their C_ID
                var customer = db.Customers.Find(selectedCustomer.C_ID);

                if (customer != null)
                {
                    IDTextBox.Text = customer.C_ID.ToString();
                    NameTextBox.Text = customer.C_Name;
                    EmailTextBox.Text = customer.C_Email;
                    PhoneTextBox.Text = customer.C_Phone;
                    MobileTextBox.Text = customer.C_Mobile;
                    FaxTextBox.Text = customer.C_Fax;
                    SiteTextBox.Text = customer.C_Site;
                }
            }

        }
        private void NewUserRadio_CheckedChanged(object sender, EventArgs e)
        {
            Update = false;
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            MobileTextBox.Text = "";
            FaxTextBox.Text = "";
            SiteTextBox.Text = "";

            UserComboBox.SelectedIndex = -1;
            UserComboBox.Enabled = false;
        }

        private void UpdateRadio_CheckedChanged(object sender, EventArgs e)
        {
            Update = true;
            UserComboBox.Enabled = true;
            UserComboBox.SelectedIndex = 0;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            var db = new EntityFW();
            if (Update == true)
            {

                var customer = db.Customers.Find(UserComboBox.SelectedValue);
                if (customer != null)
                {
                    customer.C_Name = NameTextBox.Text;
                    customer.C_Email = EmailTextBox.Text;
                    customer.C_Phone = PhoneTextBox.Text;
                    customer.C_Mobile = MobileTextBox.Text;
                    customer.C_Fax = FaxTextBox.Text;
                    customer.C_Site = SiteTextBox.Text;
                    db.SaveChanges();
                }
                Close();
                return;
            }
            else
            {
                var customer = new Customer
                {
                    C_Name = NameTextBox.Text,
                    C_Email = EmailTextBox.Text,
                    C_Phone = PhoneTextBox.Text,
                    C_Mobile = MobileTextBox.Text,
                    C_Fax = FaxTextBox.Text,
                    C_Site = SiteTextBox.Text
                };
                db.Customers.Add(customer);
                db.SaveChanges();
                Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

 
    }
}
