
namespace FuelStationManagementSystem.WUI {
    partial class ViewTransactionLineForm {
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
            this.gridTransactionLine = new DevExpress.XtraGrid.GridControl();
            this.transactionLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStationManagementDataSet3 = new FuelStationManagementSystem.DataSets.FuelStationManagementDataSet3();
            this.gridViewTransactionLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.transactionLineTableAdapter = new FuelStationManagementSystem.DataSets.FuelStationManagementDataSet3TableAdapters.TransactionLineTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(820, 123);
            this.panel1.TabIndex = 36;
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
            this.labelControl2.Size = new System.Drawing.Size(291, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "View Transaction Lines";
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
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 15);
            this.panel2.TabIndex = 93;
            // 
            // gridTransactionLine
            // 
            this.gridTransactionLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTransactionLine.DataSource = this.transactionLineBindingSource;
            this.gridTransactionLine.Location = new System.Drawing.Point(12, 130);
            this.gridTransactionLine.MainView = this.gridViewTransactionLine;
            this.gridTransactionLine.Name = "gridTransactionLine";
            this.gridTransactionLine.Size = new System.Drawing.Size(796, 398);
            this.gridTransactionLine.TabIndex = 94;
            this.gridTransactionLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLine});
            // 
            // transactionLineBindingSource
            // 
            this.transactionLineBindingSource.DataMember = "TransactionLine";
            this.transactionLineBindingSource.DataSource = this.fuelStationManagementDataSet3;
            // 
            // fuelStationManagementDataSet3
            // 
            this.fuelStationManagementDataSet3.DataSetName = "FuelStationManagementDataSet3";
            this.fuelStationManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewTransactionLine
            // 
            this.gridViewTransactionLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTransactionID,
            this.colItemID,
            this.colQuantity,
            this.colItemPrice,
            this.colValue,
            this.colItemCost,
            this.colCost,
            this.colItemType});
            this.gridViewTransactionLine.GridControl = this.gridTransactionLine;
            this.gridViewTransactionLine.Name = "gridViewTransactionLine";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colTransactionID
            // 
            this.colTransactionID.FieldName = "TransactionID";
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.Visible = true;
            this.colTransactionID.VisibleIndex = 0;
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = true;
            this.colItemID.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colItemPrice
            // 
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 3;
            // 
            // colValue
            // 
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 4;
            // 
            // colItemCost
            // 
            this.colItemCost.FieldName = "ItemCost";
            this.colItemCost.Name = "colItemCost";
            this.colItemCost.Visible = true;
            this.colItemCost.VisibleIndex = 5;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 6;
            // 
            // colItemType
            // 
            this.colItemType.FieldName = "ItemType";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 7;
            // 
            // transactionLineTableAdapter
            // 
            this.transactionLineTableAdapter.ClearBeforeFill = true;
            // 
            // ViewTransactionLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 549);
            this.Controls.Add(this.gridTransactionLine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewTransactionLineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTransactionLineForm";
            this.Load += new System.EventHandler(this.ViewTransactionLineForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridTransactionLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLine;
        private DataSets.FuelStationManagementDataSet3 fuelStationManagementDataSet3;
        private System.Windows.Forms.BindingSource transactionLineBindingSource;
        private DataSets.FuelStationManagementDataSet3TableAdapters.TransactionLineTableAdapter transactionLineTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCost;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
    }
}