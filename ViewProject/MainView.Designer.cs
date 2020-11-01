using System.Windows.Forms;

namespace Biblioteca.View
{
    partial class MainView
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
            this.SearchBttn = new System.Windows.Forms.Button();
            this.ListBttn = new System.Windows.Forms.Button();
            this.ExitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBttn
            // 
            this.SearchBttn.Location = new System.Drawing.Point(83, 25);
            this.SearchBttn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBttn.Name = "SearchBttn";
            this.SearchBttn.Size = new System.Drawing.Size(171, 56);
            this.SearchBttn.TabIndex = 0;
            this.SearchBttn.Text = "Búsqueda por DNI";
            this.SearchBttn.UseVisualStyleBackColor = true;
            this.SearchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
            // 
            // ListBttn
            // 
            this.ListBttn.Location = new System.Drawing.Point(83, 104);
            this.ListBttn.Margin = new System.Windows.Forms.Padding(2);
            this.ListBttn.Name = "ListBttn";
            this.ListBttn.Size = new System.Drawing.Size(171, 53);
            this.ListBttn.TabIndex = 1;
            this.ListBttn.Text = "Lista de usuarios";
            this.ListBttn.UseVisualStyleBackColor = true;
            this.ListBttn.Click += new System.EventHandler(this.ListBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Location = new System.Drawing.Point(133, 191);
            this.ExitBttn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(71, 22);
            this.ExitBttn.TabIndex = 2;
            this.ExitBttn.Text = "Salir";
            this.ExitBttn.UseVisualStyleBackColor = true;
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 229);
            this.Controls.Add(this.ExitBttn);
            this.Controls.Add(this.ListBttn);
            this.Controls.Add(this.SearchBttn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Menú principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchBttn;
        private System.Windows.Forms.Button ListBttn;
        private System.Windows.Forms.Button ExitBttn;

        public Button SearchBttn1 { get => SearchBttn; set => SearchBttn = value; }
        public Button ListBttn1 { get => ListBttn; set => ListBttn = value; }
        public Button ExitBttn1 { get => ExitBttn; set => ExitBttn = value; }
    }
}