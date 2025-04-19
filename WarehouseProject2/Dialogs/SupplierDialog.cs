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

namespace WarehouseProject2.Dialogs
{
    public partial class SupplierDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Update { get; set; } = false;
        public SupplierDialog()
        {
            InitializeComponent();
            var db = new EntityFW();
            SupplierComboBox.DataSource = db.Suppliers.ToList();
            SupplierComboBox.DisplayMember = "S_Name";
            SupplierComboBox.ValueMember = "S_ID";
            SupplierComboBox.SelectedIndex = -1;
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            MobileTextBox.Text = "";
            FaxTextBox.Text = "";
            SiteTextBox.Text = "";
        }
        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new EntityFW();

            var selectedSupplier = SupplierComboBox.SelectedItem as Supplier;

            if (selectedSupplier != null)
            {
                // Find the supplier by their S_ID
                var supplier = db.Suppliers.Find(selectedSupplier.S_ID);

                if (supplier != null)
                {
                    IDTextBox.Text = supplier.S_ID.ToString();
                    NameTextBox.Text = supplier.S_Name;
                    EmailTextBox.Text = supplier.S_Email;
                    PhoneTextBox.Text = supplier.S_Phone;
                    MobileTextBox.Text = supplier.S_Mobile;
                    FaxTextBox.Text = supplier.S_Fax;
                    SiteTextBox.Text = supplier.S_Site;
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

            SupplierComboBox.SelectedIndex = -1;
            SupplierComboBox.Enabled = false;
        }

        private void UpdateRadio_CheckedChanged(object sender, EventArgs e)
        {
            Update = true;
            SupplierComboBox.Enabled = true;
            SupplierComboBox.SelectedIndex = 0;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            var db = new EntityFW();
            if (Update == true)
            {

                var supplier = db.Suppliers.Find(SupplierComboBox.SelectedValue);
                if (supplier != null)
                {
                    supplier.S_Name = NameTextBox.Text;
                    supplier.S_Email = EmailTextBox.Text;
                    supplier.S_Phone = PhoneTextBox.Text;
                    supplier.S_Mobile = MobileTextBox.Text;
                    supplier.S_Fax = FaxTextBox.Text;
                    supplier.S_Site = SiteTextBox.Text;
                    db.SaveChanges();
                }
                Close();
                return;
            }
            else
            {
                var supplier = new Supplier
                {
                    S_Name = NameTextBox.Text,
                    S_Email = EmailTextBox.Text,
                    S_Phone = PhoneTextBox.Text,
                    S_Mobile = MobileTextBox.Text,
                    S_Fax = FaxTextBox.Text,
                    S_Site = SiteTextBox.Text
                };
                db.Suppliers.Add(supplier);
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
