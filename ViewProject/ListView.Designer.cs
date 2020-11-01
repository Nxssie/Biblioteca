using System.Windows.Forms;

namespace Biblioteca.View
{
    partial class ListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listDataGrid = new System.Windows.Forms.DataGridView();
            this.exitBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listDataGrid
            // 
            this.listDataGrid.AllowUserToAddRows = false;
            this.listDataGrid.AllowUserToDeleteRows = false;
            this.listDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGrid.Location = new System.Drawing.Point(11, 11);
            this.listDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.listDataGrid.Name = "listDataGrid";
            this.listDataGrid.ReadOnly = true;
            this.listDataGrid.RowHeadersWidth = 62;
            this.listDataGrid.RowTemplate.Height = 28;
            this.listDataGrid.Size = new System.Drawing.Size(483, 262);
            this.listDataGrid.TabIndex = 0;
            // 
            // exitBttn
            // 
            this.exitBttn.Location = new System.Drawing.Point(419, 296);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(75, 23);
            this.exitBttn.TabIndex = 1;
            this.exitBttn.Text = "Salir";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 331);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.listDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListView";
            this.Text = "ListView";
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listDataGrid;
        private Button exitBttn;

        public DataGridView GetListDataGrid
        {
            get
            {
                return listDataGrid;
            }
        }

        public Button GetExitButton
        {
            get
            {
                return exitBttn;
            }
        }
    }
}