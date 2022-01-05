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
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BAP_Assignment4_v2
{
    public partial class Form1 : Form
    {
        
        //Declaration of 2D Arrays for Book Names and their respective authors. Created 3 seperate arrays for 3 book categories available in the store.
        public static string[,] PnDBooksAndAuthors { get; private set; } = { { "Milk and Honey", "Jenny Erlingsson" },
                                             {"Pam Ayres on Animals", "Pam Ayres"},
                                             {"Heroes", "Stephen Fry"},
                                             {"Osebol: Voices from a Swedish Village", "Marit Kapla"},
                                             {"To The Women: words to live by", "Donna Ashworth"},
                                             {"Home Body", "Rupi Kaur"},
                                             {"Troy", "Ms. Dominique Gillain" },
                                             {"Mythos", "Stephen Fry" },
                                             {"A Muslim Woman's Diary", "Sumaya Amiri" },
                                             {"Clarity & Connection", "Yung Pueblo" },
                                             {"The Poetry Pharmacy", "William Sieghart" },
                                             {"Ten Poems About Gardens", "Monty Don" },
                                             {"the sun will rise and so will we", "Jennae Cecelia" },
                                             {"My Unapologetic Diaries", "Joan Collins" },
                                             {"Dad Jokes", "Jimmy Niro" },
                                             {"Loose Head", "Joe Marler" },
                                             {"A Song for the Dark Times", "Ian Rankin" },
                                             {"Did I Say That Out Loud?", "Kristin van Ogtrop" },
                                             {"Snow Crash", "Neal Stephenson" },
                                             {"Tom Gates That's Me!", "L Pichon" } };

        public static string[,] SciFicBooksAndAuthors { get; private set; } = {  {"Starship Pandora", "Scott Aiello and Jamie Jackson" },
                                             {"Dune", "Frank Herbert"},
                                             {"Double Eagle", "Dan Abnett and Toby Longworth" },
                                             {"Autopsy", "Patricia Cornwell" },
                                             {"Star Wars", "Pablo Hidalgo" },
                                             {"Foundation", "Isaac Asimov and Scott Brick" },
                                             {"The Three-Body Problem","Cixin Liu and Luke Daniels" },
                                             {"Hold Up The Sky", "Cixin Liu and Brian Nishii" },
                                             {"Artemis", "Andy Weir and Rosario Dawson" },
                                             {"Children of Time", "Adrian Tchaikovsky and Mel Hudson" },
                                             {"Ready Player One", "Ernest Cline and Wil Wheaton" },
                                             {"Do Androids Dream Of Electric Sheep?", "Chris Roberson" },
                                             {"The Diamond Age", "Neal Stephenson" },
                                             {"Rabbits", "Patricia Williams" },
                                             {"Count Zero", "William Gibson" },
                                             {"Robot","Peter Brown" },
                                             {"Monsa Lisa Overdrive", "William Gibson" },
                                             {"Virtual Light", "William Gibson" },
                                             {"The Every", "Dave Eggers" },
                                             {"Ready Player Two", "Ernest Cline" }, };

        public static string[,] BioFicBooksAndAuthors { get; private set; } = {{"Hamnet", "Maggie O'Farrell" },
                                             {"Still Life", "Sarah Winman" },
                                             {"Three Sisters", "Heather Morris" },
                                             {"The Mirror and The Light", "Hilary Mantel" },
                                             {"Daisy Jones and The Six", "Taylor Jenkins Reid" },
                                             {"The Bell Jar", "Sylvia Plath" },
                                             {"The Young Team", "Graeme Armstrong" },
                                             {"Six Tudor Queens", "Alison Weir" },
                                             {"The Fortune Men", "Nadifa Mohamed"},
                                             {"The Magician", "Colm Tóibín" },
                                             {"The Night Watchman", "Dr. Taylor Jones" },
                                             {"School Days", "Robert B. Parker" },
                                             {"Treacle Walker", "Alan Garner" },
                                             {"Queenie", "Candice Carty-Williams" },
                                             {"The Remains of the day", "Kazuo Ishiguro" },
                                             {"True Crime Story", "Jack Rosewood" },
                                             {"The Windsor Knot", "Christopher Wilson" },
                                             {"A Beautiful Spy", "Rachel Hore" },
                                             {"Goodbye to Berlin", "Christopher Isherwood" },
                                             {"On Earth We're Briefly Gorgeous", "Ocean Vuong" }};

         //Declaration of 2D Array for Price of each book w.r.t category.
        public static decimal[,] Price = { { 8.98m, 22.95m, 9.65m, 13.41m, 9.4m, 10.99m, 8.27m, 9.69m, 17.29m, 13m, 11.53m, 5.85m, 5.25m, 11.83m, 3.55m, 8.72m, 7.44m, 10.63m, 7.53m, 20.86m },
                                             { 19.92m, 6.49m, 10.63m, 17.14m, 29.26m, 4.13m, 9.52m, 8.72m, 5.9m, 9.23m, 7.9m, 9.92m, 9.69m, 10.63m, 9.33m, 4.72m, 4.94m, 9.64m, 11.82m, 7.09m },
                                             { 5.9m, 9.45m, 8.5m, 5.9m, 4.72m, 1.17m, 5.9m, 16.9m, 13.78m, 11.82m, 9.45m, 7.09m, 8.27m, 8.72m, 7.44m, 7.09m, 1.17m, 5.31m, 5.9m, 5.9m }}; 

        //Declaration and initializarion of Stock 2D Array for each book.
        public static int[,] Stock { get; private set; } = { { 45, 100, 35, 45, 25, 45, 30, 35, 50, 40, 55, 30, 20, 50, 15, 20, 20, 50, 10, 100 } ,
                                           { 80, 20, 50, 70, 35, 15, 10, 10, 25, 10, 35, 30, 40, 50, 60, 50, 45, 45, 70, 60},
                                           { 50, 60, 70, 50, 45, 20, 50, 100, 80, 70, 65, 60, 75, 75, 60, 60, 20, 45, 50, 50}};

        /*
        Declarations of Below Lists are to hold following value:
        Total Members= Customers added as Members of Bibliophile Book Store.
        TotalMembershipDiscountApplied = Number of Membership Discount Applied.
        TotalPriceList = Total Price of Books in the Orders.
        OrderedBooks = Name of Books in the Orders.
        RemoveOrders = Name of Books to be removed from the Orders.
        TxnDetails = Customer and Transaction Details to be added to the Transactions.txt and Members.txt file.
        */

        public static List<int> TotalMembers = new List<int>();
        public static List<int> TotalMembershipDiscountApplied = new List<int>();
        List<decimal> TotalPriceList = new List<decimal>();
        List<string> OrderedBooks = new List<string>();
        List<string> RemoveOrders = new List<string>();
        List<string> TxnDetails = new List<string>();
        decimal TotalPrice;
        int TotalBooks, SubItemIndex1 = 0;
        string TransactionID;
        bool PnDMenuButtonClick=false, SciFicMenuButtonClick=false, BioFicMenuButtonClick=false;

        //Storing Text File Paths into constants strings
        const string TXNTXTFILE = @"C:\Users\Het_96\source\repos\BAP-Assignment4_v2\bin\Debug\Transactions.txt";
        const string MEMBERSTXTFILE = @"C:\Users\Het_96\source\repos\BAP-Assignment4_v2\bin\Debug\Members.txt";
        const string STOCKDATATXTFILE = @"C:\Users\Het_96\source\repos\BAP-Assignment4_v2\bin\Debug\StockData.txt";

        //Declaration of necessary Constants 
        const int TRANSLENGTH=9, EMPTY=0;

        public static string ButtonControl { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Declaration of Lists to store Stock.txt File Data
                List<string> StockFileData = new List<string>();
                List<int> StockData = new List<int>();
                StockFileData.Clear();
                StockData.Clear();

                //Reading Data from Stock.txt File
                StockFileData.AddRange( File.ReadAllLines(STOCKDATATXTFILE));

                //Below conditional and loop statements will fetch the data from the Stock.txt file List and will add it into the Stock 2D Array.
                if(StockFileData.Count > 0)
                {
                    for(int i = 1; i<StockFileData.Count; i=i+2)
                    { 
                        StockData.Add(int.Parse(StockFileData[i]));
                    }
                    
                    if (StockData.Count > 0)
                    {
                        for(int k = 0; k<60; )
                        {
                            if (k < 20)
                            {
                                int i = 0;
                                for (int j = 0; j < 20; j++)
                                {
                                    Stock[i, j] = StockData[k];
                                    k++;
                                }
                            }
                            else if (k >= 20 && k < 40)
                            {
                                int i = 1;
                                for (int j = 0; j < 20; j++)
                                {
                                    Stock[i, j] = StockData[k];
                                    k++;
                                }
                            }
                            else if (k >= 40 && k < 60)
                            {
                                int i = 2;
                                for (int j = 0; j < 20; j++)
                                {
                                    Stock[i, j] = StockData[k];
                                    k++;
                                }
                            }
                            else
                            {
                                //Exception if more than required details found.
                                MessageBox.Show("Unwanted Lines Found in Stock File. Please Remove unwanted Data from StockData.txt File or Contact your System Admin", "Additional Lines in Stock File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        }
                    
                    }
                    else
                    {
                        //Exception if data is unable to load. Reloading the Application will re-fetch the data from Stock.txt file into Stock 2D Array.
                        MessageBox.Show("Stock Data Loading in Application - Failed. \n Please Exit To Reload the Stock Data or Contact your System Admin", "No Stock Values Found in Stock File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    //Exception if data is not found, due to any data loss in Stock.txt file.
                    MessageBox.Show("No Data Found in Stock File\n\n Contact your Store Manager", "Empty Stock File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Initiliazing the Application
                PnDMenuButton_Click(sender, e);
                PnDMenuButtonClick = true;
                ItemsGroupBox.Visible = true;
                ButtonsGroupBox.Visible = true;
                ItemsandPriceGroupBox.Visible = true;

            }
            catch (Exception exception)
            {
                //Exception Handling in extenuating circumstances, for example, deletion of Stock.txt file.
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PnDMenuButton_Click(sender, e);
            }
        }

        private void ItemsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ItemsandPriceGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void OrdersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonsGroupBox_Enter(object sender, EventArgs e)
        {

        }
       
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Resetting all possible fields to either null or empty values.
            OrdersListView.Items.Clear();
            TotalBooksTextBox.Text = "";
            TotalPriceTextBox.Text = "";
            SubItemIndex1 = 0;
            FullNameTextBox.Text = "";
            ContactTextBox.Text = "";
            EmailTextBox.Text = "";
            LocationTextBox.Text = "";
            CustomerDetailsGroupBox.Enabled = false;
            MemberShipDiscountLabel.Visible = false;
            OffersGroupBox.Enabled = false;
            TotalPriceList.Clear();
            
        }

       

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration of field variables to hold Customer Details, who are being added as member.
                string FullName, Contact, Email, Location;
                FullName = FullNameTextBox.Text;
                Contact = ContactTextBox.Text;
                Email = EmailTextBox.Text;
                Location = LocationTextBox.Text;

                //Condition to check if member already exists in the file. Email is the only unique field through which customer can be identified.
                //Note: Full Name, Contact and Location can contain duplicate values.
                if (!File.ReadAllText(MEMBERSTXTFILE).Contains(Email))
                {
                    if (CustomerDetailsGroupBox.Enabled == true)
                    {
                        if (FullNameTextBox.Text != "")
                        {
                            if (ContactTextBox.Text != "")
                            {
                                if (EmailTextBox.Text != "")
                                {
                                    if (EmailTextBox.Text.Contains("@") && EmailTextBox.Text.Contains("."))
                                    {
                                        if (LocationTextBox.Text != "")
                                        {
                                            //Customer added as member successfully, till this stage.
                                            MessageBox.Show("Following Customer is added as a Member: \n\n Customer Full Name: \t" + FullName + "\n Customer Contact Details: \t" + Contact + "\n Customer Email Details: \t" + Email + "\n Customer Location: \t" + Location
                                                , "Member Added succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            OffersGroupBox.Enabled = true;
                                            MemberShipDiscountLabel.Visible = true;

                                            //Reduction in Total Price - Membership Discount 10%
                                            TotalPrice = Math.Round(TotalPrice - (TotalPrice * 0.1m), 2);
                                            TotalPriceTextBox.Text = TotalPrice.ToString();

                                            TxnDetails.Add(DateTime.Now.ToShortDateString());
                                            TxnDetails.Add(FullName);
                                            TxnDetails.Add(Contact);
                                            TxnDetails.Add(Email);
                                            TxnDetails.Add(Location);
                                            
                                            //Fetching the Member Details and storing it in Members.txt file.
                                            //Useful for marketing and maintaining good customer relations - Good Business Strategy.
                                            StreamWriter writer = File.AppendText(MEMBERSTXTFILE);

                                            for(int i =0; i<TxnDetails.Count; i++)
                                            {
                                                writer.WriteLine(TxnDetails[i]);
                                            }
                                           
                                            writer.Close();
                                            TotalMembers.Add(1);

                                        }
                                        else
                                        {
                                            //Exception handled if location is empty.
                                            MessageBox.Show("Please Enter Location.", "Empty Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            LocationTextBox.Focus();
                                            LocationTextBox.SelectAll();
                                        }

                                    }
                                    else
                                    {
                                        //Exception handled if email is invalid. [Does not contain @ and .]
                                        MessageBox.Show("Please Enter Valid Email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        EmailTextBox.Focus();
                                        EmailTextBox.SelectAll();
                                    }

                                }
                                else
                                {
                                    //Exception handled if email is empty.
                                    MessageBox.Show("Please Enter Email.", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    EmailTextBox.Focus();
                                    EmailTextBox.SelectAll();
                                }
                            }
                            else
                            {
                                //Exception handled if Contact is empty.
                                MessageBox.Show("Please Enter Contact.", "Empty Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ContactTextBox.Focus();
                                ContactTextBox.SelectAll();
                            }
                        }
                        else
                        {
                            //Exception handled if full name is empty.
                            MessageBox.Show("Please Enter Full Name.", "Empty Full Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            FullNameTextBox.Focus();
                            FullNameTextBox.SelectAll();
                        }

                    }
                    else
                    {
                        //Exception handled if orders list is empty. - Business only adds customers if they buy atleast one book.
                        MessageBox.Show("Please add book in orders before adding customer as a member", "Orders required along with membership!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MenuListView.Focus();
                    }
                }
                else
                {
                    //Exception handled if member already added to Members.txt file.
                    MessageBox.Show("Member Already Exists in Directory \n Please try adding new customer email.", "Unable to Add Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailTextBox.Focus();
                    EmailTextBox.SelectAll();
                }

            }
            catch (Exception exception)
            {
                //Exception Handling in extenuating circumstances, for example, deletion of Members.txt file.
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TotalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalBooksTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaration of field variables to hold Customer Details, who are placing orders for books.
                string FullName, Contact, Email, Location;
                const string BOUNDARY = "------------------------------------------------------------------------------------------------------------------";
                bool TxnIDUnique = false;
                FullName = FullNameTextBox.Text;
                Contact = ContactTextBox.Text;
                Email = EmailTextBox.Text;
                Location = LocationTextBox.Text;

                //Condition to check if book is being added to the order.
                //Conditions to check if all customer detail fields are entered with non-null and valid values.
                if (OrdersListView.Items.Count > 0)
                {
                    if (FullNameTextBox.Text != "")
                    {
                        if (ContactTextBox.Text != "")
                        {
                            if (EmailTextBox.Text != "")
                            {
                                if (EmailTextBox.Text.Contains("@") && EmailTextBox.Text.Contains("."))
                                {
                                    if (LocationTextBox.Text != "")
                                    {

                                        //Below do while statement will call IsUnique() method, which will further call GenerateRandomTxnID() method to return unique random number(TransactionId) and bool value(TxnIDUnique).
                                        //Note: The loop will continue until bool value (TxnIDUnique) is true.
                                        do
                                        {
                                            TxnIDUnique = IsUnique(GenerateRandomTxnID(), TXNTXTFILE);
                                        }
                                        while (!TxnIDUnique);

                                        //Transaction Date is generated (Current Date).
                                        var TransactionDate = DateTime.Now.ToShortDateString();                     

                                        //Below lines of code will pop up required confirmation for payment of order.
                                        //If user clicks Yes, Order is committed successfully and The Transaction Details are added to the TxnDetails List, which will further be used to write data into Transactions.txt file.
                                        //If user clicks No, Payment Failed error is displayed.
                                        string ConfirmationMsg = "Transaction ID: \t\t" + TransactionID + "\n" + "Transaction Date: \t\t" + TransactionDate + "\n" + "No. of Books Ordered: \t" + TotalBooks + "\n" + "Total Price: \t\t" + TotalPrice.ToString("C");       
                                        
                                        var MsgYesNo = MessageBox.Show(ConfirmationMsg, "Payment Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                        if (MsgYesNo == DialogResult.Yes)
                                        {
                                            MessageBox.Show("Payment Succesful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            ClearButton_Click(sender, e);
                                            MenuListView.Focus();
                                            TxnDetails.Clear();
                                            TxnDetails.Add(TransactionID);
                                            TxnDetails.Add(DateTime.Now.ToShortDateString());
                                            TxnDetails.Add(FullName);
                                            TxnDetails.Add(Contact);
                                            TxnDetails.Add(Email);
                                            TxnDetails.Add(Location);
                                            TxnDetails.Add(TotalBooks.ToString());
                                            TxnDetails.Add(TotalPrice.ToString());

                                            //store value to text file

                                            StreamWriter writer = File.AppendText(TXNTXTFILE);

                                            for(int i = 0; i<TxnDetails.Count; i++)
                                            {
                                                writer.WriteLine(TxnDetails[i]);
                                                
                                            }
                                            for (int i = 0; i < OrderedBooks.Count; i++)
                                            {
                                                writer.WriteLine(OrderedBooks[i]);
                                            }
                                            
                                            TxnDetails.Clear();
                                            writer.WriteLine(BOUNDARY);
                                            writer.Close();

                                            //Write Stock Value.
                                            StreamWriter updatewriter = File.CreateText(STOCKDATATXTFILE);

                                            for (int i = 0; i < 20; i++)
                                            {
                                                updatewriter.WriteLine(PnDBooksAndAuthors[i, 0].ToString());
                                                updatewriter.WriteLine(Stock[0, i].ToString());
                                            }
                                            for (int i = 0; i < 20; i++)
                                            {
                                                updatewriter.WriteLine(SciFicBooksAndAuthors[i, 0].ToString());
                                                updatewriter.WriteLine(Stock[1, i].ToString());
                                            }
                                            for (int i = 0; i < 20; i++)
                                            {
                                                updatewriter.WriteLine(BioFicBooksAndAuthors[i, 0].ToString());
                                                updatewriter.WriteLine(Stock[2, i].ToString());
                                            }

                                            updatewriter.Close();
                                            OrderedBooks.Clear();

                                        }
                                        if (MsgYesNo == DialogResult.No)
                                        {
                                            MessageBox.Show("Payment Failed", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                    }
                                    else
                                    {
                                        //Exception handling for Empty Location.
                                        MessageBox.Show("Please Enter Location.", "Empty Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        LocationTextBox.Focus();
                                        LocationTextBox.SelectAll();
                                    }

                                }
                                else
                                {
                                    //Exception handling for Invalid Email.
                                    MessageBox.Show("Please Enter Valid Email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    EmailTextBox.Focus();
                                    EmailTextBox.SelectAll();
                                }

                            }
                            else
                            {
                                //Exception handling for Empty Email.
                                MessageBox.Show("Please Enter Email.", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                EmailTextBox.Focus();
                                EmailTextBox.SelectAll();
                            }
                        }
                        else
                        {
                            //Exception handling for Empty Contact.
                            MessageBox.Show("Please Enter Contact.", "Empty Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ContactTextBox.Focus();
                            ContactTextBox.SelectAll();
                        }
                    }
                    else
                    {
                        //Exception handling for Empty Full Name.
                        MessageBox.Show("Please Enter Full Name.", "Empty Full Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FullNameTextBox.Focus();
                        FullNameTextBox.SelectAll();
                    }

                }
               
                else
                {
                    //Exception handling for Empty Orders List.
                    MessageBox.Show("Place Order unsuccessful because orders list is empty. \n To proceed please add the book in the orders.", "Empty Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OrdersListView.Focus();
                }
            }
            catch (Exception exception)
            {
                //Exception Handling in extenuating circumstances, for example, deletion of Transactions.txt file.
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Below GenerateRandomTxnID() function is used, to generate random number(TxnID) using random.Next() function.
        private string GenerateRandomTxnID()
        {
            Random random = new Random();
            TransactionID = random.Next(10000000, 99999999).ToString();
            return TransactionID;
        }

        //Below IsUnique() function with two input parameters (TransactionID and TransactionsTextFile) is used, validate if function is unique.
        //Note: The Validation is done via reading data from Transactions.txt file and returning bool value. 
        private Boolean IsUnique(string TransactionID, string TransactionsTextFile)
        {
            try
            {
                StreamReader ReadFile = File.OpenText(TransactionsTextFile);
                while (!ReadFile.EndOfStream)
                {
                    if (TransactionID.Equals(ReadFile.ReadLine()))
                    {
                        ReadFile.Close();
                        return false;
                    }
                    for(int i =0; i< TRANSLENGTH - 1; i++)
                    {
                        ReadFile.ReadLine();
                    }
                }
                ReadFile.Close();
                return true;
            }
            catch (Exception exception)
            {
                //Exception Handling in extenuating circumstances, for example, deletion of Transactions.txt file.
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //IMPORTANT NOTE: There can be scenario when order is added in the orders list and user clicks exit, without place order. In this case, stock data file should not be updated.
            //Thus, the code for writing lines to the txt file is placed in the PlaceOrder, Confirmation Yes Button, instead of exit button.

            Application.Exit(); //Exits Application

        }

        private void CheckStockButton_Click(object sender, EventArgs e)
        {
            //The below lines of code will move the user to next form (Form2) when user clicks Check Stock button.
            //Note: There are multiple groupboxes being added in Form 2, thus, to make suitable groupbox visible, ButtonControl string variable is used.
            //If ButtonControl="CheckStockAction" then StockGroupBox is marked visible in Form2.
            Form2 f2 = new Form2();
            ButtonControl= "CheckStockAction";

            f2.Show();
            this.Hide();

        }

        public void SearchTxnButton_Click(object sender, EventArgs e)
        {
            //The below lines of code will move the user to next form (Form2) when user clicks Search Txn. button.
            //If ButtonControl="SearchAction" then SearchMainGroupBox is marked visible in Form2.
            Form2 f2 = new Form2();
            ButtonControl = "SearchAction";
            f2.Show();
            this.Hide();
        }

        private void ReportingButton_Click(object sender, EventArgs e)
        {
            //The below lines of code will move the user to next form (Form2) when user clicks Reporting button.
            //If ButtonControl="GenerateReport" then DSRPerBookGroupBox is marked visible in Form2.
            Form2 f2 = new Form2();
            ButtonControl = "GenerateReport";
            f2.Show();
            this.Hide();



        }

        private void MenuListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }



        private void PnDMenuButton_Click(object sender, EventArgs e)
        {
            //Below lines of code will add items from 2D Array(Book Names and Authors) for Poetry and Drama Category to the MenuListView.
            PnDMenuButtonClick = true;
            SciFicMenuButtonClick = false;
            BioFicMenuButtonClick = false;
            MenuListView.Visible = true;
            MenuListView.Items.Clear();
            for (int i = 0; i <= 19; i++)
            {
                MenuListView.Items.Add(PnDBooksAndAuthors[i, 0].ToString());
                MenuListView.Items[i].SubItems.Add(PnDBooksAndAuthors[i, 1].ToString());
                MenuListView.Items[i].SubItems.Add(Price[0, i].ToString("C")); 
            }

        }

        private void SciFicMenuButton_Click(object sender, EventArgs e)
        {
            //Below lines of code will add items from 2D Array(Book Names and Authors) for Science Fiction Category to the MenuListView.
            PnDMenuButtonClick = false;
            SciFicMenuButtonClick = true;
            BioFicMenuButtonClick = false;
            MenuListView.Visible = true;
            MenuListView.Items.Clear();
            for (int j = 0; j < 20; j++)
            {
                MenuListView.Items.Add(SciFicBooksAndAuthors[j, 0].ToString());
                MenuListView.Items[j].SubItems.Add(SciFicBooksAndAuthors[j, 1].ToString());
                MenuListView.Items[j].SubItems.Add(Price[1,j].ToString("C"));
            }

        }

        private void BioFicMenuButton_Click(object sender, EventArgs e)
        {
            //Below lines of code will add items from 2D Array(Book Names and Authors) for Bio Fiction Category to the MenuListView.
            PnDMenuButtonClick = false;
            SciFicMenuButtonClick = false;
            BioFicMenuButtonClick = true;
            MenuListView.Visible = true;
            MenuListView.Items.Clear();
            for (int j = 0; j < 20; j++)
            {
                MenuListView.Items.Add(BioFicBooksAndAuthors[j, 0].ToString());
                MenuListView.Items[j].SubItems.Add(BioFicBooksAndAuthors[j, 1].ToString());
                MenuListView.Items[j].SubItems.Add(Price[2,j].ToString("C"));
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MemberShipDiscountLabel_Click(object sender, EventArgs e)
        {

        }

        private void OffersGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckMembershipButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Email = EmailTextBox.Text;

                //Below Lines of Code will Check if Member already exists in the Members.txt file.
                //If Member exists, then it will ask user to confirm on applying membership discount - Yes: Discount of 10% off applied on Total Price of the Order OR No:Total Price remains as is.
                //If Member doesnt exists, user is being notified through warning msg that user is not a member and if customer is asking for discount than add the customer as member to apply membership discount.
                if(Email != "")
                {
                    if (EmailTextBox.Text.Contains("@") && EmailTextBox.Text.Contains("."))
                    {
                        if (File.ReadAllText(MEMBERSTXTFILE).Contains(Email))
                        {

                            var MsgYesNo = MessageBox.Show("Customer is a Member of Bibliophile Book Store. \n\n Please confirm if Membership Discount to be Applied.", "Confirmation required on applying Membership Discount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (MsgYesNo == DialogResult.Yes)
                            {
                                TotalPrice = TotalPriceList.Sum();
                                TotalPrice = Math.Round(TotalPrice - (TotalPrice * 0.1m), 2);
                                TotalPriceTextBox.Text = TotalPrice.ToString();
                                TotalMembershipDiscountApplied.Add(1);
                                OffersGroupBox.Enabled = true;
                                MemberShipDiscountLabel.Visible = true;
                                
                            }

                            else
                            {
                                OffersGroupBox.Enabled = false;
                                MemberShipDiscountLabel.Visible = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Sorry Customer is not a Member of Bibliophile Book Store. \n\n To Apply Membership Discount - Add Member", "Membership Discount NOT Applicable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TotalPrice = TotalPriceList.Sum();
                            TotalPriceTextBox.Text = TotalPrice.ToString();
                            OffersGroupBox.Enabled = false;
                            MemberShipDiscountLabel.Visible = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EmailTextBox.Focus();
                        EmailTextBox.SelectAll();
                    }

                }
                else
                {
                    //NOTE: Validation of members exists in file is done through unique value that is customer email.
                    MessageBox.Show("Please Enter Email.", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailTextBox.Focus();
                    EmailTextBox.SelectAll();
                }
            }
            catch (Exception exception)
            {
                //Exception Handling in extenuating circumstances, for example, deletion of Members.txt file.
                MessageBox.Show("The following process error has occured:" + "\n" + exception.Message + "\n\n Contact your System Administator", "System Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void AddToOrderButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Add To Order";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.AddToOrderButton, ToolTipMsg);

        }

        private void RemoveFromOrderButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Remove From Order";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.AddToOrderButton, ToolTipMsg);
        }

        private void ClearButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Reset Orders";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.ClearButton, ToolTipMsg);
        }

        private void CheckMembershipButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Check if customer is a member";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.CheckMembershipButton, ToolTipMsg);
        }

        private void AddMemberButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Add Customer as a member";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.AddMemberButton, ToolTipMsg);
        }

        private void PlaceOrderButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Place Order";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.PlaceOrderButton, ToolTipMsg);

        }

        private void CheckStockButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Check Current Stock";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.CheckStockButton, ToolTipMsg);

        }

        private void SearchTxnButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Search Transactions";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.SearchTxnButton, ToolTipMsg);

        }

        private void ReportingButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Generate Daily Sales Report";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.ReportingButton, ToolTipMsg);
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            //Tooltip 
            string ToolTipMsg = "Click here to Exit Application";
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.ExitButton, ToolTipMsg);
        }

        private void LocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrdersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            //Below lines of code will add the Book Name and Price as per the book is selected from MenuListView.
            //Note: It will only be added if book is being selected from ListView. Else, it will throw an error to the user to select book before adding to Orders.
            if (MenuListView.SelectedIndices.Count > 0)
            {

                //If book selected belongs to Poetry and Drama Category, then the respective Book Name and Price will be fetched from 2D arrays.
                if (PnDMenuButtonClick)
                {
                    foreach (var index in MenuListView.SelectedIndices)
                    {
                        int index1 = Convert.ToInt32(index);

                        //Once book is being added to the Orders, it will be deducted from the Stock 2D array - Poetry and Drama Book Category, until it reached 0.
                        //If stock value reached 0, then it will throw OUT OF STOCK error message. 
                        if (!Stock[0, index1].Equals(EMPTY))
                        {
                            OrderedBooks.Add(PnDBooksAndAuthors[index1, 0].ToString());
                            
                            
                            OrdersListView.Items.Add(PnDBooksAndAuthors[index1, 0].ToString());
                            OrdersListView.Items[SubItemIndex1].SubItems.Add(Price[0, index1].ToString("C"));
                            SubItemIndex1++;
                            MenuListView.SelectedIndices.Clear();
                            TotalBooks = OrdersListView.Items.Count;
                            TotalBooksTextBox.Text = TotalBooks.ToString();
                            TotalPriceList.Add(Price[0, index1]);
                            TotalPrice = TotalPriceList.Sum();
                            TotalPriceTextBox.Text = TotalPrice.ToString();

                            //Reduction in Stock - Poetry & Drama Books
                            Stock[0, index1] = Stock[0, index1] - 1;
                        }
                        else
                        {
                            MessageBox.Show("Selected Book is out of stock. \n Please Contact Store Manager.", "BOOK OUT OF STOCK.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MenuListView.Focus();
                            if (OrderedBooks.Count.Equals(EMPTY))
                            {
                                CustomerDetailsGroupBox.Enabled = false;
                                MemberShipDiscountLabel.Visible = false;
                                OffersGroupBox.Enabled = false;
                            }
                            
                        }

                    }

                }

                //If book selected belongs to Science Fiction Category, then the respective Book Name and Price will be fetched from 2D arrays.
                else if (SciFicMenuButtonClick)
                {
                    foreach (var index in MenuListView.SelectedIndices)
                    {
                        int index1 = Convert.ToInt32(index);

                        //Once book is being added to the Orders, it will be deducted from the Stock 2D array - Science Fiction Book Category, until it reached 0.
                        //If stock value reached 0, then it will throw OUT OF STOCK error message. 
                        if (!Stock[1, index1].Equals(EMPTY))
                        {
                            OrderedBooks.Add(PnDBooksAndAuthors[index1, 0].ToString());
                            
                            OrdersListView.Items.Add(SciFicBooksAndAuthors[index1, 0].ToString());
                            OrdersListView.Items[SubItemIndex1].SubItems.Add(Price[1, index1].ToString("C"));
                            SubItemIndex1++;
                            MenuListView.SelectedIndices.Clear();
                            TotalBooks = OrdersListView.Items.Count;
                            TotalBooksTextBox.Text = TotalBooks.ToString();
                            TotalPriceList.Add(Price[1, index1]);
                            TotalPrice = TotalPriceList.Sum();
                            TotalPriceTextBox.Text = TotalPrice.ToString();

                            //Reduction in Stock - SciFic Books
                            Stock[1, index1] = Stock[1, index1] - 1;
                        }
                        else
                        {
                            MessageBox.Show("Selected Book is out of stock. \n Please Contact Store Manager.", "BOOK OUT OF STOCK.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MenuListView.Focus();
                            if (OrderedBooks.Count.Equals(EMPTY))
                            {
                                CustomerDetailsGroupBox.Enabled = false;
                                MemberShipDiscountLabel.Visible = false;
                                OffersGroupBox.Enabled = false;
                            }

                        }
                    }
                    
                }
                else if (BioFicMenuButtonClick)
                {
                    foreach (var index in MenuListView.SelectedIndices)
                    {
                        int index1 = Convert.ToInt32(index);

                        //Once book is being added to the Orders, it will be deducted from the Stock 2D array - Bio Fiction Book Category, until it reached 0.
                        //If stock value reached 0, then it will throw OUT OF STOCK error message. 
                        if (!Stock[2, index1].Equals(EMPTY))
                        {
                            OrderedBooks.Add(BioFicBooksAndAuthors[index1, 0].ToString());
                            
                            OrdersListView.Items.Add(BioFicBooksAndAuthors[index1, 0].ToString());
                            OrdersListView.Items[SubItemIndex1].SubItems.Add(Price[2, index1].ToString("C"));
                            SubItemIndex1++;
                            MenuListView.SelectedIndices.Clear();
                            TotalBooks = OrdersListView.Items.Count;
                            TotalBooksTextBox.Text = TotalBooks.ToString();
                            TotalPriceList.Add(Price[2, index1]);
                            TotalPrice = TotalPriceList.Sum();
                            TotalPriceTextBox.Text = TotalPrice.ToString();

                            //Reduction in Stock - BioFiction Books
                            Stock[2, index1] = Stock[2, index1] - 1;


                        }
                        else
                        {
                            MessageBox.Show("Selected Book is out of stock.\n Please Contact Store Manager.", "BOOK OUT OF STOCK.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MenuListView.Focus();
                            if (OrderedBooks.Count.Equals(EMPTY))
                            {
                                CustomerDetailsGroupBox.Enabled = false;
                                MemberShipDiscountLabel.Visible = false;
                                OffersGroupBox.Enabled = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select any of the book categories before adding books to orders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MenuListView.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select the book from menu before adding it to the orders", "No Book Selected in Menu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MenuListView.Focus();
            }


            CustomerDetailsGroupBox.Enabled = true;
            
        }

        private void RemoveFromOrderButton_Click(object sender, EventArgs e)
        {
            const int EMPTY = 0;

            //Below lines of code will remove the Book Name and Price as per the book is selected from OrdersListView.
            //Note: It will only be removed if book is being selected from ListView. Else, it will throw an error to the user to select book before removing from Orders.
            if (OrdersListView.Items.Count > 0)
            {
                if (OrdersListView.SelectedIndices.Count > 0)
                {
                    foreach (var index in OrdersListView.SelectedIndices)
                    {
                        int index1 = Convert.ToInt32(index);
                        string OrderSelectedBook = OrdersListView.SelectedItems[0].SubItems[0].Text.ToString();
                        
                        //Book removed from order using selected index of OrdersListView
                        OrdersListView.Items.RemoveAt(index1);
                        SubItemIndex1--;
                        OrdersListView.SelectedIndices.Clear();

                        //TotalBooks will hold count of books in each order
                        TotalBooks = OrdersListView.Items.Count;
                        TotalBooksTextBox.Text = TotalBooks.ToString();

                        //TotalPrice will hold sum of prices of all the books from the orders 
                        TotalPriceList.RemoveAt(index1);
                        TotalPrice = TotalPriceList.Sum();
                        TotalPriceTextBox.Text = TotalPrice.ToString();

                        //If TotalPrice and TotalBooks become 0, that means no more books exists in orders and system can reset all the fields.
                        if(TotalPrice == EMPTY && TotalBooks == EMPTY)
                        {
                            ClearButton_Click(sender, e);
                        }

                        //Once book is being removed from the Orders, it will be added to the Stock 2D array - As per Book Categories.
                        for (int i =0; i<20; i++)
                        {
                            if(OrderSelectedBook.Equals(PnDBooksAndAuthors[i, 0].ToString()))
                            {
                                //Addition in Stock - PnDFiction Books
                                Stock[0, i] = Stock[0, i] + 1;  
                            }
                            else if(OrderSelectedBook.Equals(SciFicBooksAndAuthors[i, 0].ToString()))
                            {
                                //Addition in Stock - SciFiction Books
                                Stock[1, i] = Stock[1, i] + 1;
                            }
                            else if (OrderSelectedBook.Equals(BioFicBooksAndAuthors[i, 0].ToString()))
                            {
                                //Reduction in Stock - BioFiction Books
                                Stock[2, i] = Stock[2, i] + 1;
                            }
                        } 
                    }
                }
                else
                {
                    MessageBox.Show("Please select the book from orders before removing.", "No Book Selected in Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OrdersListView.Focus();
                }
            }
            else
            {
                //Exception handling if orderslist contains null value.
                MessageBox.Show("Book cannot be removed because orders list is empty. \n To proceed please add the book in the orders.", "Empty Orders", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerDetailsGroupBox.Enabled = false;
                RemoveOrders.Clear();
            }
        }
    }
}
