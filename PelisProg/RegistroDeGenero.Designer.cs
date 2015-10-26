namespace PelisProg
{
    partial class RegistroDeGenero
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
            this.CancelarGenerobutton = new System.Windows.Forms.Button();
            this.GuardarGenerobutton = new System.Windows.Forms.Button();
            this.DesGenerolabel = new System.Windows.Forms.Label();
            this.DescripGenerotextBox = new System.Windows.Forms.TextBox();
            this.IdgenerotextBox = new System.Windows.Forms.TextBox();
            this.Idgenerolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarGenerobutton
            // 
            this.CancelarGenerobutton.Location = new System.Drawing.Point(216, 287);
            this.CancelarGenerobutton.Name = "CancelarGenerobutton";
            this.CancelarGenerobutton.Size = new System.Drawing.Size(75, 23);
            this.CancelarGenerobutton.TabIndex = 8;
            this.CancelarGenerobutton.Text = "Cancelar";
            this.CancelarGenerobutton.UseVisualStyleBackColor = true;
            this.CancelarGenerobutton.Click += new System.EventHandler(this.CancelarGenerobutton_Click);
            // 
            // GuardarGenerobutton
            // 
            this.GuardarGenerobutton.Location = new System.Drawing.Point(61, 287);
            this.GuardarGenerobutton.Name = "GuardarGenerobutton";
            this.GuardarGenerobutton.Size = new System.Drawing.Size(75, 23);
            this.GuardarGenerobutton.TabIndex = 7;
            this.GuardarGenerobutton.Text = "Guardar";
            this.GuardarGenerobutton.UseVisualStyleBackColor = true;
            this.GuardarGenerobutton.Click += new System.EventHandler(this.GuardarGenerobutton_Click);
            // 
            // DesGenerolabel
            // 
            this.DesGenerolabel.AutoSize = true;
            this.DesGenerolabel.Location = new System.Drawing.Point(49, 129);
            this.DesGenerolabel.Name = "DesGenerolabel";
            this.DesGenerolabel.Size = new System.Drawing.Size(116, 13);
            this.DesGenerolabel.TabIndex = 6;
            this.DesGenerolabel.Text = "Descripcion del genero";
            this.DesGenerolabel.Click += new System.EventHandler(this.DesGenerolabel_Click);
            // 
            // DescripGenerotextBox
            // 
            this.DescripGenerotextBox.Location = new System.Drawing.Point(171, 129);
            this.DescripGenerotextBox.Name = "DescripGenerotextBox";
            this.DescripGenerotextBox.Size = new System.Drawing.Size(120, 20);
            this.DescripGenerotextBox.TabIndex = 9;
            // 
            // IdgenerotextBox
            // 
            this.IdgenerotextBox.Location = new System.Drawing.Point(171, 91);
            this.IdgenerotextBox.Name = "IdgenerotextBox";
            this.IdgenerotextBox.Size = new System.Drawing.Size(120, 20);
            this.IdgenerotextBox.TabIndex = 10;
            this.IdgenerotextBox.TextChanged += new System.EventHandler(this.IdgenerotextBox_TextChanged);
            // 
            // Idgenerolabel
            // 
            this.Idgenerolabel.AutoSize = true;
            this.Idgenerolabel.Location = new System.Drawing.Point(49, 94);
            this.Idgenerolabel.Name = "Idgenerolabel";
            this.Idgenerolabel.Size = new System.Drawing.Size(52, 13);
            this.Idgenerolabel.TabIndex = 11;
            this.Idgenerolabel.Text = "Id genero";
            // 
            // RegistroDeGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 422);
            this.Controls.Add(this.Idgenerolabel);
            this.Controls.Add(this.IdgenerotextBox);
            this.Controls.Add(this.DescripGenerotextBox);
            this.Controls.Add(this.CancelarGenerobutton);
            this.Controls.Add(this.GuardarGenerobutton);
            this.Controls.Add(this.DesGenerolabel);
            this.Name = "RegistroDeGenero";
            this.Text = "RegistroDeGenero";
            this.Load += new System.EventHandler(this.RegistroDeGenero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarGenerobutton;
        private System.Windows.Forms.Button GuardarGenerobutton;
        private System.Windows.Forms.Label DesGenerolabel;
        private System.Windows.Forms.TextBox DescripGenerotextBox;
        private System.Windows.Forms.TextBox IdgenerotextBox;
        private System.Windows.Forms.Label Idgenerolabel;
    }
}