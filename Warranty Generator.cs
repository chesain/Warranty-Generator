using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using document = Microsoft.Office.Interop.Word;


namespace Warranty_Generator
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();


        }

       
        public void CheckWordDocx(string replc, string placehold)
        {
            object missing = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = application.Documents.Add("C:\\Users\\USCHVAN7\\source\\repos\\Warranty Generator\\WarrantyDoc_Template.docx");

            Microsoft.Office.Interop.Word.Find findObject = application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = placehold;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replc;

            object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);

            object filename = "C:\\Users\\USCHVAN7\\OneDrive - Hitachi Energy\\Desktop\\POCD\\savefile.docx";
            document.SaveAs2(ref filename); ;

            document.Close(ref missing, ref missing, ref missing);
            document = null;
            application.Quit(ref missing, ref missing, ref missing);
            application = null;
        }
    
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void salesordEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void serialsEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void startDateEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void endDateEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void poEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveLocEntry_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void fileNameEntry_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void sbmtClick_Click(object sender, EventArgs e)
        {
            CheckWordDocx(salesordEntry.Text, "salesordercv");
            CheckWordDocx(clientEntry.Text, "endusercv");
            CheckWordDocx(poEntry.Text, "customerpocv");

        }
    }
}
