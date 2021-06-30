
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
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlTotalValue = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlDiscountValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlTotalCost = new DevExpress.XtraEditors.TextEdit();
            this.btnViewTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTransaction = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscountValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(-28, 604);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 18);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(-28, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 123);
            this.panel1.TabIndex = 33;
            // 
            // gridItems
            // 
            this.gridItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridItems.Location = new System.Drawing.Point(13, 293);
            this.gridItems.MainView = this.gridViewItems;
            this.gridItems.Margin = new System.Windows.Forms.Padding(4);
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(604, 178);
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
            this.ctrlItemType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlItemType.Location = new System.Drawing.Point(339, 257);
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
            this.ctrlItemType.Size = new System.Drawing.Size(158, 28);
            this.ctrlItemType.TabIndex = 61;
            this.ctrlItemType.SelectedValueChanged += new System.EventHandler(this.ctrlItemType_SelectedValueChanged);
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlQuantity.Location = new System.Drawing.Point(106, 258);
            this.ctrlQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(84, 27);
            this.ctrlQuantity.TabIndex = 62;
            this.ctrlQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 259);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 22);
            this.labelControl4.TabIndex = 63;
            this.labelControl4.Text = "Quantity";
            // 
            // gridTransactionLines
            // 
            this.gridTransactionLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridTransactionLines.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridTransactionLines.Location = new System.Drawing.Point(659, 242);
            this.gridTransactionLines.MainView = this.gridViewTransactionLines;
            this.gridTransactionLines.Margin = new System.Windows.Forms.Padding(4);
            this.gridTransactionLines.Name = "gridTransactionLines";
            this.gridTransactionLines.Size = new System.Drawing.Size(604, 229);
            this.gridTransactionLines.TabIndex = 64;
            this.gridTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLines});
            // 
            // gridViewTransactionLines
            // 
            this.gridViewTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TransactionID,
            this.ItemID,
            this.Quantity,
            this.ItemPrice,
            this.Value,
            this.ItemCost,
            this.Cost,
            this.ItemType});
            this.gridViewTransactionLines.DetailHeight = 431;
            this.gridViewTransactionLines.GridControl = this.gridTransactionLines;
            this.gridViewTransactionLines.Name = "gridViewTransactionLines";
            this.gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // TransactionID
            // 
            this.TransactionID.Caption = "TransactionID";
            this.TransactionID.FieldName = "TransactionID";
            this.TransactionID.Name = "TransactionID";
            // 
            // ItemID
            // 
            this.ItemID.Caption = "ItemID";
            this.ItemID.FieldName = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 0;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Caption = "ItemPrice";
            this.ItemPrice.FieldName = "ItemPrice";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Visible = true;
            this.ItemPrice.VisibleIndex = 1;
            // 
            // Value
            // 
            this.Value.Caption = "Value";
            this.Value.FieldName = "Value";
            this.Value.Name = "Value";
            this.Value.Visible = true;
            this.Value.VisibleIndex = 2;
            // 
            // ItemCost
            // 
            this.ItemCost.Caption = "ItemCost";
            this.ItemCost.FieldName = "ItemCost";
            this.ItemCost.Name = "ItemCost";
            this.ItemCost.Visible = true;
            this.ItemCost.VisibleIndex = 3;
            // 
            // Cost
            // 
            this.Cost.Caption = "Cost";
            this.Cost.FieldName = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 4;
            // 
            // ItemType
            // 
            this.ItemType.Caption = "ItemType";
            this.ItemType.FieldName = "ItemType";
            this.ItemType.Name = "ItemType";
            this.ItemType.Visible = true;
            this.ItemType.VisibleIndex = 5;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteItem.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteItem.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeleteItem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Appearance.Options.UseBackColor = true;
            this.btnDeleteItem.Appearance.Options.UseBorderColor = true;
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.Appearance.Options.UseForeColor = true;
            this.btnDeleteItem.Location = new System.Drawing.Point(664, 206);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(106, 28);
            this.btnDeleteItem.TabIndex = 66;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnAddItem.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddItem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Appearance.Options.UseBackColor = true;
            this.btnAddItem.Appearance.Options.UseBorderColor = true;
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.Appearance.Options.UseForeColor = true;
            this.btnAddItem.Location = new System.Drawing.Point(198, 257);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(98, 28);
            this.btnAddItem.TabIndex = 65;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(659, 497);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 21);
            this.labelControl6.TabIndex = 75;
            this.labelControl6.Text = "Total Value:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(871, 497);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(121, 21);
            this.labelControl5.TabIndex = 74;
            this.labelControl5.Text = "Discount Value:";
            // 
            // separatorControl3
            // 
            this.separatorControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl3.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl3.LineThickness = 5;
            this.separatorControl3.Location = new System.Drawing.Point(659, 553);
            this.separatorControl3.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Size = new System.Drawing.Size(189, 5);
            this.separatorControl3.TabIndex = 72;
            // 
            // ctrlTotalValue
            // 
            this.ctrlTotalValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotalValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalValue.EditValue = "";
            this.ctrlTotalValue.Location = new System.Drawing.Point(659, 524);
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
            this.separatorControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl2.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl2.LineThickness = 5;
            this.separatorControl2.Location = new System.Drawing.Point(871, 553);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Size = new System.Drawing.Size(189, 5);
            this.separatorControl2.TabIndex = 70;
            // 
            // ctrlDiscountValue
            // 
            this.ctrlDiscountValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlDiscountValue.EditValue = "";
            this.ctrlDiscountValue.Location = new System.Drawing.Point(871, 524);
            this.ctrlDiscountValue.Name = "ctrlDiscountValue";
            this.ctrlDiscountValue.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlDiscountValue.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDiscountValue.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseFont = true;
            this.ctrlDiscountValue.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlDiscountValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlDiscountValue.Size = new System.Drawing.Size(189, 26);
            this.ctrlDiscountValue.TabIndex = 69;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(1089, 497);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(83, 21);
            this.labelControl8.TabIndex = 78;
            this.labelControl8.Text = "Total Cost:";
            // 
            // separatorControl4
            // 
            this.separatorControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl4.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl4.LineThickness = 5;
            this.separatorControl4.Location = new System.Drawing.Point(1089, 553);
            this.separatorControl4.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl4.Size = new System.Drawing.Size(189, 5);
            this.separatorControl4.TabIndex = 77;
            // 
            // ctrlTotalCost
            // 
            this.ctrlTotalCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotalCost.EditValue = "";
            this.ctrlTotalCost.Location = new System.Drawing.Point(1089, 524);
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
            // btnViewTransaction
            // 
            this.btnViewTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewTransaction.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnViewTransaction.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnViewTransaction.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTransaction.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnViewTransaction.Appearance.Options.UseBackColor = true;
            this.btnViewTransaction.Appearance.Options.UseBorderColor = true;
            this.btnViewTransaction.Appearance.Options.UseFont = true;
            this.btnViewTransaction.Appearance.Options.UseForeColor = true;
            this.btnViewTransaction.Appearance.Options.UseTextOptions = true;
            this.btnViewTransaction.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnViewTransaction.Location = new System.Drawing.Point(1112, 149);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(115, 69);
            this.btnViewTransaction.TabIndex = 80;
            this.btnViewTransaction.Text = "View Tansactions";
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTransaction.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnAddTransaction.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddTransaction.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Appearance.Options.UseBackColor = true;
            this.btnAddTransaction.Appearance.Options.UseBorderColor = true;
            this.btnAddTransaction.Appearance.Options.UseFont = true;
            this.btnAddTransaction.Appearance.Options.UseForeColor = true;
            this.btnAddTransaction.Appearance.Options.UseTextOptions = true;
            this.btnAddTransaction.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnAddTransaction.Location = new System.Drawing.Point(960, 149);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(115, 69);
            this.btnAddTransaction.TabIndex = 79;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseBorderColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Location = new System.Drawing.Point(504, 257);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 28);
            this.btnRefresh.TabIndex = 81;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(664, 149);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(252, 33);
            this.labelControl9.TabIndex = 86;
            this.labelControl9.Text = "TRANSACTION LINES";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(13, 201);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(118, 33);
            this.labelControl10.TabIndex = 87;
            this.labelControl10.Text = "ITEMS LIST";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl1.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl1.LineThickness = 5;
            this.separatorControl1.Location = new System.Drawing.Point(147, 165);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(337, 5);
            this.separatorControl1.TabIndex = 90;
            // 
            // ctrlCustomerID
            // 
            this.ctrlCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlCustomerID.EditValue = "";
            this.ctrlCustomerID.Enabled = false;
            this.ctrlCustomerID.Location = new System.Drawing.Point(147, 136);
            this.ctrlCustomerID.Name = "ctrlCustomerID";
            this.ctrlCustomerID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseFont = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlCustomerID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlCustomerID.Size = new System.Drawing.Size(337, 26);
            this.ctrlCustomerID.TabIndex = 89;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(30, 149);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 21);
            this.labelControl7.TabIndex = 91;
            this.labelControl7.Text = "Customer ID:";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 622);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.ctrlCustomerID);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.ctrlTotalCost);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.ctrlTotalValue);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.ctrlDiscountValue);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gridTransactionLines);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.ctrlItemType);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscountValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.TextEdit ctrlTotalValue;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.TextEdit ctrlDiscountValue;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.TextEdit ctrlTotalCost;
        private DevExpress.XtraEditors.SimpleButton btnViewTransaction;
        private DevExpress.XtraEditors.SimpleButton btnAddTransaction;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn ItemID;
        private DevExpress.XtraGrid.Columns.GridColumn ItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraGrid.Columns.GridColumn ItemCost;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraGrid.Columns.GridColumn ItemType;
    }
}