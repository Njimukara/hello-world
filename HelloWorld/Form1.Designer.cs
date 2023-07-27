namespace HelloWorld
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.citylabel = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Cities = new System.Windows.Forms.ListBox();
            this.checkSkill = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnConnectDatabase = new System.Windows.Forms.Button();
            this.getTables = new System.Windows.Forms.Button();
            this.addresslabel = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // namelabel
            // 
            this.namelabel.Location = new System.Drawing.Point(88, 34);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(154, 20);
            this.namelabel.TabIndex = 2;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Location = new System.Drawing.Point(88, 75);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(154, 20);
            this.lastnameLabel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addresslabel);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.citylabel);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.namelabel);
            this.groupBox1.Controls.Add(this.lastnameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // citylabel
            // 
            this.citylabel.Location = new System.Drawing.Point(88, 120);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(154, 20);
            this.citylabel.TabIndex = 5;
            this.citylabel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(32, 120);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(24, 13);
            this.city.TabIndex = 4;
            this.city.Text = "City";
            this.city.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(445, 245);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(445, 51);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 5;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(445, 92);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 6;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Cities
            // 
            this.Cities.BackColor = System.Drawing.SystemColors.Menu;
            this.Cities.FormattingEnabled = true;
            this.Cities.Items.AddRange(new object[] {
            "Bamenda",
            "Buea",
            "Kumba",
            "Yaounda",
            "Maroua"});
            this.Cities.Location = new System.Drawing.Point(39, 268);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(190, 108);
            this.Cities.TabIndex = 7;
            this.Cities.SelectedIndexChanged += new System.EventHandler(this.Cities_SelectedIndexChanged);
            // 
            // checkSkill
            // 
            this.checkSkill.AutoSize = true;
            this.checkSkill.Location = new System.Drawing.Point(445, 144);
            this.checkSkill.Name = "checkSkill";
            this.checkSkill.Size = new System.Drawing.Size(40, 17);
            this.checkSkill.TabIndex = 8;
            this.checkSkill.Text = "C#";
            this.checkSkill.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(445, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "ASP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnConnectDatabase
            // 
            this.btnConnectDatabase.Location = new System.Drawing.Point(643, 22);
            this.btnConnectDatabase.Name = "btnConnectDatabase";
            this.btnConnectDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDatabase.TabIndex = 10;
            this.btnConnectDatabase.Text = "Connect";
            this.btnConnectDatabase.UseVisualStyleBackColor = true;
            this.btnConnectDatabase.Click += new System.EventHandler(this.btnConnectDatabase_Click);
            // 
            // getTables
            // 
            this.getTables.Location = new System.Drawing.Point(643, 76);
            this.getTables.Name = "getTables";
            this.getTables.Size = new System.Drawing.Size(75, 23);
            this.getTables.TabIndex = 11;
            this.getTables.Text = "Get Tables";
            this.getTables.UseVisualStyleBackColor = true;
            this.getTables.Click += new System.EventHandler(this.getTables_Click);
            // 
            // addresslabel
            // 
            this.addresslabel.Location = new System.Drawing.Point(88, 164);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(154, 20);
            this.addresslabel.TabIndex = 7;
            this.addresslabel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(11, 168);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 6;
            this.address.Text = "Address";
            this.address.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getTables);
            this.Controls.Add(this.btnConnectDatabase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkSkill);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namelabel;
        private System.Windows.Forms.TextBox lastnameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.ListBox Cities;
        private System.Windows.Forms.CheckBox checkSkill;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnConnectDatabase;
        private System.Windows.Forms.Button getTables;
        private System.Windows.Forms.TextBox citylabel;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox addresslabel;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

