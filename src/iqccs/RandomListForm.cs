using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iqccs
{
    public partial class RandomListForm : Form
    {
        private double[] data = new double[0];

        public void SetData(double[] rnds)
        {
            this.data = rnds;
        }

        private void ResetId()
        {
            for (int i = 0; i < this.gridRandomList.RowCount; ++i)
            {
                this.gridRandomList[0, i].Value = i + 1;
            }
        }

        public RandomListForm()
        {
            InitializeComponent();
        }

        private void RandomListForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("随机数"));
            for(int i = 0; i< this.data.Length; i++)
                table.Rows.Add(this.data[i]);
            this.gridRandomList.AutoGenerateColumns = true;
            this.gridRandomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRandomList.DataSource = table;
        }

        private void gridRandomList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResetId();
        }

    }
}
