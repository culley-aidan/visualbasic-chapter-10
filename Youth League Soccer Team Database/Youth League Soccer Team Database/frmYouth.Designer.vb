<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYouth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYouth))
        Dim Player_NumberLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Parent_Name_s_Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim Zip_CodeLabel As System.Windows.Forms.Label
        Dim Telephone_NumberLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SoccerDataSet = New Youth_League_Soccer_Team_Database.SoccerDataSet()
        Me.TeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamTableAdapter = New Youth_League_Soccer_Team_Database.SoccerDataSetTableAdapters.TeamTableAdapter()
        Me.TableAdapterManager = New Youth_League_Soccer_Team_Database.SoccerDataSetTableAdapters.TableAdapterManager()
        Me.TeamBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TeamBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Player_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Parent_Name_s_TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.Zip_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.btnAges = New System.Windows.Forms.Button()
        Me.lblAge = New System.Windows.Forms.Label()
        Player_NumberLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Parent_Name_s_Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        Zip_CodeLabel = New System.Windows.Forms.Label()
        Telephone_NumberLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        CType(Me.SoccerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeamBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 39)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(315, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Youth League Soccer Team Database"
        '
        'SoccerDataSet
        '
        Me.SoccerDataSet.DataSetName = "SoccerDataSet"
        Me.SoccerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeamBindingSource
        '
        Me.TeamBindingSource.DataMember = "Team"
        Me.TeamBindingSource.DataSource = Me.SoccerDataSet
        '
        'TeamTableAdapter
        '
        Me.TeamTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TeamTableAdapter = Me.TeamTableAdapter
        Me.TableAdapterManager.UpdateOrder = Youth_League_Soccer_Team_Database.SoccerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TeamBindingNavigator
        '
        Me.TeamBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TeamBindingNavigator.BindingSource = Me.TeamBindingSource
        Me.TeamBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TeamBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TeamBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TeamBindingNavigatorSaveItem})
        Me.TeamBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TeamBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TeamBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TeamBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TeamBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TeamBindingNavigator.Name = "TeamBindingNavigator"
        Me.TeamBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TeamBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TeamBindingNavigator.TabIndex = 1
        Me.TeamBindingNavigator.Text = "BindingNavigator1"
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
        'TeamBindingNavigatorSaveItem
        '
        Me.TeamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TeamBindingNavigatorSaveItem.Image = CType(resources.GetObject("TeamBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TeamBindingNavigatorSaveItem.Name = "TeamBindingNavigatorSaveItem"
        Me.TeamBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TeamBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Player_NumberLabel
        '
        Player_NumberLabel.AutoSize = True
        Player_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Player_NumberLabel.Location = New System.Drawing.Point(13, 123)
        Player_NumberLabel.Name = "Player_NumberLabel"
        Player_NumberLabel.Size = New System.Drawing.Size(101, 16)
        Player_NumberLabel.TabIndex = 2
        Player_NumberLabel.Text = "Player Number:"
        '
        'Player_NumberTextBox
        '
        Me.Player_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Player Number", True))
        Me.Player_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player_NumberTextBox.Location = New System.Drawing.Point(120, 120)
        Me.Player_NumberTextBox.Name = "Player_NumberTextBox"
        Me.Player_NumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Player_NumberTextBox.TabIndex = 3
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(38, 173)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(76, 16)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(120, 169)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.First_NameTextBox.TabIndex = 5
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(38, 220)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(76, 16)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(120, 219)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'Parent_Name_s_Label
        '
        Parent_Name_s_Label.AutoSize = True
        Parent_Name_s_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Parent_Name_s_Label.Location = New System.Drawing.Point(9, 274)
        Parent_Name_s_Label.Name = "Parent_Name_s_Label"
        Parent_Name_s_Label.Size = New System.Drawing.Size(105, 16)
        Parent_Name_s_Label.TabIndex = 8
        Parent_Name_s_Label.Text = "Parent Name(s):"
        '
        'Parent_Name_s_TextBox
        '
        Me.Parent_Name_s_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Parent Name(s)", True))
        Me.Parent_Name_s_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parent_Name_s_TextBox.Location = New System.Drawing.Point(120, 273)
        Me.Parent_Name_s_TextBox.Name = "Parent_Name_s_TextBox"
        Me.Parent_Name_s_TextBox.Size = New System.Drawing.Size(207, 22)
        Me.Parent_Name_s_TextBox.TabIndex = 9
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(81, 325)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(33, 16)
        CityLabel.TabIndex = 10
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(120, 321)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(207, 22)
        Me.CityTextBox.TabIndex = 11
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(562, 274)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(42, 16)
        StateLabel.TabIndex = 12
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "State", True))
        Me.StateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateTextBox.Location = New System.Drawing.Point(619, 267)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(169, 22)
        Me.StateTextBox.TabIndex = 13
        '
        'Zip_CodeLabel
        '
        Zip_CodeLabel.AutoSize = True
        Zip_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Zip_CodeLabel.Location = New System.Drawing.Point(538, 126)
        Zip_CodeLabel.Name = "Zip_CodeLabel"
        Zip_CodeLabel.Size = New System.Drawing.Size(66, 16)
        Zip_CodeLabel.TabIndex = 14
        Zip_CodeLabel.Text = "Zip Code:"
        '
        'Zip_CodeTextBox
        '
        Me.Zip_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Zip Code", True))
        Me.Zip_CodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zip_CodeTextBox.Location = New System.Drawing.Point(688, 120)
        Me.Zip_CodeTextBox.Name = "Zip_CodeTextBox"
        Me.Zip_CodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Zip_CodeTextBox.TabIndex = 15
        '
        'Telephone_NumberLabel
        '
        Telephone_NumberLabel.AutoSize = True
        Telephone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone_NumberLabel.Location = New System.Drawing.Point(476, 172)
        Telephone_NumberLabel.Name = "Telephone_NumberLabel"
        Telephone_NumberLabel.Size = New System.Drawing.Size(128, 16)
        Telephone_NumberLabel.TabIndex = 16
        Telephone_NumberLabel.Text = "Telephone Number:"
        '
        'Telephone_NumberTextBox
        '
        Me.Telephone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Telephone Number", True))
        Me.Telephone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone_NumberTextBox.Location = New System.Drawing.Point(619, 169)
        Me.Telephone_NumberTextBox.Name = "Telephone_NumberTextBox"
        Me.Telephone_NumberTextBox.Size = New System.Drawing.Size(169, 22)
        Me.Telephone_NumberTextBox.TabIndex = 17
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(568, 213)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(36, 16)
        AgeLabel.TabIndex = 18
        AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(688, 210)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AgeTextBox.TabIndex = 19
        '
        'btnAges
        '
        Me.btnAges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAges.Location = New System.Drawing.Point(383, 381)
        Me.btnAges.Name = "btnAges"
        Me.btnAges.Size = New System.Drawing.Size(94, 37)
        Me.btnAges.TabIndex = 20
        Me.btnAges.Text = "Ages"
        Me.btnAges.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(483, 393)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(69, 13)
        Me.lblAge.TabIndex = 21
        Me.lblAge.Text = "Average Age"
        '
        'frmYouth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.btnAges)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Telephone_NumberLabel)
        Me.Controls.Add(Me.Telephone_NumberTextBox)
        Me.Controls.Add(Zip_CodeLabel)
        Me.Controls.Add(Me.Zip_CodeTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Parent_Name_s_Label)
        Me.Controls.Add(Me.Parent_Name_s_TextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Player_NumberLabel)
        Me.Controls.Add(Me.Player_NumberTextBox)
        Me.Controls.Add(Me.TeamBindingNavigator)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmYouth"
        Me.Text = "Youth League Soccer Team Database"
        CType(Me.SoccerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeamBindingNavigator.ResumeLayout(False)
        Me.TeamBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents SoccerDataSet As SoccerDataSet
    Friend WithEvents TeamBindingSource As BindingSource
    Friend WithEvents TeamTableAdapter As SoccerDataSetTableAdapters.TeamTableAdapter
    Friend WithEvents TableAdapterManager As SoccerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TeamBindingNavigator As BindingNavigator
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
    Friend WithEvents TeamBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Player_NumberTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Parent_Name_s_TextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents Zip_CodeTextBox As TextBox
    Friend WithEvents Telephone_NumberTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents btnAges As Button
    Friend WithEvents lblAge As Label
End Class
