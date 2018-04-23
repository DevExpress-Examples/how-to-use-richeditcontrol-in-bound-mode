Imports Microsoft.VisualBasic
Imports System
Namespace RichEditDataBoundScenario
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New RichEditDataBoundScenario.DataSet1()
			Me.carsTableAdapter = New RichEditDataBoundScenario.DataSet1TableAdapters.CarsTableAdapter()
			Me.lblCurrentRecordInfo = New System.Windows.Forms.Label()
			Me.btnRejectChanges = New DevExpress.XtraEditors.SimpleButton()
			Me.btnAcceptChanges = New DevExpress.XtraEditors.SimpleButton()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.richEditControl1.Location = New System.Drawing.Point(9, 37)
			Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(892, 404)
			Me.richEditControl1.TabIndex = 0
'			Me.richEditControl1.ModifiedChanged += New System.EventHandler(Me.richEditControl1_ModifiedChanged);
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataNavigator1.Buttons.Append.Visible = False
			Me.dataNavigator1.Buttons.NextPage.Visible = False
			Me.dataNavigator1.Buttons.PrevPage.Visible = False
			Me.dataNavigator1.Buttons.Remove.Visible = False
			Me.dataNavigator1.DataSource = Me.carsBindingSource
			Me.dataNavigator1.Location = New System.Drawing.Point(12, 455)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(889, 24)
			Me.dataNavigator1.TabIndex = 1
			Me.dataNavigator1.Text = "dataNavigator1"
'			Me.dataNavigator1.ButtonClick += New DevExpress.XtraEditors.NavigatorButtonClickEventHandler(Me.dataNavigator1_ButtonClick);
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' lblCurrentRecordInfo
			' 
			Me.lblCurrentRecordInfo.AutoSize = True
			Me.lblCurrentRecordInfo.Location = New System.Drawing.Point(13, 13)
			Me.lblCurrentRecordInfo.Name = "lblCurrentRecordInfo"
			Me.lblCurrentRecordInfo.Size = New System.Drawing.Size(94, 13)
			Me.lblCurrentRecordInfo.TabIndex = 2
			Me.lblCurrentRecordInfo.Text = "Current record info"
			' 
			' btnRejectChanges
			' 
			Me.btnRejectChanges.Location = New System.Drawing.Point(298, 8)
			Me.btnRejectChanges.Name = "btnRejectChanges"
			Me.btnRejectChanges.Size = New System.Drawing.Size(106, 23)
			Me.btnRejectChanges.TabIndex = 3
			Me.btnRejectChanges.Text = "Reject Changes"
			Me.toolTip1.SetToolTip(Me.btnRejectChanges, "Apply original content from the database to the current record")
'			Me.btnRejectChanges.Click += New System.EventHandler(Me.btnRejectChanges_Click);
			' 
			' btnAcceptChanges
			' 
			Me.btnAcceptChanges.Location = New System.Drawing.Point(186, 8)
			Me.btnAcceptChanges.Name = "btnAcceptChanges"
			Me.btnAcceptChanges.Size = New System.Drawing.Size(106, 23)
			Me.btnAcceptChanges.TabIndex = 4
			Me.btnAcceptChanges.Text = "Accept Changes"
			Me.toolTip1.SetToolTip(Me.btnAcceptChanges, "Save all records to the database")
'			Me.btnAcceptChanges.Click += New System.EventHandler(Me.btnAcceptChanges_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(910, 499)
			Me.Controls.Add(Me.btnAcceptChanges)
			Me.Controls.Add(Me.btnRejectChanges)
			Me.Controls.Add(Me.lblCurrentRecordInfo)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.richEditControl1)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private dataSet11 As DataSet1
		Private WithEvents dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As RichEditDataBoundScenario.DataSet1TableAdapters.CarsTableAdapter
		Private lblCurrentRecordInfo As System.Windows.Forms.Label
		Private WithEvents btnRejectChanges As DevExpress.XtraEditors.SimpleButton
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private WithEvents btnAcceptChanges As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

