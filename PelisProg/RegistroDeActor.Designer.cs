namespace PelisProg
{
    partial class RegistroDeActor
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
            this.IdAclabel = new System.Windows.Forms.Label();
            this.NombreActlabel = new System.Windows.Forms.Label();
            this.IdacttextBox = new System.Windows.Forms.TextBox();
            this.NombreacttextBox = new System.Windows.Forms.TextBox();
            this.GuadarActbutton = new System.Windows.Forms.Button();
            this.LimpiarActbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdAclabel
            // 
            this.IdAclabel.AutoSize = true;
            this.IdAclabel.Location = new System.Drawing.Point(45, 57);
            this.IdAclabel.Name = "IdAclabel";
            this.IdAclabel.Size = new System.Drawing.Size(44, 13);
            this.IdAclabel.TabIndex = 0;
            this.IdAclabel.Text = "Id Actor";
            // 
            // NombreActlabel
            // 
            this.NombreActlabel.AutoSize = true;
            this.NombreActlabel.Location = new System.Drawing.Point(45, 112);
            this.NombreActlabel.Name = "NombreActlabel";
            this.NombreActlabel.Size = new System.Drawing.Size(72, 13);
            this.NombreActlabel.TabIndex = 1;
            this.NombreActlabel.Text = "Nombre Actor";
            // 
            // IdacttextBox
            // 
            this.IdacttextBox.Location = new System.Drawing.Point(143, 57);
            this.IdacttextBox.Name = "IdacttextBox";
            this.IdacttextBox.Size = new System.Drawing.Size(117, 20);
            this.IdacttextBox.TabIndex = 2;
            // 
            // NombreacttextBox
            // 
            this.NombreacttextBox.Location = new System.Drawing.Point(143, 105);
            this.NombreacttextBox.Name = "NombreacttextBox";
            this.NombreacttextBox.Size = new System.Drawing.Size(117, 20);
            this.NombreacttextBox.TabIndex = 3;
            // 
            // GuadarActbutton
            // 
            this.GuadarActbutton.Location = new System.Drawing.Point(48, 179);
            this.GuadarActbutton.Name = "GuadarActbutton";
            this.GuadarActbutton.Size = new System.Drawing.Size(75, 23);
            this.GuadarActbutton.TabIndex = 4;
            this.GuadarActbutton.Text = "Guardar";
            this.GuadarActbutton.UseVisualStyleBackColor = true;
            this.GuadarActbutton.Click += new System.EventHandler(this.GuadarActbutton_Click);
            // 
            // LimpiarActbutton
            // 
            this.LimpiarActbutton.Location = new System.Drawing.Point(185, 179);
            this.LimpiarActbutton.Name = "LimpiarActbutton";
            this.LimpiarActbutton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarActbutton.TabIndex = 5;
            this.LimpiarActbutton.Text = "Limpiar";
            this.LimpiarActbutton.UseVisualStyleBackColor = true;
            this.LimpiarActbutton.Click += new System.EventHandler(this.LimpiarActbutton_Click);
            // 
            // RegistroDeActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LimpiarActbutton);
            this.Controls.Add(this.GuadarActbutton);
            this.Controls.Add(this.NombreacttextBox);
            this.Controls.Add(this.IdacttextBox);
            this.Controls.Add(this.NombreActlabel);
            this.Controls.Add(this.IdAclabel);
            this.Name = "RegistroDeActor";
            this.Text = "RegistroDeActor";
            this.Load += new System.EventHandler(this.RegistroDeActor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdAclabel;
        private System.Windows.Forms.Label NombreActlabel;
        private System.Windows.Forms.TextBox IdacttextBox;
        private System.Windows.Forms.TextBox NombreacttextBox;
        private System.Windows.Forms.Button GuadarActbutton;
        private System.Windows.Forms.Button LimpiarActbutton;
    }
}