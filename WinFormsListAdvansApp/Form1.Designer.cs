namespace WinFormsListAdvansApp
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
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            btnCheck = new Button();
            numericUpDown1 = new NumericUpDown();
            imageList1 = new ImageList(components);
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            trackRed = new TrackBar();
            label1 = new Label();
            trackGreen = new TrackBar();
            trackBlue = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBlue).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Москва", "Тула", "Воронеж", "Новгород", "Казань" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(291, 45);
            comboBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Segoe UI", 16F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Jimmy", "Sammy", "Bobby", "Tommy" });
            checkedListBox1.Location = new Point(12, 73);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(291, 128);
            checkedListBox1.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 16F);
            btnCheck.Location = new Point(12, 224);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(141, 55);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Segoe UI", 20F);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(12, 347);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(215, 43);
            numericUpDown1.TabIndex = 3;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "brasil.jpg");
            imageList1.Images.SetKeyName(1, "china.png");
            imageList1.Images.SetKeyName(2, "russia.jpg");
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ImageIndex = 0;
            checkBox1.ImageList = imageList1;
            checkBox1.Location = new Point(337, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 50);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ImageIndex = 1;
            checkBox2.ImageList = imageList1;
            checkBox2.Location = new Point(337, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(65, 50);
            checkBox2.TabIndex = 5;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ImageIndex = 2;
            checkBox3.ImageList = imageList1;
            checkBox3.Location = new Point(337, 158);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 50);
            checkBox3.TabIndex = 6;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // trackRed
            // 
            trackRed.Location = new Point(322, 251);
            trackRed.Maximum = 255;
            trackRed.Name = "trackRed";
            trackRed.Size = new Size(334, 45);
            trackRed.TabIndex = 7;
            trackRed.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(745, 251);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 8;
            // 
            // trackGreen
            // 
            trackGreen.Location = new Point(322, 302);
            trackGreen.Maximum = 255;
            trackGreen.Name = "trackGreen";
            trackGreen.Size = new Size(334, 45);
            trackGreen.TabIndex = 7;
            trackGreen.Scroll += trackBar1_Scroll;
            // 
            // trackBlue
            // 
            trackBlue.Location = new Point(322, 353);
            trackBlue.Maximum = 255;
            trackBlue.Name = "trackBlue";
            trackBlue.Size = new Size(334, 45);
            trackBlue.TabIndex = 7;
            trackBlue.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(trackBlue);
            Controls.Add(trackGreen);
            Controls.Add(trackRed);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnCheck);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Button btnCheck;
        private NumericUpDown numericUpDown1;
        private ImageList imageList1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TrackBar trackRed;
        private Label label1;
        private TrackBar trackGreen;
        private TrackBar trackBlue;
    }
}
