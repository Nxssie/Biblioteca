using System.Windows.Forms;

namespace Biblioteca.View
{
    partial class SearchView
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
            this.searchBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DniTextBox = new System.Windows.Forms.TextBox();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.salirBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.primApellidoLabel = new System.Windows.Forms.Label();
            this.segApellidoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBttn
            // 
            this.searchBttn.Location = new System.Drawing.Point(12, 76);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(64, 23);
            this.searchBttn.TabIndex = 0;
            this.searchBttn.Text = "Buscar";
            this.searchBttn.UseVisualStyleBackColor = true;
            this.searchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI Alumno";
            // 
            // DniTextBox
            // 
            this.DniTextBox.Location = new System.Drawing.Point(12, 50);
            this.DniTextBox.Name = "DniTextBox";
            this.DniTextBox.Size = new System.Drawing.Size(108, 20);
            this.DniTextBox.TabIndex = 2;
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.Location = new System.Drawing.Point(156, 76);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBttn.TabIndex = 4;
            this.DeleteBttn.Text = "Eliminar";
            this.DeleteBttn.UseVisualStyleBackColor = true;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // salirBttn
            // 
            this.salirBttn.Location = new System.Drawing.Point(193, 345);
            this.salirBttn.Name = "salirBttn";
            this.salirBttn.Size = new System.Drawing.Size(75, 23);
            this.salirBttn.TabIndex = 9;
            this.salirBttn.Text = "Salir";
            this.salirBttn.UseVisualStyleBackColor = true;
            this.salirBttn.Click += new System.EventHandler(this.SalirBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido 2:";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(153, 159);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(111, 13);
            this.dniLabel.TabIndex = 10;
            this.dniLabel.Text = "[Búsqueda pendiente]";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(153, 199);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(111, 13);
            this.nombreLabel.TabIndex = 11;
            this.nombreLabel.Text = "[Búsqueda pendiente]";
            // 
            // primApellidoLabel
            // 
            this.primApellidoLabel.AutoSize = true;
            this.primApellidoLabel.Location = new System.Drawing.Point(153, 240);
            this.primApellidoLabel.Name = "primApellidoLabel";
            this.primApellidoLabel.Size = new System.Drawing.Size(111, 13);
            this.primApellidoLabel.TabIndex = 12;
            this.primApellidoLabel.Text = "[Búsqueda pendiente]";
            // 
            // segApellidoLabel
            // 
            this.segApellidoLabel.AutoSize = true;
            this.segApellidoLabel.Location = new System.Drawing.Point(153, 278);
            this.segApellidoLabel.Name = "segApellidoLabel";
            this.segApellidoLabel.Size = new System.Drawing.Size(111, 13);
            this.segApellidoLabel.TabIndex = 13;
            this.segApellidoLabel.Text = "[Búsqueda pendiente]";
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 380);
            this.Controls.Add(this.segApellidoLabel);
            this.Controls.Add(this.primApellidoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.salirBttn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.DniTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBttn);
            this.Name = "SearchView";
            this.Text = "Buscar alumno por DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DniTextBox;
        private System.Windows.Forms.Button DeleteBttn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button salirBttn;
        private Label dniLabel;
        private Label nombreLabel;
        private Label primApellidoLabel;
        private Label segApellidoLabel;

        public TextBox GetDniTextBox
        {
            get
            {
                return DniTextBox;
            }
        }

        public Button GetSearchBttn
        {
            get
            {
                return searchBttn;
            }
        }

        public Button GetDeleteBttn
        {
            get
            {
                return DeleteBttn;
            }
        }

        public Label GetDniLabel
        {
            get
            {
                return dniLabel;
            }
        }

        public Label GetNombreLabel
        {
            get
            {
                return nombreLabel;
            }
        }

        public Label GetPrimApellidoLabel
        {
            get
            {
                return primApellidoLabel;
            }
        }

        public Label GetSegApellidoLabel
        {
            get
            {
                return segApellidoLabel;
            }
        }

        public void SetDniLabel(string dni) 
        {
            this.dniLabel.Text = dni;
        }

        public void SetNombreLabel(string nombre)
        {
            this.nombreLabel.Text = nombre;
        }

        public void SetPrimApellido(string primApellido)
        {
            this.primApellidoLabel.Text = primApellido;
        }

        public void SetSegApellido(string segApellido)
        {
            this.segApellidoLabel.Text = segApellido;
        }
    }
}