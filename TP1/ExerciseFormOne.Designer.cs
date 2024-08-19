namespace TP1
{
    partial class ExerciseFormOne
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMoveSelection = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbSelectedNames = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.lbAddedNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(208, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMoveSelection
            // 
            this.btnMoveSelection.Enabled = false;
            this.btnMoveSelection.Location = new System.Drawing.Point(208, 155);
            this.btnMoveSelection.Name = "btnMoveSelection";
            this.btnMoveSelection.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSelection.TabIndex = 1;
            this.btnMoveSelection.Text = ">";
            this.btnMoveSelection.UseVisualStyleBackColor = true;
            this.btnMoveSelection.Click += new System.EventHandler(this.btnMoveSelection_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbSelectedNames
            // 
            this.lbSelectedNames.FormattingEnabled = true;
            this.lbSelectedNames.Location = new System.Drawing.Point(289, 95);
            this.lbSelectedNames.Name = "lbSelectedNames";
            this.lbSelectedNames.Size = new System.Drawing.Size(197, 199);
            this.lbSelectedNames.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(147, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Ingrese un nombre";
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.Enabled = false;
            this.btnMoveAll.Location = new System.Drawing.Point(208, 184);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnMoveAll.TabIndex = 5;
            this.btnMoveAll.Text = ">>";
            this.btnMoveAll.UseVisualStyleBackColor = true;
            this.btnMoveAll.Click += new System.EventHandler(this.btnMoveAll_Click);
            // 
            // lbAddedNames
            // 
            this.lbAddedNames.FormattingEnabled = true;
            this.lbAddedNames.Location = new System.Drawing.Point(5, 95);
            this.lbAddedNames.Name = "lbAddedNames";
            this.lbAddedNames.Size = new System.Drawing.Size(197, 199);
            this.lbAddedNames.TabIndex = 6;
            // 
            // ExerciseFormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 336);
            this.Controls.Add(this.lbAddedNames);
            this.Controls.Add(this.btnMoveAll);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbSelectedNames);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnMoveSelection);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.Name = "ExerciseFormOne";
            this.Text = "Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMoveSelection;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lbSelectedNames;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.ListBox lbAddedNames;
    }
}