
namespace FuelStationManagementSystem.WUI
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridCustomers = new DevExpress.XtraGrid.GridControl();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelStationManagementDataSet2 = new FuelStationManagementSystem.FuelStationManagementDataSet2();
            this.gridViewCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.customerTableAdapter = new FuelStationManagementSystem.FuelStationManagementDataSet2TableAdapters.CustomerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 100);
            this.panel1.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(306, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(258, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Manage Customers";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(172, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(557, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "FUEL STATION MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 15);
            this.panel2.TabIndex = 20;
            // 
            // ctrlName
            // 
            this.ctrlName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlName.EditValue = "";
            this.ctrlName.Location = new System.Drawing.Point(49, 183);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlName.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlName.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlName.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlName.Properties.Appearance.Options.UseFont = true;
            this.ctrlName.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlName.Size = new System.Drawing.Size(189, 26);
            this.ctrlName.TabIndex = 21;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl1.LineThickness = 5;
            this.separatorControl1.Location = new System.Drawing.Point(49, 212);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(189, 5);
            this.separatorControl1.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(47, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 33);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl2.LineThickness = 5;
            this.separatorControl2.Location = new System.Drawing.Point(49, 301);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Size = new System.Drawing.Size(189, 5);
            this.separatorControl2.TabIndex = 25;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlSurname.EditValue = "";
            this.ctrlSurname.Location = new System.Drawing.Point(49, 272);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlSurname.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSurname.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlSurname.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlSurname.Properties.Appearance.Options.UseFont = true;
            this.ctrlSurname.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlSurname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlSurname.Size = new System.Drawing.Size(189, 26);
            this.ctrlSurname.TabIndex = 24;
            // 
            // separatorControl3
            // 
            this.separatorControl3.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl3.LineThickness = 5;
            this.separatorControl3.Location = new System.Drawing.Point(47, 382);
            this.separatorControl3.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Size = new System.Drawing.Size(189, 5);
            this.separatorControl3.TabIndex = 27;
            // 
            // ctrlCardNumber
            // 
            this.ctrlCardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlCardNumber.EditValue = "";
            this.ctrlCardNumber.Location = new System.Drawing.Point(47, 353);
            this.ctrlCardNumber.Name = "ctrlCardNumber";
            this.ctrlCardNumber.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlCardNumber.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCardNumber.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlCardNumber.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlCardNumber.Properties.Appearance.Options.UseFont = true;
            this.ctrlCardNumber.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlCardNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlCardNumber.Size = new System.Drawing.Size(189, 26);
            this.ctrlCardNumber.TabIndex = 26;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnEdit.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseBorderColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseForeColor = true;
            this.btnEdit.Location = new System.Drawing.Point(141, 418);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 33);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.Location = new System.Drawing.Point(235, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 33);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridCustomers
            // 
            this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomers.DataSource = this.customerBindingSource;
            this.gridCustomers.Location = new System.Drawing.Point(379, 180);
            this.gridCustomers.MainView = this.gridViewCustomers;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(499, 452);
            this.gridCustomers.TabIndex = 31;
            this.gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomers});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.fuelStationManagementDataSet2;
            // 
            // fuelStationManagementDataSet2
            // 
            this.fuelStationManagementDataSet2.DataSetName = "FuelStationManagementDataSet2";
            this.fuelStationManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridViewCustomers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCustomers_FocusedRowChanged);
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
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(526, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(203, 33);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "CUSTOMERS LIST";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(49, 156);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 21);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Name:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(49, 245);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 21);
            this.labelControl5.TabIndex = 34;
            this.labelControl5.Text = "Surname:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 326);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(111, 21);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "Card Number:";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 668);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.ctrlCardNumber);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.TextEdit ctrlCardNumber;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomers;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private FuelStationManagementDataSet2 fuelStationManagementDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FuelStationManagementDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}