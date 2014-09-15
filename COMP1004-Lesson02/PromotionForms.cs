/*
 * Author: Luis Acevedo
 * Version: 2014/09/15
 * Purpose: Lesson 02 - To allow a member to sign in a then show promotional codes and details as requested
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Lesson02
{
    public partial class PromotionForms : Form
    {
        public PromotionForms()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //Prints the offer and the code.
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        } 

        private void signInButton_Click(object sender, EventArgs e)
        {
            //let the user log in. Enable some controls; disable others
            //hide signning controls or inputs
            nameLabel.Visible = false;
            memberIdLabel.Visible = false;
            nameTextBox.Visible = false;
            memberIdMaskedTextBox.Visible = false;

            //enable the department names
            departmentGroupBox.Enabled = true;

            //Feed the Welcome Rich Text Box with the user information
            welcomeRichTextBox.Text = "Welcome: " + nameTextBox.Text + Environment.NewLine + "ID: " + memberIdMaskedTextBox.Text;

            //Make the promotions text, welcome text, picture box and image visible check box visible
            welcomeRichTextBox.Visible = true;
            promotionTextBox.Visible = true;
            imageVisibleTextBox.Visible = true;

            //Disable the sign in button
            signInButton.Enabled = false;
        }

        //Useless ones
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
        }

        private void imageVisibleTextBox_CheckedChanged(object sender, EventArgs e)
        {
            //make the picture box visible when the user chooses to do so
            departmentPictureBox.Visible = imageVisibleTextBox.Checked;
        }

        private void clothingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //show the image if selected of clothes
            promotionTextBox.Text = "30% OFF clearance items";
            departmentPictureBox.Image = COMP1004_Lesson02.Properties.Resources.clothes;
        }

        private void equipmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //show the image if selected of equipment
            promotionTextBox.Text = "25% OFF on all equipments";
            departmentPictureBox.Image = COMP1004_Lesson02.Properties.Resources.equipment;
        }

        private void juiceBarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //show the image if selected of equipment
            promotionTextBox.Text = "Free serving of WheatBerry Shake";
            departmentPictureBox.Image = COMP1004_Lesson02.Properties.Resources.juice_bar;
        }

        private void membershipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //show the image if selected of equipment
            promotionTextBox.Text = "50% OFF if you bring a friend!";
            departmentPictureBox.Image = COMP1004_Lesson02.Properties.Resources.membership;
        }

        private void personalTrainingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //show the image if selected of equipment
            promotionTextBox.Text = "Free personal trainer for the first month";
            departmentPictureBox.Image = COMP1004_Lesson02.Properties.Resources.personal_trainer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //let the user log in. Enable some controls; disable others
            //hide signning controls or inputs
            nameLabel.Visible = true;
            memberIdLabel.Visible = true;
            nameTextBox.Visible = true;
            memberIdMaskedTextBox.Visible = true;

            //enable the department names
            departmentGroupBox.Enabled = false;

            //Feed the Welcome Rich Text Box with the user information
            welcomeRichTextBox.Clear();

            //Make the promotions text, welcome text, picture box and image visible check box visible
            welcomeRichTextBox.Visible = false;
            promotionTextBox.Visible = false;
            imageVisibleTextBox.Visible = false;

            //Disable the sign in button
            signInButton.Enabled = true;

            //reset the image display
            departmentPictureBox.Visible = false;

            //restart the user, id and the state of the visible image check box
            nameTextBox.Clear();
            memberIdMaskedTextBox.Clear();
            imageVisibleTextBox.Checked = false;
        }
    }
}
