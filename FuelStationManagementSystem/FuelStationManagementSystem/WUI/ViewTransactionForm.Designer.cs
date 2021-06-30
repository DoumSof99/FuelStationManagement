
namespace FuelStationManagementSystem.WUI {
    partial class ViewTransactionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridTransaction = new DevExpress.XtraGrid.GridControl();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStationManagementDataSet1 = new FuelStationManagementSystem.FuelStationManagementDataSet1();
            this.gridViewTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.transactionTableAdapter = new FuelStationManagementSystem.FuelStationManagementDataSet1TableAdapters.TransactionTableAdapter();
            this.btnShowTransactionLine = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(805, 123);
            this.panel1.TabIndex = 35;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(223, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(222, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "View Transaction";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(65, 13);
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
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 15);
            this.panel2.TabIndex = 92;
            // 
            // gridTransaction
            // 
            this.gridTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransaction.DataSource = this.transactionBindingSource;
            this.gridTransaction.Location = new System.Drawing.Point(12, 166);
            this.gridTransaction.MainView = this.gridViewTransaction;
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.Size = new System.Drawing.Size(781, 365);
            this.gridTransaction.TabIndex = 93;
            this.gridTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransaction});
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.fuelStationManagementDataSet1;
            // 
            // fuelStationManagementDataSet1
            // 
            this.fuelStationManagementDataSet1.DataSetName = "FuelStationManagementDataSet1";
            this.fuelStationManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewTransaction
            // 
            this.gridViewTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDate,
            this.colCustomerID,
            this.colDiscountValue,
            this.colTotalValue,
            this.colTotalCost});
            this.gridViewTransaction.GridControl = this.gridTransaction;
            this.gridViewTransaction.Name = "gridViewTransaction";
            this.gridViewTransaction.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTransaction_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colCustomerID
            // 
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 1;
            // 
            // colDiscountValue
            // 
            this.colDiscountValue.FieldName = "DiscountValue";
            this.colDiscountValue.Name = "colDiscountValue";
            this.colDiscountValue.Visible = true;
            this.colDiscountValue.VisibleIndex = 2;
            // 
            // colTotalValue
            // 
            this.colTotalValue.FieldName = "TotalValue";
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.Visible = true;
            this.colTotalValue.VisibleIndex = 3;
            // 
            // colTotalCost
            // 
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 4;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // btnShowTransactionLine
            // 
            this.btnShowTransactionLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowTransactionLine.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnShowTransactionLine.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnShowTransactionLine.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnShowTransactionLine.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnShowTransactionLine.Appearance.Options.UseBackColor = true;
            this.btnShowTransactionLine.Appearance.Options.UseBorderColor = true;
            this.btnShowTransactionLine.Appearance.Options.UseFont = true;
            this.btnShowTransactionLine.Appearance.Options.UseForeColor = true;
            this.btnShowTransactionLine.Location = new System.Drawing.Point(473, 135);
            this.btnShowTransactionLine.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowTransactionLine.Name = "btnShowTransactionLine";
            this.btnShowTransactionLine.Size = new System.Drawing.Size(176, 28);
            this.btnShowTransactionLine.TabIndex = 94;
            this.btnShowTransactionLine.Text = "Show Transaction Line";
            this.btnShowTransactionLine.Click += new System.EventHandler(this.btnShowTransactionLine_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 142);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 21);
            this.labelControl7.TabIndex = 97;
            this.labelControl7.Text = "Customer ID:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl1.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl1.LineThickness = 5;
            this.separatorControl1.Location = new System.Drawing.Point(129, 158);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(337, 5);
            this.separatorControl1.TabIndex = 96;
            // 
            // ctrlCustomerID
            // 
            this.ctrlCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlCustomerID.EditValue = "";
            this.ctrlCustomerID.Enabled = false;
            this.ctrlCustomerID.Location = new System.Drawing.Point(129, 129);
            this.ctrlCustomerID.Name = "ctrlCustomerID";
            this.ctrlCustomerID.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlCustomerID.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseFont = true;
            this.ctrlCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlCustomerID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlCustomerID.Size = new System.Drawing.Size(337, 26);
            this.ctrlCustomerID.TabIndex = 95;
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 552);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.ctrlCustomerID);
            this.Controls.Add(this.btnShowTransactionLine);
            this.Controls.Add(this.gridTransaction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTransactionForm";
            this.Load += new System.EventHandler(this.ViewTransactionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransaction;
        private FuelStationManagementDataSet1 fuelStationManagementDataSet1;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private FuelStationManagementDataSet1TableAdapters.TransactionTableAdapter transactionTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraEditors.SimpleButton btnShowTransactionLine;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit ctrlCustomerID;
    }
}