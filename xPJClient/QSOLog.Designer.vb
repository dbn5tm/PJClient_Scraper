<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QSOLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim IdLabel As System.Windows.Forms.Label
        Dim BandLabel As System.Windows.Forms.Label
        Dim ModeLabel As System.Windows.Forms.Label
        Dim PowerLabel As System.Windows.Forms.Label
        Dim AntennaLabel As System.Windows.Forms.Label
        Dim ReportLabel As System.Windows.Forms.Label
        Dim ExchangeLabel As System.Windows.Forms.Label
        Dim QsodistanceLabel As System.Windows.Forms.Label
        Dim QsoazmuthLabel As System.Windows.Forms.Label
        Dim HispowerLabel As System.Windows.Forms.Label
        Dim HisantennaLabel As System.Windows.Forms.Label
        Dim MoondegrLabel As System.Windows.Forms.Label
        Dim ShowerLabel As System.Windows.Forms.Label
        Dim StationIDLabel As System.Windows.Forms.Label
        Dim QsolocatorLabel As System.Windows.Forms.Label
        Dim QsoUTCLabel As System.Windows.Forms.Label
        Dim QsodateLabel1 As System.Windows.Forms.Label
        Dim SentLabel As System.Windows.Forms.Label
        Dim ImgLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QSOLog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        'Me.QsoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        'Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        'Me.QsoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.PJCLogBook2DataSet = New PJClient.PJCLogBook2DataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.QsoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.BandTextBox = New System.Windows.Forms.TextBox
        Me.ModeTextBox = New System.Windows.Forms.TextBox
        Me.PowerTextBox = New System.Windows.Forms.TextBox
        Me.AntennaTextBox = New System.Windows.Forms.TextBox
        Me.ReportTextBox = New System.Windows.Forms.TextBox
        Me.ExchangeTextBox = New System.Windows.Forms.TextBox
        Me.QsodistanceTextBox = New System.Windows.Forms.TextBox
        Me.QsoazmuthTextBox = New System.Windows.Forms.TextBox
        Me.HispowerTextBox = New System.Windows.Forms.TextBox
        Me.HisantennaTextBox = New System.Windows.Forms.TextBox
        Me.MoondegrTextBox = New System.Windows.Forms.TextBox
        Me.ShowerTextBox = New System.Windows.Forms.TextBox
        Me.StationIDTextBox = New System.Windows.Forms.TextBox
        Me.QsolocatorTextBox = New System.Windows.Forms.TextBox
        Me.QsoUTCTextBox = New System.Windows.Forms.TextBox
        Me.StationTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        'Me.QsoTableAdapter = New PJClient.PJCLogBook2DataSetTableAdapters.QsoTableAdapter
        'Me.TableAdapterManager = New PJClient.PJCLogBook2DataSetTableAdapters.TableAdapterManager
        'Me.StationTableAdapter = New PJClient.PJCLogBook2DataSetTableAdapters.StationTableAdapter
        Me.QSOFormatedDateTextBox = New System.Windows.Forms.TextBox
        Me.SentTextBox = New System.Windows.Forms.TextBox
        Me.QSODateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ImgTextBox = New System.Windows.Forms.TextBox
        Me.ImgButton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.StationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox1 = New System.Windows.Forms.TextBox
        Me.BandComboBox = New System.Windows.Forms.ComboBox
        Me.ModeComboBox = New System.Windows.Forms.ComboBox
        Me.ShowImgButton = New System.Windows.Forms.Button
        IdLabel = New System.Windows.Forms.Label
        BandLabel = New System.Windows.Forms.Label
        ModeLabel = New System.Windows.Forms.Label
        PowerLabel = New System.Windows.Forms.Label
        AntennaLabel = New System.Windows.Forms.Label
        ReportLabel = New System.Windows.Forms.Label
        ExchangeLabel = New System.Windows.Forms.Label
        QsodistanceLabel = New System.Windows.Forms.Label
        QsoazmuthLabel = New System.Windows.Forms.Label
        HispowerLabel = New System.Windows.Forms.Label
        HisantennaLabel = New System.Windows.Forms.Label
        MoondegrLabel = New System.Windows.Forms.Label
        ShowerLabel = New System.Windows.Forms.Label
        StationIDLabel = New System.Windows.Forms.Label
        QsolocatorLabel = New System.Windows.Forms.Label
        QsoUTCLabel = New System.Windows.Forms.Label
        QsodateLabel1 = New System.Windows.Forms.Label
        SentLabel = New System.Windows.Forms.Label
        ImgLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        'CType(Me.QsoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        'Me.QsoBindingNavigator.SuspendLayout()
        'CType(Me.QsoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.PJCLogBook2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(288, 49)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "id:"
        '
        'BandLabel
        '
        BandLabel.AutoSize = True
        BandLabel.Location = New System.Drawing.Point(64, 121)
        BandLabel.Name = "BandLabel"
        BandLabel.Size = New System.Drawing.Size(34, 13)
        BandLabel.TabIndex = 4
        BandLabel.Text = "band:"
        '
        'ModeLabel
        '
        ModeLabel.AutoSize = True
        ModeLabel.Location = New System.Drawing.Point(64, 147)
        ModeLabel.Name = "ModeLabel"
        ModeLabel.Size = New System.Drawing.Size(36, 13)
        ModeLabel.TabIndex = 6
        ModeLabel.Text = "mode:"
        '
        'PowerLabel
        '
        PowerLabel.AutoSize = True
        PowerLabel.Location = New System.Drawing.Point(65, 173)
        PowerLabel.Name = "PowerLabel"
        PowerLabel.Size = New System.Drawing.Size(39, 13)
        PowerLabel.TabIndex = 8
        PowerLabel.Text = "power:"
        '
        'AntennaLabel
        '
        AntennaLabel.AutoSize = True
        AntennaLabel.Location = New System.Drawing.Point(64, 199)
        AntennaLabel.Name = "AntennaLabel"
        AntennaLabel.Size = New System.Drawing.Size(49, 13)
        AntennaLabel.TabIndex = 10
        AntennaLabel.Text = "antenna:"
        '
        'ReportLabel
        '
        ReportLabel.AutoSize = True
        ReportLabel.Location = New System.Drawing.Point(230, 121)
        ReportLabel.Name = "ReportLabel"
        ReportLabel.Size = New System.Drawing.Size(37, 13)
        ReportLabel.TabIndex = 12
        ReportLabel.Text = "report:"
        '
        'ExchangeLabel
        '
        ExchangeLabel.AutoSize = True
        ExchangeLabel.Location = New System.Drawing.Point(64, 251)
        ExchangeLabel.Name = "ExchangeLabel"
        ExchangeLabel.Size = New System.Drawing.Size(57, 13)
        ExchangeLabel.TabIndex = 14
        ExchangeLabel.Text = "exchange:"
        '
        'QsodistanceLabel
        '
        QsodistanceLabel.AutoSize = True
        QsodistanceLabel.Location = New System.Drawing.Point(353, 121)
        QsodistanceLabel.Name = "QsodistanceLabel"
        QsodistanceLabel.Size = New System.Drawing.Size(67, 13)
        QsodistanceLabel.TabIndex = 16
        QsodistanceLabel.Text = "qsodistance:"
        '
        'QsoazmuthLabel
        '
        QsoazmuthLabel.AutoSize = True
        QsoazmuthLabel.Location = New System.Drawing.Point(353, 147)
        QsoazmuthLabel.Name = "QsoazmuthLabel"
        QsoazmuthLabel.Size = New System.Drawing.Size(61, 13)
        QsoazmuthLabel.TabIndex = 18
        QsoazmuthLabel.Text = "qsoazmuth:"
        '
        'HispowerLabel
        '
        HispowerLabel.AutoSize = True
        HispowerLabel.Location = New System.Drawing.Point(215, 173)
        HispowerLabel.Name = "HispowerLabel"
        HispowerLabel.Size = New System.Drawing.Size(52, 13)
        HispowerLabel.TabIndex = 20
        HispowerLabel.Text = "hispower:"
        '
        'HisantennaLabel
        '
        HisantennaLabel.AutoSize = True
        HisantennaLabel.Location = New System.Drawing.Point(64, 225)
        HisantennaLabel.Name = "HisantennaLabel"
        HisantennaLabel.Size = New System.Drawing.Size(62, 13)
        HisantennaLabel.TabIndex = 22
        HisantennaLabel.Text = "hisantenna:"
        '
        'MoondegrLabel
        '
        MoondegrLabel.AutoSize = True
        MoondegrLabel.Location = New System.Drawing.Point(353, 173)
        MoondegrLabel.Name = "MoondegrLabel"
        MoondegrLabel.Size = New System.Drawing.Size(57, 13)
        MoondegrLabel.TabIndex = 24
        MoondegrLabel.Text = "moondegr:"
        '
        'ShowerLabel
        '
        ShowerLabel.AutoSize = True
        ShowerLabel.Location = New System.Drawing.Point(64, 309)
        ShowerLabel.Name = "ShowerLabel"
        ShowerLabel.Size = New System.Drawing.Size(44, 13)
        ShowerLabel.TabIndex = 26
        ShowerLabel.Text = "shower:"
        '
        'StationIDLabel
        '
        StationIDLabel.AutoSize = True
        StationIDLabel.Location = New System.Drawing.Point(353, 49)
        StationIDLabel.Name = "StationIDLabel"
        StationIDLabel.Size = New System.Drawing.Size(55, 13)
        StationIDLabel.TabIndex = 28
        StationIDLabel.Text = "station ID:"
        '
        'QsolocatorLabel
        '
        QsolocatorLabel.AutoSize = True
        QsolocatorLabel.Location = New System.Drawing.Point(353, 90)
        QsolocatorLabel.Name = "QsolocatorLabel"
        QsolocatorLabel.Size = New System.Drawing.Size(59, 13)
        QsolocatorLabel.TabIndex = 32
        QsolocatorLabel.Text = "qsolocator:"
        '
        'QsoUTCLabel
        '
        QsoUTCLabel.AutoSize = True
        QsoUTCLabel.Location = New System.Drawing.Point(234, 90)
        QsoUTCLabel.Name = "QsoUTCLabel"
        QsoUTCLabel.Size = New System.Drawing.Size(32, 13)
        QsoUTCLabel.TabIndex = 34
        QsoUTCLabel.Text = "UTC:"
        '
        'QsodateLabel1
        '
        QsodateLabel1.AutoSize = True
        QsodateLabel1.Location = New System.Drawing.Point(65, 93)
        QsodateLabel1.Name = "QsodateLabel1"
        QsodateLabel1.Size = New System.Drawing.Size(48, 13)
        QsodateLabel1.TabIndex = 36
        QsodateLabel1.Text = "qsodate:"
        '
        'SentLabel
        '
        SentLabel.AutoSize = True
        SentLabel.Location = New System.Drawing.Point(239, 147)
        SentLabel.Name = "SentLabel"
        SentLabel.Size = New System.Drawing.Size(30, 13)
        SentLabel.TabIndex = 40
        SentLabel.Text = "sent:"
        '
        'ImgLabel
        '
        ImgLabel.AutoSize = True
        ImgLabel.Location = New System.Drawing.Point(64, 335)
        ImgLabel.Name = "ImgLabel"
        ImgLabel.Size = New System.Drawing.Size(26, 13)
        ImgLabel.TabIndex = 42
        ImgLabel.Text = "img:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(449, 400)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 50
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 15
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 16
        Me.Cancel_Button.Text = "Cancel"
        '
        'QsoBindingNavigator
        '
        'Me.QsoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        'Me.QsoBindingNavigator.BindingSource = Me.QsoBindingSource
        'Me.QsoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        'Me.QsoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        'Me.QsoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QsoBindingNavigatorSaveItem})
        'Me.QsoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        'Me.QsoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        'Me.QsoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        'Me.QsoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        'Me.QsoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        'Me.QsoBindingNavigator.Name = "QsoBindingNavigator"
        'Me.QsoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        'Me.QsoBindingNavigator.Size = New System.Drawing.Size(607, 25)
        'Me.QsoBindingNavigator.TabIndex = 1
        'Me.QsoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'QsoBindingSource
        '
        'Me.QsoBindingSource.DataMember = "Qso"
        'Me.QsoBindingSource.DataSource = Me.PJCLogBook2DataSet
        '
        'PJCLogBook2DataSet
        '
        'Me.PJCLogBook2DataSet.DataSetName = "PJCLogBook2DataSet"
        'Me.PJCLogBook2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'QsoBindingNavigatorSaveItem
        '
        Me.QsoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QsoBindingNavigatorSaveItem.Image = CType(resources.GetObject("QsoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QsoBindingNavigatorSaveItem.Name = "QsoBindingNavigatorSaveItem"
        Me.QsoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QsoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(312, 46)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(35, 20)
        Me.IdTextBox.TabIndex = 23
        '
        'BandTextBox
        '
        Me.BandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "band", True))
        Me.BandTextBox.Location = New System.Drawing.Point(137, 118)
        Me.BandTextBox.Name = "BandTextBox"
        Me.BandTextBox.Size = New System.Drawing.Size(62, 20)
        Me.BandTextBox.TabIndex = 33
        '
        'ModeTextBox
        '
        Me.ModeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "mode", True))
        Me.ModeTextBox.Location = New System.Drawing.Point(137, 145)
        Me.ModeTextBox.Name = "ModeTextBox"
        Me.ModeTextBox.Size = New System.Drawing.Size(62, 20)
        Me.ModeTextBox.TabIndex = 34
        '
        'PowerTextBox
        '
        Me.PowerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "power", True))
        Me.PowerTextBox.Location = New System.Drawing.Point(137, 170)
        Me.PowerTextBox.Name = "PowerTextBox"
        Me.PowerTextBox.Size = New System.Drawing.Size(62, 20)
        Me.PowerTextBox.TabIndex = 7
        '
        'AntennaTextBox
        '
        Me.AntennaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "antenna", True))
        Me.AntennaTextBox.Location = New System.Drawing.Point(137, 196)
        Me.AntennaTextBox.Name = "AntennaTextBox"
        Me.AntennaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AntennaTextBox.TabIndex = 9
        '
        'ReportTextBox
        '
        Me.ReportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "report", True))
        Me.ReportTextBox.Location = New System.Drawing.Point(275, 118)
        Me.ReportTextBox.Name = "ReportTextBox"
        Me.ReportTextBox.Size = New System.Drawing.Size(62, 20)
        Me.ReportTextBox.TabIndex = 5
        '
        'ExchangeTextBox
        '
        Me.ExchangeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "exchange", True))
        Me.ExchangeTextBox.Location = New System.Drawing.Point(137, 248)
        Me.ExchangeTextBox.Multiline = True
        Me.ExchangeTextBox.Name = "ExchangeTextBox"
        Me.ExchangeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ExchangeTextBox.Size = New System.Drawing.Size(371, 52)
        Me.ExchangeTextBox.TabIndex = 11
        '
        'QsodistanceTextBox
        '
        Me.QsodistanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "qsodistance", True))
        Me.QsodistanceTextBox.Location = New System.Drawing.Point(426, 118)
        Me.QsodistanceTextBox.Name = "QsodistanceTextBox"
        Me.QsodistanceTextBox.Size = New System.Drawing.Size(62, 20)
        Me.QsodistanceTextBox.TabIndex = 20
        '
        'QsoazmuthTextBox
        '
        Me.QsoazmuthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "qsoazmuth", True))
        Me.QsoazmuthTextBox.Location = New System.Drawing.Point(426, 144)
        Me.QsoazmuthTextBox.Name = "QsoazmuthTextBox"
        Me.QsoazmuthTextBox.Size = New System.Drawing.Size(62, 20)
        Me.QsoazmuthTextBox.TabIndex = 21
        '
        'HispowerTextBox
        '
        Me.HispowerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "hispower", True))
        Me.HispowerTextBox.Location = New System.Drawing.Point(275, 170)
        Me.HispowerTextBox.Name = "HispowerTextBox"
        Me.HispowerTextBox.Size = New System.Drawing.Size(62, 20)
        Me.HispowerTextBox.TabIndex = 8
        '
        'HisantennaTextBox
        '
        Me.HisantennaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "hisantenna", True))
        Me.HisantennaTextBox.Location = New System.Drawing.Point(137, 222)
        Me.HisantennaTextBox.Name = "HisantennaTextBox"
        Me.HisantennaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HisantennaTextBox.TabIndex = 10
        '
        'MoondegrTextBox
        '
        Me.MoondegrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "moondegr", True))
        Me.MoondegrTextBox.Location = New System.Drawing.Point(426, 170)
        Me.MoondegrTextBox.Name = "MoondegrTextBox"
        Me.MoondegrTextBox.Size = New System.Drawing.Size(62, 20)
        Me.MoondegrTextBox.TabIndex = 21
        '
        'ShowerTextBox
        '
        Me.ShowerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "shower", True))
        Me.ShowerTextBox.Location = New System.Drawing.Point(137, 306)
        Me.ShowerTextBox.Name = "ShowerTextBox"
        Me.ShowerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShowerTextBox.TabIndex = 12
        '
        'StationIDTextBox
        '
        Me.StationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "stationID", True))
        Me.StationIDTextBox.Location = New System.Drawing.Point(426, 46)
        Me.StationIDTextBox.Name = "StationIDTextBox"
        Me.StationIDTextBox.Size = New System.Drawing.Size(62, 20)
        Me.StationIDTextBox.TabIndex = 24
        '
        'QsolocatorTextBox
        '
        Me.QsolocatorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "qsolocator", True))
        Me.QsolocatorTextBox.Location = New System.Drawing.Point(426, 87)
        Me.QsolocatorTextBox.Name = "QsolocatorTextBox"
        Me.QsolocatorTextBox.Size = New System.Drawing.Size(62, 20)
        Me.QsolocatorTextBox.TabIndex = 2
        '
        'QsoUTCTextBox
        '
        Me.QsoUTCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "qsoUTC", True))
        Me.QsoUTCTextBox.Location = New System.Drawing.Point(275, 87)
        Me.QsoUTCTextBox.Name = "QsoUTCTextBox"
        Me.QsoUTCTextBox.Size = New System.Drawing.Size(62, 20)
        Me.QsoUTCTextBox.TabIndex = 1
        '
        'StationTextBox
        '
        Me.StationTextBox.Location = New System.Drawing.Point(137, 46)
        Me.StationTextBox.Name = "StationTextBox"
        Me.StationTextBox.Size = New System.Drawing.Size(117, 20)
        Me.StationTextBox.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Station:"
        '
        'QsoTableAdapter
        '
        Me.QsoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        'Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.QsoTableAdapter = Me.QsoTableAdapter
        'Me.TableAdapterManager.StationTableAdapter = Me.StationTableAdapter
        'Me.TableAdapterManager.UpdateOrder = PJClient.PJCLogBook2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StationTableAdapter
        '
        Me.StationTableAdapter.ClearBeforeFill = True
        '
        'QSOFormatedDateTextBox
        '
        Me.QSOFormatedDateTextBox.Location = New System.Drawing.Point(137, 90)
        Me.QSOFormatedDateTextBox.Name = "QSOFormatedDateTextBox"
        Me.QSOFormatedDateTextBox.Size = New System.Drawing.Size(82, 20)
        Me.QSOFormatedDateTextBox.TabIndex = 0
        '
        'SentTextBox
        '
        Me.SentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "sent", True))
        Me.SentTextBox.Location = New System.Drawing.Point(275, 144)
        Me.SentTextBox.Name = "SentTextBox"
        Me.SentTextBox.Size = New System.Drawing.Size(62, 20)
        Me.SentTextBox.TabIndex = 6
        '
        'QSODateTimePicker
        '
        Me.QSODateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QsoBindingSource, "qsodate", True))
        Me.QSODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.QSODateTimePicker.Location = New System.Drawing.Point(137, 90)
        Me.QSODateTimePicker.Name = "QSODateTimePicker"
        Me.QSODateTimePicker.Size = New System.Drawing.Size(82, 20)
        Me.QSODateTimePicker.TabIndex = 41
        '
        'ImgTextBox
        '
        Me.ImgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QsoBindingSource, "img", True))
        Me.ImgTextBox.Location = New System.Drawing.Point(137, 332)
        Me.ImgTextBox.Name = "ImgTextBox"
        Me.ImgTextBox.Size = New System.Drawing.Size(283, 20)
        Me.ImgTextBox.TabIndex = 13
        '
        'ImgButton
        '
        Me.ImgButton.Location = New System.Drawing.Point(458, 332)
        Me.ImgButton.Name = "ImgButton"
        Me.ImgButton.Size = New System.Drawing.Size(61, 21)
        Me.ImgButton.TabIndex = 14
        Me.ImgButton.Text = "..."
        Me.ImgButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StationBindingSource
        '
        Me.StationBindingSource.DataMember = "Station"
        Me.StationBindingSource.DataSource = Me.PJCLogBook2DataSet
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "id", True))
        Me.IdTextBox1.Location = New System.Drawing.Point(494, 46)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(47, 20)
        Me.IdTextBox1.TabIndex = 51
        '
        'BandComboBox
        '
        Me.BandComboBox.AllowDrop = True
        Me.BandComboBox.FormattingEnabled = True
        Me.BandComboBox.Items.AddRange(New Object() {"160m", "80m", "60m", "40m", "30m", "20m", "17m", "15m", "12m", "10m", "6m", "2m", "70cm", "23cm"})
        Me.BandComboBox.Location = New System.Drawing.Point(137, 117)
        Me.BandComboBox.Name = "BandComboBox"
        Me.BandComboBox.Size = New System.Drawing.Size(62, 21)
        Me.BandComboBox.TabIndex = 3
        '
        'ModeComboBox
        '
        Me.ModeComboBox.FormattingEnabled = True
        Me.ModeComboBox.Items.AddRange(New Object() {"CW", "SSB", "JT65", "FSK441", "PSK2K", "ISCAT"})
        Me.ModeComboBox.Location = New System.Drawing.Point(137, 144)
        Me.ModeComboBox.Name = "ModeComboBox"
        Me.ModeComboBox.Size = New System.Drawing.Size(62, 21)
        Me.ModeComboBox.TabIndex = 4
        '
        'ShowImgButton
        '
        Me.ShowImgButton.Location = New System.Drawing.Point(426, 332)
        Me.ShowImgButton.Name = "ShowImgButton"
        Me.ShowImgButton.Size = New System.Drawing.Size(23, 20)
        Me.ShowImgButton.TabIndex = 52
        Me.ShowImgButton.UseVisualStyleBackColor = True
        '
        'QSOLog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(607, 441)
        Me.Controls.Add(Me.ShowImgButton)
        Me.Controls.Add(Me.ModeComboBox)
        Me.Controls.Add(Me.BandComboBox)
        Me.Controls.Add(Me.IdTextBox1)
        Me.Controls.Add(Me.ImgButton)
        Me.Controls.Add(ImgLabel)
        Me.Controls.Add(Me.ImgTextBox)
        Me.Controls.Add(Me.QSODateTimePicker)
        Me.Controls.Add(SentLabel)
        Me.Controls.Add(Me.SentTextBox)
        Me.Controls.Add(Me.QSOFormatedDateTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StationTextBox)
        Me.Controls.Add(QsodateLabel1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(BandLabel)
        Me.Controls.Add(Me.BandTextBox)
        Me.Controls.Add(ModeLabel)
        Me.Controls.Add(Me.ModeTextBox)
        Me.Controls.Add(PowerLabel)
        Me.Controls.Add(Me.PowerTextBox)
        Me.Controls.Add(AntennaLabel)
        Me.Controls.Add(Me.AntennaTextBox)
        Me.Controls.Add(ReportLabel)
        Me.Controls.Add(Me.ReportTextBox)
        Me.Controls.Add(ExchangeLabel)
        Me.Controls.Add(Me.ExchangeTextBox)
        Me.Controls.Add(QsodistanceLabel)
        Me.Controls.Add(Me.QsodistanceTextBox)
        Me.Controls.Add(QsoazmuthLabel)
        Me.Controls.Add(Me.QsoazmuthTextBox)
        Me.Controls.Add(HispowerLabel)
        Me.Controls.Add(Me.HispowerTextBox)
        Me.Controls.Add(HisantennaLabel)
        Me.Controls.Add(Me.HisantennaTextBox)
        Me.Controls.Add(MoondegrLabel)
        Me.Controls.Add(Me.MoondegrTextBox)
        Me.Controls.Add(ShowerLabel)
        Me.Controls.Add(Me.ShowerTextBox)
        Me.Controls.Add(StationIDLabel)
        Me.Controls.Add(Me.StationIDTextBox)
        Me.Controls.Add(QsolocatorLabel)
        Me.Controls.Add(Me.QsolocatorTextBox)
        Me.Controls.Add(QsoUTCLabel)
        Me.Controls.Add(Me.QsoUTCTextBox)
        Me.Controls.Add(Me.QsoBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QSOLog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "QSOLog"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.QsoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QsoBindingNavigator.ResumeLayout(False)
        Me.QsoBindingNavigator.PerformLayout()
        CType(Me.QsoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PJCLogBook2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    'Friend WithEvents PJCLogBook2DataSet As PJClient.PJCLogBook2DataSet
    'Friend WithEvents QsoBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents QsoTableAdapter As PJClient.PJCLogBook2DataSetTableAdapters.QsoTableAdapter
    'Friend WithEvents TableAdapterManager As PJClient.PJCLogBook2DataSetTableAdapters.TableAdapterManager
    'Friend WithEvents QsoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QsoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AntennaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExchangeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QsodistanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QsoazmuthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HispowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HisantennaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MoondegrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QsolocatorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QsoUTCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QSOFormatedDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QSODateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImgButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StationTableAdapter As PJClient.PJCLogBook2DataSetTableAdapters.StationTableAdapter
    Friend WithEvents StationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BandComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ShowImgButton As System.Windows.Forms.Button

End Class
