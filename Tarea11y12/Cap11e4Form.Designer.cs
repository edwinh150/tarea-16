namespace Tarea11y12
{
    partial class Cap11e4Form
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
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ruta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.Location = new System.Drawing.Point(132, 200);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Borrarbutton.TabIndex = 6;
            this.Borrarbutton.Text = "Borrar";
            this.Borrarbutton.UseVisualStyleBackColor = true;
            this.Borrarbutton.Click += new System.EventHandler(this.Borrarbutton_Click);
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(54, 132);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(236, 20);
            this.RutatextBox.TabIndex = 4;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(54, 74);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(236, 20);
            this.NombretextBox.TabIndex = 5;
            // 
            // Cap11e4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Borrarbutton);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Cap11e4Form";
            this.Text = "Cap11e4Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.TextBox NombretextBox;
    }
}