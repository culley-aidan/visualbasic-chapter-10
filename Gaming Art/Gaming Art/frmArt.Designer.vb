<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArt
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
        Me.picArt = New System.Windows.Forms.PictureBox()
        CType(Me.picArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picArt
        '
        Me.picArt.Image = Global.Gaming_Art.My.Resources.Resources.art
        Me.picArt.Location = New System.Drawing.Point(24, 23)
        Me.picArt.Name = "picArt"
        Me.picArt.Size = New System.Drawing.Size(293, 160)
        Me.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArt.TabIndex = 0
        Me.picArt.TabStop = False
        '
        'frmArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(654, 411)
        Me.Controls.Add(Me.picArt)
        Me.Name = "frmArt"
        Me.Text = "Gaming Art Commission - Game Art & Design Competition"
        CType(Me.picArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picArt As PictureBox
End Class
