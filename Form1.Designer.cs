namespace backupAppDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectDestino = new System.Windows.Forms.Button();
            this.Sincronizar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.InfOrigen = new System.Windows.Forms.Label();
            this.InfoDestino = new System.Windows.Forms.Label();
            this.SelectOrigen = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // SelectDestino
            // 
            this.SelectDestino.Location = new System.Drawing.Point(367, 399);
            this.SelectDestino.Name = "SelectDestino";
            this.SelectDestino.Size = new System.Drawing.Size(75, 23);
            this.SelectDestino.TabIndex = 1;
            this.SelectDestino.Text = "Seleccionar";
            this.SelectDestino.UseVisualStyleBackColor = true;
            // 
            // Sincronizar
            // 
            this.Sincronizar.Location = new System.Drawing.Point(45, 72);
            this.Sincronizar.Name = "Sincronizar";
            this.Sincronizar.Size = new System.Drawing.Size(75, 23);
            this.Sincronizar.TabIndex = 2;
            this.Sincronizar.Text = "Sincronizar";
            this.Sincronizar.UseVisualStyleBackColor = true;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(45, 112);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 3;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(367, 52);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(188, 328);
            this.checkedListBox2.TabIndex = 6;
            // 
            // InfOrigen
            // 
            this.InfOrigen.AutoSize = true;
            this.InfOrigen.Location = new System.Drawing.Point(164, 34);
            this.InfOrigen.Name = "InfOrigen";
            this.InfOrigen.Size = new System.Drawing.Size(43, 15);
            this.InfOrigen.TabIndex = 7;
            this.InfOrigen.Text = "Origen";
            // 
            // InfoDestino
            // 
            this.InfoDestino.AutoSize = true;
            this.InfoDestino.Location = new System.Drawing.Point(367, 34);
            this.InfoDestino.Name = "InfoDestino";
            this.InfoDestino.Size = new System.Drawing.Size(47, 15);
            this.InfoDestino.TabIndex = 8;
            this.InfoDestino.Text = "Destino";
            // 
            // SelectOrigen
            // 
            this.SelectOrigen.Location = new System.Drawing.Point(164, 399);
            this.SelectOrigen.Name = "SelectOrigen";
            this.SelectOrigen.Size = new System.Drawing.Size(75, 23);
            this.SelectOrigen.TabIndex = 0;
            this.SelectOrigen.Text = "Seleccionar";
            this.SelectOrigen.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(164, 52);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 328);
            this.checkedListBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 502);
            this.Controls.Add(this.InfoDestino);
            this.Controls.Add(this.InfOrigen);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Sincronizar);
            this.Controls.Add(this.SelectDestino);
            this.Controls.Add(this.SelectOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectDestino;
        private System.Windows.Forms.Button Sincronizar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label InfOrigen;
        private System.Windows.Forms.Label InfoDestino;
        private System.Windows.Forms.Button SelectOrigen;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

