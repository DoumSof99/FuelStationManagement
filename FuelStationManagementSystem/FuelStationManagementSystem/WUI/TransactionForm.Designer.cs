
namespace FuelStationManagementSystem.WUI
{
    partial class TransactionForm
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
            this.gridCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctrlItemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ctrlQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlTotalValue = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlDiscount = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlTotalCost = new DevExpress.XtraEditors.TextEdit();
            this.btnDeleteTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.txt12 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCardNumber = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalCost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomers
            // 
            this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridCustomers.Location = new System.Drawing.Point(13, 171);
            this.gridCustomers.MainView = this.gridViewCustomers;
            this.gridCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(553, 238);
            this.gridCustomers.TabIndex = 35;
            this.gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colCardNumber});
            this.gridViewCustomers.DetailHeight = 431;
            this.gridViewCustomers.GridControl = this.gridCustomers;
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 27;
            this.colID.Name = "colID";
            this.colID.Width = 100;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 27;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 100;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.MinWidth = 27;
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            this.colSurname.Width = 100;
            // 
            // colCardNumber
            // 
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.MinWidth = 27;
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 2;
            this.colCardNumber.Width = 100;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(578, 68);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(278, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Manage Transactions";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(400, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(557, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "FUEL STATION MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 791);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1361, 18);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 123);
            this.panel1.TabIndex = 33;
            // 
            // gridItems
            // 
            this.gridItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridItems.Location = new System.Drawing.Point(13, 488);
            this.gridItems.MainView = this.gridViewItems;
            this.gridItems.Margin = new System.Windows.Forms.Padding(4);
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(724, 297);
            this.gridItems.TabIndex = 59;
            this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
            // 
            // gridViewItems
            // 
            this.gridViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice,
            this.colCost});
            this.gridViewItems.DetailHeight = 431;
            this.gridViewItems.GridControl = this.gridItems;
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 100;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 27;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 27;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 100;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.MinWidth = 27;
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            this.colItemType.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 27;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 100;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.MinWidth = 27;
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 4;
            this.colCost.Width = 100;
            // 
            // ctrlItemType
            // 
            this.ctrlItemType.Location = new System.Drawing.Point(309, 417);
            this.ctrlItemType.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlItemType.Name = "ctrlItemType";
            this.ctrlItemType.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlItemType.Properties.Appearance.Options.UseFont = true;
            this.ctrlItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlItemType.Properties.Items.AddRange(new object[] {
            "Fuel",
            "Products",
            "Services"});
            this.ctrlItemType.Size = new System.Drawing.Size(280, 28);
            this.ctrlItemType.TabIndex = 61;
            this.ctrlItemType.SelectedValueChanged += new System.EventHandler(this.ctrlItemType_SelectedValueChanged);
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Location = new System.Drawing.Point(400, 453);
            this.ctrlQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(84, 22);
            this.ctrlQuantity.TabIndex = 62;
            this.ctrlQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(309, 450);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 22);
            this.labelControl4.TabIndex = 63;
            this.labelControl4.Text = "Quantity";
            // 
            // gridTransactionLines
            // 
            this.gridTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransactionLines.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridTransactionLines.Location = new System.Drawing.Point(598, 171);
            this.gridTransactionLines.MainView = this.gridViewTransactionLines;
            this.gridTransactionLines.Margin = new System.Windows.Forms.Padding(4);
            this.gridTransactionLines.Name = "gridTransactionLines";
            this.gridTransactionLines.Size = new System.Drawing.Size(746, 232);
            this.gridTransactionLines.TabIndex = 64;
            this.gridTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLines});
            // 
            // gridViewTransactionLines
            // 
            this.gridViewTransactionLines.DetailHeight = 431;
            this.gridViewTransactionLines.GridControl = this.gridTransactionLines;
            this.gridViewTransactionLines.Name = "gridViewTransactionLines";
            this.gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteItem.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeleteItem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Appearance.Options.UseBackColor = true;
            this.btnDeleteItem.Appearance.Options.UseBorderColor = true;
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.Appearance.Options.UseForeColor = true;
            this.btnDeleteItem.Location = new System.Drawing.Point(598, 452);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(106, 28);
            this.btnDeleteItem.TabIndex = 66;
            this.btnDeleteItem.Text = "Delete Item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnAddItem.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddItem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Appearance.Options.UseBackColor = true;
            this.btnAddItem.Appearance.Options.UseBorderColor = true;
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.Appearance.Options.UseForeColor = true;
            this.btnAddItem.Location = new System.Drawing.Point(492, 452);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(98, 28);
            this.btnAddItem.TabIndex = 65;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(1045, 505);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 21);
            this.labelControl6.TabIndex = 75;
            this.labelControl6.Text = "Total Value:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(843, 594);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(121, 21);
            this.labelControl5.TabIndex = 74;
            this.labelControl5.Text = "Discount Value:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(843, 505);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 21);
            this.labelControl7.TabIndex = 73;
            this.labelControl7.Text = "Customer ID:";
            // 
            // separatorControl3
            // 
            this.separatorControl3.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl3.LineThickness = 5;
            this.separatorControl3.Location = new System.Drawing.Point(1045, 561);
            this.separatorControl3.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Size = new System.Drawing.Size(189, 5);
            this.separatorControl3.TabIndex = 72;
            // 
            // ctrlTotalValue
            // 
            this.ctrlTotalValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalValue.EditValue = "";
            this.ctrlTotalValue.Location = new System.Drawing.Point(1045, 532);
            this.ctrlTotalValue.Name = "ctrlTotalValue";
            this.ctrlTotalValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotalValue.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotalValue.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlTotalValue.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotalValue.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotalValue.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotalValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotalValue.Size = new System.Drawing.Size(189, 26);
            this.ctrlTotalValue.TabIndex = 71;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl2.LineThickness = 5;
            this.separatorControl2.Location = new System.Drawing.Point(843, 652);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Size = new System.Drawing.Size(189, 5);
            this.separatorControl2.TabIndex = 70;
            // 
            // ctrlDiscount
            // 
            this.ctrlDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlDiscount.EditValue = "";
            this.ctrlDiscount.Location = new System.Drawing.Point(843, 621);
            this.ctrlDiscount.Name = "ctrlDiscount";
            this.ctrlDiscount.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlDiscount.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDiscount.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlDiscount.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlDiscount.Properties.Appearance.Options.UseFont = true;
            this.ctrlDiscount.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlDiscount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlDiscount.Size = new System.Drawing.Size(189, 26);
            this.ctrlDiscount.TabIndex = 69;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl1.LineThickness = 5;
            this.separatorControl1.Location = new System.Drawing.Point(843, 561);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(189, 5);
            this.separatorControl1.TabIndex = 68;
            // 
            // ctrlCustomerID
            // 
            this.ctrlCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlCustomerID.EditValue = "";
            this.ctrlCustomerID.Location = new System.Drawing.Point(843, 532);
            this.ctrlCustomerID.Name = "ctrlCustomerID";
            this.ctrlCustomerID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseFont = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlCustomerID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlCustomerID.Size = new System.Drawing.Size(189, 26);
            this.ctrlCustomerID.TabIndex = 67;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(1045, 596);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(83, 21);
            this.labelControl8.TabIndex = 78;
            this.labelControl8.Text = "Total Cost:";
            // 
            // separatorControl4
            // 
            this.separatorControl4.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl4.LineThickness = 5;
            this.separatorControl4.Location = new System.Drawing.Point(1045, 652);
            this.separatorControl4.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl4.Size = new System.Drawing.Size(189, 5);
            this.separatorControl4.TabIndex = 77;
            // 
            // ctrlTotalCost
            // 
            this.ctrlTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalCost.EditValue = "";
            this.ctrlTotalCost.Location = new System.Drawing.Point(1045, 623);
            this.ctrlTotalCost.Name = "ctrlTotalCost";
            this.ctrlTotalCost.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotalCost.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotalCost.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotalCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotalCost.Size = new System.Drawing.Size(189, 26);
            this.ctrlTotalCost.TabIndex = 76;
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteTransaction.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDeleteTransaction.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTransaction.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTransaction.Appearance.Options.UseBackColor = true;
            this.btnDeleteTransaction.Appearance.Options.UseBorderColor = true;
            this.btnDeleteTransaction.Appearance.Options.UseFont = true;
            this.btnDeleteTransaction.Appearance.Options.UseForeColor = true;
            this.btnDeleteTransaction.Location = new System.Drawing.Point(1045, 709);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(168, 33);
            this.btnDeleteTransaction.TabIndex = 80;
            this.btnDeleteTransaction.Text = "Delete Tansaction";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnAddTransaction.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddTransaction.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Appearance.Options.UseBackColor = true;
            this.btnAddTransaction.Appearance.Options.UseBorderColor = true;
            this.btnAddTransaction.Appearance.Options.UseFont = true;
            this.btnAddTransaction.Appearance.Options.UseForeColor = true;
            this.btnAddTransaction.Location = new System.Drawing.Point(871, 709);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(168, 33);
            this.btnAddTransaction.TabIndex = 79;
            this.btnAddTransaction.Text = "Add Transaction";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseBorderColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Location = new System.Drawing.Point(598, 417);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 28);
            this.btnRefresh.TabIndex = 81;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txt12
            // 
            this.txt12.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt12.Appearance.Options.UseFont = true;
            this.txt12.Appearance.Options.UseForeColor = true;
            this.txt12.Location = new System.Drawing.Point(234, 137);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(111, 21);
            this.txt12.TabIndex = 84;
            this.txt12.Text = "Card Number:";
            // 
            // ctrlCardNumber
            // 
            this.ctrlCardNumber.FormattingEnabled = true;
            this.ctrlCardNumber.Location = new System.Drawing.Point(352, 136);
            this.ctrlCardNumber.Name = "ctrlCardNumber";
            this.ctrlCardNumber.Size = new System.Drawing.Size(214, 24);
            this.ctrlCardNumber.TabIndex = 85;
            this.ctrlCardNumber.SelectionChangeCommitted += new System.EventHandler(this.ctrlCardNumber_SelectionChangeCommitted);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 130);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(203, 33);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "CUSTOMERS LIST";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(823, 130);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(252, 33);
            this.labelControl9.TabIndex = 86;
            this.labelControl9.Text = "TRANSACTION LINES";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(13, 447);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(118, 33);
            this.labelControl10.TabIndex = 87;
            this.labelControl10.Text = "ITEMS LIST";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(843, 448);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(246, 33);
            this.labelControl11.TabIndex = 88;
            this.labelControl11.Text = "ADD TRANSACTION";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 809);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.ctrlCardNumber);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.ctrlTotalCost);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.ctrlTotalValue);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.ctrlDiscount);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.ctrlCustomerID);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gridTransactionLines);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.ctrlItemType);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalCost.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraEditors.ComboBoxEdit ctrlItemType;
        private System.Windows.Forms.NumericUpDown ctrlQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLines;
        private DevExpress.XtraEditors.SimpleButton btnDeleteItem;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.TextEdit ctrlTotalValue;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.TextEdit ctrlDiscount;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.TextEdit ctrlTotalCost;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTransaction;
        private DevExpress.XtraEditors.SimpleButton btnAddTransaction;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl txt12;
        private System.Windows.Forms.ComboBox ctrlCardNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}