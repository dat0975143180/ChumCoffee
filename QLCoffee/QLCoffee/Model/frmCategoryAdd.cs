using Guna.UI2.WinForms;
using QLCoffee.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLCoffee.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if(id == 0) 
            {
                qry = "Insert into category Values(@Name)";
            }
            else
            {
                qry = "Update category Set catName = @Name where catID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);  

            if(MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Lưu thành công!");
                id= 0;
                txtName.Text = "";
                txtName.Focus();

            }
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }

    }
}
