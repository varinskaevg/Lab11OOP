namespace Lab11OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            tap = new DataGridViewTextBoxColumn();
            textBox5 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "Рік";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Марка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Пробіг";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 397);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 27);
            textBox4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, model, year, tap });
            dataGridView1.Location = new Point(96, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(621, 188);
            dataGridView1.TabIndex = 9;
            // 
            // name
            // 
            name.HeaderText = "Марка";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // model
            // 
            model.HeaderText = "Модель";
            model.MinimumWidth = 6;
            model.Name = "model";
            model.Width = 125;
            // 
            // year
            // 
            year.HeaderText = "Рік";
            year.MinimumWidth = 6;
            year.Name = "year";
            year.ToolTipText = "ffff";
            year.Width = 125;
            // 
            // tap
            // 
            tap.HeaderText = "Пробіг";
            tap.MinimumWidth = 6;
            tap.Name = "tap";
            tap.Width = 125;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(96, 115);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(209, 27);
            textBox5.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn tap;
    }
}
