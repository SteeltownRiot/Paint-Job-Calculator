namespace Prog1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.squareFootageTB = new System.Windows.Forms.TextBox();
            this.coatsTB = new System.Windows.Forms.TextBox();
            this.squareFootagePromptLabel = new System.Windows.Forms.Label();
            this.coatsPromptLabel = new System.Windows.Forms.Label();
            this.jobDetailsGB = new System.Windows.Forms.GroupBox();
            this.totalHousLabel = new System.Windows.Forms.Label();
            this.totalHousOutputLabel = new System.Windows.Forms.Label();
            this.gallonsPaintLabel = new System.Windows.Forms.Label();
            this.gallonsPaintOutputLabel = new System.Windows.Forms.Label();
            this.paintQuestionPB = new System.Windows.Forms.PictureBox();
            this.coatsQuestionPB = new System.Windows.Forms.PictureBox();
            this.footageQuestionPB = new System.Windows.Forms.PictureBox();
            this.paintPricePromptLabel = new System.Windows.Forms.Label();
            this.paintPriceTB = new System.Windows.Forms.TextBox();
            this.totalSquareFootageOutputLabel = new System.Windows.Forms.Label();
            this.squareFootageLabel = new System.Windows.Forms.Label();
            this.jobCostsGB = new System.Windows.Forms.GroupBox();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.costOfLaborOutputLabel = new System.Windows.Forms.Label();
            this.costOfPaintOutputLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.costOfLaborLabel = new System.Windows.Forms.Label();
            this.costOfPaintLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.jobDetailsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintQuestionPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatsQuestionPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footageQuestionPB)).BeginInit();
            this.jobCostsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // squareFootageTB
            // 
            this.squareFootageTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.squareFootageTB.Location = new System.Drawing.Point(295, 21);
            this.squareFootageTB.Margin = new System.Windows.Forms.Padding(2);
            this.squareFootageTB.Name = "squareFootageTB";
            this.squareFootageTB.Size = new System.Drawing.Size(68, 23);
            this.squareFootageTB.TabIndex = 0;
            // 
            // coatsTB
            // 
            this.coatsTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.coatsTB.Location = new System.Drawing.Point(295, 50);
            this.coatsTB.Margin = new System.Windows.Forms.Padding(2);
            this.coatsTB.Name = "coatsTB";
            this.coatsTB.Size = new System.Drawing.Size(68, 23);
            this.coatsTB.TabIndex = 1;
            // 
            // squareFootagePromptLabel
            // 
            this.squareFootagePromptLabel.AutoSize = true;
            this.squareFootagePromptLabel.Location = new System.Drawing.Point(65, 24);
            this.squareFootagePromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.squareFootagePromptLabel.Name = "squareFootagePromptLabel";
            this.squareFootagePromptLabel.Size = new System.Drawing.Size(227, 17);
            this.squareFootagePromptLabel.TabIndex = 2;
            this.squareFootagePromptLabel.Text = "Enter total square footage of walls:";
            // 
            // coatsPromptLabel
            // 
            this.coatsPromptLabel.AutoSize = true;
            this.coatsPromptLabel.Location = new System.Drawing.Point(38, 55);
            this.coatsPromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coatsPromptLabel.Name = "coatsPromptLabel";
            this.coatsPromptLabel.Size = new System.Drawing.Size(254, 17);
            this.coatsPromptLabel.TabIndex = 3;
            this.coatsPromptLabel.Text = "Enter number of desired coast of paint:";
            // 
            // jobDetailsGB
            // 
            this.jobDetailsGB.Controls.Add(this.totalHousLabel);
            this.jobDetailsGB.Controls.Add(this.totalHousOutputLabel);
            this.jobDetailsGB.Controls.Add(this.gallonsPaintLabel);
            this.jobDetailsGB.Controls.Add(this.gallonsPaintOutputLabel);
            this.jobDetailsGB.Controls.Add(this.paintQuestionPB);
            this.jobDetailsGB.Controls.Add(this.coatsQuestionPB);
            this.jobDetailsGB.Controls.Add(this.footageQuestionPB);
            this.jobDetailsGB.Controls.Add(this.paintPricePromptLabel);
            this.jobDetailsGB.Controls.Add(this.paintPriceTB);
            this.jobDetailsGB.Controls.Add(this.totalSquareFootageOutputLabel);
            this.jobDetailsGB.Controls.Add(this.squareFootageLabel);
            this.jobDetailsGB.Controls.Add(this.squareFootageTB);
            this.jobDetailsGB.Controls.Add(this.coatsPromptLabel);
            this.jobDetailsGB.Controls.Add(this.squareFootagePromptLabel);
            this.jobDetailsGB.Controls.Add(this.coatsTB);
            this.jobDetailsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobDetailsGB.Location = new System.Drawing.Point(19, 16);
            this.jobDetailsGB.Margin = new System.Windows.Forms.Padding(2);
            this.jobDetailsGB.Name = "jobDetailsGB";
            this.jobDetailsGB.Padding = new System.Windows.Forms.Padding(2);
            this.jobDetailsGB.Size = new System.Drawing.Size(394, 193);
            this.jobDetailsGB.TabIndex = 0;
            this.jobDetailsGB.TabStop = false;
            this.jobDetailsGB.Text = "Job Details";
            // 
            // totalHousLabel
            // 
            this.totalHousLabel.AutoSize = true;
            this.totalHousLabel.Location = new System.Drawing.Point(205, 158);
            this.totalHousLabel.Name = "totalHousLabel";
            this.totalHousLabel.Size = new System.Drawing.Size(84, 17);
            this.totalHousLabel.TabIndex = 14;
            this.totalHousLabel.Text = "Total hours:";
            // 
            // totalHousOutputLabel
            // 
            this.totalHousOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalHousOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalHousOutputLabel.Location = new System.Drawing.Point(295, 157);
            this.totalHousOutputLabel.Name = "totalHousOutputLabel";
            this.totalHousOutputLabel.Size = new System.Drawing.Size(67, 19);
            this.totalHousOutputLabel.TabIndex = 13;
            // 
            // gallonsPaintLabel
            // 
            this.gallonsPaintLabel.AutoSize = true;
            this.gallonsPaintLabel.Location = new System.Drawing.Point(148, 133);
            this.gallonsPaintLabel.Name = "gallonsPaintLabel";
            this.gallonsPaintLabel.Size = new System.Drawing.Size(144, 17);
            this.gallonsPaintLabel.TabIndex = 12;
            this.gallonsPaintLabel.Text = "Total gallons of paint:";
            // 
            // gallonsPaintOutputLabel
            // 
            this.gallonsPaintOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gallonsPaintOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsPaintOutputLabel.Location = new System.Drawing.Point(295, 132);
            this.gallonsPaintOutputLabel.Name = "gallonsPaintOutputLabel";
            this.gallonsPaintOutputLabel.Size = new System.Drawing.Size(67, 19);
            this.gallonsPaintOutputLabel.TabIndex = 11;
            // 
            // paintQuestionPB
            // 
            this.paintQuestionPB.Image = ((System.Drawing.Image)(resources.GetObject("paintQuestionPB.Image")));
            this.paintQuestionPB.Location = new System.Drawing.Point(368, 83);
            this.paintQuestionPB.Name = "paintQuestionPB";
            this.paintQuestionPB.Size = new System.Drawing.Size(17, 17);
            this.paintQuestionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paintQuestionPB.TabIndex = 10;
            this.paintQuestionPB.TabStop = false;
            // 
            // coatsQuestionPB
            // 
            this.coatsQuestionPB.Image = ((System.Drawing.Image)(resources.GetObject("coatsQuestionPB.Image")));
            this.coatsQuestionPB.Location = new System.Drawing.Point(368, 55);
            this.coatsQuestionPB.Name = "coatsQuestionPB";
            this.coatsQuestionPB.Size = new System.Drawing.Size(17, 17);
            this.coatsQuestionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coatsQuestionPB.TabIndex = 9;
            this.coatsQuestionPB.TabStop = false;
            // 
            // footageQuestionPB
            // 
            this.footageQuestionPB.Image = ((System.Drawing.Image)(resources.GetObject("footageQuestionPB.Image")));
            this.footageQuestionPB.Location = new System.Drawing.Point(368, 24);
            this.footageQuestionPB.Name = "footageQuestionPB";
            this.footageQuestionPB.Size = new System.Drawing.Size(17, 17);
            this.footageQuestionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.footageQuestionPB.TabIndex = 8;
            this.footageQuestionPB.TabStop = false;
            // 
            // paintPricePromptLabel
            // 
            this.paintPricePromptLabel.AutoSize = true;
            this.paintPricePromptLabel.Location = new System.Drawing.Point(65, 83);
            this.paintPricePromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paintPricePromptLabel.Name = "paintPricePromptLabel";
            this.paintPricePromptLabel.Size = new System.Drawing.Size(226, 17);
            this.paintPricePromptLabel.TabIndex = 7;
            this.paintPricePromptLabel.Text = "Enter the price of a gallon of paint:";
            // 
            // paintPriceTB
            // 
            this.paintPriceTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paintPriceTB.Location = new System.Drawing.Point(295, 79);
            this.paintPriceTB.Margin = new System.Windows.Forms.Padding(2);
            this.paintPriceTB.Name = "paintPriceTB";
            this.paintPriceTB.Size = new System.Drawing.Size(68, 23);
            this.paintPriceTB.TabIndex = 2;
            // 
            // totalSquareFootageOutputLabel
            // 
            this.totalSquareFootageOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalSquareFootageOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSquareFootageOutputLabel.Location = new System.Drawing.Point(295, 107);
            this.totalSquareFootageOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalSquareFootageOutputLabel.Name = "totalSquareFootageOutputLabel";
            this.totalSquareFootageOutputLabel.Size = new System.Drawing.Size(67, 19);
            this.totalSquareFootageOutputLabel.TabIndex = 3;
            // 
            // squareFootageLabel
            // 
            this.squareFootageLabel.AutoSize = true;
            this.squareFootageLabel.Location = new System.Drawing.Point(108, 108);
            this.squareFootageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.squareFootageLabel.Name = "squareFootageLabel";
            this.squareFootageLabel.Size = new System.Drawing.Size(183, 17);
            this.squareFootageLabel.TabIndex = 4;
            this.squareFootageLabel.Text = "Total square footage of job:";
            // 
            // jobCostsGB
            // 
            this.jobCostsGB.Controls.Add(this.totalCostOutputLabel);
            this.jobCostsGB.Controls.Add(this.costOfLaborOutputLabel);
            this.jobCostsGB.Controls.Add(this.costOfPaintOutputLabel);
            this.jobCostsGB.Controls.Add(this.totalCostLabel);
            this.jobCostsGB.Controls.Add(this.costOfLaborLabel);
            this.jobCostsGB.Controls.Add(this.costOfPaintLabel);
            this.jobCostsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobCostsGB.Location = new System.Drawing.Point(19, 224);
            this.jobCostsGB.Margin = new System.Windows.Forms.Padding(2);
            this.jobCostsGB.Name = "jobCostsGB";
            this.jobCostsGB.Padding = new System.Windows.Forms.Padding(2);
            this.jobCostsGB.Size = new System.Drawing.Size(230, 119);
            this.jobCostsGB.TabIndex = 5;
            this.jobCostsGB.TabStop = false;
            this.jobCostsGB.Text = "Job Costs";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(145, 85);
            this.totalCostOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(67, 22);
            this.totalCostOutputLabel.TabIndex = 5;
            this.totalCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costOfLaborOutputLabel
            // 
            this.costOfLaborOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.costOfLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfLaborOutputLabel.Location = new System.Drawing.Point(145, 55);
            this.costOfLaborOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costOfLaborOutputLabel.Name = "costOfLaborOutputLabel";
            this.costOfLaborOutputLabel.Size = new System.Drawing.Size(67, 22);
            this.costOfLaborOutputLabel.TabIndex = 4;
            this.costOfLaborOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costOfPaintOutputLabel
            // 
            this.costOfPaintOutputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.costOfPaintOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfPaintOutputLabel.Location = new System.Drawing.Point(145, 25);
            this.costOfPaintOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costOfPaintOutputLabel.Name = "costOfPaintOutputLabel";
            this.costOfPaintOutputLabel.Size = new System.Drawing.Size(67, 22);
            this.costOfPaintOutputLabel.TabIndex = 3;
            this.costOfPaintOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(22, 88);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(119, 17);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "Total Cost of Job:";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costOfLaborLabel
            // 
            this.costOfLaborLabel.AutoSize = true;
            this.costOfLaborLabel.Location = new System.Drawing.Point(44, 58);
            this.costOfLaborLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costOfLaborLabel.Name = "costOfLaborLabel";
            this.costOfLaborLabel.Size = new System.Drawing.Size(97, 17);
            this.costOfLaborLabel.TabIndex = 1;
            this.costOfLaborLabel.Text = "Cost of Labor:";
            this.costOfLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costOfPaintLabel
            // 
            this.costOfPaintLabel.AutoSize = true;
            this.costOfPaintLabel.Location = new System.Drawing.Point(49, 28);
            this.costOfPaintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costOfPaintLabel.Name = "costOfPaintLabel";
            this.costOfPaintLabel.Size = new System.Drawing.Size(92, 17);
            this.costOfPaintLabel.TabIndex = 0;
            this.costOfPaintLabel.Text = "Cost of Paint:";
            this.costOfPaintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.FlatAppearance.BorderSize = 2;
            this.calcButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(269, 231);
            this.calcButton.Margin = new System.Windows.Forms.Padding(2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(144, 34);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "&Calculate Cost";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(269, 270);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 34);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(269, 309);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 34);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(434, 364);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.jobCostsGB);
            this.Controls.Add(this.jobDetailsGB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Paint Job Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.jobDetailsGB.ResumeLayout(false);
            this.jobDetailsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintQuestionPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coatsQuestionPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footageQuestionPB)).EndInit();
            this.jobCostsGB.ResumeLayout(false);
            this.jobCostsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox squareFootageTB;
        private System.Windows.Forms.TextBox coatsTB;
        private System.Windows.Forms.Label squareFootagePromptLabel;
        private System.Windows.Forms.Label coatsPromptLabel;
        private System.Windows.Forms.GroupBox jobDetailsGB;
        private System.Windows.Forms.GroupBox jobCostsGB;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Label costOfLaborOutputLabel;
        private System.Windows.Forms.Label costOfPaintOutputLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label costOfLaborLabel;
        private System.Windows.Forms.Label costOfPaintLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalSquareFootageOutputLabel;
        private System.Windows.Forms.Label squareFootageLabel;
        private System.Windows.Forms.Label paintPricePromptLabel;
        private System.Windows.Forms.TextBox paintPriceTB;
        private System.Windows.Forms.PictureBox footageQuestionPB;
        private System.Windows.Forms.PictureBox paintQuestionPB;
        private System.Windows.Forms.PictureBox coatsQuestionPB;
        private System.Windows.Forms.Label gallonsPaintLabel;
        private System.Windows.Forms.Label gallonsPaintOutputLabel;
        private System.Windows.Forms.Label totalHousLabel;
        private System.Windows.Forms.Label totalHousOutputLabel;
    }
}

