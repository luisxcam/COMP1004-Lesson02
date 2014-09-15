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




        //Useless ones
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
        }


    }
}
