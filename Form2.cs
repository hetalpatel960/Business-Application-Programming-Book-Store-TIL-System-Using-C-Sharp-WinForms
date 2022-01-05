/* Student Name: Hetal Patel
   Student ID: 21235177
   Date: 10-12-2021
   Assignment No.: 4
   Description: The application is designed with an objective of processing sale and monitoring stock in Bibliophile Book Store.
                The system is divided into two part, Sale System and Management System. In the sale system (Form1), the operation such as adding members and placing order can be done. 
                In management system (Form2), the operation such as check stock, search transactions and Daily Sales Report can be done.  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace BAP_Assignment4_v2
{
    public partial class Form2 : Form
    {
        //Storing Text File Paths into constants strings
        const string TXNSTEXTFILE = @"C:\Users\Het_96\source\repos\BAP-Assignment4_v2\bin\Debug\Transactions.txt";
        const string MEMBERSTXTFILE = @"C:\Users\Het_96\source\repos\BAP-Assignment4_v2\bin\Debug\Members.txt";
        const string DAILYSALESREPORTTXTFILE = @"C:\Users\Het_96\source\repos\BAP-Assignment4_v2\bin\Debug\DailySalesReport.txt";
        
        string SearchBy;
        /*
        Declarations of Below Lists are to hold following value:
        NumberofBooks= Total numbers of books in report.
        TotalSale = TotalSale(in euros.) of all books in report.
        NumberofMembers = Total numbers of members in report.
        BookNames = Name of Books in report.
        SalePerCateg1 = Total Sale(in euros.) for category Poetry and Drama Books.
        SalePerCateg2 = Total Sale(in euros.) for category Science Fiction Books.
        SalePerCateg3 = Total Sale(in euros.) for category BioFiction Books.
        */

        List<int> NumberofBooks = new List<int>();
        List<decimal> TotalSale = new List<decimal>();
        List<int> NumberofMembers = new List<int>();
        List<string> BookNames = new List<string>();
        List<decimal> SalePerCateg1 = new List<decimal>();
        List<decimal> SalePerCateg2 = new List<decimal>();
        List<decimal> SalePerCateg3 = new List<decimal>();
        int PnDOrderQty = 0, SciFicOrderQty = 0, BioFicOrderQty = 0;
        decimal AvgSale;
        string[] TxnsTextFile;
        string[] MembersTextFile;
        

        Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();  //Application exists.

        }

        private void SearchMainGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchByTransactionIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchByTransactionDateTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            //Below lines of code will clear all the fields used for searching transactions.
            SearchTxnIDRadioButton.Checked = false;
            SearchTxnDateRadioButton.Checked = false;
            SearchByTransactionIdTextBox.Text = "";
            SearchByTransactionIdTextBox.Enabled = false;
            SearchByTransactionDateTextBox.Text = "";
            SearchByTransactionDateTextBox.Enabled = false;
            TransactionsFoundListBox.Visible = false;
            TransactionsFoundLabel.Visible = false;
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Search Functionality
            string SearchTransactionString = SearchByTransactionIdTextBox.Text;
            string SearchDateString = SearchByTransactionDateTextBox.Text;
            
            //Search By Trans ID
            if (SearchBy == "TxnID")
            {

                if (SearchTransactionString != "")
                {

                    TransactionsFoundListBox.Items.Clear();
                    //Calling Search function and passing Search String and Search by identifier.
                    SearchTxn(SearchTransactionString, 1);

                }
                else
                {
                    //Exception handling if TransID is empty 
                    MessageBox.Show("Enter Transaction ID", "Empty Transaction ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SearchByTransactionIdTextBox.Focus();
                    SearchByTransactionIdTextBox.SelectAll();
                }

            }

            //Search By Trans Date
            else if (SearchBy == "TxnDate")
            {

                if (SearchDateString != "")
                {
                    TransactionsFoundListBox.Items.Clear();
                    //Calling Search function and passing Search String and Search by identifier.
                    SearchTxn(SearchDateString, 2);

                }
                else
                {
                    //Exception handling if TransDate is empty 
                    MessageBox.Show("Enter Transaction Date", "Empty Transaction Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SearchByTransactionDateTextBox.Focus();
                    SearchByTransactionDateTextBox.SelectAll();
                }
            }
            else
            {
                //Exception handling if both TransID & TransDate are empty 
                MessageBox.Show("Please select any one search criteria", "Search criteria required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SearchRadioGroupBox.Focus();
                ResetSearchButton_Click(sender, e);
                return;
            }

            TransactionsFoundListBox.Visible = true;
            TransactionsFoundLabel.Visible = true;

        }

        //Search function
        private void SearchTxn(string SearchString, int SearchType)
        {
            
            try
            {
                //Below lines of code will search data using TxnsTextFile array which holds all the lined read from Transactions.txt file.
                for (int i =0; i<TxnsTextFile.Length; i++)
                {
                    //If search by ID
                    if (SearchType == 1)
                    {
                        //When TransID is found
                        if (TxnsTextFile[i].Equals(SearchString))
                        {
                            //Add following items to the TransactionsFoundListBox
                            //Note: Each line of transaction is being fetched and added to the listbox in a formatted way.

                            TransactionsFoundListBox.Items.Add("-------------------------------------------------------");
                            TransactionsFoundListBox.Items.Add("Transaction ID: " + TxnsTextFile[i]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("Transaction Date: " + TxnsTextFile[i + 1]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("CUSTOMER DETAILS:");
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("Full Name: \t" + TxnsTextFile[i + 2]);
                            TransactionsFoundListBox.Items.Add("Contact: \t\t" + TxnsTextFile[i + 3]);
                            TransactionsFoundListBox.Items.Add("Email: \t\t" + TxnsTextFile[i + 4]);
                            TransactionsFoundListBox.Items.Add("Location: \t" + TxnsTextFile[i + 5]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("BOOKS SOLD:");
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("No. of Books: \t" + TxnsTextFile[i + 6]);
                            TransactionsFoundListBox.Items.Add("Total Price: \t €" + TxnsTextFile[i + 7]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("List of Books in Order:");

                            //Below loop and condition statement will fetch the list of book names found in transaction. The loop will be breaked once splitting limit is being identified, which is a string with hyphens.
                            for (int j = i+8; j< TxnsTextFile.Length; j++)
                            {
                                if(!TxnsTextFile[j].Equals("------------------------------------------------------------------------------------------------------------------"))
                                {
                                    TransactionsFoundListBox.Items.Add(TxnsTextFile[j]);
                                }
                                else
                                {
                                    break;
                                }
                                
                            }

                            TransactionsFoundListBox.Items.Add("-------------------------------------------------------");
                        }

                    }
                    //If search by Date
                    else if (SearchType == 2)
                    {
                        //When TransDate is found
                        if (TxnsTextFile[i].Equals(SearchString))
                        {
                            //Add following items to the TransactionsFoundListBox
                            //Note: Each line of transaction is being fetched and added to the listbox in a formatted way.

                            TransactionsFoundListBox.Items.Add("-------------------------------------------------------");
                            TransactionsFoundListBox.Items.Add("Transaction ID: " + TxnsTextFile[i-1]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("Transaction Date: " + TxnsTextFile[i]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("CUSTOMER DETAILS:");
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("Full Name: \t" + TxnsTextFile[i + 1]);
                            TransactionsFoundListBox.Items.Add("Contact: \t\t" + TxnsTextFile[i + 2]);
                            TransactionsFoundListBox.Items.Add("Email: \t\t" + TxnsTextFile[i + 3]);
                            TransactionsFoundListBox.Items.Add("Location: \t" + TxnsTextFile[i + 4]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("BOOKS SOLD:");
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("No. of Books: \t" + TxnsTextFile[i + 5]);
                            TransactionsFoundListBox.Items.Add("Total Price: \t €" + TxnsTextFile[i + 6]);
                            TransactionsFoundListBox.Items.Add("");
                            TransactionsFoundListBox.Items.Add("List of Books in Order:");

                            //Below loop and condition statement will fetch the list of book names found in transaction. The loop will be breaked once splitting limit is being identified, which is a string with hyphens.
                            for (int j = i + 7; j < TxnsTextFile.Length; j++)
                            {
                                if (!TxnsTextFile[j].Equals("------------------------------------------------------------------------------------------------------------------"))
                                {
                                    TransactionsFoundListBox.Items.Add(TxnsTextFile[j]);
                                }
                                else
                                {
                                    break;
                                }
                            }

                            TransactionsFoundListBox.Items.Add("-------------------------------------------------------"); 
                        }
                    }
                   
                }

                //If No transaction is found, system will notify user about it and it will ask user to retry with some other search criteria
                if(TransactionsFoundListBox.Items.Count == 0)
                {
                    MessageBox.Show("No Transactions Found. \n Please retry changing search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetSearchButton_Click(null, null);
                }

                SearchTxnIDRadioButton.Checked = false;
                SearchTxnDateRadioButton.Checked = false;
                SearchByTransactionIdTextBox.Text = "";
                SearchByTransactionDateTextBox.Text = "";
                SearchByTransactionIdTextBox.Enabled = false;
                SearchByTransactionDateTextBox.Enabled = false;

            }
            catch (Exception exception)
            {

                //Exception Handling in extenuating circumstances, for example, deletion of Transactions.txt file.
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void TransactionsFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransactionsFoundLabel_Click(object sender, EventArgs e)
        {

        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //Form Load
                string ButtonControl = Form1.ButtonControl;

                //Displaying GroupBoxes as per the button clicked on Form1 and string value passed in ButtonControl variable
                if (ButtonControl.Equals("SearchAction"))
                {
                    SearchMainGroupBox.Visible = true;
                    StockGroupBox.Visible = false;
                    PnDInvListView.Visible = false;
                    SciFicInvListView.Visible = false;
                    BioFicInvListView.Visible = false;
                    ReportGroupBox.Visible = false;

                }
                else if (ButtonControl.Equals("CheckStockAction"))
                {
                    SearchMainGroupBox.Visible = false;
                    StockGroupBox.Visible = true;
                    PnDInvListView.Visible = true;
                    SciFicInvListView.Visible = true;
                    BioFicInvListView.Visible = true;
                    ReportGroupBox.Visible = false;
                }
                else if (ButtonControl.Equals("GenerateReport"))
                {
                    SearchMainGroupBox.Visible = false;
                    StockGroupBox.Visible = false;
                    PnDInvListView.Visible = false;
                    SciFicInvListView.Visible = false;
                    BioFicInvListView.Visible = false;
                    ReportGroupBox.Visible = true;
                    DSRPerBookGroupBox.Visible = true;
                    GenerateDSRByDateGroupBox.Visible = true;
                    SaleReportGroupBox.Visible = false;
                }
                else
                {
                    SearchMainGroupBox.Visible = true;
                    StockGroupBox.Visible = false;
                    PnDInvListView.Visible = false;
                    SciFicInvListView.Visible = false;
                    BioFicInvListView.Visible = false;
                    ReportGroupBox.Visible = false;
                }

                /*Reading stock from Form1 2D Array.
                IMPORTANT NOTE: Stock value was being read already into the application when Form1 was loaded. However, to display the read stock we are using Form2.
                Thus, reading from Form1 2D Array instead of reading directly from txt file*/

                //Displaying stock of Poetry and Drama Books
                for (int i = 0; i <= 19; i++)
                {
                    PnDInvListView.Items.Add(Form1.PnDBooksAndAuthors[i, 0].ToString());
                    PnDInvListView.Items[i].SubItems.Add(Form1.PnDBooksAndAuthors[i, 1].ToString());
                    PnDInvListView.Items[i].SubItems.Add(Form1.Stock[0, i].ToString());
                }

                //Displaying stock of SciFiction Books
                for (int i = 0; i <= 19; i++)
                {
                    SciFicInvListView.Items.Add(Form1.SciFicBooksAndAuthors[i, 0].ToString());
                    SciFicInvListView.Items[i].SubItems.Add(Form1.SciFicBooksAndAuthors[i, 1].ToString());
                    SciFicInvListView.Items[i].SubItems.Add(Form1.Stock[1, i].ToString());
                }

                //Displaying stock of BioFiction Books
                for (int i = 0; i <= 19; i++)
                {
                    BioFicInvListView.Items.Add(Form1.BioFicBooksAndAuthors[i, 0].ToString());
                    BioFicInvListView.Items[i].SubItems.Add(Form1.BioFicBooksAndAuthors[i, 1].ToString());
                    BioFicInvListView.Items[i].SubItems.Add(Form1.Stock[2, i].ToString());
                }

                TxnsTextFile = File.ReadAllLines(TXNSTEXTFILE);
                MembersTextFile = File.ReadAllLines(MEMBERSTXTFILE);

            }
            catch (Exception exception)
            {
                //Exception Handling in extenuating circumstances, for example, deletion of Transactions.txt file.
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SearchTxnIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Search by Trans ID Radio Button 
            SearchBy = "TxnID";
            SearchByTransactionIdTextBox.Enabled = true;
            SearchByTransactionDateTextBox.Enabled = false;
        }

        private void SearchTxnDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Search by Trans Date Radio Button 
            SearchBy = "TxnDate";
            SearchByTransactionDateTextBox.Enabled = true;
            SearchByTransactionIdTextBox.Enabled = false;
        }

        private void SearchRadioGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void StockGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void BacktoMainMenuButton_Click(object sender, EventArgs e)
        {
            //Taking user back to Main Form (Form 1)
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void SciFicInvListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void PnDInvListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

       

        private void BioFicInvListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void ReportGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ReportsByCategoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ReportByCategGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ReportingDateTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TotalBooksSoldTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TotalSaleTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AvgSaleTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TotalMembersAddedTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void TotalMembershipDiscountAppliedTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaleReportGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void GenerateDSRByDateGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void DSRDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Field variables to record average sale per book category
                decimal AvgSale1, AvgSale2, AvgSale3;
                string DSRDate;
                DSRDate = DSRDateTextBox.Text;      //Capture date to generate DSR (DSR Date)

                if (DSRDateTextBox.Text != "")
                {
                    DSRDate = Convert.ToDateTime(DSRDate).ToShortDateString();
                    DailySalesReportDateTextBox.Text = DSRDate;
                    ReportingDateTextBox.Text = DateTime.Now.ToShortDateString();

                }
                else
                {
                    //Exception handled if DSR Date is empty
                    MessageBox.Show("Date Field is Empty. \n Please retry with non-empty date value.", "Empty Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DSRDateTextBox.Focus();
                    DSRDateTextBox.SelectAll();
                    return;
                }

                //Search for DSR Date in Transactions.txt file.
                for (int i = 0; i < TxnsTextFile.Length; i++)
                {
                    //If Trans Date found
                    if (TxnsTextFile[i].Equals(DSRDate))
                    {
                        //Capture Number of Books
                        NumberofBooks.Add(int.Parse(TxnsTextFile[i + 5]));

                        //Capture Total Sale of Books
                        TotalSale.Add(Convert.ToDecimal(TxnsTextFile[i + 6]));

                        //Capture Name of Books
                        for (int j = i + 7; j < TxnsTextFile.Length; j++)
                        {
                            if (!TxnsTextFile[j].Equals("------------------------------------------------------------------------------------------------------------------"))
                            {
                                BookNames.Add(TxnsTextFile[j]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                }
                //Capture Members Added on DSR date
                for (int i = 0; i < MembersTextFile.Length; i++)
                {
                    if (MembersTextFile[i].Equals(DSRDate))
                    {
                        NumberofMembers.Add(1);
                    }

                }

                //Capture sale, qty sold per book category
                for (int i = 0; i < BookNames.Count; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (BookNames[i].Equals(Form1.PnDBooksAndAuthors[j, 0].ToString()))
                        {
                            PnDOrderQty++;
                            SalePerCateg1.Add(Form1.Price[0, j]);

                        }
                        if (BookNames[i].Equals(Form1.SciFicBooksAndAuthors[j, 0].ToString()))
                        {
                            SciFicOrderQty++;
                            SalePerCateg2.Add(Form1.Price[1, j]);
                        }
                        if (BookNames[i].Equals(Form1.BioFicBooksAndAuthors[j, 0].ToString()))
                        {
                            BioFicOrderQty++;
                            SalePerCateg3.Add(Form1.Price[2, j]);
                        }
                    }
                }

                //Display Sale per category Report using SalePerBookCategListView
                SalePerBookCategListView.Items[0].SubItems.Clear();
                SalePerBookCategListView.Items[1].SubItems.Clear();
                SalePerBookCategListView.Items[2].SubItems.Clear();
                SalePerBookCategListView.Items.Insert(0, "Quantity Sold");
                SalePerBookCategListView.Items[0].SubItems.Add(PnDOrderQty.ToString());
                SalePerBookCategListView.Items[0].SubItems.Add(SciFicOrderQty.ToString());
                SalePerBookCategListView.Items[0].SubItems.Add(BioFicOrderQty.ToString());
                SalePerBookCategListView.Items.Insert(1, "Sale (in euros.)");
                SalePerBookCategListView.Items[1].SubItems.Add(SalePerCateg1.Sum().ToString("C"));
                SalePerBookCategListView.Items[1].SubItems.Add(SalePerCateg2.Sum().ToString("C"));
                SalePerBookCategListView.Items[1].SubItems.Add(SalePerCateg3.Sum().ToString("C"));
                SalePerBookCategListView.Items.Insert(2, "Average Sale (in euros.)");

                //Handles exception of divide by zero
                if (PnDOrderQty > 0)
                    AvgSale1 = SalePerCateg1.Sum() / PnDOrderQty;
                else
                    AvgSale1 = 0;
                if (SciFicOrderQty > 0)
                    AvgSale2 = SalePerCateg2.Sum() / SciFicOrderQty;
                else
                    AvgSale2 = 0;
                if (BioFicOrderQty > 0)
                    AvgSale3 = SalePerCateg3.Sum() / BioFicOrderQty;
                else
                    AvgSale3 = 0;

                SalePerBookCategListView.Items[2].SubItems.Add(AvgSale1.ToString("C"));
                SalePerBookCategListView.Items[2].SubItems.Add(AvgSale2.ToString("C"));
                SalePerBookCategListView.Items[2].SubItems.Add(AvgSale3.ToString("C"));

                //Display Daily Sale Summary Report using SaleReportGroupBox
                if (!NumberofBooks.Count.Equals(0))
                {
                    //Total Books Sold for all books in a particular day (DSR Date)
                    TotalBooksSoldTextBox.Text = NumberofBooks.Sum().ToString();

                    if (!TotalSale.Count.Equals(0))
                    {
                        //Total Sale for all books in a particular day (DSR Date)
                        TotalSaleTextBox.Text = TotalSale.Sum().ToString("C");

                        //Average Sale for all books in a particular day (DSR Date)
                        AvgSale = TotalSale.Sum() / NumberofBooks.Sum();
                        AvgSaleTextBox.Text = AvgSale.ToString("C");

                        //Total Members added in a particular day (DSR Date)
                        TotalMembersAddedTextBox.Text = NumberofMembers.Sum().ToString();

                        //Writing Report to DailySalesReportFile
                        StreamWriter writer = File.AppendText(DAILYSALESREPORTTXTFILE);
                        writer.WriteLine("DSR DATE: " + DSRDate);
                        writer.WriteLine("REPORT GENERATION DATE: " + ReportingDateTextBox.Text);
                        writer.WriteLine("TOTAL BOOKS SOLD: " + NumberofBooks.Sum().ToString());
                        writer.WriteLine("TOTAL SALE: " + TotalSale.Sum().ToString("C"));
                        writer.WriteLine("AVG SALE: " + AvgSale.ToString("C"));
                        writer.WriteLine("TOTAL MEMBERS ADDED: " + NumberofMembers.Sum().ToString());
                        writer.WriteLine("SALE PER BOOK CATEGORY: ");
                        writer.WriteLine("Poetry and Drama - Qty Sold: " + PnDOrderQty.ToString() + ", Sale: " + SalePerCateg1.Sum().ToString("C") + ", Average Sale: " + AvgSale1.ToString("C"));
                        writer.WriteLine("Science Fiction - Qty Sold: " + SciFicOrderQty.ToString() + ", Sale: " + SalePerCateg2.Sum().ToString("C") + ", Average Sale: " + AvgSale2.ToString("C"));
                        writer.WriteLine("Biographical Fiction - Qty Sold: " + BioFicOrderQty.ToString() + ", Sale: " + SalePerCateg3.Sum().ToString("C") + ", Average Sale: " + AvgSale3.ToString("C"));
                        writer.WriteLine("------------------------------------------------------------------------------------------------------------------");
                        writer.Close();

                    }
                    else
                    {
                        //Exception Handling if Sale Not Found
                        MessageBox.Show("Sale not available for mentioned date. \n Please retry with another date.", "No Sale Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DSRDateTextBox.Focus();
                        DSRDateTextBox.SelectAll();
                        ClearButton_Click(sender, e);
                        return;
                    }
                }
                else
                {
                    //Exception Handling if Sale Not Found
                    MessageBox.Show("Sale not available for mentioned date. \n Please retry with another date.", "No Sale Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DSRDateTextBox.Focus();
                    DSRDateTextBox.SelectAll();
                    ClearButton_Click(sender, e);
                    return;
                }

                //Resetting all fields
                NumberofBooks.Clear();
                TotalSale.Clear();
                NumberofMembers.Clear();
                BookNames.Clear();
                PnDOrderQty = 0;
                SciFicOrderQty = 0;
                BioFicOrderQty = 0;
                SalePerCateg1.Clear();
                SalePerCateg2.Clear();
                SalePerCateg3.Clear();
                AvgSale1 = 0;
                AvgSale2 = 0;
                AvgSale3 = 0;
                SaleReportGroupBox.Visible = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Resetting all the necessary fields to initial state
            DSRDateTextBox.Text = "";
            SaleReportGroupBox.Visible = false;
            ReportingDateTextBox.Text = "";
            TotalBooksSoldTextBox.Text = "";
            TotalSaleTextBox.Text = "";
            AvgSaleTextBox.Text = "";
            TotalMembersAddedTextBox.Text = "";
            SalePerBookCategListView.Items[0].SubItems.Clear();
            SalePerBookCategListView.Items[1].SubItems.Clear();
            SalePerBookCategListView.Items[2].SubItems.Clear();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DailySalesReportDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DSRPerBookGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SalePerBookCategListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
