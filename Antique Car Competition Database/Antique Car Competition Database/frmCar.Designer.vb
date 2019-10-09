<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCar
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
        Me.components = New System.ComponentModel.Container()
        Dim Contestant_IDLabel As System.Windows.Forms.Label
        Dim Car_YearLabel As System.Windows.Forms.Label
        Dim Car_ModelLabel As System.Windows.Forms.Label
        Dim Owner_NameLabel As System.Windows.Forms.Label
        Dim HometownLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCar))
        Me.CarDataSet = New Antique_Car_Competition_Database.CarDataSet()
        Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarsTableAdapter = New Antique_Car_Competition_Database.CarDataSetTableAdapters.CarsTableAdapter()
        Me.TableAdapterManager = New Antique_Car_Competition_Database.CarDataSetTableAdapters.TableAdapterManager()
        Me.CarsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CarsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Contestant_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Car_YearTextBox = New System.Windows.Forms.TextBox()
        Me.Car_ModelTextBox = New System.Windows.Forms.TextBox()
        Me.Owner_NameTextBox = New System.Windows.Forms.TextBox()
        Me.HometownTextBox = New System.Windows.Forms.TextBox()
        Me.picCar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Contestant_IDLabel = New System.Windows.Forms.Label()
        Car_YearLabel = New System.Windows.Forms.Label()
        Car_ModelLabel = New System.Windows.Forms.Label()
        Owner_NameLabel = New System.Windows.Forms.Label()
        HometownLabel = New System.Windows.Forms.Label()
        CType(Me.CarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarsBindingNavigator.SuspendLayout()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Contestant_IDLabel
        '
        Contestant_IDLabel.AutoSize = True
        Contestant_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contestant_IDLabel.Location = New System.Drawing.Point(29, 145)
        Contestant_IDLabel.Name = "Contestant_IDLabel"
        Contestant_IDLabel.Size = New System.Drawing.Size(139, 24)
        Contestant_IDLabel.TabIndex = 1
        Contestant_IDLabel.Text = "Contestant ID:"
        '
        'Car_YearLabel
        '
        Car_YearLabel.AutoSize = True
        Car_YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_YearLabel.Location = New System.Drawing.Point(29, 191)
        Car_YearLabel.Name = "Car_YearLabel"
        Car_YearLabel.Size = New System.Drawing.Size(97, 24)
        Car_YearLabel.TabIndex = 3
        Car_YearLabel.Text = "Car Year:"
        '
        'Car_ModelLabel
        '
        Car_ModelLabel.AutoSize = True
        Car_ModelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_ModelLabel.Location = New System.Drawing.Point(29, 240)
        Car_ModelLabel.Name = "Car_ModelLabel"
        Car_ModelLabel.Size = New System.Drawing.Size(112, 24)
        Car_ModelLabel.TabIndex = 5
        Car_ModelLabel.Text = "Car Model:"
        '
        'Owner_NameLabel
        '
        Owner_NameLabel.AutoSize = True
        Owner_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Owner_NameLabel.Location = New System.Drawing.Point(29, 293)
        Owner_NameLabel.Name = "Owner_NameLabel"
        Owner_NameLabel.Size = New System.Drawing.Size(139, 24)
        Owner_NameLabel.TabIndex = 7
        Owner_NameLabel.Text = "Owner Name:"
        '
        'HometownLabel
        '
        HometownLabel.AutoSize = True
        HometownLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HometownLabel.Location = New System.Drawing.Point(29, 344)
        HometownLabel.Name = "HometownLabel"
        HometownLabel.Size = New System.Drawing.Size(116, 24)
        HometownLabel.TabIndex = 9
        HometownLabel.Text = "Hometown:"
        '
        'CarDataSet
        '
        Me.CarDataSet.DataSetName = "CarDataSet"
        Me.CarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarsBindingSource
        '
        Me.CarsBindingSource.DataMember = "Cars"
        Me.CarsBindingSource.DataSource = Me.CarDataSet
        '
        'CarsTableAdapter
        '
        Me.CarsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarsTableAdapter = Me.CarsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Antique_Car_Competition_Database.CarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarsBindingNavigator
        '
        Me.CarsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CarsBindingNavigator.BindingSource = Me.CarsBindingSource
        Me.CarsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CarsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CarsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CarsBindingNavigatorSaveItem})
        Me.CarsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CarsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CarsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CarsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CarsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CarsBindingNavigator.Name = "CarsBindingNavigator"
        Me.CarsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CarsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CarsBindingNavigator.TabIndex = 0
        Me.CarsBindingNavigator.Text = "BindingNavigator1"
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
        'CarsBindingNavigatorSaveItem
        '
        Me.CarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CarsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CarsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CarsBindingNavigatorSaveItem.Name = "CarsBindingNavigatorSaveItem"
        Me.CarsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CarsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Contestant_IDTextBox
        '
        Me.Contestant_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Contestant ID", True))
        Me.Contestant_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contestant_IDTextBox.Location = New System.Drawing.Point(183, 142)
        Me.Contestant_IDTextBox.Name = "Contestant_IDTextBox"
        Me.Contestant_IDTextBox.Size = New System.Drawing.Size(58, 29)
        Me.Contestant_IDTextBox.TabIndex = 2
        '
        'Car_YearTextBox
        '
        Me.Car_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Car Year", True))
        Me.Car_YearTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_YearTextBox.Location = New System.Drawing.Point(183, 188)
        Me.Car_YearTextBox.Name = "Car_YearTextBox"
        Me.Car_YearTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Car_YearTextBox.TabIndex = 4
        '
        'Car_ModelTextBox
        '
        Me.Car_ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Car Model", True))
        Me.Car_ModelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_ModelTextBox.Location = New System.Drawing.Point(183, 237)
        Me.Car_ModelTextBox.Name = "Car_ModelTextBox"
        Me.Car_ModelTextBox.Size = New System.Drawing.Size(146, 29)
        Me.Car_ModelTextBox.TabIndex = 6
        '
        'Owner_NameTextBox
        '
        Me.Owner_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Owner Name", True))
        Me.Owner_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owner_NameTextBox.Location = New System.Drawing.Point(183, 290)
        Me.Owner_NameTextBox.Name = "Owner_NameTextBox"
        Me.Owner_NameTextBox.Size = New System.Drawing.Size(146, 29)
        Me.Owner_NameTextBox.TabIndex = 8
        '
        'HometownTextBox
        '
        Me.HometownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarsBindingSource, "Hometown", True))
        Me.HometownTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HometownTextBox.Location = New System.Drawing.Point(183, 344)
        Me.HometownTextBox.Name = "HometownTextBox"
        Me.HometownTextBox.Size = New System.Drawing.Size(146, 29)
        Me.HometownTextBox.TabIndex = 10
        '
        'picCar
        '
        Me.picCar.Image = Global.Antique_Car_Competition_Database.My.Resources.Resources.car
        Me.picCar.Location = New System.Drawing.Point(457, 69)
        Me.picCar.Name = "picCar"
        Me.picCar.Size = New System.Drawing.Size(343, 381)
        Me.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar.TabIndex = 11
        Me.picCar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Violet
        Me.Label1.Location = New System.Drawing.Point(27, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 36)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Antique Car Top Ten Finalists"
        '
        'frmCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picCar)
        Me.Controls.Add(HometownLabel)
        Me.Controls.Add(Me.HometownTextBox)
        Me.Controls.Add(Owner_NameLabel)
        Me.Controls.Add(Me.Owner_NameTextBox)
        Me.Controls.Add(Car_ModelLabel)
        Me.Controls.Add(Me.Car_ModelTextBox)
        Me.Controls.Add(Car_YearLabel)
        Me.Controls.Add(Me.Car_YearTextBox)
        Me.Controls.Add(Contestant_IDLabel)
        Me.Controls.Add(Me.Contestant_IDTextBox)
        Me.Controls.Add(Me.CarsBindingNavigator)
        Me.Name = "frmCar"
        Me.Text = "Anqiue Car Competition Database"
        CType(Me.CarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarsBindingNavigator.ResumeLayout(False)
        Me.CarsBindingNavigator.PerformLayout()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarDataSet As CarDataSet
    Friend WithEvents CarsBindingSource As BindingSource
    Friend WithEvents CarsTableAdapter As CarDataSetTableAdapters.CarsTableAdapter
    Friend WithEvents TableAdapterManager As CarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarsBindingNavigator As BindingNavigator
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
    Friend WithEvents CarsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Contestant_IDTextBox As TextBox
    Friend WithEvents Car_YearTextBox As TextBox
    Friend WithEvents Car_ModelTextBox As TextBox
    Friend WithEvents Owner_NameTextBox As TextBox
    Friend WithEvents HometownTextBox As TextBox
    Friend WithEvents picCar As PictureBox
    Friend WithEvents Label1 As Label
End Class
