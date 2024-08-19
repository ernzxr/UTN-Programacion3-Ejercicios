namespace TP1
{
    partial class ExerciseFormThree
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
            this.gbxGenre = new System.Windows.Forms.GroupBox();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.gbxMaritalStatus = new System.Windows.Forms.GroupBox();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.clbOccupation = new System.Windows.Forms.CheckedListBox();
            this.gbxOccupation = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.gbxGenre.SuspendLayout();
            this.gbxMaritalStatus.SuspendLayout();
            this.gbxOccupation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGenre
            // 
            this.gbxGenre.Controls.Add(this.rbtnOther);
            this.gbxGenre.Controls.Add(this.rbtnFemale);
            this.gbxGenre.Controls.Add(this.rbtnMale);
            this.gbxGenre.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGenre.Location = new System.Drawing.Point(62, 31);
            this.gbxGenre.Name = "gbxGenre";
            this.gbxGenre.Size = new System.Drawing.Size(276, 64);
            this.gbxGenre.TabIndex = 0;
            this.gbxGenre.TabStop = false;
            this.gbxGenre.Text = "Sexo";
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOther.Location = new System.Drawing.Point(202, 27);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(51, 19);
            this.rbtnOther.TabIndex = 3;
            this.rbtnOther.Text = "Otro";
            this.rbtnOther.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Checked = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(21, 27);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(84, 19);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Femenino";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(111, 27);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(85, 19);
            this.rbtnMale.TabIndex = 2;
            this.rbtnMale.Text = "Masculino";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // gbxMaritalStatus
            // 
            this.gbxMaritalStatus.Controls.Add(this.rbtnMarried);
            this.gbxMaritalStatus.Controls.Add(this.rbtnSingle);
            this.gbxMaritalStatus.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMaritalStatus.Location = new System.Drawing.Point(62, 101);
            this.gbxMaritalStatus.Name = "gbxMaritalStatus";
            this.gbxMaritalStatus.Size = new System.Drawing.Size(276, 64);
            this.gbxMaritalStatus.TabIndex = 4;
            this.gbxMaritalStatus.TabStop = false;
            this.gbxMaritalStatus.Text = "Estado Civil";
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Checked = true;
            this.rbtnMarried.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMarried.Location = new System.Drawing.Point(54, 27);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(78, 19);
            this.rbtnMarried.TabIndex = 1;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Casado/a";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSingle.Location = new System.Drawing.Point(144, 27);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(76, 19);
            this.rbtnSingle.TabIndex = 2;
            this.rbtnSingle.Text = "Soltero/a";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // clbOccupation
            // 
            this.clbOccupation.CheckOnClick = true;
            this.clbOccupation.FormattingEnabled = true;
            this.clbOccupation.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester",
            "Otro"});
            this.clbOccupation.Location = new System.Drawing.Point(23, 25);
            this.clbOccupation.Name = "clbOccupation";
            this.clbOccupation.Size = new System.Drawing.Size(232, 100);
            this.clbOccupation.TabIndex = 5;
            this.clbOccupation.SelectedValueChanged += new System.EventHandler(this.clbOccupation_SelectedValueChanged);
            // 
            // gbxOccupation
            // 
            this.gbxOccupation.Controls.Add(this.clbOccupation);
            this.gbxOccupation.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOccupation.Location = new System.Drawing.Point(62, 171);
            this.gbxOccupation.Name = "gbxOccupation";
            this.gbxOccupation.Size = new System.Drawing.Size(276, 139);
            this.gbxOccupation.TabIndex = 5;
            this.gbxOccupation.TabStop = false;
            this.gbxOccupation.Text = "Ocupación";
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(134, 325);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Mostrar selección";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(59, 360);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(0, 13);
            this.lblPreview.TabIndex = 7;
            // 
            // ExerciseFormThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 529);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbxOccupation);
            this.Controls.Add(this.gbxMaritalStatus);
            this.Controls.Add(this.gbxGenre);
            this.MaximizeBox = false;
            this.Name = "ExerciseFormThree";
            this.Text = "Ejercicio 3";
            this.gbxGenre.ResumeLayout(false);
            this.gbxGenre.PerformLayout();
            this.gbxMaritalStatus.ResumeLayout(false);
            this.gbxMaritalStatus.PerformLayout();
            this.gbxOccupation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGenre;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.GroupBox gbxMaritalStatus;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.CheckedListBox clbOccupation;
        private System.Windows.Forms.GroupBox gbxOccupation;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblPreview;
    }
}