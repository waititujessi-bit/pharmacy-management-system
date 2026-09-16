<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registration))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Lblpassword = New System.Windows.Forms.Label()
        Me.Lblcofirmpassword = New System.Windows.Forms.Label()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Txtcofirmpassword = New System.Windows.Forms.TextBox()
        Me.btnregistratio = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(608, 408)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.Location = New System.Drawing.Point(53, 37)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(71, 17)
        Me.Lblusername.TabIndex = 1
        Me.Lblusername.Text = "username"
        '
        'Lblpassword
        '
        Me.Lblpassword.AutoSize = True
        Me.Lblpassword.Location = New System.Drawing.Point(53, 110)
        Me.Lblpassword.Name = "Lblpassword"
        Me.Lblpassword.Size = New System.Drawing.Size(68, 17)
        Me.Lblpassword.TabIndex = 2
        Me.Lblpassword.Text = "password"
        '
        'Lblcofirmpassword
        '
        Me.Lblcofirmpassword.AutoSize = True
        Me.Lblcofirmpassword.Location = New System.Drawing.Point(53, 201)
        Me.Lblcofirmpassword.Name = "Lblcofirmpassword"
        Me.Lblcofirmpassword.Size = New System.Drawing.Size(106, 17)
        Me.Lblcofirmpassword.TabIndex = 3
        Me.Lblcofirmpassword.Text = "cofirmpassword"
        '
        'Txtusername
        '
        Me.Txtusername.Location = New System.Drawing.Point(184, 37)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(173, 22)
        Me.Txtusername.TabIndex = 4
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(182, 100)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(175, 22)
        Me.Txtpassword.TabIndex = 5
        '
        'Txtcofirmpassword
        '
        Me.Txtcofirmpassword.Location = New System.Drawing.Point(182, 196)
        Me.Txtcofirmpassword.Name = "Txtcofirmpassword"
        Me.Txtcofirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtcofirmpassword.Size = New System.Drawing.Size(183, 22)
        Me.Txtcofirmpassword.TabIndex = 6
        '
        'btnregistratio
        '
        Me.btnregistratio.Location = New System.Drawing.Point(195, 303)
        Me.btnregistratio.Name = "btnregistratio"
        Me.btnregistratio.Size = New System.Drawing.Size(149, 87)
        Me.btnregistratio.TabIndex = 8
        Me.btnregistratio.Text = "Registation"
        Me.btnregistratio.UseVisualStyleBackColor = True
        '
        'registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 402)
        Me.Controls.Add(Me.btnregistratio)
        Me.Controls.Add(Me.Txtcofirmpassword)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Txtusername)
        Me.Controls.Add(Me.Lblcofirmpassword)
        Me.Controls.Add(Me.Lblpassword)
        Me.Controls.Add(Me.Lblusername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "registration"
        Me.Text = "registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lblusername As System.Windows.Forms.Label
    Friend WithEvents Lblpassword As System.Windows.Forms.Label
    Friend WithEvents Lblcofirmpassword As System.Windows.Forms.Label
    Friend WithEvents Txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Txtcofirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnregistratio As System.Windows.Forms.Button
End Class
