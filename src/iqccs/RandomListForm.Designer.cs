namespace iqccs
{
    partial class RandomListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridRandomList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRandomList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRandomList
            // 
            this.gridRandomList.AllowUserToAddRows = false;
            this.gridRandomList.AllowUserToDeleteRows = false;
            this.gridRandomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRandomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.gridRandomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRandomList.Location = new System.Drawing.Point(0, 0);
            this.gridRandomList.Name = "gridRandomList";
            this.gridRandomList.ReadOnly = true;
            this.gridRandomList.RowTemplate.Height = 23;
            this.gridRandomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRandomList.Size = new System.Drawing.Size(284, 362);
            this.gridRandomList.TabIndex = 0;
            this.gridRandomList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridRandomList_RowsAdded);
            this.gridRandomList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gridRandomList_RowsRemoved);
            // 
            // Id
            // 
            this.Id.HeaderText = "序号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // RandomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.gridRandomList);
            this.Name = "RandomListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "随机数列表";
            this.Load += new System.EventHandler(this.RandomListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRandomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRandomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}