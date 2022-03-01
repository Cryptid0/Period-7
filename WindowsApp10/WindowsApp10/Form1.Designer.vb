<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim AttractionNameLabel As System.Windows.Forms.Label
        Dim AtractionTypeLabel As System.Windows.Forms.Label
        Dim AmenitiesLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim RestaurantsLabel As System.Windows.Forms.Label
        Dim ShoppingLabel As System.Windows.Forms.Label
        Dim Open_CloseLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim Theme_ParkLabel As System.Windows.Forms.Label
        Dim Natural_ParkLabel As System.Windows.Forms.Label
        Dim MuseumLabel As System.Windows.Forms.Label
        Dim ResortLabel As System.Windows.Forms.Label
        Me.ThemeParkButton = New System.Windows.Forms.Button()
        Me.NaturalParkButton = New System.Windows.Forms.Button()
        Me.MuseumButton = New System.Windows.Forms.Button()
        Me.ResortButton = New System.Windows.Forms.Button()
        Me.Tourist_AttractionsAZDataSet = New WindowsApp10.Tourist_AttractionsAZDataSet()
        Me.TouristAttractionsAZBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TouristAttractionsAZTableAdapter = New WindowsApp10.Tourist_AttractionsAZDataSetTableAdapters.TouristAttractionsAZTableAdapter()
        Me.TableAdapterManager = New WindowsApp10.Tourist_AttractionsAZDataSetTableAdapters.TableAdapterManager()
        Me.TouristAttractionsAZBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TouristAttractionsAZBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.AttractionNameTextBox = New System.Windows.Forms.TextBox()
        Me.AtractionTypeTextBox = New System.Windows.Forms.TextBox()
        Me.AmenitiesTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.RestaurantsTextBox = New System.Windows.Forms.TextBox()
        Me.ShoppingTextBox = New System.Windows.Forms.TextBox()
        Me.Open_CloseTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Theme_ParkCheckBox = New System.Windows.Forms.CheckBox()
        Me.Natural_ParkCheckBox = New System.Windows.Forms.CheckBox()
        Me.MuseumCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResortCheckBox = New System.Windows.Forms.CheckBox()
        IDLabel = New System.Windows.Forms.Label()
        AttractionNameLabel = New System.Windows.Forms.Label()
        AtractionTypeLabel = New System.Windows.Forms.Label()
        AmenitiesLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        RestaurantsLabel = New System.Windows.Forms.Label()
        ShoppingLabel = New System.Windows.Forms.Label()
        Open_CloseLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        Theme_ParkLabel = New System.Windows.Forms.Label()
        Natural_ParkLabel = New System.Windows.Forms.Label()
        MuseumLabel = New System.Windows.Forms.Label()
        ResortLabel = New System.Windows.Forms.Label()
        CType(Me.Tourist_AttractionsAZDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TouristAttractionsAZBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TouristAttractionsAZBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TouristAttractionsAZBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ThemeParkButton
        '
        Me.ThemeParkButton.Location = New System.Drawing.Point(497, 44)
        Me.ThemeParkButton.Name = "ThemeParkButton"
        Me.ThemeParkButton.Size = New System.Drawing.Size(75, 23)
        Me.ThemeParkButton.TabIndex = 0
        Me.ThemeParkButton.Text = "Button1"
        Me.ThemeParkButton.UseVisualStyleBackColor = True
        '
        'NaturalParkButton
        '
        Me.NaturalParkButton.Location = New System.Drawing.Point(497, 74)
        Me.NaturalParkButton.Name = "NaturalParkButton"
        Me.NaturalParkButton.Size = New System.Drawing.Size(75, 23)
        Me.NaturalParkButton.TabIndex = 1
        Me.NaturalParkButton.Text = "Button2"
        Me.NaturalParkButton.UseVisualStyleBackColor = True
        '
        'MuseumButton
        '
        Me.MuseumButton.Location = New System.Drawing.Point(497, 104)
        Me.MuseumButton.Name = "MuseumButton"
        Me.MuseumButton.Size = New System.Drawing.Size(75, 23)
        Me.MuseumButton.TabIndex = 2
        Me.MuseumButton.Text = "Button3"
        Me.MuseumButton.UseVisualStyleBackColor = True
        '
        'ResortButton
        '
        Me.ResortButton.Location = New System.Drawing.Point(497, 134)
        Me.ResortButton.Name = "ResortButton"
        Me.ResortButton.Size = New System.Drawing.Size(75, 23)
        Me.ResortButton.TabIndex = 3
        Me.ResortButton.Text = "Button4"
        Me.ResortButton.UseVisualStyleBackColor = True
        '
        'Tourist_AttractionsAZDataSet
        '
        Me.Tourist_AttractionsAZDataSet.DataSetName = "Tourist_AttractionsAZDataSet"
        Me.Tourist_AttractionsAZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TouristAttractionsAZBindingSource
        '
        Me.TouristAttractionsAZBindingSource.DataMember = "TouristAttractionsAZ"
        Me.TouristAttractionsAZBindingSource.DataSource = Me.Tourist_AttractionsAZDataSet
        '
        'TouristAttractionsAZTableAdapter
        '
        Me.TouristAttractionsAZTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TouristAttractionsAZTableAdapter = Me.TouristAttractionsAZTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp10.Tourist_AttractionsAZDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TouristAttractionsAZBindingNavigator
        '
        Me.TouristAttractionsAZBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TouristAttractionsAZBindingNavigator.BindingSource = Me.TouristAttractionsAZBindingSource
        Me.TouristAttractionsAZBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TouristAttractionsAZBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TouristAttractionsAZBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TouristAttractionsAZBindingNavigatorSaveItem})
        Me.TouristAttractionsAZBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TouristAttractionsAZBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TouristAttractionsAZBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TouristAttractionsAZBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TouristAttractionsAZBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TouristAttractionsAZBindingNavigator.Name = "TouristAttractionsAZBindingNavigator"
        Me.TouristAttractionsAZBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TouristAttractionsAZBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TouristAttractionsAZBindingNavigator.TabIndex = 4
        Me.TouristAttractionsAZBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TouristAttractionsAZBindingNavigatorSaveItem
        '
        Me.TouristAttractionsAZBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TouristAttractionsAZBindingNavigatorSaveItem.Image = CType(resources.GetObject("TouristAttractionsAZBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TouristAttractionsAZBindingNavigatorSaveItem.Name = "TouristAttractionsAZBindingNavigatorSaveItem"
        Me.TouristAttractionsAZBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TouristAttractionsAZBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(88, 53)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 5
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(180, 50)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IDTextBox.TabIndex = 6
        '
        'AttractionNameLabel
        '
        AttractionNameLabel.AutoSize = True
        AttractionNameLabel.Location = New System.Drawing.Point(88, 79)
        AttractionNameLabel.Name = "AttractionNameLabel"
        AttractionNameLabel.Size = New System.Drawing.Size(86, 13)
        AttractionNameLabel.TabIndex = 7
        AttractionNameLabel.Text = "Attraction Name:"
        '
        'AttractionNameTextBox
        '
        Me.AttractionNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "AttractionName", True))
        Me.AttractionNameTextBox.Location = New System.Drawing.Point(180, 76)
        Me.AttractionNameTextBox.Name = "AttractionNameTextBox"
        Me.AttractionNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.AttractionNameTextBox.TabIndex = 8
        '
        'AtractionTypeLabel
        '
        AtractionTypeLabel.AutoSize = True
        AtractionTypeLabel.Location = New System.Drawing.Point(88, 105)
        AtractionTypeLabel.Name = "AtractionTypeLabel"
        AtractionTypeLabel.Size = New System.Drawing.Size(79, 13)
        AtractionTypeLabel.TabIndex = 9
        AtractionTypeLabel.Text = "Atraction Type:"
        '
        'AtractionTypeTextBox
        '
        Me.AtractionTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "AtractionType", True))
        Me.AtractionTypeTextBox.Location = New System.Drawing.Point(180, 102)
        Me.AtractionTypeTextBox.Name = "AtractionTypeTextBox"
        Me.AtractionTypeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.AtractionTypeTextBox.TabIndex = 10
        '
        'AmenitiesLabel
        '
        AmenitiesLabel.AutoSize = True
        AmenitiesLabel.Location = New System.Drawing.Point(88, 131)
        AmenitiesLabel.Name = "AmenitiesLabel"
        AmenitiesLabel.Size = New System.Drawing.Size(55, 13)
        AmenitiesLabel.TabIndex = 11
        AmenitiesLabel.Text = "Amenities:"
        '
        'AmenitiesTextBox
        '
        Me.AmenitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "Amenities", True))
        Me.AmenitiesTextBox.Location = New System.Drawing.Point(180, 128)
        Me.AmenitiesTextBox.Name = "AmenitiesTextBox"
        Me.AmenitiesTextBox.Size = New System.Drawing.Size(104, 20)
        Me.AmenitiesTextBox.TabIndex = 12
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(88, 157)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 13
        CostLabel.Text = "Cost:"
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(180, 154)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CostTextBox.TabIndex = 14
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(88, 183)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 15
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(180, 180)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(104, 20)
        Me.LocationTextBox.TabIndex = 16
        '
        'RestaurantsLabel
        '
        RestaurantsLabel.AutoSize = True
        RestaurantsLabel.Location = New System.Drawing.Point(88, 209)
        RestaurantsLabel.Name = "RestaurantsLabel"
        RestaurantsLabel.Size = New System.Drawing.Size(67, 13)
        RestaurantsLabel.TabIndex = 17
        RestaurantsLabel.Text = "Restaurants:"
        '
        'RestaurantsTextBox
        '
        Me.RestaurantsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "Restaurants", True))
        Me.RestaurantsTextBox.Location = New System.Drawing.Point(180, 206)
        Me.RestaurantsTextBox.Name = "RestaurantsTextBox"
        Me.RestaurantsTextBox.Size = New System.Drawing.Size(104, 20)
        Me.RestaurantsTextBox.TabIndex = 18
        '
        'ShoppingLabel
        '
        ShoppingLabel.AutoSize = True
        ShoppingLabel.Location = New System.Drawing.Point(88, 235)
        ShoppingLabel.Name = "ShoppingLabel"
        ShoppingLabel.Size = New System.Drawing.Size(55, 13)
        ShoppingLabel.TabIndex = 19
        ShoppingLabel.Text = "Shopping:"
        '
        'ShoppingTextBox
        '
        Me.ShoppingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "Shopping", True))
        Me.ShoppingTextBox.Location = New System.Drawing.Point(180, 232)
        Me.ShoppingTextBox.Name = "ShoppingTextBox"
        Me.ShoppingTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ShoppingTextBox.TabIndex = 20
        '
        'Open_CloseLabel
        '
        Open_CloseLabel.AutoSize = True
        Open_CloseLabel.Location = New System.Drawing.Point(88, 261)
        Open_CloseLabel.Name = "Open_CloseLabel"
        Open_CloseLabel.Size = New System.Drawing.Size(65, 13)
        Open_CloseLabel.TabIndex = 21
        Open_CloseLabel.Text = "Open-Close:"
        '
        'Open_CloseTextBox
        '
        Me.Open_CloseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "Open-Close", True))
        Me.Open_CloseTextBox.Location = New System.Drawing.Point(180, 258)
        Me.Open_CloseTextBox.Name = "Open_CloseTextBox"
        Me.Open_CloseTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Open_CloseTextBox.TabIndex = 22
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(88, 287)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 23
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TouristAttractionsAZBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(180, 284)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PhoneNumberTextBox.TabIndex = 24
        '
        'Theme_ParkLabel
        '
        Theme_ParkLabel.AutoSize = True
        Theme_ParkLabel.Location = New System.Drawing.Point(88, 315)
        Theme_ParkLabel.Name = "Theme_ParkLabel"
        Theme_ParkLabel.Size = New System.Drawing.Size(68, 13)
        Theme_ParkLabel.TabIndex = 25
        Theme_ParkLabel.Text = "Theme Park:"
        '
        'Theme_ParkCheckBox
        '
        Me.Theme_ParkCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TouristAttractionsAZBindingSource, "Theme Park", True))
        Me.Theme_ParkCheckBox.Location = New System.Drawing.Point(180, 310)
        Me.Theme_ParkCheckBox.Name = "Theme_ParkCheckBox"
        Me.Theme_ParkCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Theme_ParkCheckBox.TabIndex = 26
        Me.Theme_ParkCheckBox.Text = "CheckBox1"
        Me.Theme_ParkCheckBox.UseVisualStyleBackColor = True
        '
        'Natural_ParkLabel
        '
        Natural_ParkLabel.AutoSize = True
        Natural_ParkLabel.Location = New System.Drawing.Point(88, 345)
        Natural_ParkLabel.Name = "Natural_ParkLabel"
        Natural_ParkLabel.Size = New System.Drawing.Size(69, 13)
        Natural_ParkLabel.TabIndex = 27
        Natural_ParkLabel.Text = "Natural Park:"
        '
        'Natural_ParkCheckBox
        '
        Me.Natural_ParkCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TouristAttractionsAZBindingSource, "Natural Park", True))
        Me.Natural_ParkCheckBox.Location = New System.Drawing.Point(180, 340)
        Me.Natural_ParkCheckBox.Name = "Natural_ParkCheckBox"
        Me.Natural_ParkCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Natural_ParkCheckBox.TabIndex = 28
        Me.Natural_ParkCheckBox.Text = "CheckBox1"
        Me.Natural_ParkCheckBox.UseVisualStyleBackColor = True
        '
        'MuseumLabel
        '
        MuseumLabel.AutoSize = True
        MuseumLabel.Location = New System.Drawing.Point(88, 375)
        MuseumLabel.Name = "MuseumLabel"
        MuseumLabel.Size = New System.Drawing.Size(50, 13)
        MuseumLabel.TabIndex = 29
        MuseumLabel.Text = "Museum:"
        '
        'MuseumCheckBox
        '
        Me.MuseumCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TouristAttractionsAZBindingSource, "Museum", True))
        Me.MuseumCheckBox.Location = New System.Drawing.Point(180, 370)
        Me.MuseumCheckBox.Name = "MuseumCheckBox"
        Me.MuseumCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.MuseumCheckBox.TabIndex = 30
        Me.MuseumCheckBox.Text = "CheckBox1"
        Me.MuseumCheckBox.UseVisualStyleBackColor = True
        '
        'ResortLabel
        '
        ResortLabel.AutoSize = True
        ResortLabel.Location = New System.Drawing.Point(88, 405)
        ResortLabel.Name = "ResortLabel"
        ResortLabel.Size = New System.Drawing.Size(41, 13)
        ResortLabel.TabIndex = 31
        ResortLabel.Text = "Resort:"
        '
        'ResortCheckBox
        '
        Me.ResortCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TouristAttractionsAZBindingSource, "Resort", True))
        Me.ResortCheckBox.Location = New System.Drawing.Point(180, 400)
        Me.ResortCheckBox.Name = "ResortCheckBox"
        Me.ResortCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ResortCheckBox.TabIndex = 32
        Me.ResortCheckBox.Text = "CheckBox1"
        Me.ResortCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(AttractionNameLabel)
        Me.Controls.Add(Me.AttractionNameTextBox)
        Me.Controls.Add(AtractionTypeLabel)
        Me.Controls.Add(Me.AtractionTypeTextBox)
        Me.Controls.Add(AmenitiesLabel)
        Me.Controls.Add(Me.AmenitiesTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(RestaurantsLabel)
        Me.Controls.Add(Me.RestaurantsTextBox)
        Me.Controls.Add(ShoppingLabel)
        Me.Controls.Add(Me.ShoppingTextBox)
        Me.Controls.Add(Open_CloseLabel)
        Me.Controls.Add(Me.Open_CloseTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Theme_ParkLabel)
        Me.Controls.Add(Me.Theme_ParkCheckBox)
        Me.Controls.Add(Natural_ParkLabel)
        Me.Controls.Add(Me.Natural_ParkCheckBox)
        Me.Controls.Add(MuseumLabel)
        Me.Controls.Add(Me.MuseumCheckBox)
        Me.Controls.Add(ResortLabel)
        Me.Controls.Add(Me.ResortCheckBox)
        Me.Controls.Add(Me.TouristAttractionsAZBindingNavigator)
        Me.Controls.Add(Me.ResortButton)
        Me.Controls.Add(Me.MuseumButton)
        Me.Controls.Add(Me.NaturalParkButton)
        Me.Controls.Add(Me.ThemeParkButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Tourist_AttractionsAZDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TouristAttractionsAZBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TouristAttractionsAZBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TouristAttractionsAZBindingNavigator.ResumeLayout(False)
        Me.TouristAttractionsAZBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThemeParkButton As Button
    Friend WithEvents NaturalParkButton As Button
    Friend WithEvents MuseumButton As Button
    Friend WithEvents ResortButton As Button
    Friend WithEvents Tourist_AttractionsAZDataSet As Tourist_AttractionsAZDataSet
    Friend WithEvents TouristAttractionsAZBindingSource As BindingSource
    Friend WithEvents TouristAttractionsAZTableAdapter As Tourist_AttractionsAZDataSetTableAdapters.TouristAttractionsAZTableAdapter
    Friend WithEvents TableAdapterManager As Tourist_AttractionsAZDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TouristAttractionsAZBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TouristAttractionsAZBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents AttractionNameTextBox As TextBox
    Friend WithEvents AtractionTypeTextBox As TextBox
    Friend WithEvents AmenitiesTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents RestaurantsTextBox As TextBox
    Friend WithEvents ShoppingTextBox As TextBox
    Friend WithEvents Open_CloseTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Theme_ParkCheckBox As CheckBox
    Friend WithEvents Natural_ParkCheckBox As CheckBox
    Friend WithEvents MuseumCheckBox As CheckBox
    Friend WithEvents ResortCheckBox As CheckBox
End Class
