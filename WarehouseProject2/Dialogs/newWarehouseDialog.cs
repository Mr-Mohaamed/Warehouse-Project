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
    public partial class newWarehouseDialog : Form
    {
        public newWarehouseDialog()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            var db = new EntityFW();
            var warehouse = new Warehouse
            {
                W_Name = nameTextbox.Text,
                W_Address = addressTextBox.Text,
                Manager_Name = managerTextbox.Text
            };
            db.Warehouses.Add(warehouse);
            db.SaveChanges();

            // ok 
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
