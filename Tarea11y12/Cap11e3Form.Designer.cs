namespace Tarea11y12
{
    partial class Cap11e3Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Copiarbutton = new System.Windows.Forms.Button();
            this.NuevaRutatextBox = new System.Windows.Forms.TextBox();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nueva Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ruta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // Copiarbutton
            // 
            this.Copiarbutton.Location = new System.Drawing.Point(141, 257);
            this.Copiarbutton.Name = "Copiarbutton";
            this.Copiarbutton.Size = new System.Drawing.Size(75, 23);
            this.Copiarbutton.TabIndex = 6;
            this.Copiarbutton.Text = "Copiar";
            this.Copiarbutton.UseVisualStyleBackColor = true;
            this.Copiarbutton.Click += new System.EventHandler(this.Copiarbutton_Click);
            // 
            // NuevaRutatextBox
            // 
            this.NuevaRutatextBox.Location = new System.Drawing.Point(64, 190);
            this.NuevaRutatextBox.Name = "NuevaRutatextBox";
            this.NuevaRutatextBox.Size = new System.Drawing.Size(236, 20);
            this.NuevaRutatextBox.TabIndex = 3;
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(64, 128);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(236, 20);
            this.RutatextBox.TabIndex = 4;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(64, 70);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(236, 20);
            this.NombretextBox.TabIndex = 5;
            // 
            // Cap11e3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Copiarbutton);
            this.Controls.Add(this.NuevaRutatextBox);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Cap11e3Form";
            this.Text = "Cap11e3Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Copiarbutton;
        private System.Windows.Forms.TextBox NuevaRutatextBox;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.TextBox NombretextBox;
    }
}