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

namespace QLCoffee.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"Select MainID, TableName, WaiterName, orderType, status, total from tblMain
                            where status <> 'Pending' ";
            ListBox LB = new ListBox();
            LB.Items.Add(dgvid);
            LB.Items.Add(dgvtable);
            LB.Items.Add(dgvWaiter);
            LB.Items.Add(dgvType);
            LB.Items.Add(dgvStatus);
            LB.Items.Add(dgvTotal);

            MainClass.LoadData(qry, guna2DataGridView2, LB);
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView2.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
           
        public void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView2.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                MainID = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid"].Value);
                this.Close();
   
            }
            
        }


    }
}
