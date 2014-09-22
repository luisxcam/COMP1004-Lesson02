namespace COMP1004_Lesson02
{
    partial class PromotionForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromotionForms));
            this.designedByLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.departmentGroupBox = new System.Windows.Forms.GroupBox();
            this.personalTrainingRadioButton = new System.Windows.Forms.RadioButton();
            this.membershipRadioButton = new System.Windows.Forms.RadioButton();
            this.juiceBarRadioButton = new System.Windows.Forms.RadioButton();
            this.equipmentRadioButton = new System.Windows.Forms.RadioButton();
            this.clothingRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.welcomeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.promotionTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.memberIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.departmentPictureBox = new System.Windows.Forms.PictureBox();
            this.imageVisibleTextBox = new System.Windows.Forms.CheckBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.departmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // designedByLabel
            // 
            this.designedByLabel.AutoSize = true;
            this.designedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designedByLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.designedByLabel.Location = new System.Drawing.Point(416, 456);
            this.designedByLabel.Name = "designedByLabel";
            this.designedByLabel.Size = new System.Drawing.Size(102, 13);
            this.designedByLabel.TabIndex = 0;
            this.designedByLabel.Text = "By Luis Acevedo";
            this.designedByLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(153, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(268, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Look Sharp Fitness Center";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(523, 478);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -18;
            this.lineShape1.X2 = 928;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // departmentGroupBox
            // 
            this.departmentGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.departmentGroupBox.Controls.Add(this.personalTrainingRadioButton);
            this.departmentGroupBox.Controls.Add(this.membershipRadioButton);
            this.departmentGroupBox.Controls.Add(this.juiceBarRadioButton);
            this.departmentGroupBox.Controls.Add(this.equipmentRadioButton);
            this.departmentGroupBox.Controls.Add(this.clothingRadioButton);
            this.departmentGroupBox.Enabled = false;
            this.departmentGroupBox.Location = new System.Drawing.Point(13, 53);
            this.departmentGroupBox.Name = "departmentGroupBox";
            this.departmentGroupBox.Size = new System.Drawing.Size(183, 148);
            this.departmentGroupBox.TabIndex = 3;
            this.departmentGroupBox.TabStop = false;
            this.departmentGroupBox.Text = "&Department";
            // 
            // personalTrainingRadioButton
            // 
            this.personalTrainingRadioButton.AutoSize = true;
            this.personalTrainingRadioButton.Location = new System.Drawing.Point(6, 111);
            this.personalTrainingRadioButton.Name = "personalTrainingRadioButton";
            this.personalTrainingRadioButton.Size = new System.Drawing.Size(107, 17);
            this.personalTrainingRadioButton.TabIndex = 4;
            this.personalTrainingRadioButton.TabStop = true;
            this.personalTrainingRadioButton.Text = "Personal &Training";
            this.personalTrainingRadioButton.UseVisualStyleBackColor = true;
            this.personalTrainingRadioButton.CheckedChanged += new System.EventHandler(this.personalTrainingRadioButton_CheckedChanged);
            // 
            // membershipRadioButton
            // 
            this.membershipRadioButton.AutoSize = true;
            this.membershipRadioButton.Location = new System.Drawing.Point(6, 88);
            this.membershipRadioButton.Name = "membershipRadioButton";
            this.membershipRadioButton.Size = new System.Drawing.Size(82, 17);
            this.membershipRadioButton.TabIndex = 3;
            this.membershipRadioButton.TabStop = true;
            this.membershipRadioButton.Text = "&Membership";
            this.membershipRadioButton.UseVisualStyleBackColor = true;
            this.membershipRadioButton.CheckedChanged += new System.EventHandler(this.membershipRadioButton_CheckedChanged);
            // 
            // juiceBarRadioButton
            // 
            this.juiceBarRadioButton.AutoSize = true;
            this.juiceBarRadioButton.Location = new System.Drawing.Point(6, 65);
            this.juiceBarRadioButton.Name = "juiceBarRadioButton";
            this.juiceBarRadioButton.Size = new System.Drawing.Size(69, 17);
            this.juiceBarRadioButton.TabIndex = 2;
            this.juiceBarRadioButton.TabStop = true;
            this.juiceBarRadioButton.Text = "&Juice Bar";
            this.juiceBarRadioButton.UseVisualStyleBackColor = true;
            this.juiceBarRadioButton.CheckedChanged += new System.EventHandler(this.juiceBarRadioButton_CheckedChanged);
            // 
            // equipmentRadioButton
            // 
            this.equipmentRadioButton.AutoSize = true;
            this.equipmentRadioButton.Location = new System.Drawing.Point(6, 42);
            this.equipmentRadioButton.Name = "equipmentRadioButton";
            this.equipmentRadioButton.Size = new System.Drawing.Size(132, 17);
            this.equipmentRadioButton.TabIndex = 1;
            this.equipmentRadioButton.TabStop = true;
            this.equipmentRadioButton.Text = "&Equipment/Accesories";
            this.equipmentRadioButton.UseVisualStyleBackColor = true;
            this.equipmentRadioButton.CheckedChanged += new System.EventHandler(this.equipmentRadioButton_CheckedChanged);
            // 
            // clothingRadioButton
            // 
            this.clothingRadioButton.AutoSize = true;
            this.clothingRadioButton.Location = new System.Drawing.Point(6, 19);
            this.clothingRadioButton.Name = "clothingRadioButton";
            this.clothingRadioButton.Size = new System.Drawing.Size(63, 17);
            this.clothingRadioButton.TabIndex = 0;
            this.clothingRadioButton.TabStop = true;
            this.clothingRadioButton.Text = "&Clothing";
            this.clothingRadioButton.UseVisualStyleBackColor = true;
            this.clothingRadioButton.CheckedChanged += new System.EventHandler(this.clothingRadioButton_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(203, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.AutoSize = true;
            this.memberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIdLabel.Location = new System.Drawing.Point(203, 99);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(72, 13);
            this.memberIdLabel.TabIndex = 5;
            this.memberIdLabel.Text = "Member ID:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(305, 72);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 20);
            this.nameTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.nameTextBox, "Enter the name of the User");
            this.nameTextBox.WordWrap = false;
            // 
            // welcomeRichTextBox
            // 
            this.welcomeRichTextBox.ForeColor = System.Drawing.Color.Red;
            this.welcomeRichTextBox.Location = new System.Drawing.Point(205, 211);
            this.welcomeRichTextBox.Name = "welcomeRichTextBox";
            this.welcomeRichTextBox.Size = new System.Drawing.Size(312, 82);
            this.welcomeRichTextBox.TabIndex = 2;
            this.welcomeRichTextBox.Text = "";
            this.welcomeRichTextBox.Visible = false;
            // 
            // promotionTextBox
            // 
            this.promotionTextBox.Location = new System.Drawing.Point(205, 300);
            this.promotionTextBox.Name = "promotionTextBox";
            this.promotionTextBox.Size = new System.Drawing.Size(312, 20);
            this.promotionTextBox.TabIndex = 3;
            this.promotionTextBox.Visible = false;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(442, 333);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "&Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(442, 414);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(442, 387);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "&Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // memberIdMaskedTextBox
            // 
            this.memberIdMaskedTextBox.Location = new System.Drawing.Point(305, 99);
            this.memberIdMaskedTextBox.Mask = "00000";
            this.memberIdMaskedTextBox.Name = "memberIdMaskedTextBox";
            this.memberIdMaskedTextBox.Size = new System.Drawing.Size(39, 20);
            this.memberIdMaskedTextBox.TabIndex = 1;
            this.memberIdMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.memberIdMaskedTextBox, "Enter Member ID");
            this.memberIdMaskedTextBox.ValidatingType = typeof(int);
            // 
            // departmentPictureBox
            // 
            this.departmentPictureBox.Location = new System.Drawing.Point(13, 211);
            this.departmentPictureBox.Name = "departmentPictureBox";
            this.departmentPictureBox.Size = new System.Drawing.Size(183, 109);
            this.departmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.departmentPictureBox.TabIndex = 13;
            this.departmentPictureBox.TabStop = false;
            this.departmentPictureBox.Visible = false;
            // 
            // imageVisibleTextBox
            // 
            this.imageVisibleTextBox.AutoSize = true;
            this.imageVisibleTextBox.Location = new System.Drawing.Point(12, 403);
            this.imageVisibleTextBox.Name = "imageVisibleTextBox";
            this.imageVisibleTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.imageVisibleTextBox.Size = new System.Drawing.Size(88, 17);
            this.imageVisibleTextBox.TabIndex = 4;
            this.imageVisibleTextBox.Text = "Image Visible";
            this.imageVisibleTextBox.UseVisualStyleBackColor = true;
            this.imageVisibleTextBox.Visible = false;
            this.imageVisibleTextBox.CheckedChanged += new System.EventHandler(this.imageVisibleTextBox_CheckedChanged);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clea&r";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PromotionForms
            // 
            this.AcceptButton = this.signInButton;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(523, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageVisibleTextBox);
            this.Controls.Add(this.departmentPictureBox);
            this.Controls.Add(this.memberIdMaskedTextBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.promotionTextBox);
            this.Controls.Add(this.welcomeRichTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.memberIdLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.departmentGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.designedByLabel);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PromotionForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotions";
            this.departmentGroupBox.ResumeLayout(false);
            this.departmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label designedByLabel;
        private System.Windows.Forms.Label titleLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox departmentGroupBox;
        private System.Windows.Forms.RadioButton personalTrainingRadioButton;
        private System.Windows.Forms.RadioButton membershipRadioButton;
        private System.Windows.Forms.RadioButton juiceBarRadioButton;
        private System.Windows.Forms.RadioButton equipmentRadioButton;
        private System.Windows.Forms.RadioButton clothingRadioButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox welcomeRichTextBox;
        private System.Windows.Forms.TextBox promotionTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.MaskedTextBox memberIdMaskedTextBox;
        private System.Windows.Forms.PictureBox departmentPictureBox;
        private System.Windows.Forms.CheckBox imageVisibleTextBox;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

