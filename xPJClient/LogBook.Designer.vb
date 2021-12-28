<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logbook
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
        Dim CallsignLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim LocatorLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim CountyLabel As System.Windows.Forms.Label
        Dim AntennaLabel As System.Windows.Forms.Label
        Dim PowerLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim PostLabel As System.Windows.Forms.Label
        Dim DistanceLabel As System.Windows.Forms.Label
        Dim AzmuthLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim AddrLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim LatLabel As System.Windows.Forms.Label
        Dim LonLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logbook))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.StationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.StationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PJCLogBook2DataSet = New PJClient.PJCLogBook2DataSet
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
        Me.StationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CallSignToolStripComboBox = New System.Windows.Forms.ToolStripComboBox
        Me.NewQsoToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FileToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADIFImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WSJTLogImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADIFExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.CallsignTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.LocatorTextBox = New System.Windows.Forms.TextBox
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.CountyTextBox = New System.Windows.Forms.TextBox
        Me.AntennaTextBox = New System.Windows.Forms.TextBox
        Me.PowerTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.WebTextBox = New System.Windows.Forms.TextBox
        Me.DistanceTextBox = New System.Windows.Forms.TextBox
        Me.AzmuthTextBox = New System.Windows.Forms.TextBox
        Me.QsoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StationTableAdapter = New PJClient.PJCLogBook2DataSetTableAdapters.StationTableAdapter
        Me.TableAdapterManager = New PJClient.PJCLogBook2DataSetTableAdapters.TableAdapterManager
        Me.QsoTableAdapter = New PJClient.PJCLogBook2DataSetTableAdapters.QsoTableAdapter
        Me.LastPostTextBox = New System.Windows.Forms.TextBox
        Me.TimeSincePostLabel = New System.Windows.Forms.Label
        Me.QsoDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QRZButton = New System.Windows.Forms.Button
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.AddrTextBox = New System.Windows.Forms.TextBox
        Me.ZipTextBox = New System.Windows.Forms.TextBox
        Me.LatTextBox = New System.Windows.Forms.TextBox
        Me.LonTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        IdLabel = New System.Windows.Forms.Label
        CallsignLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        LocatorLabel = New System.Windows.Forms.Label
        StateLabel = New System.Windows.Forms.Label
        CountryLabel = New System.Windows.Forms.Label
        CountyLabel = New System.Windows.Forms.Label
        AntennaLabel = New System.Windows.Forms.Label
        PowerLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        WebLabel = New System.Windows.Forms.Label
        PostLabel = New System.Windows.Forms.Label
        DistanceLabel = New System.Windows.Forms.Label
        AzmuthLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        AddrLabel = New System.Windows.Forms.Label
        ZipLabel = New System.Windows.Forms.Label
        LatLabel = New System.Windows.Forms.Label
        LonLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.StationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StationBindingNavigator.SuspendLayout()
        CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PJCLogBook2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QsoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QsoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(63, 53)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "id:"
        '
        'CallsignLabel
        '
        CallsignLabel.AutoSize = True
        CallsignLabel.Location = New System.Drawing.Point(63, 79)
        CallsignLabel.Name = "CallsignLabel"
        CallsignLabel.Size = New System.Drawing.Size(45, 13)
        CallsignLabel.TabIndex = 4
        CallsignLabel.Text = "callsign:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(63, 105)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(36, 13)
        NameLabel.TabIndex = 6
        NameLabel.Text = "name:"
        '
        'LocatorLabel
        '
        LocatorLabel.AutoSize = True
        LocatorLabel.Location = New System.Drawing.Point(357, 183)
        LocatorLabel.Name = "LocatorLabel"
        LocatorLabel.Size = New System.Drawing.Size(42, 13)
        LocatorLabel.TabIndex = 8
        LocatorLabel.Text = "locator:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(63, 183)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(33, 13)
        StateLabel.TabIndex = 10
        StateLabel.Text = "state:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(63, 235)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(45, 13)
        CountryLabel.TabIndex = 12
        CountryLabel.Text = "country:"
        '
        'CountyLabel
        '
        CountyLabel.AutoSize = True
        CountyLabel.Location = New System.Drawing.Point(63, 209)
        CountyLabel.Name = "CountyLabel"
        CountyLabel.Size = New System.Drawing.Size(42, 13)
        CountyLabel.TabIndex = 14
        CountyLabel.Text = "county:"
        '
        'AntennaLabel
        '
        AntennaLabel.AutoSize = True
        AntennaLabel.Location = New System.Drawing.Point(357, 79)
        AntennaLabel.Name = "AntennaLabel"
        AntennaLabel.Size = New System.Drawing.Size(49, 13)
        AntennaLabel.TabIndex = 16
        AntennaLabel.Text = "antenna:"
        '
        'PowerLabel
        '
        PowerLabel.AutoSize = True
        PowerLabel.Location = New System.Drawing.Point(357, 105)
        PowerLabel.Name = "PowerLabel"
        PowerLabel.Size = New System.Drawing.Size(39, 13)
        PowerLabel.TabIndex = 18
        PowerLabel.Text = "power:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(357, 131)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 20
        EmailLabel.Text = "email:"
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Location = New System.Drawing.Point(357, 157)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(30, 13)
        WebLabel.TabIndex = 22
        WebLabel.Text = "web:"
        '
        'PostLabel
        '
        PostLabel.AutoSize = True
        PostLabel.Location = New System.Drawing.Point(357, 53)
        PostLabel.Name = "PostLabel"
        PostLabel.Size = New System.Drawing.Size(53, 13)
        PostLabel.TabIndex = 24
        PostLabel.Text = "Last post:"
        '
        'DistanceLabel
        '
        DistanceLabel.AutoSize = True
        DistanceLabel.Location = New System.Drawing.Point(500, 209)
        DistanceLabel.Name = "DistanceLabel"
        DistanceLabel.Size = New System.Drawing.Size(50, 13)
        DistanceLabel.TabIndex = 26
        DistanceLabel.Text = "distance:"
        '
        'AzmuthLabel
        '
        AzmuthLabel.AutoSize = True
        AzmuthLabel.Location = New System.Drawing.Point(357, 209)
        AzmuthLabel.Name = "AzmuthLabel"
        AzmuthLabel.Size = New System.Drawing.Size(44, 13)
        AzmuthLabel.TabIndex = 28
        AzmuthLabel.Text = "azmuth:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(63, 157)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(26, 13)
        CityLabel.TabIndex = 33
        CityLabel.Text = "city:"
        '
        'AddrLabel
        '
        AddrLabel.AutoSize = True
        AddrLabel.Location = New System.Drawing.Point(65, 131)
        AddrLabel.Name = "AddrLabel"
        AddrLabel.Size = New System.Drawing.Size(31, 13)
        AddrLabel.TabIndex = 35
        AddrLabel.Text = "addr:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(190, 183)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(23, 13)
        ZipLabel.TabIndex = 37
        ZipLabel.Text = "zip:"
        '
        'LatLabel
        '
        LatLabel.AutoSize = True
        LatLabel.Location = New System.Drawing.Point(375, 235)
        LatLabel.Name = "LatLabel"
        LatLabel.Size = New System.Drawing.Size(21, 13)
        LatLabel.TabIndex = 39
        LatLabel.Text = "lat:"
        '
        'LonLabel
        '
        LonLabel.AutoSize = True
        LonLabel.Location = New System.Drawing.Point(526, 235)
        LonLabel.Name = "LonLabel"
        LonLabel.Size = New System.Drawing.Size(24, 13)
        LonLabel.TabIndex = 41
        LonLabel.Text = "lon:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(597, 519)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'StationBindingNavigator
        '
        Me.StationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StationBindingNavigator.BindingSource = Me.StationBindingSource
        Me.StationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StationBindingNavigatorSaveItem, Me.CallSignToolStripComboBox, Me.NewQsoToolStripButton, Me.FileToolStripDropDownButton})
        Me.StationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StationBindingNavigator.Name = "StationBindingNavigator"
        Me.StationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StationBindingNavigator.Size = New System.Drawing.Size(808, 25)
        Me.StationBindingNavigator.TabIndex = 1
        Me.StationBindingNavigator.Text = "BindingNavigator1"
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
        'StationBindingSource
        '
        Me.StationBindingSource.DataMember = "Station"
        Me.StationBindingSource.DataSource = Me.PJCLogBook2DataSet
        '
        'PJCLogBook2DataSet
        '
        Me.PJCLogBook2DataSet.DataSetName = "PJCLogBook2DataSet"
        Me.PJCLogBook2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'StationBindingNavigatorSaveItem
        '
        Me.StationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StationBindingNavigatorSaveItem.Image = CType(resources.GetObject("StationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StationBindingNavigatorSaveItem.Name = "StationBindingNavigatorSaveItem"
        Me.StationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CallSignToolStripComboBox
        '
        Me.CallSignToolStripComboBox.Name = "CallSignToolStripComboBox"
        Me.CallSignToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'NewQsoToolStripButton
        '
        Me.NewQsoToolStripButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NewQsoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewQsoToolStripButton.Image = CType(resources.GetObject("NewQsoToolStripButton.Image"), System.Drawing.Image)
        Me.NewQsoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewQsoToolStripButton.Name = "NewQsoToolStripButton"
        Me.NewQsoToolStripButton.Size = New System.Drawing.Size(85, 22)
        Me.NewQsoToolStripButton.Text = "Log New QSO"
        '
        'FileToolStripDropDownButton
        '
        Me.FileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.FileToolStripDropDownButton.Image = CType(resources.GetObject("FileToolStripDropDownButton.Image"), System.Drawing.Image)
        Me.FileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileToolStripDropDownButton.Name = "FileToolStripDropDownButton"
        Me.FileToolStripDropDownButton.Size = New System.Drawing.Size(38, 22)
        Me.FileToolStripDropDownButton.Text = "File"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADIFImportToolStripMenuItem, Me.WSJTLogImportToolStripMenuItem})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ADIFImportToolStripMenuItem
        '
        Me.ADIFImportToolStripMenuItem.Name = "ADIFImportToolStripMenuItem"
        Me.ADIFImportToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ADIFImportToolStripMenuItem.Text = "ADIF"
        '
        'WSJTLogImportToolStripMenuItem
        '
        Me.WSJTLogImportToolStripMenuItem.Name = "WSJTLogImportToolStripMenuItem"
        Me.WSJTLogImportToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.WSJTLogImportToolStripMenuItem.Text = "WSJT Log"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADIFExportToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ADIFExportToolStripMenuItem
        '
        Me.ADIFExportToolStripMenuItem.Name = "ADIFExportToolStripMenuItem"
        Me.ADIFExportToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ADIFExportToolStripMenuItem.Text = "ADIF"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(119, 50)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(45, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'CallsignTextBox
        '
        Me.CallsignTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "callsign", True))
        Me.CallsignTextBox.Location = New System.Drawing.Point(119, 76)
        Me.CallsignTextBox.Name = "CallsignTextBox"
        Me.CallsignTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CallsignTextBox.TabIndex = 5
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(119, 102)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 7
        '
        'LocatorTextBox
        '
        Me.LocatorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "locator", True))
        Me.LocatorTextBox.Location = New System.Drawing.Point(413, 180)
        Me.LocatorTextBox.Name = "LocatorTextBox"
        Me.LocatorTextBox.Size = New System.Drawing.Size(54, 20)
        Me.LocatorTextBox.TabIndex = 9
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "state", True))
        Me.StateTextBox.Location = New System.Drawing.Point(119, 180)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(45, 20)
        Me.StateTextBox.TabIndex = 11
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(119, 232)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CountryTextBox.TabIndex = 13
        '
        'CountyTextBox
        '
        Me.CountyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "county", True))
        Me.CountyTextBox.Location = New System.Drawing.Point(119, 206)
        Me.CountyTextBox.Name = "CountyTextBox"
        Me.CountyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CountyTextBox.TabIndex = 15
        '
        'AntennaTextBox
        '
        Me.AntennaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "antenna", True))
        Me.AntennaTextBox.Location = New System.Drawing.Point(413, 76)
        Me.AntennaTextBox.Name = "AntennaTextBox"
        Me.AntennaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AntennaTextBox.TabIndex = 17
        '
        'PowerTextBox
        '
        Me.PowerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "power", True))
        Me.PowerTextBox.Location = New System.Drawing.Point(413, 102)
        Me.PowerTextBox.Name = "PowerTextBox"
        Me.PowerTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PowerTextBox.TabIndex = 19
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(413, 128)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 21
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(413, 154)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WebTextBox.TabIndex = 23
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "distance", True))
        Me.DistanceTextBox.Location = New System.Drawing.Point(556, 206)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.Size = New System.Drawing.Size(57, 20)
        Me.DistanceTextBox.TabIndex = 27
        '
        'AzmuthTextBox
        '
        Me.AzmuthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "azmuth", True))
        Me.AzmuthTextBox.Location = New System.Drawing.Point(413, 206)
        Me.AzmuthTextBox.Name = "AzmuthTextBox"
        Me.AzmuthTextBox.Size = New System.Drawing.Size(57, 20)
        Me.AzmuthTextBox.TabIndex = 29
        '
        'QsoBindingSource
        '
        Me.QsoBindingSource.DataMember = "FK_Station_Qso"
        Me.QsoBindingSource.DataSource = Me.StationBindingSource
        '
        'StationTableAdapter
        '
        Me.StationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.QsoTableAdapter = Me.QsoTableAdapter
        Me.TableAdapterManager.StationTableAdapter = Me.StationTableAdapter
        Me.TableAdapterManager.UpdateOrder = PJClient.PJCLogBook2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QsoTableAdapter
        '
        Me.QsoTableAdapter.ClearBeforeFill = True
        '
        'LastPostTextBox
        '
        Me.LastPostTextBox.Location = New System.Drawing.Point(413, 50)
        Me.LastPostTextBox.Name = "LastPostTextBox"
        Me.LastPostTextBox.Size = New System.Drawing.Size(118, 20)
        Me.LastPostTextBox.TabIndex = 31
        '
        'TimeSincePostLabel
        '
        Me.TimeSincePostLabel.AutoSize = True
        Me.TimeSincePostLabel.Location = New System.Drawing.Point(617, 53)
        Me.TimeSincePostLabel.Name = "TimeSincePostLabel"
        Me.TimeSincePostLabel.Size = New System.Drawing.Size(49, 13)
        Me.TimeSincePostLabel.TabIndex = 32
        Me.TimeSincePostLabel.Text = "00:00:00"
        '
        'QsoDataGridView
        '
        Me.QsoDataGridView.AutoGenerateColumns = False
        Me.QsoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QsoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxID, Me.DataGridViewTextBoxColumn16})
        Me.QsoDataGridView.DataSource = Me.QsoBindingSource
        Me.QsoDataGridView.Location = New System.Drawing.Point(34, 269)
        Me.QsoDataGridView.Name = "QsoDataGridView"
        Me.QsoDataGridView.Size = New System.Drawing.Size(709, 220)
        Me.QsoDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "qsodate"
        Me.DataGridViewTextBoxColumn17.HeaderText = "qsodate"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "qsoUTC"
        Me.DataGridViewTextBoxColumn19.HeaderText = "qsoUTC"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "band"
        Me.DataGridViewTextBoxColumn2.HeaderText = "band"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "mode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "mode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "report"
        Me.DataGridViewTextBoxColumn6.HeaderText = "report"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "sent"
        Me.DataGridViewTextBoxColumn20.HeaderText = "sent"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "power"
        Me.DataGridViewTextBoxColumn4.HeaderText = "power"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "qsolocator"
        Me.DataGridViewTextBoxColumn18.HeaderText = "grid"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "qsodistance"
        Me.DataGridViewTextBoxColumn8.HeaderText = "dist"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "qsoazmuth"
        Me.DataGridViewTextBoxColumn9.HeaderText = "az"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "antenna"
        Me.DataGridViewTextBoxColumn5.HeaderText = "antenna"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "exchange"
        Me.DataGridViewTextBoxColumn7.HeaderText = "exchange"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "hispower"
        Me.DataGridViewTextBoxColumn12.HeaderText = "hispower"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "hisantenna"
        Me.DataGridViewTextBoxColumn13.HeaderText = "hisantenna"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "moondegr"
        Me.DataGridViewTextBoxColumn14.HeaderText = "moondegr"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "shower"
        Me.DataGridViewTextBoxColumn15.HeaderText = "shower"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxID
        '
        Me.DataGridViewTextBoxID.DataPropertyName = "id"
        Me.DataGridViewTextBoxID.HeaderText = "id"
        Me.DataGridViewTextBoxID.Name = "DataGridViewTextBoxID"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "stationID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "stationID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'QRZButton
        '
        Me.QRZButton.Location = New System.Drawing.Point(221, 43)
        Me.QRZButton.Name = "QRZButton"
        Me.QRZButton.Size = New System.Drawing.Size(82, 26)
        Me.QRZButton.TabIndex = 33
        Me.QRZButton.Text = "QRZ..."
        Me.QRZButton.UseVisualStyleBackColor = True
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "city", True))
        Me.CityTextBox.Location = New System.Drawing.Point(119, 154)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 34
        '
        'AddrTextBox
        '
        Me.AddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "addr", True))
        Me.AddrTextBox.Location = New System.Drawing.Point(119, 128)
        Me.AddrTextBox.Name = "AddrTextBox"
        Me.AddrTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddrTextBox.TabIndex = 36
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(219, 180)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipTextBox.TabIndex = 38
        '
        'LatTextBox
        '
        Me.LatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "lat", True))
        Me.LatTextBox.Location = New System.Drawing.Point(413, 232)
        Me.LatTextBox.Name = "LatTextBox"
        Me.LatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LatTextBox.TabIndex = 40
        '
        'LonTextBox
        '
        Me.LonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StationBindingSource, "lon", True))
        Me.LonTextBox.Location = New System.Drawing.Point(556, 232)
        Me.LonTextBox.Name = "LonTextBox"
        Me.LonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LonTextBox.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Elapsed Time:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 572)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(808, 22)
        Me.StatusStrip1.TabIndex = 44
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Logbook
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(808, 594)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(LonLabel)
        Me.Controls.Add(Me.LonTextBox)
        Me.Controls.Add(LatLabel)
        Me.Controls.Add(Me.LatTextBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(AddrLabel)
        Me.Controls.Add(Me.AddrTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.QRZButton)
        Me.Controls.Add(Me.QsoDataGridView)
        Me.Controls.Add(Me.TimeSincePostLabel)
        Me.Controls.Add(Me.LastPostTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(CallsignLabel)
        Me.Controls.Add(Me.CallsignTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(LocatorLabel)
        Me.Controls.Add(Me.LocatorTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(CountyLabel)
        Me.Controls.Add(Me.CountyTextBox)
        Me.Controls.Add(AntennaLabel)
        Me.Controls.Add(Me.AntennaTextBox)
        Me.Controls.Add(PowerLabel)
        Me.Controls.Add(Me.PowerTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(WebLabel)
        Me.Controls.Add(Me.WebTextBox)
        Me.Controls.Add(PostLabel)
        Me.Controls.Add(DistanceLabel)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(AzmuthLabel)
        Me.Controls.Add(Me.AzmuthTextBox)
        Me.Controls.Add(Me.StationBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimizeBox = False
        Me.Name = "Logbook"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Logbook"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.StationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StationBindingNavigator.ResumeLayout(False)
        Me.StationBindingNavigator.PerformLayout()
        CType(Me.StationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PJCLogBook2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QsoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QsoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PJCLogBook2DataSet As Global.PJClient.PJCLogBook2DataSet
    Friend WithEvents StationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StationTableAdapter As Global.PJClient.PJCLogBook2DataSetTableAdapters.StationTableAdapter
    Friend WithEvents TableAdapterManager As Global.PJClient.PJCLogBook2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents StationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QsoTableAdapter As Global.PJClient.PJCLogBook2DataSetTableAdapters.QsoTableAdapter
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CallsignTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocatorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AntennaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AzmuthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QsoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CallSignToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents NewQsoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LastPostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeSincePostLabel As System.Windows.Forms.Label
    Friend WithEvents QsoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QRZButton As System.Windows.Forms.Button
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FileToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADIFImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WSJTLogImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADIFExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar

End Class
