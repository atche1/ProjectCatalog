namespace CatalogProjectFormsApp
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            printAllMoviesList = new ListBox();
            showAllMovies = new Button();
            tabPage2 = new TabPage();
            addMovie = new Button();
            ratingComboBox = new ComboBox();
            label6 = new Label();
            reviewRichTextBox = new RichTextBox();
            descriptionRichTextBox = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            genreComboBox = new ComboBox();
            label3 = new Label();
            directorComboBox = new ComboBox();
            label2 = new Label();
            titleBox = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            updateButton = new Button();
            updateRatingcomboBox4 = new ComboBox();
            label12 = new Label();
            updateReviewrichTextBox2 = new RichTextBox();
            label11 = new Label();
            updateDescriptionrichTextBox1 = new RichTextBox();
            label10 = new Label();
            genreUpdatecomboBox3 = new ComboBox();
            label9 = new Label();
            updateDirectorcomboBox2 = new ComboBox();
            label8 = new Label();
            updateMoviecomboBox1 = new ComboBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            deleteMovielistBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            deleteButton = new Button();
            comboBox5 = new ComboBox();
            label13 = new Label();
            tabPage5 = new TabPage();
            addRatingbutton = new Button();
            addReviewbutton = new Button();
            addReviewrichTextBox1 = new RichTextBox();
            addRatingcomboBox2 = new ComboBox();
            opinionMoviecomboBox1 = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            tabPage6 = new TabPage();
            sortlistBox1 = new ListBox();
            sortbutton1 = new Button();
            tabPage7 = new TabPage();
            label17 = new Label();
            searchrichTextBox1 = new RichTextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Script MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1003, 635);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(printAllMoviesList);
            tabPage1.Controls.Add(showAllMovies);
            tabPage1.Location = new Point(4, 49);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(995, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movies";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 188, 201);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(620, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 237);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // printAllMoviesList
            // 
            printAllMoviesList.FormattingEnabled = true;
            printAllMoviesList.ItemHeight = 37;
            printAllMoviesList.Location = new Point(28, 32);
            printAllMoviesList.Name = "printAllMoviesList";
            printAllMoviesList.Size = new Size(562, 522);
            printAllMoviesList.TabIndex = 1;
            // 
            // showAllMovies
            // 
            showAllMovies.BackgroundImage = (Image)resources.GetObject("showAllMovies.BackgroundImage");
            showAllMovies.BackgroundImageLayout = ImageLayout.Stretch;
            showAllMovies.Location = new Point(620, 480);
            showAllMovies.Name = "showAllMovies";
            showAllMovies.Size = new Size(340, 74);
            showAllMovies.TabIndex = 0;
            showAllMovies.Text = "Show all";
            showAllMovies.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(addMovie);
            tabPage2.Controls.Add(ratingComboBox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(reviewRichTextBox);
            tabPage2.Controls.Add(descriptionRichTextBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(genreComboBox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(directorComboBox);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(titleBox);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 49);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(995, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addMovie
            // 
            addMovie.BackgroundImage = (Image)resources.GetObject("addMovie.BackgroundImage");
            addMovie.Location = new Point(795, 32);
            addMovie.Name = "addMovie";
            addMovie.Size = new Size(154, 486);
            addMovie.TabIndex = 12;
            addMovie.Text = "Add Movie";
            addMovie.UseCompatibleTextRendering = true;
            addMovie.UseVisualStyleBackColor = true;
            // 
            // ratingComboBox
            // 
            ratingComboBox.FormattingEnabled = true;
            ratingComboBox.Location = new Point(166, 476);
            ratingComboBox.Name = "ratingComboBox";
            ratingComboBox.Size = new Size(561, 45);
            ratingComboBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(36, 479);
            label6.Name = "label6";
            label6.Size = new Size(108, 37);
            label6.TabIndex = 10;
            label6.Text = "Rating:";
            // 
            // reviewRichTextBox
            // 
            reviewRichTextBox.Location = new Point(166, 363);
            reviewRichTextBox.Name = "reviewRichTextBox";
            reviewRichTextBox.Size = new Size(561, 87);
            reviewRichTextBox.TabIndex = 9;
            reviewRichTextBox.Text = "";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(217, 249);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(510, 89);
            descriptionRichTextBox.TabIndex = 8;
            descriptionRichTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(36, 363);
            label5.Name = "label5";
            label5.Size = new Size(111, 37);
            label5.TabIndex = 7;
            label5.Text = "Review:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(36, 252);
            label4.Name = "label4";
            label4.Size = new Size(159, 37);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(150, 178);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(577, 45);
            genreComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(36, 186);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 4;
            label3.Text = "Genre:";
            // 
            // directorComboBox
            // 
            directorComboBox.FormattingEnabled = true;
            directorComboBox.Location = new Point(253, 106);
            directorComboBox.Name = "directorComboBox";
            directorComboBox.Size = new Size(474, 45);
            directorComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 109);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 2;
            label2.Text = "Director name:";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(140, 32);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(587, 44);
            titleBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 37);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Controls.Add(updateButton);
            tabPage3.Controls.Add(updateRatingcomboBox4);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(updateReviewrichTextBox2);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(updateDescriptionrichTextBox1);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(genreUpdatecomboBox3);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(updateDirectorcomboBox2);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(updateMoviecomboBox1);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 49);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(995, 582);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.BackgroundImage = (Image)resources.GetObject("updateButton.BackgroundImage");
            updateButton.Location = new Point(775, 47);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(160, 458);
            updateButton.TabIndex = 12;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // updateRatingcomboBox4
            // 
            updateRatingcomboBox4.FormattingEnabled = true;
            updateRatingcomboBox4.Location = new Point(283, 478);
            updateRatingcomboBox4.Name = "updateRatingcomboBox4";
            updateRatingcomboBox4.Size = new Size(431, 45);
            updateRatingcomboBox4.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(16, 481);
            label12.Name = "label12";
            label12.Size = new Size(208, 37);
            label12.TabIndex = 10;
            label12.Text = "Pick new rating:";
            // 
            // updateReviewrichTextBox2
            // 
            updateReviewrichTextBox2.Location = new Point(289, 345);
            updateReviewrichTextBox2.Name = "updateReviewrichTextBox2";
            updateReviewrichTextBox2.Size = new Size(425, 98);
            updateReviewrichTextBox2.TabIndex = 9;
            updateReviewrichTextBox2.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(16, 348);
            label11.Name = "label11";
            label11.Size = new Size(225, 37);
            label11.TabIndex = 8;
            label11.Text = "Write new review:";
            // 
            // updateDescriptionrichTextBox1
            // 
            updateDescriptionrichTextBox1.Location = new Point(341, 210);
            updateDescriptionrichTextBox1.Name = "updateDescriptionrichTextBox1";
            updateDescriptionrichTextBox1.Size = new Size(373, 107);
            updateDescriptionrichTextBox1.TabIndex = 7;
            updateDescriptionrichTextBox1.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(16, 223);
            label10.Name = "label10";
            label10.Size = new Size(279, 37);
            label10.TabIndex = 6;
            label10.Text = "Write new description:";
            // 
            // genreUpdatecomboBox3
            // 
            genreUpdatecomboBox3.FormattingEnabled = true;
            genreUpdatecomboBox3.Location = new Point(240, 141);
            genreUpdatecomboBox3.Name = "genreUpdatecomboBox3";
            genreUpdatecomboBox3.Size = new Size(474, 45);
            genreUpdatecomboBox3.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(16, 149);
            label9.Name = "label9";
            label9.Size = new Size(170, 37);
            label9.TabIndex = 4;
            label9.Text = "Pick a genre:";
            // 
            // updateDirectorcomboBox2
            // 
            updateDirectorcomboBox2.FormattingEnabled = true;
            updateDirectorcomboBox2.Location = new Point(328, 75);
            updateDirectorcomboBox2.Name = "updateDirectorcomboBox2";
            updateDirectorcomboBox2.Size = new Size(386, 45);
            updateDirectorcomboBox2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(16, 83);
            label8.Name = "label8";
            label8.Size = new Size(272, 37);
            label8.TabIndex = 2;
            label8.Text = "Choose director name:";
            // 
            // updateMoviecomboBox1
            // 
            updateMoviecomboBox1.FormattingEnabled = true;
            updateMoviecomboBox1.Location = new Point(240, 12);
            updateMoviecomboBox1.Name = "updateMoviecomboBox1";
            updateMoviecomboBox1.Size = new Size(474, 45);
            updateMoviecomboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(16, 20);
            label7.Name = "label7";
            label7.Size = new Size(179, 37);
            label7.TabIndex = 0;
            label7.Text = "Choose movie:";
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.Controls.Add(deleteMovielistBox1);
            tabPage4.Controls.Add(pictureBox2);
            tabPage4.Controls.Add(deleteButton);
            tabPage4.Controls.Add(comboBox5);
            tabPage4.Controls.Add(label13);
            tabPage4.Location = new Point(4, 49);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(995, 582);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteMovielistBox1
            // 
            deleteMovielistBox1.FormattingEnabled = true;
            deleteMovielistBox1.ItemHeight = 37;
            deleteMovielistBox1.Location = new Point(426, 55);
            deleteMovielistBox1.Name = "deleteMovielistBox1";
            deleteMovielistBox1.Size = new Size(453, 152);
            deleteMovielistBox1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(245, 188, 201);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(705, 281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 188);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // deleteButton
            // 
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteButton.Font = new Font("Script MT Bold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(79, 281);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(579, 188);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete movie";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(399, 67);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(0, 28);
            comboBox5.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ButtonHighlight;
            label13.Font = new Font("Script MT Bold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(79, 76);
            label13.Name = "label13";
            label13.Size = new Size(281, 57);
            label13.TabIndex = 0;
            label13.Text = "Choose movie:";
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.Controls.Add(addRatingbutton);
            tabPage5.Controls.Add(addReviewbutton);
            tabPage5.Controls.Add(addReviewrichTextBox1);
            tabPage5.Controls.Add(addRatingcomboBox2);
            tabPage5.Controls.Add(opinionMoviecomboBox1);
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(label14);
            tabPage5.Location = new Point(4, 49);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(995, 582);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Opinion";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // addRatingbutton
            // 
            addRatingbutton.BackColor = SystemColors.ButtonHighlight;
            addRatingbutton.Location = new Point(733, 507);
            addRatingbutton.Name = "addRatingbutton";
            addRatingbutton.Size = new Size(151, 46);
            addRatingbutton.TabIndex = 7;
            addRatingbutton.Text = "Add";
            addRatingbutton.UseVisualStyleBackColor = false;
            // 
            // addReviewbutton
            // 
            addReviewbutton.BackColor = SystemColors.ButtonHighlight;
            addReviewbutton.Location = new Point(733, 338);
            addReviewbutton.Name = "addReviewbutton";
            addReviewbutton.Size = new Size(151, 47);
            addReviewbutton.TabIndex = 6;
            addReviewbutton.Text = "Add";
            addReviewbutton.UseVisualStyleBackColor = false;
            // 
            // addReviewrichTextBox1
            // 
            addReviewrichTextBox1.Location = new Point(287, 209);
            addReviewrichTextBox1.Name = "addReviewrichTextBox1";
            addReviewrichTextBox1.Size = new Size(597, 84);
            addReviewrichTextBox1.TabIndex = 5;
            addReviewrichTextBox1.Text = "";
            // 
            // addRatingcomboBox2
            // 
            addRatingcomboBox2.FormattingEnabled = true;
            addRatingcomboBox2.Location = new Point(275, 429);
            addRatingcomboBox2.Name = "addRatingcomboBox2";
            addRatingcomboBox2.Size = new Size(609, 45);
            addRatingcomboBox2.TabIndex = 4;
            // 
            // opinionMoviecomboBox1
            // 
            opinionMoviecomboBox1.FormattingEnabled = true;
            opinionMoviecomboBox1.Location = new Point(287, 73);
            opinionMoviecomboBox1.Name = "opinionMoviecomboBox1";
            opinionMoviecomboBox1.Size = new Size(597, 45);
            opinionMoviecomboBox1.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(57, 432);
            label16.Name = "label16";
            label16.Size = new Size(155, 37);
            label16.TabIndex = 2;
            label16.Text = "Add rating:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(57, 212);
            label15.Name = "label15";
            label15.Size = new Size(165, 37);
            label15.TabIndex = 1;
            label15.Text = "Add rewiew:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(57, 76);
            label14.Name = "label14";
            label14.Size = new Size(179, 37);
            label14.TabIndex = 0;
            label14.Text = "Choose movie:";
            // 
            // tabPage6
            // 
            tabPage6.BackgroundImage = (Image)resources.GetObject("tabPage6.BackgroundImage");
            tabPage6.Controls.Add(sortlistBox1);
            tabPage6.Controls.Add(sortbutton1);
            tabPage6.Location = new Point(4, 49);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(995, 582);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Sort";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // sortlistBox1
            // 
            sortlistBox1.FormattingEnabled = true;
            sortlistBox1.ItemHeight = 37;
            sortlistBox1.Location = new Point(49, 57);
            sortlistBox1.Name = "sortlistBox1";
            sortlistBox1.Size = new Size(897, 263);
            sortlistBox1.TabIndex = 1;
            // 
            // sortbutton1
            // 
            sortbutton1.BackgroundImage = (Image)resources.GetObject("sortbutton1.BackgroundImage");
            sortbutton1.BackgroundImageLayout = ImageLayout.Stretch;
            sortbutton1.Location = new Point(474, 386);
            sortbutton1.Name = "sortbutton1";
            sortbutton1.Size = new Size(472, 139);
            sortbutton1.TabIndex = 0;
            sortbutton1.Text = "Sort";
            sortbutton1.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.BackgroundImage = (Image)resources.GetObject("tabPage7.BackgroundImage");
            tabPage7.Controls.Add(label17);
            tabPage7.Controls.Add(searchrichTextBox1);
            tabPage7.Location = new Point(4, 49);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(995, 582);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Search";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ButtonHighlight;
            label17.Font = new Font("Script MT Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(43, 34);
            label17.Name = "label17";
            label17.Size = new Size(419, 41);
            label17.TabIndex = 1;
            label17.Text = "Type keywords for searching:";
            // 
            // searchrichTextBox1
            // 
            searchrichTextBox1.Location = new Point(43, 124);
            searchrichTextBox1.Name = "searchrichTextBox1";
            searchrichTextBox1.Size = new Size(434, 375);
            searchrichTextBox1.TabIndex = 0;
            searchrichTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(754, 159);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1003, 635);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Catalog";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button showAllMovies;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private PictureBox pictureBox1;
        private ListBox printAllMoviesList;
        private Label label3;
        private ComboBox directorComboBox;
        private Label label2;
        private TextBox titleBox;
        private Label label1;
        private ComboBox ratingComboBox;
        private Label label6;
        private RichTextBox reviewRichTextBox;
        private RichTextBox descriptionRichTextBox;
        private Label label5;
        private Label label4;
        private ComboBox genreComboBox;
        private Button addMovie;
        private Label label8;
        private ComboBox updateMoviecomboBox1;
        private Label label7;
        private Label label10;
        private ComboBox genreUpdatecomboBox3;
        private Label label9;
        private ComboBox updateDirectorcomboBox2;
        private Button updateButton;
        private ComboBox updateRatingcomboBox4;
        private Label label12;
        private RichTextBox updateReviewrichTextBox2;
        private Label label11;
        private RichTextBox updateDescriptionrichTextBox1;
        private PictureBox pictureBox2;
        private Button deleteButton;
        private ComboBox comboBox5;
        private Label label13;
        private ListBox deleteMovielistBox1;
        private Label label15;
        private Label label14;
        private Button addRatingbutton;
        private Button addReviewbutton;
        private RichTextBox addReviewrichTextBox1;
        private ComboBox addRatingcomboBox2;
        private ComboBox opinionMoviecomboBox1;
        private Label label16;
        private ListBox sortlistBox1;
        private Button sortbutton1;
        private Label label17;

/* Unmerged change from project 'CatalogProjectForms'
Before:
        private RichTextBox richTextBox1;
    }
After:
        private RichTextBox searchrichTextBox1;
        private Button searchbutton1;
        private ListBox searchlistBox1;
    }
*/
        private RichTextBox searchrichTextBox1;
        private Button button1;
    }
}
