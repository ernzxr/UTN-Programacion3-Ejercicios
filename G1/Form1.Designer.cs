namespace G1
{
    partial class frmListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.lvNavigation = new System.Windows.Forms.ListView();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.rbtnLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbtnSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbtnList = new System.Windows.Forms.RadioButton();
            this.rbtnDetail = new System.Windows.Forms.RadioButton();
            this.rbtnTittle = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.gbxView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNavigation
            // 
            this.lvNavigation.HideSelection = false;
            this.lvNavigation.LargeImageList = this.imageListLarge;
            this.lvNavigation.Location = new System.Drawing.Point(61, 75);
            this.lvNavigation.Name = "lvNavigation";
            this.lvNavigation.Size = new System.Drawing.Size(449, 287);
            this.lvNavigation.SmallImageList = this.imageListSmall;
            this.lvNavigation.TabIndex = 0;
            this.lvNavigation.UseCompatibleStateImageBehavior = false;
            this.lvNavigation.View = System.Windows.Forms.View.Details;
            this.lvNavigation.ItemActivate += new System.EventHandler(this.lvNavigation_ItemActivate);
            // 
            // gbxView
            // 
            this.gbxView.Controls.Add(this.rbtnTittle);
            this.gbxView.Controls.Add(this.rbtnDetail);
            this.gbxView.Controls.Add(this.rbtnList);
            this.gbxView.Controls.Add(this.rbtnSmallIcon);
            this.gbxView.Controls.Add(this.rbtnLargeIcon);
            this.gbxView.Location = new System.Drawing.Point(541, 75);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(200, 287);
            this.gbxView.TabIndex = 1;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "Modo de Vista";
            // 
            // rbtnLargeIcon
            // 
            this.rbtnLargeIcon.AutoSize = true;
            this.rbtnLargeIcon.Location = new System.Drawing.Point(24, 59);
            this.rbtnLargeIcon.Name = "rbtnLargeIcon";
            this.rbtnLargeIcon.Size = new System.Drawing.Size(73, 17);
            this.rbtnLargeIcon.TabIndex = 0;
            this.rbtnLargeIcon.Text = "LargeIcon";
            this.rbtnLargeIcon.UseVisualStyleBackColor = true;
            this.rbtnLargeIcon.CheckedChanged += new System.EventHandler(this.rbtnLargeIcon_CheckedChanged);
            // 
            // rbtnSmallIcon
            // 
            this.rbtnSmallIcon.AutoSize = true;
            this.rbtnSmallIcon.Location = new System.Drawing.Point(24, 82);
            this.rbtnSmallIcon.Name = "rbtnSmallIcon";
            this.rbtnSmallIcon.Size = new System.Drawing.Size(71, 17);
            this.rbtnSmallIcon.TabIndex = 1;
            this.rbtnSmallIcon.Text = "SmallIcon";
            this.rbtnSmallIcon.UseVisualStyleBackColor = true;
            this.rbtnSmallIcon.CheckedChanged += new System.EventHandler(this.rbtnSmallIcon_CheckedChanged);
            // 
            // rbtnList
            // 
            this.rbtnList.AutoSize = true;
            this.rbtnList.Location = new System.Drawing.Point(24, 105);
            this.rbtnList.Name = "rbtnList";
            this.rbtnList.Size = new System.Drawing.Size(47, 17);
            this.rbtnList.TabIndex = 2;
            this.rbtnList.Text = "Lista";
            this.rbtnList.UseVisualStyleBackColor = true;
            this.rbtnList.CheckedChanged += new System.EventHandler(this.rbtnList_CheckedChanged);
            // 
            // rbtnDetail
            // 
            this.rbtnDetail.AutoSize = true;
            this.rbtnDetail.Checked = true;
            this.rbtnDetail.Location = new System.Drawing.Point(24, 128);
            this.rbtnDetail.Name = "rbtnDetail";
            this.rbtnDetail.Size = new System.Drawing.Size(58, 17);
            this.rbtnDetail.TabIndex = 3;
            this.rbtnDetail.TabStop = true;
            this.rbtnDetail.Text = "Detalle";
            this.rbtnDetail.UseVisualStyleBackColor = true;
            this.rbtnDetail.CheckedChanged += new System.EventHandler(this.rbtnDetail_CheckedChanged);
            // 
            // rbtnTittle
            // 
            this.rbtnTittle.AutoSize = true;
            this.rbtnTittle.Location = new System.Drawing.Point(24, 151);
            this.rbtnTittle.Name = "rbtnTittle";
            this.rbtnTittle.Size = new System.Drawing.Size(51, 17);
            this.rbtnTittle.TabIndex = 4;
            this.rbtnTittle.Text = "Titulo";
            this.rbtnTittle.UseVisualStyleBackColor = true;
            this.rbtnTittle.CheckedChanged += new System.EventHandler(this.rbtnTittle_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(243, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.Location = new System.Drawing.Point(61, 54);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(449, 18);
            this.lblTittle.TabIndex = 3;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "folder16.png");
            this.imageListSmall.Images.SetKeyName(1, "page16.png");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "folder32.ico");
            this.imageListLarge.Images.SetKeyName(1, "page32.ico");
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxView);
            this.Controls.Add(this.lvNavigation);
            this.Name = "frmListView";
            this.Text = "ListView";
            this.gbxView.ResumeLayout(false);
            this.gbxView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvNavigation;
        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.RadioButton rbtnTittle;
        private System.Windows.Forms.RadioButton rbtnDetail;
        private System.Windows.Forms.RadioButton rbtnList;
        private System.Windows.Forms.RadioButton rbtnSmallIcon;
        private System.Windows.Forms.RadioButton rbtnLargeIcon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
    }
}

