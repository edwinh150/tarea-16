namespace Tarea11y12
{
    partial class Cap11e2Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ruta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(298, 91);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 12;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(34, 126);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(236, 20);
            this.RutatextBox.TabIndex = 10;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(34, 68);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(236, 20);
            this.NombretextBox.TabIndex = 11;
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Location = new System.Drawing.Point(34, 189);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(236, 121);
            this.ResultadolistBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Resultado";
            // 
            // Cap11e2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Cap11e2Form";
            this.Text = "Cap12e2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.Label label3;
    }
}