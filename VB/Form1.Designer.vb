Namespace RichEditDataBoundScenario

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Me.btnRejectChanges = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAcceptChanges = New DevExpress.XtraEditors.SimpleButton()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Form1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.richEditControl1item = New DevExpress.XtraLayout.LayoutControlItem()
            Me.btnAcceptChangesitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.btnRejectChangesitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dataNavigator1item = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.carsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Form1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Form1layoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditControl1item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnAcceptChangesitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnRejectChangesitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataNavigator1item), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.richEditControl1.Location = New System.Drawing.Point(12, 88)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(1719, 821)
            Me.richEditControl1.TabIndex = 0
            AddHandler Me.richEditControl1.ModifiedChanged, New System.EventHandler(AddressOf Me.richEditControl1_ModifiedChanged)
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.Buttons.NextPage.Visible = False
            Me.dataNavigator1.Buttons.PrevPage.Visible = False
            Me.dataNavigator1.Buttons.Remove.Visible = False
            Me.dataNavigator1.DataSource = Me.carsBindingSource
            Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.dataNavigator1.Location = New System.Drawing.Point(12, 913)
            Me.dataNavigator1.Margin = New System.Windows.Forms.Padding(48, 48, 48, 48)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(273, 36)
            Me.dataNavigator1.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.dataNavigator1.TabIndex = 1
            Me.dataNavigator1.Text = "dataNavigator1"
            AddHandler Me.dataNavigator1.ButtonClick, New DevExpress.XtraEditors.NavigatorButtonClickEventHandler(AddressOf Me.dataNavigator1_ButtonClick)
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
            ' btnRejectChanges
            ' 
            Me.btnRejectChanges.Location = New System.Drawing.Point(999, 12)
            Me.btnRejectChanges.Margin = New System.Windows.Forms.Padding(48, 48, 48, 48)
            Me.btnRejectChanges.Name = "btnRejectChanges"
            Me.btnRejectChanges.Size = New System.Drawing.Size(732, 44)
            Me.btnRejectChanges.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.btnRejectChanges.TabIndex = 3
            Me.btnRejectChanges.Text = "Reject Changes"
            Me.toolTip1.SetToolTip(Me.btnRejectChanges, "Apply original content from the database to the current record")
            AddHandler Me.btnRejectChanges.Click, New System.EventHandler(AddressOf Me.btnRejectChanges_Click)
            ' 
            ' btnAcceptChanges
            ' 
            Me.btnAcceptChanges.Location = New System.Drawing.Point(12, 12)
            Me.btnAcceptChanges.Margin = New System.Windows.Forms.Padding(48, 48, 48, 48)
            Me.btnAcceptChanges.Name = "btnAcceptChanges"
            Me.btnAcceptChanges.Size = New System.Drawing.Size(983, 44)
            Me.btnAcceptChanges.StyleController = Me.Form1layoutControl1ConvertedLayout
            Me.btnAcceptChanges.TabIndex = 4
            Me.btnAcceptChanges.Text = "Accept Changes"
            Me.toolTip1.SetToolTip(Me.btnAcceptChanges, "Save all records to the database")
            AddHandler Me.btnAcceptChanges.Click, New System.EventHandler(AddressOf Me.btnAcceptChanges_Click)
            ' 
            ' Form1layoutControl1ConvertedLayout
            ' 
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.richEditControl1)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.btnAcceptChanges)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.btnRejectChanges)
            Me.Form1layoutControl1ConvertedLayout.Controls.Add(Me.dataNavigator1)
            Me.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Form1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout"
            Me.Form1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.Form1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(1743, 959)
            Me.Form1layoutControl1ConvertedLayout.TabIndex = 5
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.richEditControl1item, Me.btnAcceptChangesitem, Me.btnRejectChangesitem, Me.dataNavigator1item})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1743, 959)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' richEditControl1item
            ' 
            Me.richEditControl1item.Control = Me.richEditControl1
            Me.richEditControl1item.Location = New System.Drawing.Point(0, 48)
            Me.richEditControl1item.Name = "richEditControl1item"
            Me.richEditControl1item.Size = New System.Drawing.Size(1723, 853)
            Me.richEditControl1item.Text = "Current record info"
            Me.richEditControl1item.TextLocation = DevExpress.Utils.Locations.Top
            Me.richEditControl1item.TextSize = New System.Drawing.Size(180, 25)
            ' 
            ' btnAcceptChangesitem
            ' 
            Me.btnAcceptChangesitem.Control = Me.btnAcceptChanges
            Me.btnAcceptChangesitem.Location = New System.Drawing.Point(0, 0)
            Me.btnAcceptChangesitem.Name = "btnAcceptChangesitem"
            Me.btnAcceptChangesitem.Size = New System.Drawing.Size(987, 48)
            Me.btnAcceptChangesitem.TextSize = New System.Drawing.Size(0, 0)
            Me.btnAcceptChangesitem.TextVisible = False
            ' 
            ' btnRejectChangesitem
            ' 
            Me.btnRejectChangesitem.Control = Me.btnRejectChanges
            Me.btnRejectChangesitem.Location = New System.Drawing.Point(987, 0)
            Me.btnRejectChangesitem.Name = "btnRejectChangesitem"
            Me.btnRejectChangesitem.Size = New System.Drawing.Size(736, 48)
            Me.btnRejectChangesitem.TextSize = New System.Drawing.Size(0, 0)
            Me.btnRejectChangesitem.TextVisible = False
            ' 
            ' dataNavigator1item
            ' 
            Me.dataNavigator1item.Control = Me.dataNavigator1
            Me.dataNavigator1item.Location = New System.Drawing.Point(0, 901)
            Me.dataNavigator1item.Name = "dataNavigator1item"
            Me.dataNavigator1item.Size = New System.Drawing.Size(1723, 38)
            Me.dataNavigator1item.TextSize = New System.Drawing.Size(0, 0)
            Me.dataNavigator1item.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(12F, 25F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1743, 959)
            Me.Controls.Add(Me.Form1layoutControl1ConvertedLayout)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.carsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Form1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.Form1layoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditControl1item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnAcceptChangesitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnRejectChangesitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataNavigator1item), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private dataSet11 As RichEditDataBoundScenario.DataSet1

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

        Private carsBindingSource As System.Windows.Forms.BindingSource

        Private carsTableAdapter As RichEditDataBoundScenario.DataSet1TableAdapters.CarsTableAdapter

        Private btnRejectChanges As DevExpress.XtraEditors.SimpleButton

        Private toolTip1 As System.Windows.Forms.ToolTip

        Private btnAcceptChanges As DevExpress.XtraEditors.SimpleButton

        Private Form1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private richEditControl1item As DevExpress.XtraLayout.LayoutControlItem

        Private btnAcceptChangesitem As DevExpress.XtraLayout.LayoutControlItem

        Private btnRejectChangesitem As DevExpress.XtraLayout.LayoutControlItem

        Private dataNavigator1item As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
