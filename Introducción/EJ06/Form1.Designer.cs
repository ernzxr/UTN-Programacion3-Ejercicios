namespace EJ06
{
    partial class MainForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblProgrammer = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cbxProgrammer = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.gbxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bebas Neue Pro Exp Eb", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NOMBRE";
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.AutoSize = true;
            this.lblProgrammer.Font = new System.Drawing.Font("Bebas Neue Pro Exp Eb", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammer.Location = new System.Drawing.Point(241, 87);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.Size = new System.Drawing.Size(122, 23);
            this.lblProgrammer.TabIndex = 1;
            this.lblProgrammer.Text = "PROGRAMADOR";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Bebas Neue Pro Exp Eb", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(31, 146);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(63, 23);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "SALIDA";
            // 
            // gbxGender
            // 
            this.gbxGender.Controls.Add(this.rbtnMale);
            this.gbxGender.Controls.Add(this.rbtnFemale);
            this.gbxGender.Font = new System.Drawing.Font("Bebas Neue Pro Exp Eb", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGender.Location = new System.Drawing.Point(35, 66);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(178, 58);
            this.gbxGender.TabIndex = 3;
            this.gbxGender.TabStop = false;
            this.gbxGender.Text = "SEXO";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(25, 22);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(62, 17);
            this.rbtnMale.TabIndex = 5;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "HOMBRE";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(96, 22);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(54, 17);
            this.rbtnFemale.TabIndex = 6;
            this.rbtnFemale.Text = "MUJER";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(325, 19);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(76, 21);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbxProgrammer
            // 
            this.cbxProgrammer.AutoSize = true;
            this.cbxProgrammer.Location = new System.Drawing.Point(369, 93);
            this.cbxProgrammer.Name = "cbxProgrammer";
            this.cbxProgrammer.Size = new System.Drawing.Size(15, 14);
            this.cbxProgrammer.TabIndex = 7;
            this.cbxProgrammer.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(99, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(25, 178);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(376, 88);
            this.txtOutput.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 308);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbxProgrammer);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbxGender);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblProgrammer);
            this.Controls.Add(this.lblName);
            this.Name = "MainForm";
            this.Text = "RadioButton y CheckBox";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.CheckBox cbxProgrammer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

