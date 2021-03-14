
namespace gallery
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuPage1 = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imagesNamesList = new System.Windows.Forms.ListBox();
            this.OKButtonMenu = new System.Windows.Forms.Button();
            this.deletPicturesButton = new System.Windows.Forms.Button();
            this.addPicturesButton = new System.Windows.Forms.Button();
            this.GobackButton = new System.Windows.Forms.Button();
            this.selectModePage2 = new System.Windows.Forms.TabPage();
            this.OKButtonSelectModePage2 = new System.Windows.Forms.Button();
            this.threeModesList = new System.Windows.Forms.ListBox();
            this.ModePage3 = new System.Windows.Forms.TabPage();
            this.readyToDisplayLabel = new System.Windows.Forms.Label();
            this.OKPage3Button = new System.Windows.Forms.Button();
            this.deletePage3Button = new System.Windows.Forms.Button();
            this.DisplayList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.multiShowPage4 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.menuPage1.SuspendLayout();
            this.selectModePage2.SuspendLayout();
            this.ModePage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.multiShowPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.menuPage1);
            this.tabControl1.Controls.Add(this.selectModePage2);
            this.tabControl1.Controls.Add(this.ModePage3);
            this.tabControl1.Controls.Add(this.multiShowPage4);
            this.tabControl1.Location = new System.Drawing.Point(-5, -23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // menuPage1
            // 
            this.menuPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuPage1.BackgroundImage = global::gallery.Properties.Resources.oqci8i0__4_;
            this.menuPage1.Controls.Add(this.exitButton);
            this.menuPage1.Controls.Add(this.label1);
            this.menuPage1.Controls.Add(this.imagesNamesList);
            this.menuPage1.Controls.Add(this.OKButtonMenu);
            this.menuPage1.Controls.Add(this.deletPicturesButton);
            this.menuPage1.Controls.Add(this.addPicturesButton);
            this.menuPage1.Controls.Add(this.GobackButton);
            this.menuPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuPage1.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPage1.Location = new System.Drawing.Point(4, 22);
            this.menuPage1.Name = "menuPage1";
            this.menuPage1.Padding = new System.Windows.Forms.Padding(3);
            this.menuPage1.Size = new System.Drawing.Size(803, 603);
            this.menuPage1.TabIndex = 0;
            this.menuPage1.Text = "menu";
            this.menuPage1.Click += new System.EventHandler(this.menuPage1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Image = global::gallery.Properties.Resources.Alarm_Error_icon__1_;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(749, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(38, 39);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "selected pictures";
            // 
            // imagesNamesList
            // 
            this.imagesNamesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagesNamesList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagesNamesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesNamesList.Font = new System.Drawing.Font("Andalus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesNamesList.FormattingEnabled = true;
            this.imagesNamesList.ItemHeight = 20;
            this.imagesNamesList.Location = new System.Drawing.Point(282, 123);
            this.imagesNamesList.Name = "imagesNamesList";
            this.imagesNamesList.Size = new System.Drawing.Size(260, 122);
            this.imagesNamesList.Sorted = true;
            this.imagesNamesList.TabIndex = 1;
            this.imagesNamesList.SelectedIndexChanged += new System.EventHandler(this.imagesNamesList_SelectedIndexChanged);
            // 
            // OKButtonMenu
            // 
            this.OKButtonMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKButtonMenu.BackColor = System.Drawing.Color.MediumAquamarine;
            this.OKButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButtonMenu.Enabled = false;
            this.OKButtonMenu.FlatAppearance.BorderSize = 2;
            this.OKButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButtonMenu.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButtonMenu.Image = global::gallery.Properties.Resources.check_1_icon;
            this.OKButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKButtonMenu.Location = new System.Drawing.Point(533, 273);
            this.OKButtonMenu.Name = "OKButtonMenu";
            this.OKButtonMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OKButtonMenu.Size = new System.Drawing.Size(168, 46);
            this.OKButtonMenu.TabIndex = 3;
            this.OKButtonMenu.Text = "OK";
            this.OKButtonMenu.UseVisualStyleBackColor = false;
            this.OKButtonMenu.Click += new System.EventHandler(this.OKButtonMenu_Click);
            // 
            // deletPicturesButton
            // 
            this.deletPicturesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletPicturesButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.deletPicturesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletPicturesButton.Enabled = false;
            this.deletPicturesButton.FlatAppearance.BorderSize = 2;
            this.deletPicturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletPicturesButton.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletPicturesButton.Image = global::gallery.Properties.Resources.red_cross_icon;
            this.deletPicturesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletPicturesButton.Location = new System.Drawing.Point(359, 273);
            this.deletPicturesButton.Name = "deletPicturesButton";
            this.deletPicturesButton.Size = new System.Drawing.Size(168, 46);
            this.deletPicturesButton.TabIndex = 2;
            this.deletPicturesButton.Text = "Delet picture";
            this.deletPicturesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletPicturesButton.UseVisualStyleBackColor = false;
            this.deletPicturesButton.Click += new System.EventHandler(this.deletPicturesButton_Click);
            // 
            // addPicturesButton
            // 
            this.addPicturesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPicturesButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addPicturesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPicturesButton.FlatAppearance.BorderSize = 2;
            this.addPicturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPicturesButton.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPicturesButton.Image = global::gallery.Properties.Resources.eog_icon;
            this.addPicturesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPicturesButton.Location = new System.Drawing.Point(185, 273);
            this.addPicturesButton.Name = "addPicturesButton";
            this.addPicturesButton.Size = new System.Drawing.Size(168, 46);
            this.addPicturesButton.TabIndex = 0;
            this.addPicturesButton.Text = "Add pictures";
            this.addPicturesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPicturesButton.UseVisualStyleBackColor = false;
            this.addPicturesButton.Click += new System.EventHandler(this.addPicturesButton_Click);
            // 
            // GobackButton
            // 
            this.GobackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GobackButton.Enabled = false;
            this.GobackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GobackButton.FlatAppearance.BorderSize = 0;
            this.GobackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GobackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GobackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GobackButton.Font = new System.Drawing.Font("Snap ITC", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GobackButton.Image = global::gallery.Properties.Resources.arrow_back_icon;
            this.GobackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GobackButton.Location = new System.Drawing.Point(6, 6);
            this.GobackButton.Name = "GobackButton";
            this.GobackButton.Size = new System.Drawing.Size(42, 40);
            this.GobackButton.TabIndex = 0;
            this.GobackButton.UseVisualStyleBackColor = false;
            this.GobackButton.Click += new System.EventHandler(this.GobackButton_Click);
            // 
            // selectModePage2
            // 
            this.selectModePage2.BackgroundImage = global::gallery.Properties.Resources.oqci8i0__4_;
            this.selectModePage2.Controls.Add(this.OKButtonSelectModePage2);
            this.selectModePage2.Controls.Add(this.threeModesList);
            this.selectModePage2.Location = new System.Drawing.Point(4, 22);
            this.selectModePage2.Name = "selectModePage2";
            this.selectModePage2.Size = new System.Drawing.Size(803, 603);
            this.selectModePage2.TabIndex = 1;
            this.selectModePage2.Text = "select modePage2";
            this.selectModePage2.UseVisualStyleBackColor = true;
            // 
            // OKButtonSelectModePage2
            // 
            this.OKButtonSelectModePage2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKButtonSelectModePage2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.OKButtonSelectModePage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OKButtonSelectModePage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButtonSelectModePage2.Enabled = false;
            this.OKButtonSelectModePage2.FlatAppearance.BorderSize = 2;
            this.OKButtonSelectModePage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButtonSelectModePage2.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButtonSelectModePage2.Image = global::gallery.Properties.Resources.check_1_icon;
            this.OKButtonSelectModePage2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKButtonSelectModePage2.Location = new System.Drawing.Point(337, 220);
            this.OKButtonSelectModePage2.Name = "OKButtonSelectModePage2";
            this.OKButtonSelectModePage2.Size = new System.Drawing.Size(168, 46);
            this.OKButtonSelectModePage2.TabIndex = 2;
            this.OKButtonSelectModePage2.Text = "OK";
            this.OKButtonSelectModePage2.UseVisualStyleBackColor = false;
            this.OKButtonSelectModePage2.Click += new System.EventHandler(this.OKButtonSelectModePage2_Click);
            // 
            // threeModesList
            // 
            this.threeModesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeModesList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.threeModesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeModesList.FormattingEnabled = true;
            this.threeModesList.Items.AddRange(new object[] {
            "Single picture",
            "Multi picture",
            "Slide show"});
            this.threeModesList.Location = new System.Drawing.Point(379, 113);
            this.threeModesList.Name = "threeModesList";
            this.threeModesList.Size = new System.Drawing.Size(81, 41);
            this.threeModesList.TabIndex = 1;
            this.threeModesList.SelectedIndexChanged += new System.EventHandler(this.threeModesList_SelectedIndexChanged);
            // 
            // ModePage3
            // 
            this.ModePage3.BackgroundImage = global::gallery.Properties.Resources.oqci8i0__4_;
            this.ModePage3.Controls.Add(this.readyToDisplayLabel);
            this.ModePage3.Controls.Add(this.OKPage3Button);
            this.ModePage3.Controls.Add(this.deletePage3Button);
            this.ModePage3.Controls.Add(this.DisplayList);
            this.ModePage3.Controls.Add(this.pictureBox1);
            this.ModePage3.Location = new System.Drawing.Point(4, 22);
            this.ModePage3.Name = "ModePage3";
            this.ModePage3.Size = new System.Drawing.Size(803, 603);
            this.ModePage3.TabIndex = 2;
            this.ModePage3.Text = "tabPage1";
            this.ModePage3.UseVisualStyleBackColor = true;
            // 
            // readyToDisplayLabel
            // 
            this.readyToDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readyToDisplayLabel.AutoSize = true;
            this.readyToDisplayLabel.Font = new System.Drawing.Font("SketchFlow Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyToDisplayLabel.Location = new System.Drawing.Point(590, 108);
            this.readyToDisplayLabel.Name = "readyToDisplayLabel";
            this.readyToDisplayLabel.Size = new System.Drawing.Size(115, 12);
            this.readyToDisplayLabel.TabIndex = 4;
            this.readyToDisplayLabel.Text = "Ready to display";
            // 
            // OKPage3Button
            // 
            this.OKPage3Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OKPage3Button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.OKPage3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKPage3Button.Enabled = false;
            this.OKPage3Button.FlatAppearance.BorderSize = 2;
            this.OKPage3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKPage3Button.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKPage3Button.Image = global::gallery.Properties.Resources.check_1_icon;
            this.OKPage3Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKPage3Button.Location = new System.Drawing.Point(329, 315);
            this.OKPage3Button.Name = "OKPage3Button";
            this.OKPage3Button.Size = new System.Drawing.Size(168, 46);
            this.OKPage3Button.TabIndex = 2;
            this.OKPage3Button.Text = "OK";
            this.OKPage3Button.UseVisualStyleBackColor = false;
            this.OKPage3Button.Click += new System.EventHandler(this.OKPage3Button_Click);
            // 
            // deletePage3Button
            // 
            this.deletePage3Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletePage3Button.BackColor = System.Drawing.Color.PaleVioletRed;
            this.deletePage3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePage3Button.Enabled = false;
            this.deletePage3Button.FlatAppearance.BorderSize = 2;
            this.deletePage3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePage3Button.Font = new System.Drawing.Font("Snap ITC", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePage3Button.Image = global::gallery.Properties.Resources.red_cross_icon__2_;
            this.deletePage3Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletePage3Button.Location = new System.Drawing.Point(592, 248);
            this.deletePage3Button.Name = "deletePage3Button";
            this.deletePage3Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deletePage3Button.Size = new System.Drawing.Size(118, 27);
            this.deletePage3Button.TabIndex = 1;
            this.deletePage3Button.Text = "Delete picture";
            this.deletePage3Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletePage3Button.UseVisualStyleBackColor = false;
            this.deletePage3Button.Visible = false;
            this.deletePage3Button.Click += new System.EventHandler(this.deletePage3Button_Click);
            // 
            // DisplayList
            // 
            this.DisplayList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DisplayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayList.FormattingEnabled = true;
            this.DisplayList.Location = new System.Drawing.Point(592, 123);
            this.DisplayList.Name = "DisplayList";
            this.DisplayList.Size = new System.Drawing.Size(118, 119);
            this.DisplayList.Sorted = true;
            this.DisplayList.TabIndex = 0;
            this.DisplayList.SelectedIndexChanged += new System.EventHandler(this.DisplayList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(50, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 444);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // multiShowPage4
            // 
            this.multiShowPage4.BackColor = System.Drawing.Color.Transparent;
            this.multiShowPage4.BackgroundImage = global::gallery.Properties.Resources.oqci8i0__4_;
            this.multiShowPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiShowPage4.Controls.Add(this.flowLayoutPanel1);
            this.multiShowPage4.Location = new System.Drawing.Point(4, 22);
            this.multiShowPage4.Name = "multiShowPage4";
            this.multiShowPage4.Size = new System.Drawing.Size(803, 603);
            this.multiShowPage4.TabIndex = 3;
            this.multiShowPage4.Text = "tabPage1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(693, 444);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 576);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(798, 22);
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Name = "statusBarPanel3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slideShowTimer
            // 
            this.slideShowTimer.Interval = 2000;
            this.slideShowTimer.Tick += new System.EventHandler(this.slideShowTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 598);
            this.ControlBox = false;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.menuPage1.ResumeLayout(false);
            this.menuPage1.PerformLayout();
            this.selectModePage2.ResumeLayout(false);
            this.ModePage3.ResumeLayout(false);
            this.ModePage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.multiShowPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage menuPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addPicturesButton;
        private System.Windows.Forms.ListBox imagesNamesList;
        private System.Windows.Forms.Button deletPicturesButton;
        private System.Windows.Forms.Button OKButtonMenu;
        private System.Windows.Forms.TabPage selectModePage2;
        private System.Windows.Forms.Button GobackButton;
        private System.Windows.Forms.Button OKButtonSelectModePage2;
        private System.Windows.Forms.ListBox threeModesList;
        private System.Windows.Forms.TabPage ModePage3;
        private System.Windows.Forms.ListBox DisplayList;
        private System.Windows.Forms.Button deletePage3Button;
        private System.Windows.Forms.Button OKPage3Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer slideShowTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label readyToDisplayLabel;
        private System.Windows.Forms.TabPage multiShowPage4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.StatusBarPanel statusBarPanel3;
    }
}

