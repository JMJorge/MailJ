<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acesso
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acesso))
        Me.TBPass = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.BTLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTSair = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBPass
        '
        Me.TBPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPass.Location = New System.Drawing.Point(156, 256)
        Me.TBPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBPass.Name = "TBPass"
        Me.TBPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPass.Size = New System.Drawing.Size(424, 26)
        Me.TBPass.TabIndex = 2
        Me.TBPass.Text = "Password"
        '
        'TBEmail
        '
        Me.TBEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TBEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEmail.Location = New System.Drawing.Point(156, 203)
        Me.TBEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(424, 26)
        Me.TBEmail.TabIndex = 1
        Me.TBEmail.Text = "email"
        '
        'BTLogin
        '
        Me.BTLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTLogin.Location = New System.Drawing.Point(284, 314)
        Me.BTLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTLogin.Name = "BTLogin"
        Me.BTLogin.Size = New System.Drawing.Size(172, 44)
        Me.BTLogin.TabIndex = 3
        Me.BTLogin.Text = "Aceder"
        Me.BTLogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.MailJ.My.Resources.Resources.user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(313, 85)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 92)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BTSair
        '
        Me.BTSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSair.Location = New System.Drawing.Point(284, 366)
        Me.BTSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTSair.Name = "BTSair"
        Me.BTSair.Size = New System.Drawing.Size(172, 44)
        Me.BTSair.TabIndex = 4
        Me.BTSair.Text = "Sair"
        Me.BTSair.UseVisualStyleBackColor = True
        '
        'acesso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MailJ.My.Resources.Resources.backg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 443)
        Me.Controls.Add(Me.BTSair)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTLogin)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.TBPass)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "acesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "acesso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBPass As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents BTLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTSair As Button
End Class
