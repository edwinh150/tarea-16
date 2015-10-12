namespace Tarea11y12
{
    partial class Cap12e1Form
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
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(47, 74);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(215, 20);
            this.NumerotextBox.TabIndex = 0;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(281, 72);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 1;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Location = new System.Drawing.Point(47, 128);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(215, 134);
            this.ResultadolistBox.TabIndex = 2;
            // 
            // Cap12e1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 294);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.NumerotextBox);
            this.Name = "Cap12e1Form";
            this.Text = "Cap12e1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.ListBox ResultadolistBox;
    }
}