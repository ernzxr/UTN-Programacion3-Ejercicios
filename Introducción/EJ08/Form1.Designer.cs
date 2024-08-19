namespace EJ08
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
            this.clbNumbers = new System.Windows.Forms.CheckedListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clbNumbers
            // 
            this.clbNumbers.CheckOnClick = true;
            this.clbNumbers.FormattingEnabled = true;
            this.clbNumbers.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinto",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve"});
            this.clbNumbers.Location = new System.Drawing.Point(55, 71);
            this.clbNumbers.Name = "clbNumbers";
            this.clbNumbers.Size = new System.Drawing.Size(285, 304);
            this.clbNumbers.TabIndex = 0;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(346, 219);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Mover";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMove_MouseClick);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(427, 72);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(285, 303);
            this.lbNumbers.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.clbNumbers);
            this.Name = "MainForm";
            this.Text = "ListBox y CheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbNumbers;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.ListBox lbNumbers;
    }
}

