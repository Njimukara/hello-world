namespace MovieApp
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
            groupBox1 = new GroupBox();
            addMovies = new Button();
            addUsers = new Button();
            getUsers = new Button();
            getMovies = new Button();
            grid_allMovies = new DataGridView();
            panel1 = new Panel();
            delete = new Button();
            update = new Button();
            group_newmovie = new GroupBox();
            label_dataProcess = new Label();
            dataProcessingTypeDropdown = new ComboBox();
            name = new Label();
            description = new Label();
            cancel_btn = new Button();
            submit_bbtn = new Button();
            label4 = new Label();
            input_description = new RichTextBox();
            movieBindingSource = new BindingSource(components);
            input_ratings = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            input_movieName = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_allMovies).BeginInit();
            panel1.SuspendLayout();
            group_newmovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)input_ratings).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(addMovies);
            groupBox1.Controls.Add(addUsers);
            groupBox1.Controls.Add(getUsers);
            groupBox1.Controls.Add(getMovies);
            groupBox1.Location = new Point(1, -6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 513);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // addMovies
            // 
            addMovies.Location = new Point(0, 417);
            addMovies.Name = "addMovies";
            addMovies.Size = new Size(200, 23);
            addMovies.TabIndex = 3;
            addMovies.Text = "New Movie";
            addMovies.UseVisualStyleBackColor = true;
            addMovies.Click += addMovies_Click;
            // 
            // addUsers
            // 
            addUsers.Location = new Point(0, 461);
            addUsers.Name = "addUsers";
            addUsers.Size = new Size(200, 23);
            addUsers.TabIndex = 2;
            addUsers.Text = "New User";
            addUsers.UseVisualStyleBackColor = true;
            // 
            // getUsers
            // 
            getUsers.Location = new Point(0, 77);
            getUsers.Name = "getUsers";
            getUsers.Size = new Size(200, 23);
            getUsers.TabIndex = 1;
            getUsers.Text = "All Users";
            getUsers.UseVisualStyleBackColor = true;
            getUsers.Click += getUsers_Click;
            // 
            // getMovies
            // 
            getMovies.Location = new Point(0, 31);
            getMovies.Name = "getMovies";
            getMovies.Size = new Size(200, 23);
            getMovies.TabIndex = 0;
            getMovies.Text = "All Movies";
            getMovies.UseVisualStyleBackColor = true;
            getMovies.Click += getMovies_Click;
            // 
            // grid_allMovies
            // 
            grid_allMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_allMovies.Dock = DockStyle.Fill;
            grid_allMovies.Location = new Point(0, 0);
            grid_allMovies.Name = "grid_allMovies";
            grid_allMovies.RowTemplate.Height = 25;
            grid_allMovies.Size = new Size(955, 482);
            grid_allMovies.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(delete);
            panel1.Controls.Add(update);
            panel1.Controls.Add(group_newmovie);
            panel1.Controls.Add(grid_allMovies);
            panel1.Location = new Point(207, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 482);
            panel1.TabIndex = 2;
            // 
            // delete
            // 
            delete.BackColor = Color.Tomato;
            delete.ForeColor = SystemColors.ButtonHighlight;
            delete.Location = new Point(681, 28);
            delete.Name = "delete";
            delete.Size = new Size(94, 37);
            delete.TabIndex = 4;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Location = new Point(554, 28);
            update.Name = "update";
            update.Size = new Size(105, 37);
            update.TabIndex = 3;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // group_newmovie
            // 
            group_newmovie.Controls.Add(label_dataProcess);
            group_newmovie.Controls.Add(dataProcessingTypeDropdown);
            group_newmovie.Controls.Add(name);
            group_newmovie.Controls.Add(description);
            group_newmovie.Controls.Add(cancel_btn);
            group_newmovie.Controls.Add(submit_bbtn);
            group_newmovie.Controls.Add(label4);
            group_newmovie.Controls.Add(input_description);
            group_newmovie.Controls.Add(input_ratings);
            group_newmovie.Controls.Add(label3);
            group_newmovie.Controls.Add(label1);
            group_newmovie.Controls.Add(input_movieName);
            group_newmovie.Location = new Point(1, 1);
            group_newmovie.Name = "group_newmovie";
            group_newmovie.Size = new Size(689, 481);
            group_newmovie.TabIndex = 2;
            group_newmovie.TabStop = false;
            group_newmovie.Text = "Add New Movie";
            group_newmovie.Visible = false;
            // 
            // label_dataProcess
            // 
            label_dataProcess.AutoSize = true;
            label_dataProcess.Location = new Point(605, 115);
            label_dataProcess.Name = "label_dataProcess";
            label_dataProcess.Size = new Size(119, 15);
            label_dataProcess.TabIndex = 14;
            label_dataProcess.Text = "Select Data Processor";
            // 
            // dataProcessingTypeDropdown
            // 
            dataProcessingTypeDropdown.FormattingEnabled = true;
            dataProcessingTypeDropdown.Location = new Point(553, 153);
            dataProcessingTypeDropdown.Name = "dataProcessingTypeDropdown";
            dataProcessingTypeDropdown.Size = new Size(221, 23);
            dataProcessingTypeDropdown.TabIndex = 13;
            dataProcessingTypeDropdown.SelectedIndexChanged += dataProcessingTypeDropdown_SelectedIndexChanged_1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(164, 66);
            name.Name = "name";
            name.Size = new Size(0, 15);
            name.TabIndex = 12;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(164, 252);
            description.Name = "description";
            description.Size = new Size(0, 15);
            description.TabIndex = 11;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(206, 270);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(91, 35);
            cancel_btn.TabIndex = 10;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // submit_bbtn
            // 
            submit_bbtn.BackColor = SystemColors.ActiveCaption;
            submit_bbtn.Location = new Point(317, 270);
            submit_bbtn.Name = "submit_bbtn";
            submit_bbtn.Size = new Size(91, 35);
            submit_bbtn.TabIndex = 9;
            submit_bbtn.Text = "Submit";
            submit_bbtn.UseVisualStyleBackColor = false;
            submit_bbtn.Click += submit_bbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 93);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Ratings";
            // 
            // input_description
            // 
            input_description.DataBindings.Add(new Binding("Text", movieBindingSource, "Description", true));
            input_description.Location = new Point(164, 139);
            input_description.Name = "input_description";
            input_description.Size = new Size(244, 96);
            input_description.TabIndex = 7;
            input_description.Text = "";
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Database.DataModels.Movie);
            // 
            // input_ratings
            // 
            input_ratings.DataBindings.Add(new Binding("Value", movieBindingSource, "ratings", true));
            input_ratings.Location = new Point(164, 85);
            input_ratings.Name = "input_ratings";
            input_ratings.Size = new Size(244, 23);
            input_ratings.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 135);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 5;
            label3.Text = "Movie Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Movie Name";
            // 
            // input_movieName
            // 
            input_movieName.DataBindings.Add(new Binding("Text", movieBindingSource, "MovieName", true));
            input_movieName.Location = new Point(164, 35);
            input_movieName.Name = "input_movieName";
            input_movieName.Size = new Size(244, 23);
            input_movieName.TabIndex = 0;
            input_movieName.TextChanged += input_movieName_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 506);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_allMovies).EndInit();
            panel1.ResumeLayout(false);
            group_newmovie.ResumeLayout(false);
            group_newmovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)input_ratings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button getMovies;
        private Button addMovies;
        private Button addUsers;
        private Button getUsers;
        private DataGridView grid_allMovies;
        private Panel panel1;
        private GroupBox group_newmovie;
        private Label label2;
        private Label label1;
        private TextBox input_;
        private TextBox input_movieName;
        private Label label4;
        private RichTextBox input_description;
        private NumericUpDown input_ratings;
        private Label label3;
        private Button submit_bbtn;
        private Button cancel_btn;
        private Label description;
        private Label name;
        private Button update;
        private Button delete;
        private BindingSource movieBindingSource;
        private Label label_dataProcess;
        public ComboBox dataProcessingTypeDropdown;
    }
}