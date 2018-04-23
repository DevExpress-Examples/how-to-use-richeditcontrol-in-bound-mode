using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace RichEditDataBoundScenario {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dataSet11.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.dataSet11.Cars);

            // Setup binding only when datasource is filled with data to minimize number of UpdateCommandsState() method calls
            richEditControl1.DataBindings.Add(new Binding("RtfText", this.carsBindingSource, "RtfContent"));

            this.dataSet11.Cars.ColumnChanged += new DataColumnChangeEventHandler(Cars_ColumnChanged);

            UpdateCommandsState();
        }

        void Cars_ColumnChanged(object sender, DataColumnChangeEventArgs e) {
            if (!richEditControl1.Modified)
                e.Row.AcceptChanges();
        }

        private void dataNavigator1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
                richEditControl1.Modified = false;
            
            this.BeginInvoke(new MethodInvoker(UpdateCommandsState));
        }

        private void richEditControl1_ModifiedChanged(object sender, EventArgs e) {
            UpdateCommandsState();
        }

        private void btnAcceptChanges_Click(object sender, EventArgs e) {
            this.carsTableAdapter.Update(this.dataSet11.Cars);
            this.dataSet11.Cars.AcceptChanges();
            UpdateCommandsState();
        }

        private void btnRejectChanges_Click(object sender, EventArgs e) {
            DataRow currentDataRow = this.dataSet11.Cars.Rows[carsBindingSource.Position];
            currentDataRow.RejectChanges();
            UpdateCommandsState();
        }

        private void UpdateCommandsState() {
            // Update control level commands state
            dataNavigator1.Buttons.CancelEdit.Enabled = richEditControl1.Modified;
            dataNavigator1.Buttons.EndEdit.Enabled = richEditControl1.Modified;

            // Update data (in-memory) level commands state
            DataRow currentDataRow = this.dataSet11.Cars.Rows[carsBindingSource.Position];
            btnRejectChanges.Enabled = (currentDataRow.RowState != DataRowState.Unchanged) && !richEditControl1.Modified;
            btnAcceptChanges.Enabled = this.dataSet11.HasChanges() && !richEditControl1.Modified;

            // Update info panel
            lblCurrentRecordInfo.Text = string.Format("Current Record: {0}{1}",
                carsBindingSource.Position, (btnRejectChanges.Enabled ? "*" : ""));
        }
    }
}