/*
 * John Hopson
 * Prog1
 * 14 February 2016
 * CIS 199-75
 * This program is designed to accept input about a paint job then calculate details about, and costs for, the job.
 */

using System;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //When clicked will calculate the total square footage of the job, the gallons of paint required, the total manhours needed, the costs for each, and the total cost.

            const double LABOR_CHARGE = 10.50,      //Holds the fixed cost of labor
                         GALLON_FOOTAGE = 325;      //Holds the fixed square footage for a gallon of paint
            const int LABOR_TIME = 8;               //Holds the fixed amount of labor per 325 sq ft
            double squareFeet,                      //Stores the square feet of the job
                   paintPrice,                      //Stores the price of paint
                   totalSquareFeet,                 //Holds calcualtion of total square feet
                   hours,                           //Holds calculated number of hours job requires
                   totalPaintCost,                  //Holds calculated price of paint
                   calculatedGallons,               //Holds claculated number of gallons of paint
                   actualGallons,                   //Holds rounded amount of gallons
                   totalLaborCost,                  //Holds calculated labor cost
                   totalJobCost = 0;                //Holds calculated total job cost
            int coats;                              //Stores the coats of paint needed

            //Grabs and parses the inputs if they are valid and returns error messages if invalid
            if (double.TryParse(squareFootageTB.Text, out squareFeet))
            {
                if (int.TryParse(coatsTB.Text, out coats))
                {
                    if (double.TryParse(paintPriceTB.Text, out paintPrice))
                    {
                        //Calculates total square footage
                        totalSquareFeet = squareFeet * coats;

                        //Calculates gallons of paint
                        calculatedGallons = totalSquareFeet / GALLON_FOOTAGE;

                        //Calculates gallons of paint and rounds up to nearest integer
                        actualGallons = Math.Ceiling(totalSquareFeet / GALLON_FOOTAGE);

                        //Calculates the hours required for the job
                        hours = calculatedGallons * LABOR_TIME;

                        //Calculates cost of paint
                        totalPaintCost = actualGallons * paintPrice;

                        //Calculates cost of labor
                        totalLaborCost = LABOR_CHARGE * hours;

                        //Calculates total cost of the job
                        totalJobCost += totalPaintCost + totalLaborCost;

                        //Displays the totals of all calculations
                        totalSquareFootageOutputLabel.Text = totalSquareFeet.ToString("N1");
                        gallonsPaintOutputLabel.Text = actualGallons.ToString();
                        totalHousOutputLabel.Text = hours.ToString("N1");
                        costOfPaintOutputLabel.Text = totalPaintCost.ToString("C");
                        costOfLaborOutputLabel.Text = totalLaborCost.ToString("C");
                        totalCostOutputLabel.Text = totalJobCost.ToString("C");
                    }
                    else
                    {
                        //Display an error message about the price of paint
                        MessageBox.Show("The price of paint entered is invalid. Click the help button next to the text box for instructions and examplese and please try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Display an error message about the number of coats of paint
                    MessageBox.Show("The number of coats of paint entered is invalid. Click the help button next to the text box for instructions and examplese and please try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Display an error message about the square footage
                MessageBox.Show("The square footage entered is invalid. Click the help button next to the text box for instructions and examplese and please try again.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the textboxes and labels
            squareFootageTB.Clear();
            coatsTB.Clear();
            paintPriceTB.Clear();
            totalSquareFootageOutputLabel.Text = "";
            gallonsPaintOutputLabel.Text = "";
            totalHousOutputLabel.Text = "";
            costOfLaborOutputLabel.Text = "";
            costOfPaintOutputLabel.Text = "";
            totalCostOutputLabel.Text = "";

            //Returns focus to square footage textbox
            squareFootageTB.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes app
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates tool tips when the form loads to help guide user's input
            System.Windows.Forms.ToolTip footageToolTip = new System.Windows.Forms.ToolTip(),      //Holds tool tip for entering square footage
                                         coatsToolTip = new System.Windows.Forms.ToolTip(),        //Holds tool tip for entering coats of paint
                                         paintToolTip = new System.Windows.Forms.ToolTip();        //Holds tool tip for entering cost of gallon of paint

            //Displays the tooltips
            footageToolTip.SetToolTip(this.footageQuestionPB, "Please enter the square footage in numbers only. No letters, spaces, or special characters. \n\n For example: 327 or 435.65");
            coatsToolTip.SetToolTip(this.coatsQuestionPB, "Please enter the number of coats of paint in numbers only. No letters, spaces, or special characters. \n\n For example: 2 or 5.");
            paintToolTip.SetToolTip(this.paintQuestionPB, "Please enter the cost of a gallon of paint in numbers only. No letters, spaces, or special characters. \n\n For example: 3.27 or 34.65");
        }
    }
}
