
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLines)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomers
            // 
            this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomers.Location = new System.Drawing.Point(21, 141);
            this.gridCustomers.MainView = this.gridViewCustomers;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(456, 273);
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
            this.gridViewCustomers.GridControl = this.gridCustomers;
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            // 
            // colCardNumber
            // 
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(355, 57);
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
            this.labelControl1.Location = new System.Drawing.Point(221, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(557, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "FUEL STATION MANAGEMENT SYSTEM";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(139, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(203, 33);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "CUSTOMERS LIST";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 734);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 15);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 100);
            this.panel1.TabIndex = 33;
            // 
            // gridItems
            // 
            this.gridItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItems.Location = new System.Drawing.Point(507, 141);
            this.gridItems.MainView = this.gridViewItems;
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(475, 273);
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
            this.gridViewItems.GridControl = this.gridItems;
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 4;
            // 
            // ctrlItemType
            // 
            this.ctrlItemType.Location = new System.Drawing.Point(653, 106);
            this.ctrlItemType.Name = "ctrlItemType";
            this.ctrlItemType.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlItemType.Properties.Appearance.Options.UseFont = true;
            this.ctrlItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlItemType.Properties.Items.AddRange(new object[] {
            "Fuel",
            "Products",
            "Services"});
            this.ctrlItemType.Size = new System.Drawing.Size(187, 28);
            this.ctrlItemType.TabIndex = 61;
            this.ctrlItemType.SelectedValueChanged += new System.EventHandler(this.ctrlItemType_SelectedValueChanged);
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Location = new System.Drawing.Point(588, 420);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(63, 20);
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
            this.labelControl4.Location = new System.Drawing.Point(490, 418);
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
            this.gridTransactionLines.Location = new System.Drawing.Point(439, 446);
            this.gridTransactionLines.MainView = this.gridViewTransactionLines;
            this.gridTransactionLines.Name = "gridTransactionLines";
            this.gridTransactionLines.Size = new System.Drawing.Size(543, 264);
            this.gridTransactionLines.TabIndex = 64;
            this.gridTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLines});
            // 
            // gridViewTransactionLines
            // 
            this.gridViewTransactionLines.GridControl = this.gridTransactionLines;
            this.gridViewTransactionLines.Name = "gridViewTransactionLines";
            this.gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 749);
            this.Controls.Add(this.gridTransactionLines);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.ctrlItemType);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private DevExpress.XtraEditors.LabelControl labelControl3;
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
    }
}