namespace OOP_Project
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
            value_x = new TextBox();
            value_y = new TextBox();
            label1 = new Label();
            label2 = new Label();
            value_length = new TextBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            value_edges = new TextBox();
            checkBox1 = new CheckBox();
            value_angle = new TextBox();
            label7 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // value_x
            // 
            value_x.Location = new Point(693, 43);
            value_x.Name = "value_x";
            value_x.Size = new Size(50, 27);
            value_x.TabIndex = 0;
            value_x.Text = "0";
            value_x.TextAlign = HorizontalAlignment.Center;
            // 
            // value_y
            // 
            value_y.Location = new Point(763, 43);
            value_y.Name = "value_y";
            value_y.Size = new Size(50, 27);
            value_y.TabIndex = 1;
            value_y.Text = "0";
            value_y.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 50);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Center (x,y)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Length";
            // 
            // value_length
            // 
            value_length.Location = new Point(693, 92);
            value_length.Name = "value_length";
            value_length.Size = new Size(120, 27);
            value_length.TabIndex = 4;
            value_length.Text = "4";
            value_length.TextAlign = HorizontalAlignment.Center;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(693, 134);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(120, 56);
            trackBar1.TabIndex = 5;
            trackBar1.TickStyle = TickStyle.None;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(693, 172);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(120, 56);
            trackBar2.TabIndex = 6;
            trackBar2.TickStyle = TickStyle.None;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(693, 212);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(120, 56);
            trackBar3.TabIndex = 7;
            trackBar3.TickStyle = TickStyle.None;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(598, 134);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 8;
            label3.Text = "Red";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 172);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Green";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(598, 212);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 10;
            label5.Text = "Blue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(598, 267);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 11;
            label6.Text = "Edge";
            // 
            // value_edges
            // 
            value_edges.Location = new Point(693, 260);
            value_edges.Name = "value_edges";
            value_edges.Size = new Size(50, 27);
            value_edges.TabIndex = 12;
            value_edges.Text = "5";
            value_edges.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(763, 263);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "CCW";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // value_angle
            // 
            value_angle.Location = new Point(693, 305);
            value_angle.Name = "value_angle";
            value_angle.Size = new Size(120, 27);
            value_angle.TabIndex = 14;
            value_angle.Text = "30";
            value_angle.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 308);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 15;
            label7.Text = "Angle";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(598, 353);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 104);
            listBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(46, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(693, 463);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 18;
            button1.Text = "DRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += drawButton;
            // 
            // button2
            // 
            button2.Location = new Point(693, 498);
            button2.Name = "button2";
            button2.Size = new Size(120, 29);
            button2.TabIndex = 19;
            button2.Text = "ROTATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += rotateButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(693, 533);
            button3.Name = "button3";
            button3.Size = new Size(120, 29);
            button3.TabIndex = 20;
            button3.Text = "RESET";
            button3.UseVisualStyleBackColor = true;
            button3.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 582);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(value_angle);
            Controls.Add(checkBox1);
            Controls.Add(value_edges);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(value_length);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(value_y);
            Controls.Add(value_x);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox value_x;
        private TextBox value_y;
        private Label label1;
        private Label label2;
        private TextBox value_length;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox value_edges;
        private CheckBox checkBox1;
        private TextBox value_angle;
        private Label label7;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
