
namespace BAP_Assignment4_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.OffersGroupBox = new System.Windows.Forms.GroupBox();
            this.MemberShipDiscountLabel = new System.Windows.Forms.Label();
            this.CustomerDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckMembershipButton = new System.Windows.Forms.Button();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveFromOrderButton = new System.Windows.Forms.Button();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.OrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdersListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.TotalBooksTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ItemsandPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.MenuListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BioFicMenuButton = new System.Windows.Forms.Button();
            this.SciFicMenuButton = new System.Windows.Forms.Button();
            this.PnDMenuButton = new System.Windows.Forms.Button();
            this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.ReportingButton = new System.Windows.Forms.Button();
            this.SearchTxnButton = new System.Windows.Forms.Button();
            this.CheckStockButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ItemsGroupBox.SuspendLayout();
            this.OffersGroupBox.SuspendLayout();
            this.CustomerDetailsGroupBox.SuspendLayout();
            this.OrdersGroupBox.SuspendLayout();
            this.ItemsandPriceGroupBox.SuspendLayout();
            this.ButtonsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 535);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.OffersGroupBox);
            this.ItemsGroupBox.Controls.Add(this.CustomerDetailsGroupBox);
            this.ItemsGroupBox.Controls.Add(this.RemoveFromOrderButton);
            this.ItemsGroupBox.Controls.Add(this.AddToOrderButton);
            this.ItemsGroupBox.Controls.Add(this.OrdersGroupBox);
            this.ItemsGroupBox.Controls.Add(this.ItemsandPriceGroupBox);
            this.ItemsGroupBox.Location = new System.Drawing.Point(12, 0);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(1393, 529);
            this.ItemsGroupBox.TabIndex = 2;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Enter += new System.EventHandler(this.ItemsGroupBox_Enter);
            // 
            // OffersGroupBox
            // 
            this.OffersGroupBox.Controls.Add(this.MemberShipDiscountLabel);
            this.OffersGroupBox.Enabled = false;
            this.OffersGroupBox.Location = new System.Drawing.Point(1087, 407);
            this.OffersGroupBox.Name = "OffersGroupBox";
            this.OffersGroupBox.Size = new System.Drawing.Size(300, 97);
            this.OffersGroupBox.TabIndex = 12;
            this.OffersGroupBox.TabStop = false;
            this.OffersGroupBox.Text = "OFFERS";
            this.OffersGroupBox.Enter += new System.EventHandler(this.OffersGroupBox_Enter);
            // 
            // MemberShipDiscountLabel
            // 
            this.MemberShipDiscountLabel.AutoSize = true;
            this.MemberShipDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberShipDiscountLabel.ForeColor = System.Drawing.Color.Green;
            this.MemberShipDiscountLabel.Location = new System.Drawing.Point(6, 35);
            this.MemberShipDiscountLabel.Name = "MemberShipDiscountLabel";
            this.MemberShipDiscountLabel.Size = new System.Drawing.Size(231, 36);
            this.MemberShipDiscountLabel.TabIndex = 0;
            this.MemberShipDiscountLabel.Text = "FLAT 10% OFF\r\nMembership Discount Applied";
            this.MemberShipDiscountLabel.Visible = false;
            this.MemberShipDiscountLabel.Click += new System.EventHandler(this.MemberShipDiscountLabel_Click);
            // 
            // CustomerDetailsGroupBox
            // 
            this.CustomerDetailsGroupBox.Controls.Add(this.CheckMembershipButton);
            this.CustomerDetailsGroupBox.Controls.Add(this.LocationTextBox);
            this.CustomerDetailsGroupBox.Controls.Add(this.label12);
            this.CustomerDetailsGroupBox.Controls.Add(this.EmailTextBox);
            this.CustomerDetailsGroupBox.Controls.Add(this.ContactTextBox);
            this.CustomerDetailsGroupBox.Controls.Add(this.FullNameTextBox);
            this.CustomerDetailsGroupBox.Controls.Add(this.label6);
            this.CustomerDetailsGroupBox.Controls.Add(this.label5);
            this.CustomerDetailsGroupBox.Controls.Add(this.label4);
            this.CustomerDetailsGroupBox.Controls.Add(this.label3);
            this.CustomerDetailsGroupBox.Enabled = false;
            this.CustomerDetailsGroupBox.Location = new System.Drawing.Point(1087, 21);
            this.CustomerDetailsGroupBox.Name = "CustomerDetailsGroupBox";
            this.CustomerDetailsGroupBox.Size = new System.Drawing.Size(300, 380);
            this.CustomerDetailsGroupBox.TabIndex = 11;
            this.CustomerDetailsGroupBox.TabStop = false;
            this.CustomerDetailsGroupBox.Enter += new System.EventHandler(this.CustomerDetailsGroupBox_Enter);
            // 
            // CheckMembershipButton
            // 
            this.CheckMembershipButton.Location = new System.Drawing.Point(139, 318);
            this.CheckMembershipButton.Name = "CheckMembershipButton";
            this.CheckMembershipButton.Size = new System.Drawing.Size(140, 42);
            this.CheckMembershipButton.TabIndex = 31;
            this.CheckMembershipButton.Text = "CHECK MEMBERSHIP";
            this.CheckMembershipButton.UseVisualStyleBackColor = true;
            this.CheckMembershipButton.Click += new System.EventHandler(this.CheckMembershipButton_Click);
            this.CheckMembershipButton.MouseHover += new System.EventHandler(this.CheckMembershipButton_MouseHover);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(88, 239);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(191, 22);
            this.LocationTextBox.TabIndex = 30;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.LocationTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Location:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(88, 176);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(191, 22);
            this.EmailTextBox.TabIndex = 28;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(88, 117);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(191, 22);
            this.ContactTextBox.TabIndex = 27;
            this.ContactTextBox.TextChanged += new System.EventHandler(this.ContactTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(88, 63);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(191, 22);
            this.FullNameTextBox.TabIndex = 26;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Customer Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RemoveFromOrderButton
            // 
            this.RemoveFromOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromOrderButton.Location = new System.Drawing.Point(712, 232);
            this.RemoveFromOrderButton.Name = "RemoveFromOrderButton";
            this.RemoveFromOrderButton.Size = new System.Drawing.Size(51, 33);
            this.RemoveFromOrderButton.TabIndex = 10;
            this.RemoveFromOrderButton.Text = "<<";
            this.RemoveFromOrderButton.UseVisualStyleBackColor = true;
            this.RemoveFromOrderButton.Click += new System.EventHandler(this.RemoveFromOrderButton_Click);
            this.RemoveFromOrderButton.MouseHover += new System.EventHandler(this.RemoveFromOrderButton_MouseHover);
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToOrderButton.Location = new System.Drawing.Point(712, 181);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(51, 33);
            this.AddToOrderButton.TabIndex = 9;
            this.AddToOrderButton.Text = ">>";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            this.AddToOrderButton.MouseHover += new System.EventHandler(this.AddToOrderButton_MouseHover);
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Controls.Add(this.OrdersListView);
            this.OrdersGroupBox.Controls.Add(this.label9);
            this.OrdersGroupBox.Controls.Add(this.TotalBooksTextBox);
            this.OrdersGroupBox.Controls.Add(this.label8);
            this.OrdersGroupBox.Controls.Add(this.TotalPriceTextBox);
            this.OrdersGroupBox.Controls.Add(this.ClearButton);
            this.OrdersGroupBox.Controls.Add(this.label7);
            this.OrdersGroupBox.Location = new System.Drawing.Point(769, 21);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Size = new System.Drawing.Size(312, 483);
            this.OrdersGroupBox.TabIndex = 7;
            this.OrdersGroupBox.TabStop = false;
            this.OrdersGroupBox.Enter += new System.EventHandler(this.OrdersGroupBox_Enter);
            // 
            // OrdersListView
            // 
            this.OrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.OrdersListView.FullRowSelect = true;
            this.OrdersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrdersListView.HideSelection = false;
            this.OrdersListView.Location = new System.Drawing.Point(8, 42);
            this.OrdersListView.MultiSelect = false;
            this.OrdersListView.Name = "OrdersListView";
            this.OrdersListView.Size = new System.Drawing.Size(298, 299);
            this.OrdersListView.TabIndex = 22;
            this.OrdersListView.UseCompatibleStateImageBehavior = false;
            this.OrdersListView.View = System.Windows.Forms.View.Details;
            this.OrdersListView.SelectedIndexChanged += new System.EventHandler(this.OrdersListView_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Book Name";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Books";
            // 
            // TotalBooksTextBox
            // 
            this.TotalBooksTextBox.Enabled = false;
            this.TotalBooksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBooksTextBox.Location = new System.Drawing.Point(187, 347);
            this.TotalBooksTextBox.Name = "TotalBooksTextBox";
            this.TotalBooksTextBox.Size = new System.Drawing.Size(109, 24);
            this.TotalBooksTextBox.TabIndex = 7;
            this.TotalBooksTextBox.TextChanged += new System.EventHandler(this.TotalBooksTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Price (in euros.)";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Enabled = false;
            this.TotalPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceTextBox.Location = new System.Drawing.Point(187, 389);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(109, 24);
            this.TotalPriceTextBox.TabIndex = 5;
            this.TotalPriceTextBox.TextChanged += new System.EventHandler(this.TotalPriceTextBox_TextChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(228, 446);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(78, 31);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "CLEAR ORDER";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.MouseHover += new System.EventHandler(this.ClearButton_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Orders";
            // 
            // ItemsandPriceGroupBox
            // 
            this.ItemsandPriceGroupBox.Controls.Add(this.MenuListView);
            this.ItemsandPriceGroupBox.Controls.Add(this.BioFicMenuButton);
            this.ItemsandPriceGroupBox.Controls.Add(this.SciFicMenuButton);
            this.ItemsandPriceGroupBox.Controls.Add(this.PnDMenuButton);
            this.ItemsandPriceGroupBox.Location = new System.Drawing.Point(15, 12);
            this.ItemsandPriceGroupBox.Name = "ItemsandPriceGroupBox";
            this.ItemsandPriceGroupBox.Size = new System.Drawing.Size(691, 511);
            this.ItemsandPriceGroupBox.TabIndex = 6;
            this.ItemsandPriceGroupBox.TabStop = false;
            this.ItemsandPriceGroupBox.Enter += new System.EventHandler(this.ItemsandPriceGroupBox_Enter);
            // 
            // MenuListView
            // 
            this.MenuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.MenuListView.FullRowSelect = true;
            this.MenuListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MenuListView.HideSelection = false;
            this.MenuListView.Location = new System.Drawing.Point(15, 51);
            this.MenuListView.MultiSelect = false;
            this.MenuListView.Name = "MenuListView";
            this.MenuListView.Size = new System.Drawing.Size(661, 454);
            this.MenuListView.TabIndex = 8;
            this.MenuListView.UseCompatibleStateImageBehavior = false;
            this.MenuListView.View = System.Windows.Forms.View.Details;
            this.MenuListView.SelectedIndexChanged += new System.EventHandler(this.MenuListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
            // 
            // BioFicMenuButton
            // 
            this.BioFicMenuButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BioFicMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BioFicMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BioFicMenuButton.Location = new System.Drawing.Point(476, 11);
            this.BioFicMenuButton.Name = "BioFicMenuButton";
            this.BioFicMenuButton.Size = new System.Drawing.Size(209, 33);
            this.BioFicMenuButton.TabIndex = 21;
            this.BioFicMenuButton.Text = "BIOGRAPHICAL FIC.";
            this.BioFicMenuButton.UseVisualStyleBackColor = false;
            this.BioFicMenuButton.Click += new System.EventHandler(this.BioFicMenuButton_Click);
            // 
            // SciFicMenuButton
            // 
            this.SciFicMenuButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SciFicMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SciFicMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SciFicMenuButton.Location = new System.Drawing.Point(233, 12);
            this.SciFicMenuButton.Name = "SciFicMenuButton";
            this.SciFicMenuButton.Size = new System.Drawing.Size(213, 33);
            this.SciFicMenuButton.TabIndex = 20;
            this.SciFicMenuButton.Text = "SCIENCE FIC.";
            this.SciFicMenuButton.UseVisualStyleBackColor = false;
            this.SciFicMenuButton.Click += new System.EventHandler(this.SciFicMenuButton_Click);
            // 
            // PnDMenuButton
            // 
            this.PnDMenuButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PnDMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnDMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnDMenuButton.Location = new System.Drawing.Point(15, 12);
            this.PnDMenuButton.Name = "PnDMenuButton";
            this.PnDMenuButton.Size = new System.Drawing.Size(212, 33);
            this.PnDMenuButton.TabIndex = 19;
            this.PnDMenuButton.Text = "POETRY AND DRAMA";
            this.PnDMenuButton.UseVisualStyleBackColor = false;
            this.PnDMenuButton.Click += new System.EventHandler(this.PnDMenuButton_Click);
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.Controls.Add(this.ReportingButton);
            this.ButtonsGroupBox.Controls.Add(this.SearchTxnButton);
            this.ButtonsGroupBox.Controls.Add(this.CheckStockButton);
            this.ButtonsGroupBox.Controls.Add(this.ExitButton);
            this.ButtonsGroupBox.Controls.Add(this.AddMemberButton);
            this.ButtonsGroupBox.Controls.Add(this.PlaceOrderButton);
            this.ButtonsGroupBox.Location = new System.Drawing.Point(539, 545);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(574, 143);
            this.ButtonsGroupBox.TabIndex = 3;
            this.ButtonsGroupBox.TabStop = false;
            this.ButtonsGroupBox.Enter += new System.EventHandler(this.ButtonsGroupBox_Enter);
            // 
            // ReportingButton
            // 
            this.ReportingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportingButton.Location = new System.Drawing.Point(207, 79);
            this.ReportingButton.Name = "ReportingButton";
            this.ReportingButton.Size = new System.Drawing.Size(191, 43);
            this.ReportingButton.TabIndex = 5;
            this.ReportingButton.Text = "DAILY SALES REPORT";
            this.ReportingButton.UseVisualStyleBackColor = true;
            this.ReportingButton.Click += new System.EventHandler(this.ReportingButton_Click);
            this.ReportingButton.MouseHover += new System.EventHandler(this.ReportingButton_MouseHover);
            // 
            // SearchTxnButton
            // 
            this.SearchTxnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxnButton.Location = new System.Drawing.Point(17, 79);
            this.SearchTxnButton.Name = "SearchTxnButton";
            this.SearchTxnButton.Size = new System.Drawing.Size(168, 43);
            this.SearchTxnButton.TabIndex = 4;
            this.SearchTxnButton.Text = "SEARCH TXN.";
            this.SearchTxnButton.UseVisualStyleBackColor = true;
            this.SearchTxnButton.Click += new System.EventHandler(this.SearchTxnButton_Click);
            this.SearchTxnButton.MouseHover += new System.EventHandler(this.SearchTxnButton_MouseHover);
            // 
            // CheckStockButton
            // 
            this.CheckStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckStockButton.Location = new System.Drawing.Point(412, 21);
            this.CheckStockButton.Name = "CheckStockButton";
            this.CheckStockButton.Size = new System.Drawing.Size(142, 43);
            this.CheckStockButton.TabIndex = 3;
            this.CheckStockButton.Text = "CHECK STOCK";
            this.CheckStockButton.UseVisualStyleBackColor = true;
            this.CheckStockButton.Click += new System.EventHandler(this.CheckStockButton_Click);
            this.CheckStockButton.MouseHover += new System.EventHandler(this.CheckStockButton_MouseHover);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(412, 79);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(142, 43);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.Location = new System.Drawing.Point(17, 21);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(168, 43);
            this.AddMemberButton.TabIndex = 1;
            this.AddMemberButton.Text = "ADD MEMBER";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            this.AddMemberButton.MouseHover += new System.EventHandler(this.AddMemberButton_MouseHover);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.Location = new System.Drawing.Point(225, 21);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(157, 43);
            this.PlaceOrderButton.TabIndex = 0;
            this.PlaceOrderButton.Text = "PLACE ORDER";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            this.PlaceOrderButton.MouseHover += new System.EventHandler(this.PlaceOrderButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1417, 708);
            this.Controls.Add(this.ButtonsGroupBox);
            this.Controls.Add(this.ItemsGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to Bibliophile Book Store - Sale System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ItemsGroupBox.ResumeLayout(false);
            this.OffersGroupBox.ResumeLayout(false);
            this.OffersGroupBox.PerformLayout();
            this.CustomerDetailsGroupBox.ResumeLayout(false);
            this.CustomerDetailsGroupBox.PerformLayout();
            this.OrdersGroupBox.ResumeLayout(false);
            this.OrdersGroupBox.PerformLayout();
            this.ItemsandPriceGroupBox.ResumeLayout(false);
            this.ButtonsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.GroupBox ItemsandPriceGroupBox;
        private System.Windows.Forms.GroupBox OrdersGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalBooksTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CheckStockButton;
        private System.Windows.Forms.Button SearchTxnButton;
        private System.Windows.Forms.Button ReportingButton;
        private System.Windows.Forms.Button PnDMenuButton;
        private System.Windows.Forms.Button SciFicMenuButton;
        private System.Windows.Forms.Button BioFicMenuButton;
        private System.Windows.Forms.ListView MenuListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Button RemoveFromOrderButton;
        private System.Windows.Forms.ListView OrdersListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox CustomerDetailsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.GroupBox OffersGroupBox;
        private System.Windows.Forms.Label MemberShipDiscountLabel;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CheckMembershipButton;
    }
}

