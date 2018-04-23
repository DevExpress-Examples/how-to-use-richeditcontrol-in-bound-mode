Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit

Namespace RichEditDataBoundScenario
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'dataSet11.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.dataSet11.Cars)

			' Setup binding only when datasource is filled with data to minimize number of UpdateCommandsState() method calls
			richEditControl1.DataBindings.Add(New Binding("RtfText", Me.carsBindingSource, "RtfContent"))

			AddHandler dataSet11.Cars.ColumnChanged, AddressOf Cars_ColumnChanged

			UpdateCommandsState()
		End Sub

		Private Sub Cars_ColumnChanged(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
			If (Not richEditControl1.Modified) Then
				e.Row.AcceptChanges()
			End If
		End Sub

		Private Sub dataNavigator1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles dataNavigator1.ButtonClick
			If e.Button.ButtonType = NavigatorButtonType.EndEdit Then
				richEditControl1.Modified = False
			End If

			Me.BeginInvoke(New MethodInvoker(AddressOf UpdateCommandsState))
		End Sub

		Private Sub richEditControl1_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.ModifiedChanged
			UpdateCommandsState()
		End Sub

		Private Sub btnAcceptChanges_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAcceptChanges.Click
			Me.carsTableAdapter.Update(Me.dataSet11.Cars)
			Me.dataSet11.Cars.AcceptChanges()
			UpdateCommandsState()
		End Sub

		Private Sub btnRejectChanges_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRejectChanges.Click
			Dim currentDataRow As DataRow = Me.dataSet11.Cars.Rows(carsBindingSource.Position)
			currentDataRow.RejectChanges()
			UpdateCommandsState()
		End Sub

		Private Sub UpdateCommandsState()
			' Update control level commands state
			dataNavigator1.Buttons.CancelEdit.Enabled = richEditControl1.Modified
			dataNavigator1.Buttons.EndEdit.Enabled = richEditControl1.Modified

			' Update data (in-memory) level commands state
			Dim currentDataRow As DataRow = Me.dataSet11.Cars.Rows(carsBindingSource.Position)
			btnRejectChanges.Enabled = (currentDataRow.RowState <> DataRowState.Unchanged) AndAlso Not richEditControl1.Modified
			btnAcceptChanges.Enabled = Me.dataSet11.HasChanges() AndAlso Not richEditControl1.Modified

			' Update info panel
			lblCurrentRecordInfo.Text = String.Format("Current Record: {0}{1}", carsBindingSource.Position, (IIf(btnRejectChanges.Enabled, "*", "")))
		End Sub
	End Class
End Namespace