
namespace FuelStationManagementSystem.WUI {
    partial class LedgerForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.ctrlDateTo = new DevExpress.XtraEditors.DateEdit();
            this.fuelStationManagementDataSet41 = new FuelStationManagementSystem.FuelStationManagementDataSet4();
            this.transactionTableAdapter1 = new FuelStationManagementSystem.FuelStationManagementDataSet4TableAdapters.TransactionTableAdapter();
            this.fuelStationManagementDataSet42 = new FuelStationManagementSystem.FuelStationManagementDataSet4();
            this.transactionTableAdapter2 = new FuelStationManagementSystem.FuelStationManagementDataSet4TableAdapters.TransactionTableAdapter();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlIncome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlExpenses = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlTotal = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIncome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlExpenses.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotal.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(737, 100);
            this.panel1.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(272, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "View Ledger";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(96, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(557, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "FUEL STATION MANAGEMENT SYSTEM";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(33, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 21);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "Date From:";
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
            this.btnAdd.Location = new System.Drawing.Point(47, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 33);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "View";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 15);
            this.panel3.TabIndex = 43;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(33, 219);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 21);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Date To:";
            // 
            // ctrlDateFrom
            // 
            this.ctrlDateFrom.EditValue = null;
            this.ctrlDateFrom.Location = new System.Drawing.Point(33, 158);
            this.ctrlDateFrom.Name = "ctrlDateFrom";
            this.ctrlDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateFrom.Size = new System.Drawing.Size(135, 20);
            this.ctrlDateFrom.TabIndex = 44;
            // 
            // ctrlDateTo
            // 
            this.ctrlDateTo.EditValue = null;
            this.ctrlDateTo.Location = new System.Drawing.Point(33, 246);
            this.ctrlDateTo.Name = "ctrlDateTo";
            this.ctrlDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateTo.Size = new System.Drawing.Size(135, 20);
            this.ctrlDateTo.TabIndex = 45;
            // 
            // fuelStationManagementDataSet41
            // 
            this.fuelStationManagementDataSet41.DataSetName = "FuelStationManagementDataSet4";
            this.fuelStationManagementDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableAdapter1
            // 
            this.transactionTableAdapter1.ClearBeforeFill = true;
            // 
            // fuelStationManagementDataSet42
            // 
            this.fuelStationManagementDataSet42.DataSetName = "FuelStationManagementDataSet4";
            this.fuelStationManagementDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableAdapter2
            // 
            this.transactionTableAdapter2.ClearBeforeFill = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(232, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 21);
            this.labelControl7.TabIndex = 94;
            this.labelControl7.Text = "Income:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl1.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl1.LineThickness = 5;
            this.separatorControl1.Location = new System.Drawing.Point(349, 148);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(337, 5);
            this.separatorControl1.TabIndex = 93;
            // 
            // ctrlIncome
            // 
            this.ctrlIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlIncome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlIncome.EditValue = "";
            this.ctrlIncome.Enabled = false;
            this.ctrlIncome.Location = new System.Drawing.Point(349, 119);
            this.ctrlIncome.Name = "ctrlIncome";
            this.ctrlIncome.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlIncome.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlIncome.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlIncome.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlIncome.Properties.Appearance.Options.UseFont = true;
            this.ctrlIncome.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlIncome.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlIncome.Size = new System.Drawing.Size(337, 26);
            this.ctrlIncome.TabIndex = 92;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(232, 221);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 21);
            this.labelControl3.TabIndex = 97;
            this.labelControl3.Text = "Expenses:";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl2.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl2.LineThickness = 5;
            this.separatorControl2.Location = new System.Drawing.Point(349, 237);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Size = new System.Drawing.Size(337, 5);
            this.separatorControl2.TabIndex = 96;
            // 
            // ctrlExpenses
            // 
            this.ctrlExpenses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlExpenses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlExpenses.EditValue = "";
            this.ctrlExpenses.Enabled = false;
            this.ctrlExpenses.Location = new System.Drawing.Point(349, 208);
            this.ctrlExpenses.Name = "ctrlExpenses";
            this.ctrlExpenses.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlExpenses.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlExpenses.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlExpenses.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlExpenses.Properties.Appearance.Options.UseFont = true;
            this.ctrlExpenses.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlExpenses.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlExpenses.Size = new System.Drawing.Size(337, 26);
            this.ctrlExpenses.TabIndex = 95;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(232, 312);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 21);
            this.labelControl6.TabIndex = 100;
            this.labelControl6.Text = "Total Value:";
            // 
            // separatorControl3
            // 
            this.separatorControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl3.LineColor = System.Drawing.Color.DarkViolet;
            this.separatorControl3.LineThickness = 5;
            this.separatorControl3.Location = new System.Drawing.Point(349, 328);
            this.separatorControl3.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Size = new System.Drawing.Size(337, 5);
            this.separatorControl3.TabIndex = 99;
            // 
            // ctrlTotal
            // 
            this.ctrlTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctrlTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlTotal.EditValue = "";
            this.ctrlTotal.Enabled = false;
            this.ctrlTotal.Location = new System.Drawing.Point(349, 299);
            this.ctrlTotal.Name = "ctrlTotal";
            this.ctrlTotal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlTotal.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTotal.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlTotal.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlTotal.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotal.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlTotal.Size = new System.Drawing.Size(337, 26);
            this.ctrlTotal.TabIndex = 98;
            // 
            // LedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 438);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.ctrlTotal);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.ctrlExpenses);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.ctrlIncome);
            this.Controls.Add(this.ctrlDateTo);
            this.Controls.Add(this.ctrlDateFrom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnAdd);
            this.Name = "LedgerForm";
            this.Text = "LedgerForm";
            this.Load += new System.EventHandler(this.LedgerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelStationManagementDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlIncome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlExpenses.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit ctrlDateFrom;
        private DevExpress.XtraEditors.DateEdit ctrlDateTo;
        private FuelStationManagementDataSet4 fuelStationManagementDataSet41;
        private FuelStationManagementDataSet4TableAdapters.TransactionTableAdapter transactionTableAdapter1;
        private FuelStationManagementDataSet4 fuelStationManagementDataSet42;
        private FuelStationManagementDataSet4TableAdapters.TransactionTableAdapter transactionTableAdapter2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit ctrlIncome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.TextEdit ctrlExpenses;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.TextEdit ctrlTotal;
    }
}