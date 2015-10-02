namespace LibManDA
{
    partial class EditForm
    {
        /// <summary>d
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
            this.coverPB = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publisherBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.RichTextBox();
            this.desLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.cateLabel = new System.Windows.Forms.Label();
            this.cateComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverPB)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPB
            // 
            this.coverPB.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.coverPB.Location = new System.Drawing.Point(17, 16);
            this.coverPB.Name = "coverPB";
            this.coverPB.Size = new System.Drawing.Size(150, 218);
            this.coverPB.TabIndex = 0;
            this.coverPB.TabStop = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(236, 12);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(297, 12);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(153, 20);
            this.idBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(236, 52);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(297, 52);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(153, 20);
            this.titleBox.TabIndex = 5;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(236, 92);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Author";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(297, 92);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(153, 20);
            this.authorBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Publisher";
            // 
            // publisherBox
            // 
            this.publisherBox.Location = new System.Drawing.Point(297, 132);
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(153, 20);
            this.publisherBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cover URL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.urlTextBox.Location = new System.Drawing.Point(297, 172);
            this.urlTextBox.Size = new System.Drawing.Size(153, 20);
            this.urlTextBox.TabIndex = 15;
            //
            // cateLabel
            //
            this.cateLabel.AutoSize = true;
            this.cateLabel.Location = new System.Drawing.Point(236, 212);
            this.cateLabel.Name = "catelabel";
            this.cateLabel.Size = new System.Drawing.Size(60, 13);
            this.cateLabel.TabIndex = 14;
            this.cateLabel.Text = "Category";
            //
            // cateComboBox
            //
            string[] employees = new string[] {"Textbook","Science","Comics","Novel","Magazines","Other"};
            cateComboBox.Items.AddRange(employees);
            this.cateComboBox.Location = new System.Drawing.Point(297, 212);
            this.cateComboBox.Size = new System.Drawing.Size(136, 81);

            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(12, 300);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(583, 171);
            this.descBox.TabIndex = 10;
            this.descBox.Text = "";
            // 
            // desLabel
            // 
            this.desLabel.AutoSize = true;
            this.desLabel.Location = new System.Drawing.Point(17, 280);
            this.desLabel.Name = "desLabel";
            this.desLabel.Size = new System.Drawing.Size(60, 13);
            this.desLabel.TabIndex = 11;
            this.desLabel.Text = "Description";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(526, 220);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(77, 32);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(82, 201);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 13;
            this.selectBtn.Text = "select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 490);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.desLabel);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.coverPB);
            this.Controls.Add(this.cateLabel);
            this.Controls.Add(this.cateComboBox);
            this.Name = "EditForm";
            this.Text = "Book Details";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        
        private System.Drawing.Image coverImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox coverPB;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publisherBox;
        private System.Windows.Forms.Label cateLabel;
        private System.Windows.Forms.ComboBox cateComboBox;
        private System.Windows.Forms.RichTextBox descBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label desLabel;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlTextBox;
    }
}