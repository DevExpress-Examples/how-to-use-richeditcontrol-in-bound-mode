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
            this.btnRejectChanges = new DevExpress.XtraEditors.SimpleButton();
            this.btnAcceptChanges = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Form1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.richEditControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnAcceptChangesitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRejectChangesitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataNavigator1item = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).BeginInit();
            this.Form1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptChangesitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRejectChangesitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNavigator1item)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richEditControl1.Location = new System.Drawing.Point(12, 88);
            this.richEditControl1.Margin = new System.Windows.Forms.Padding(4);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(1719, 821);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.ModifiedChanged += new System.EventHandler(this.richEditControl1_ModifiedChanged);
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.carsBindingSource;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(12, 913);
            this.dataNavigator1.Margin = new System.Windows.Forms.Padding(48, 48, 48, 48);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(273, 36);
            this.dataNavigator1.StyleController = this.Form1layoutControl1ConvertedLayout;
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
            // btnRejectChanges
            // 
            this.btnRejectChanges.Location = new System.Drawing.Point(999, 12);
            this.btnRejectChanges.Margin = new System.Windows.Forms.Padding(48, 48, 48, 48);
            this.btnRejectChanges.Name = "btnRejectChanges";
            this.btnRejectChanges.Size = new System.Drawing.Size(732, 44);
            this.btnRejectChanges.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.btnRejectChanges.TabIndex = 3;
            this.btnRejectChanges.Text = "Reject Changes";
            this.toolTip1.SetToolTip(this.btnRejectChanges, "Apply original content from the database to the current record");
            this.btnRejectChanges.Click += new System.EventHandler(this.btnRejectChanges_Click);
            // 
            // btnAcceptChanges
            // 
            this.btnAcceptChanges.Location = new System.Drawing.Point(12, 12);
            this.btnAcceptChanges.Margin = new System.Windows.Forms.Padding(48, 48, 48, 48);
            this.btnAcceptChanges.Name = "btnAcceptChanges";
            this.btnAcceptChanges.Size = new System.Drawing.Size(983, 44);
            this.btnAcceptChanges.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.btnAcceptChanges.TabIndex = 4;
            this.btnAcceptChanges.Text = "Accept Changes";
            this.toolTip1.SetToolTip(this.btnAcceptChanges, "Save all records to the database");
            this.btnAcceptChanges.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // Form1layoutControl1ConvertedLayout
            // 
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.richEditControl1);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.btnAcceptChanges);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.btnRejectChanges);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.dataNavigator1);
            this.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout";
            this.Form1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.Form1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(1743, 959);
            this.Form1layoutControl1ConvertedLayout.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.richEditControl1item,
            this.btnAcceptChangesitem,
            this.btnRejectChangesitem,
            this.dataNavigator1item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1743, 959);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // richEditControl1item
            // 
            this.richEditControl1item.Control = this.richEditControl1;
            this.richEditControl1item.Location = new System.Drawing.Point(0, 48);
            this.richEditControl1item.Name = "richEditControl1item";
            this.richEditControl1item.Size = new System.Drawing.Size(1723, 853);
            this.richEditControl1item.Text = "Current record info";
            this.richEditControl1item.TextLocation = DevExpress.Utils.Locations.Top;
            this.richEditControl1item.TextSize = new System.Drawing.Size(180, 25);
            // 
            // btnAcceptChangesitem
            // 
            this.btnAcceptChangesitem.Control = this.btnAcceptChanges;
            this.btnAcceptChangesitem.Location = new System.Drawing.Point(0, 0);
            this.btnAcceptChangesitem.Name = "btnAcceptChangesitem";
            this.btnAcceptChangesitem.Size = new System.Drawing.Size(987, 48);
            this.btnAcceptChangesitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnAcceptChangesitem.TextVisible = false;
            // 
            // btnRejectChangesitem
            // 
            this.btnRejectChangesitem.Control = this.btnRejectChanges;
            this.btnRejectChangesitem.Location = new System.Drawing.Point(987, 0);
            this.btnRejectChangesitem.Name = "btnRejectChangesitem";
            this.btnRejectChangesitem.Size = new System.Drawing.Size(736, 48);
            this.btnRejectChangesitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnRejectChangesitem.TextVisible = false;
            // 
            // dataNavigator1item
            // 
            this.dataNavigator1item.Control = this.dataNavigator1;
            this.dataNavigator1item.Location = new System.Drawing.Point(0, 901);
            this.dataNavigator1item.Name = "dataNavigator1item";
            this.dataNavigator1item.Size = new System.Drawing.Size(1723, 38);
            this.dataNavigator1item.TextSize = new System.Drawing.Size(0, 0);
            this.dataNavigator1item.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 959);
            this.Controls.Add(this.Form1layoutControl1ConvertedLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).EndInit();
            this.Form1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAcceptChangesitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRejectChangesitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNavigator1item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DataSet1 dataSet11;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private RichEditDataBoundScenario.DataSet1TableAdapters.CarsTableAdapter carsTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnRejectChanges;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.SimpleButton btnAcceptChanges;
        private DevExpress.XtraLayout.LayoutControl Form1layoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem richEditControl1item;
        private DevExpress.XtraLayout.LayoutControlItem btnAcceptChangesitem;
        private DevExpress.XtraLayout.LayoutControlItem btnRejectChangesitem;
        private DevExpress.XtraLayout.LayoutControlItem dataNavigator1item;
    }
}

