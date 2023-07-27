namespace NewHelloWorld
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
            label1 = new Label();
            label_Meals = new Label();
            meal_name = new Label();
            meal_name_input = new TextBox();
            meal_date = new Label();
            client_name_input = new TextBox();
            label3 = new Label();
            client_tel_input = new TextBox();
            label4 = new Label();
            label5 = new Label();
            submit = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 0;
            label1.Text = "Meals";
            // 
            // label_Meals
            // 
            label_Meals.BackColor = SystemColors.ActiveBorder;
            label_Meals.BorderStyle = BorderStyle.Fixed3D;
            label_Meals.Location = new Point(25, 45);
            label_Meals.Name = "label_Meals";
            label_Meals.Size = new Size(295, 258);
            label_Meals.TabIndex = 0;
            // 
            // meal_name
            // 
            meal_name.AutoSize = true;
            meal_name.Location = new Point(454, 60);
            meal_name.Name = "meal_name";
            meal_name.Size = new Size(66, 15);
            meal_name.TabIndex = 1;
            meal_name.Text = "Meal name";
            // 
            // meal_name_input
            // 
            meal_name_input.Location = new Point(538, 60);
            meal_name_input.Name = "meal_name_input";
            meal_name_input.Size = new Size(198, 23);
            meal_name_input.TabIndex = 2;
            // 
            // meal_date
            // 
            meal_date.AutoSize = true;
            meal_date.Location = new Point(454, 121);
            meal_date.Name = "meal_date";
            meal_date.Size = new Size(59, 15);
            meal_date.TabIndex = 3;
            meal_date.Text = "Meal date";
            // 
            // client_name_input
            // 
            client_name_input.Location = new Point(538, 178);
            client_name_input.Name = "client_name_input";
            client_name_input.Size = new Size(198, 23);
            client_name_input.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 178);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Client Name";
            // 
            // client_tel_input
            // 
            client_tel_input.Location = new Point(538, 237);
            client_tel_input.Name = "client_tel_input";
            client_tel_input.Size = new Size(198, 23);
            client_tel_input.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 237);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Client Tel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 294);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Meal cost";
            label5.Click += label5_Click;
            // 
            // submit
            // 
            submit.Location = new Point(228, 344);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 11;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(submit);
            groupBox1.Location = new Point(433, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 373);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD MEAL";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 95);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(107, 264);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(196, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 468);
            Controls.Add(label5);
            Controls.Add(client_tel_input);
            Controls.Add(label4);
            Controls.Add(client_name_input);
            Controls.Add(label3);
            Controls.Add(meal_date);
            Controls.Add(meal_name_input);
            Controls.Add(meal_name);
            Controls.Add(label_Meals);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_Meals;
        private Label meal_name;
        private TextBox meal_name_input;
        private Label meal_date;
        private TextBox client_name_input;
        private Label label3;
        private TextBox client_tel_input;
        private Label label4;
        private Label label5;
        private Button submit;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
    }
}

