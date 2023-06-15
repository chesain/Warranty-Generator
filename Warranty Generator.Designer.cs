namespace Warranty_Generator
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
            this.sbmtClick = new System.Windows.Forms.Button();
            this.salesordEntry = new System.Windows.Forms.TextBox();
            this.serialsEntry = new System.Windows.Forms.TextBox();
            this.clientEntry = new System.Windows.Forms.TextBox();
            this.startDateEntry = new System.Windows.Forms.TextBox();
            this.endDateEntry = new System.Windows.Forms.TextBox();
            this.poEntry = new System.Windows.Forms.TextBox();
            this.saveLocEntry = new System.Windows.Forms.TextBox();
            this.fileNameEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sbmtClick
            // 
            this.sbmtClick.Location = new System.Drawing.Point(317, 401);
            this.sbmtClick.Name = "sbmtClick";
            this.sbmtClick.Size = new System.Drawing.Size(91, 38);
            this.sbmtClick.TabIndex = 0;
            this.sbmtClick.Text = "Submit";
            this.sbmtClick.UseVisualStyleBackColor = true;
            this.sbmtClick.Click += new System.EventHandler(this.sbmtClick_Click);
            // 
            // salesordEntry
            // 
            this.salesordEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesordEntry.Location = new System.Drawing.Point(210, 19);
            this.salesordEntry.Name = "salesordEntry";
            this.salesordEntry.Size = new System.Drawing.Size(468, 22);
            this.salesordEntry.TabIndex = 1;
            this.salesordEntry.TextChanged += new System.EventHandler(this.salesordEntry_TextChanged);
            // 
            // serialsEntry
            // 
            this.serialsEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serialsEntry.Location = new System.Drawing.Point(210, 58);
            this.serialsEntry.Name = "serialsEntry";
            this.serialsEntry.Size = new System.Drawing.Size(468, 22);
            this.serialsEntry.TabIndex = 4;
            this.serialsEntry.TextChanged += new System.EventHandler(this.serialsEntry_TextChanged);
            // 
            // clientEntry
            // 
            this.clientEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientEntry.Location = new System.Drawing.Point(210, 101);
            this.clientEntry.Name = "clientEntry";
            this.clientEntry.Size = new System.Drawing.Size(468, 22);
            this.clientEntry.TabIndex = 6;
            this.clientEntry.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // startDateEntry
            // 
            this.startDateEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startDateEntry.Location = new System.Drawing.Point(210, 140);
            this.startDateEntry.Name = "startDateEntry";
            this.startDateEntry.Size = new System.Drawing.Size(468, 22);
            this.startDateEntry.TabIndex = 7;
            this.startDateEntry.TextChanged += new System.EventHandler(this.startDateEntry_TextChanged);
            // 
            // endDateEntry
            // 
            this.endDateEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endDateEntry.Location = new System.Drawing.Point(210, 181);
            this.endDateEntry.Name = "endDateEntry";
            this.endDateEntry.Size = new System.Drawing.Size(468, 22);
            this.endDateEntry.TabIndex = 8;
            this.endDateEntry.TextChanged += new System.EventHandler(this.endDateEntry_TextChanged);
            // 
            // poEntry
            // 
            this.poEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poEntry.Location = new System.Drawing.Point(210, 223);
            this.poEntry.Name = "poEntry";
            this.poEntry.Size = new System.Drawing.Size(468, 22);
            this.poEntry.TabIndex = 9;
            this.poEntry.TextChanged += new System.EventHandler(this.poEntry_TextChanged);
            // 
            // saveLocEntry
            // 
            this.saveLocEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveLocEntry.Location = new System.Drawing.Point(210, 267);
            this.saveLocEntry.Name = "saveLocEntry";
            this.saveLocEntry.Size = new System.Drawing.Size(468, 22);
            this.saveLocEntry.TabIndex = 10;
            this.saveLocEntry.TextChanged += new System.EventHandler(this.saveLocEntry_TextChanged);
            // 
            // fileNameEntry
            // 
            this.fileNameEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileNameEntry.Location = new System.Drawing.Point(210, 308);
            this.fileNameEntry.Name = "fileNameEntry";
            this.fileNameEntry.Size = new System.Drawing.Size(468, 22);
            this.fileNameEntry.TabIndex = 11;
            this.fileNameEntry.TextChanged += new System.EventHandler(this.fileNameEntry_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sales Order No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Serial Numbers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Client";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Warrant Start Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Warrant End Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customer PO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Where to save letter";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name of letter";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 522);
            this.Controls.Add(this.fileNameEntry);
            this.Controls.Add(this.saveLocEntry);
            this.Controls.Add(this.poEntry);
            this.Controls.Add(this.endDateEntry);
            this.Controls.Add(this.startDateEntry);
            this.Controls.Add(this.clientEntry);
            this.Controls.Add(this.serialsEntry);
            this.Controls.Add(this.salesordEntry);
            this.Controls.Add(this.sbmtClick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sbmtClick;
        private System.Windows.Forms.TextBox serialsEntry;
        private System.Windows.Forms.TextBox clientEntry;
        private System.Windows.Forms.TextBox startDateEntry;
        private System.Windows.Forms.TextBox endDateEntry;
        private System.Windows.Forms.TextBox poEntry;
        private System.Windows.Forms.TextBox saveLocEntry;
        private System.Windows.Forms.TextBox fileNameEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox salesordEntry;
    }
}

