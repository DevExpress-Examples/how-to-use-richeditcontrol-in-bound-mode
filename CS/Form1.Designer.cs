namespace RichEditDataBoundScenario {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new RichEditDataBoundScenario.DataSet1();
            this.carsTableAdapter = new RichEditDataBoundScenario.DataSet1TableAdapters.CarsTableAdapter();
            this.lblCurrentRecordInfo = new System.Windows.Forms.Label();
            this.btnRejectChanges = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcceptChanges = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richEditControl1.Location = new System.Drawing.Point(9, 37);
            this.richEditControl1.Margin = new System.Windows.Forms.Padding(2);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(892, 404);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.ModifiedChanged += new System.EventHandler(this.richEditControl1_ModifiedChanged);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.carsBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(12, 455);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(889, 24);
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.dataNavigator1_ButtonClick);
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // lblCurrentRecordInfo
            // 
            this.lblCurrentRecordInfo.AutoSize = true;
            this.lblCurrentRecordInfo.Location = new System.Drawing.Point(13, 13);
            this.lblCurrentRecordInfo.Name = "lblCurrentRecordInfo";
            this.lblCurrentRecordInfo.Size = new System.Drawing.Size(94, 13);
            this.lblCurrentRecordInfo.TabIndex = 2;
            this.lblCurrentRecordInfo.Text = "Current record info";
            // 
            // btnRejectChanges
            // 
            this.btnRejectChanges.Location = new System.Drawing.Point(298, 8);
            this.btnRejectChanges.Name = "btnRejectChanges";
            this.btnRejectChanges.Size = new System.Drawing.Size(106, 23);
            this.btnRejectChanges.TabIndex = 3;
            this.btnRejectChanges.Text = "Reject Changes";
            this.toolTip1.SetToolTip(this.btnRejectChanges, "Apply original content from the database to the current record");
            this.btnRejectChanges.Click += new System.EventHandler(this.btnRejectChanges_Click);
            // 
            // btnAcceptChanges
            // 
            this.btnAcceptChanges.Location = new System.Drawing.Point(186, 8);
            this.btnAcceptChanges.Name = "btnAcceptChanges";
            this.btnAcceptChanges.Size = new System.Drawing.Size(106, 23);
            this.btnAcceptChanges.TabIndex = 4;
            this.btnAcceptChanges.Text = "Accept Changes";
            this.toolTip1.SetToolTip(this.btnAcceptChanges, "Save all records to the database");
            this.btnAcceptChanges.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 499);
            this.Controls.Add(this.btnAcceptChanges);
            this.Controls.Add(this.btnRejectChanges);
            this.Controls.Add(this.lblCurrentRecordInfo);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.richEditControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DataSet1 dataSet11;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private RichEditDataBoundScenario.DataSet1TableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.Label lblCurrentRecordInfo;
        private DevExpress.XtraEditors.SimpleButton btnRejectChanges;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.SimpleButton btnAcceptChanges;
    }
}

