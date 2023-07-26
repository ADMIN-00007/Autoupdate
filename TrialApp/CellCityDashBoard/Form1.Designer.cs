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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            label5 = new Label();
            button5 = new Button();
            label6 = new Label();
            button6 = new Button();
            label7 = new Label();
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
            headerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            headerpanel.BackgroundColor = SystemColors.ActiveCaptionText;
            headerpanel.BorderStyle = BorderStyle.None;
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
            sidepanel.BorderStyle = BorderStyle.None;
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
            pictureBox1.BackColor = Color.White;
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
            DateTimeMainLabel1.Click += DateTimeMainLabel1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(288, 147);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 8;
            label2.Text = "B2B Form";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.tester;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(256, 177);
            button1.Name = "button1";
            button1.Size = new Size(174, 174);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.aeroplane;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(517, 177);
            button2.Name = "button2";
            button2.Size = new Size(174, 174);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(535, 147);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 10;
            label3.Text = "Just Arrived";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Windows_7_earth_Icon_256;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(796, 177);
            button3.Name = "button3";
            button3.Size = new Size(174, 174);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(828, 147);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 12;
            label4.Text = "Updates";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.agency;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(1060, 177);
            button4.Name = "button4";
            button4.Size = new Size(174, 174);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1013, 147);
            label5.Name = "label5";
            label5.Size = new Size(271, 25);
            label5.TabIndex = 14;
            label5.Text = "OBF Form Repair Centre";
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.probsol;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(1060, 408);
            button5.Name = "button5";
            button5.Size = new Size(174, 174);
            button5.TabIndex = 17;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSkyBlue;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1114, 369);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 16;
            label6.Text = "New";
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.Driver;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(256, 408);
            button6.Name = "button6";
            button6.Size = new Size(174, 174);
            button6.TabIndex = 19;
            button6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(217, 369);
            label7.Name = "label7";
            label7.Size = new Size(245, 25);
            label7.TabIndex = 18;
            label7.Text = "Coming  Soon (Driver)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1453, 608);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(DateTimeMainLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(sidepanel);
            Controls.Add(headerpanel);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
        private Label label4;
        private Button button4;
        private Label label5;
        private Button button5;
        private Label label6;
        private Button button6;
        private Label label7;
    }
}