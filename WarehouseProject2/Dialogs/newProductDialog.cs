using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseProject2.Common;
using WarehouseProject2.Entities;
using static WarehouseProject2.Dialogs.OrderInDialog;
using Type = WarehouseProject2.Entities.Type;

namespace WarehouseProject2.Dialogs
{
    public partial class newProductDialog : Form
    {
        EntityFW db = new EntityFW();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<DisplayItem> selectedItems { get; set; } = new();


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Product Product = new();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public MeasuringUnit MUSelected { get; set; }
        public MeasuringUnits MUSelected { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Quantity { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Type selectedType { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime date { get; set; }

        public newProductDialog()
        {
            InitializeComponent();
            // Put All MeasuringUnits in combobox
            typeCombobox.Items.Add(Type.Weight);
            typeCombobox.Items.Add(Type.Volume);
            typeCombobox.Items.Add(Type.Quantity);
            typeCombobox.SelectedIndex = 0;
            expiryDatePicker.Value = DateTime.Now + TimeSpan.FromDays(180);

        }
        public newProductDialog(List<DisplayItem> selectItems)
        {
            InitializeComponent();

            selectedItems = selectItems;
            // Put All MeasuringUnits in combobox
            typeCombobox.Items.Add(Type.Weight);
            typeCombobox.Items.Add(Type.Volume);
            typeCombobox.Items.Add(Type.Quantity);

            typeCombobox.SelectedIndex = 0;

            expiryDatePicker.Value = DateTime.Now + TimeSpan.FromDays(180);

        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            // put date 
            date = expiryDatePicker.Value;
            if ((Type)typeCombobox.SelectedItem == Type.Weight)
            {
                if (kilogramRadio.Checked)
                {
                    //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Weight && mu.MU_Name == "Kilogram").FirstOrDefault();
                    MUSelected = MeasuringUnits.Kg;
                }
                else if (gramRadio.Checked)
                {
                    //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Weight && mu.MU_Name == "Gram").FirstOrDefault();
                    MUSelected = MeasuringUnits.gm;
                }
            }
            else if ((Type)typeCombobox.SelectedItem == Type.Volume)
            {
                if (literRadio.Checked)
                {
                    //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Volume && mu.MU_Name == "Liter").FirstOrDefault();
                    MUSelected = MeasuringUnits.L;
                }
                else if (milleLiterMU.Checked)
                {
                    //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Volume && mu.MU_Name == "MilleLiter").FirstOrDefault();
                    MUSelected = MeasuringUnits.ml;
                }
            }
            else
            {
                //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Quantity).FirstOrDefault();
                MUSelected = MeasuringUnits.Quantity;
            }

            Product = new Product();
            Product.P_Name = nameTextBox.Text;
            Product.P_Code = codeTextBox.Text;

            if (quantityTextbox.Text == "")
            {
                MessageBox.Show("Please enter a quantity");
                return;
            }
            Quantity = int.Parse(quantityTextbox.Text);
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void typeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = (Type)typeCombobox.SelectedItem;
            if (selectedType == Type.Weight)
            {
                kilogramRadio.Enabled = true;
                gramRadio.Enabled = true;
                literRadio.Enabled = false;
                milleLiterMU.Enabled = false;
            }
            else if (selectedType == Type.Volume)
            {
                kilogramRadio.Enabled = false;
                gramRadio.Enabled = false;
                literRadio.Enabled = true;
                milleLiterMU.Enabled = true;
            }
            else
            {
                kilogramRadio.Enabled = false;
                gramRadio.Enabled = false;
                literRadio.Enabled = false;
                milleLiterMU.Enabled = false;
            }
        }

        private void kilogramRadio_CheckedChanged(object sender, EventArgs e)
        {
            //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Weight && mu.MU_Name == "Kilogram").FirstOrDefault();

            MUSelected = MeasuringUnits.Kg;
        }

        private void gramRadio_CheckedChanged(object sender, EventArgs e)
        {
            //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Weight && mu.MU_Name == "Gram").FirstOrDefault();

            MUSelected = MeasuringUnits.gm;
        }

        private void literRadio_CheckedChanged(object sender, EventArgs e)
        {
            //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Volume && mu.MU_Name == "Liter").FirstOrDefault();
            MUSelected = MeasuringUnits.L;
        }

        private void milleLiterMU_CheckedChanged(object sender, EventArgs e)
        {
            //MUSelected = db.MeasuringUnits.Where(mu => mu.MU_Type == Type.Volume && mu.MU_Name == "MilleLiter").FirstOrDefault();

            MUSelected = MeasuringUnits.ml;
        }
    }
}
