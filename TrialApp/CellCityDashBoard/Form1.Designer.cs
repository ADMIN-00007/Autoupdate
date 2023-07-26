namespace CellCityDashBoard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            headerpanel = new DataGridView();
            sidepanel = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            DateTimeMainLabel1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)headerpanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sidepanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 103);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 1;
            label1.Text = "Version 3.0";
            // 
            // headerpanel
            // 
            headerpanel.BackgroundColor = SystemColors.ActiveCaptionText;
            headerpanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            headerpanel.GridColor = SystemColors.ActiveCaptionText;
            headerpanel.Location = new Point(155, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.RowTemplate.Height = 36;
            headerpanel.Size = new Size(1298, 100);
            headerpanel.TabIndex = 2;
            // 
            // sidepanel
            // 
            sidepanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sidepanel.BackgroundColor = SystemColors.ActiveCaptionText;
            sidepanel.BorderStyle = BorderStyle.Fixed3D;
            sidepanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sidepanel.Dock = DockStyle.Left;
            sidepanel.GridColor = SystemColors.ActiveCaptionText;
            sidepanel.Location = new Point(0, 0);
            sidepanel.Name = "sidepanel";
            sidepanel.RowTemplate.Height = 36;
            sidepanel.Size = new Size(160, 608);
            sidepanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources._7koo;
            pictureBox1.Location = new Point(160, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources._215_2151329_logo_cell_city_logo_botswana;
            pictureBox2.Location = new Point(262, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(349, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Image = Properties.Resources._7YyR;
            pictureBox3.Location = new Point(612, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // DateTimeMainLabel1
            // 
            DateTimeMainLabel1.AutoSize = true;
            DateTimeMainLabel1.BackColor = Color.Black;
            DateTimeMainLabel1.ForeColor = Color.White;
            DateTimeMainLabel1.Location = new Point(796, 78);
            DateTimeMainLabel1.Name = "DateTimeMainLabel1";
            DateTimeMainLabel1.Size = new Size(236, 20);
            DateTimeMainLabel1.TabIndex = 7;
            DateTimeMainLabel1.Text = "Welcome to Cell City Dashboard";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1453, 608);
            Controls.Add(DateTimeMainLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(sidepanel);
            Controls.Add(headerpanel);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Cellcity Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)headerpanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)sidepanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView headerpanel;
        private DataGridView sidepanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label DateTimeMainLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}