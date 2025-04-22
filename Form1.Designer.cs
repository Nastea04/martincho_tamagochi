namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblfood = new Label();
            lblcare = new Label();
            lblenergy = new Label();
            lblclean = new Label();
            cbfood = new ComboBox();
            btnfood = new Button();
            btnclean = new Button();
            cmbcleen = new ComboBox();
            btnslep = new Button();
            cmbslep = new ComboBox();
            btnacti = new Button();
            cmbacti = new ComboBox();
            timer30sec = new System.Windows.Forms.Timer(components);
            sexbar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 492);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 133);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(27, 252);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(92, 106);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Gray;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(27, 369);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(92, 106);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // lblfood
            // 
            lblfood.BackColor = Color.Silver;
            lblfood.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblfood.ForeColor = Color.DimGray;
            lblfood.Location = new Point(123, 36);
            lblfood.Name = "lblfood";
            lblfood.Size = new Size(130, 53);
            lblfood.TabIndex = 6;
            lblfood.Text = ":100%";
            lblfood.Click += lblfood_Click;
            // 
            // lblcare
            // 
            lblcare.BackColor = Color.Silver;
            lblcare.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblcare.ForeColor = Color.DimGray;
            lblcare.Location = new Point(123, 159);
            lblcare.Name = "lblcare";
            lblcare.Size = new Size(130, 53);
            lblcare.TabIndex = 7;
            lblcare.Text = ":100%";
            // 
            // lblenergy
            // 
            lblenergy.BackColor = Color.Silver;
            lblenergy.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblenergy.ForeColor = Color.DimGray;
            lblenergy.Location = new Point(123, 281);
            lblenergy.Name = "lblenergy";
            lblenergy.Size = new Size(130, 53);
            lblenergy.TabIndex = 8;
            lblenergy.Text = ":100%";
            lblenergy.Click += label2_Click;
            // 
            // lblclean
            // 
            lblclean.BackColor = Color.Silver;
            lblclean.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblclean.ForeColor = Color.DimGray;
            lblclean.Location = new Point(123, 401);
            lblclean.Name = "lblclean";
            lblclean.Size = new Size(130, 53);
            lblclean.TabIndex = 9;
            lblclean.Text = ":100%";
            // 
            // cbfood
            // 
            cbfood.BackColor = Color.FromArgb(255, 224, 192);
            cbfood.DropDownStyle = ComboBoxStyle.DropDownList;
            cbfood.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbfood.ForeColor = Color.Black;
            cbfood.FormattingEnabled = true;
            cbfood.Items.AddRange(new object[] { "Hot Dog  +5", "McDonalds cheseburger +10", "Oreo +15", "Pizza +18", "Ayran +50", "Broccolli -5", "Happy Meal +20" });
            cbfood.Location = new Point(641, 36);
            cbfood.Name = "cbfood";
            cbfood.Size = new Size(332, 45);
            cbfood.TabIndex = 10;
            cbfood.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // btnfood
            // 
            btnfood.BackColor = Color.FromArgb(255, 224, 192);
            btnfood.FlatStyle = FlatStyle.Popup;
            btnfood.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnfood.Location = new Point(858, 87);
            btnfood.Name = "btnfood";
            btnfood.Size = new Size(115, 47);
            btnfood.TabIndex = 11;
            btnfood.Text = "Eat";
            btnfood.UseVisualStyleBackColor = false;
            btnfood.Click += btnfood_Click;
            // 
            // btnclean
            // 
            btnclean.BackColor = Color.FromArgb(255, 224, 192);
            btnclean.FlatStyle = FlatStyle.Popup;
            btnclean.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnclean.Location = new Point(858, 441);
            btnclean.Name = "btnclean";
            btnclean.Size = new Size(115, 47);
            btnclean.TabIndex = 13;
            btnclean.Text = "Clean";
            btnclean.UseVisualStyleBackColor = false;
            // 
            // cmbcleen
            // 
            cmbcleen.BackColor = Color.FromArgb(255, 224, 192);
            cmbcleen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcleen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbcleen.ForeColor = Color.Black;
            cmbcleen.FormattingEnabled = true;
            cmbcleen.Items.AddRange(new object[] { "Shower +50", "Brush teeth +15", "Bathtub +70", "Wash hands +2" });
            cmbcleen.Location = new Point(641, 390);
            cmbcleen.Name = "cmbcleen";
            cmbcleen.Size = new Size(332, 45);
            cmbcleen.TabIndex = 12;
            // 
            // btnslep
            // 
            btnslep.BackColor = Color.FromArgb(255, 224, 192);
            btnslep.FlatStyle = FlatStyle.Popup;
            btnslep.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnslep.Location = new Point(858, 323);
            btnslep.Name = "btnslep";
            btnslep.Size = new Size(115, 47);
            btnslep.TabIndex = 15;
            btnslep.Text = "ZZZ...";
            btnslep.UseVisualStyleBackColor = false;
            // 
            // cmbslep
            // 
            cmbslep.BackColor = Color.FromArgb(255, 224, 192);
            cmbslep.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbslep.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbslep.ForeColor = Color.Black;
            cmbslep.FormattingEnabled = true;
            cmbslep.Items.AddRange(new object[] { "Nap(30min) +10", "Fast Sleep(1h30min) +20", "Sleep(7h)->90%" });
            cmbslep.Location = new Point(641, 272);
            cmbslep.Name = "cmbslep";
            cmbslep.Size = new Size(332, 45);
            cmbslep.TabIndex = 14;
            // 
            // btnacti
            // 
            btnacti.BackColor = Color.FromArgb(255, 224, 192);
            btnacti.FlatStyle = FlatStyle.Popup;
            btnacti.Font = new Font("Bahnschrift", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnacti.Location = new Point(858, 201);
            btnacti.Name = "btnacti";
            btnacti.Size = new Size(115, 47);
            btnacti.TabIndex = 17;
            btnacti.Text = "Do";
            btnacti.UseVisualStyleBackColor = false;
            // 
            // cmbacti
            // 
            cmbacti.BackColor = Color.FromArgb(255, 224, 192);
            cmbacti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbacti.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbacti.ForeColor = Color.Black;
            cmbacti.FormattingEnabled = true;
            cmbacti.Items.AddRange(new object[] { "Play +6", "YouTube +10", "Programm +10", "Walk +17", "Math solving +8", "Jump +10", "Pool Party +25" });
            cmbacti.Location = new Point(641, 150);
            cmbacti.Name = "cmbacti";
            cmbacti.Size = new Size(332, 45);
            cmbacti.TabIndex = 16;
            cmbacti.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // timer30sec
            // 
            timer30sec.Interval = 1000;
            timer30sec.Tick += timer30sec_Tick;
            // 
            // sexbar
            // 
            sexbar.Location = new Point(196, 503);
            sexbar.Name = "sexbar";
            sexbar.Size = new Size(463, 50);
            sexbar.TabIndex = 18;
            sexbar.Visible = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1006, 565);
            Controls.Add(sexbar);
            Controls.Add(btnacti);
            Controls.Add(cmbacti);
            Controls.Add(btnslep);
            Controls.Add(cmbslep);
            Controls.Add(btnclean);
            Controls.Add(cmbcleen);
            Controls.Add(btnfood);
            Controls.Add(cbfood);
            Controls.Add(lblclean);
            Controls.Add(lblenergy);
            Controls.Add(lblcare);
            Controls.Add(lblfood);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "tamagoci";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblfood;
        private Label lblcare;
        private Label lblenergy;
        private Label lblclean;
        private ComboBox cbfood;
        private Button btnfood;
        private Button btnclean;
        private ComboBox cmbcleen;
        private Button btnslep;
        private ComboBox cmbslep;
        private Button btnacti;
        private ComboBox cmbacti;
        private System.Windows.Forms.Timer timer30sec;
        private ProgressBar sexbar;
        private System.Windows.Forms.Timer timer;
    }
}
