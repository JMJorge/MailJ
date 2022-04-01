<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emailBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(emailBox))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAnexos = New System.Windows.Forms.Label()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.txtCorpo = New System.Windows.Forms.TextBox()
        Me.ButtonAnexar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_Cont = New System.Windows.Forms.Button()
        Me.TB_BCC = New System.Windows.Forms.TextBox()
        Me.L_Bcc = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Para"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Assunto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Corpo"
        '
        'txtAnexos
        '
        Me.txtAnexos.AutoSize = True
        Me.txtAnexos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnexos.Location = New System.Drawing.Point(245, 439)
        Me.txtAnexos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtAnexos.Name = "txtAnexos"
        Me.txtAnexos.Size = New System.Drawing.Size(10, 16)
        Me.txtAnexos.TabIndex = 3
        Me.txtAnexos.Text = "|"
        '
        'txtPara
        '
        Me.txtPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPara.Location = New System.Drawing.Point(124, 32)
        Me.txtPara.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(763, 22)
        Me.txtPara.TabIndex = 4
        '
        'txtAssunto
        '
        Me.txtAssunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssunto.Location = New System.Drawing.Point(124, 129)
        Me.txtAssunto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(763, 22)
        Me.txtAssunto.TabIndex = 5
        '
        'txtCorpo
        '
        Me.txtCorpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorpo.Location = New System.Drawing.Point(124, 175)
        Me.txtCorpo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCorpo.Multiline = True
        Me.txtCorpo.Name = "txtCorpo"
        Me.txtCorpo.Size = New System.Drawing.Size(763, 243)
        Me.txtCorpo.TabIndex = 6
        '
        'ButtonAnexar
        '
        Me.ButtonAnexar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnexar.Location = New System.Drawing.Point(124, 426)
        Me.ButtonAnexar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonAnexar.Name = "ButtonAnexar"
        Me.ButtonAnexar.Size = New System.Drawing.Size(100, 42)
        Me.ButtonAnexar.TabIndex = 8
        Me.ButtonAnexar.Text = "Anexar"
        Me.ButtonAnexar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(757, 450)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 54)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Btn_Cont
        '
        Me.Btn_Cont.BackgroundImage = CType(resources.GetObject("Btn_Cont.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Cont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Cont.Location = New System.Drawing.Point(900, 49)
        Me.Btn_Cont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Cont.Name = "Btn_Cont"
        Me.Btn_Cont.Size = New System.Drawing.Size(44, 44)
        Me.Btn_Cont.TabIndex = 10
        Me.Btn_Cont.UseVisualStyleBackColor = True
        '
        'TB_BCC
        '
        Me.TB_BCC.AccessibleDescription = ""
        Me.TB_BCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TB_BCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_BCC.Location = New System.Drawing.Point(124, 69)
        Me.TB_BCC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_BCC.Name = "TB_BCC"
        Me.TB_BCC.Size = New System.Drawing.Size(763, 22)
        Me.TB_BCC.TabIndex = 11
        '
        'L_Bcc
        '
        Me.L_Bcc.AutoSize = True
        Me.L_Bcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Bcc.Location = New System.Drawing.Point(60, 70)
        Me.L_Bcc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Bcc.Name = "L_Bcc"
        Me.L_Bcc.Size = New System.Drawing.Size(40, 20)
        Me.L_Bcc.TabIndex = 12
        Me.L_Bcc.Text = "Bcc:"
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(124, 476)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(100, 42)
        Me.btnLimpar.TabIndex = 29
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'emailBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(955, 545)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.TB_BCC)
        Me.Controls.Add(Me.L_Bcc)
        Me.Controls.Add(Me.Btn_Cont)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonAnexar)
        Me.Controls.Add(Me.txtCorpo)
        Me.Controls.Add(Me.txtAssunto)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.txtAnexos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "emailBox"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAnexos As System.Windows.Forms.Label
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents txtAssunto As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpo As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAnexar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Btn_Cont As System.Windows.Forms.Button
    Friend WithEvents TB_BCC As System.Windows.Forms.TextBox
    Friend WithEvents L_Bcc As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button

End Class
