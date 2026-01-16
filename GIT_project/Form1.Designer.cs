namespace GIT_project
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(80, 159);
            button1.Name = "button1";
            button1.Size = new Size(350, 29);
            button1.TabIndex = 0;
            button1.Text = "add task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(80, 400);
            button2.Name = "button2";
            button2.Size = new Size(170, 29);
            button2.TabIndex = 1;
            button2.Text = "done";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(260, 400);
            button3.Name = "button3";
            button3.Size = new Size(170, 29);
            button3.TabIndex = 2;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 126);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(350, 200);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 59);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 96);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 9;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 131);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Deadline:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
