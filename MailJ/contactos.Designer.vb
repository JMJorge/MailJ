<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contactos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(contactos))
        Me.ContactGrid = New System.Windows.Forms.DataGridView()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.ButtonCarregar = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBoxSearch = New System.Windows.Forms.PictureBox()
        CType(Me.ContactGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactGrid
        '
        Me.ContactGrid.AllowUserToAddRows = False
        Me.ContactGrid.AllowUserToDeleteRows = False
        Me.ContactGrid.AllowUserToOrderColumns = True
        Me.ContactGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ContactGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ContactGrid.BackgroundColor = System.Drawing.Color.MintCream
        Me.ContactGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactGrid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ContactGrid.Location = New System.Drawing.Point(16, 15)
        Me.ContactGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactGrid.Name = "ContactGrid"
        Me.ContactGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ContactGrid.Size = New System.Drawing.Size(1137, 401)
        Me.ContactGrid.StandardTab = True
        Me.ContactGrid.TabIndex = 1
        '
        'ButtonFechar
        '
        Me.ButtonFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFechar.Location = New System.Drawing.Point(1033, 428)
        Me.ButtonFechar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(120, 48)
        Me.ButtonFechar.TabIndex = 4
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'ButtonCarregar
        '
        Me.ButtonCarregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCarregar.Location = New System.Drawing.Point(16, 428)
        Me.ButtonCarregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCarregar.Name = "ButtonCarregar"
        Me.ButtonCarregar.Size = New System.Drawing.Size(120, 48)
        Me.ButtonCarregar.TabIndex = 3
        Me.ButtonCarregar.Text = "Carregar"
        Me.ButtonCarregar.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(385, 442)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(300, 22)
        Me.TextBoxSearch.TabIndex = 5
        '
        'PictureBoxSearch
        '
        Me.PictureBoxSearch.BackColor = System.Drawing.Color.White
        Me.PictureBoxSearch.BackgroundImage = CType(resources.GetObject("PictureBoxSearch.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxSearch.InitialImage = CType(resources.GetObject("PictureBoxSearch.InitialImage"), System.Drawing.Image)
        Me.PictureBoxSearch.Location = New System.Drawing.Point(680, 442)
        Me.PictureBoxSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBoxSearch.Name = "PictureBoxSearch"
        Me.PictureBoxSearch.Size = New System.Drawing.Size(33, 27)
        Me.PictureBoxSearch.TabIndex = 6
        Me.PictureBoxSearch.TabStop = False
        '
        'contactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1169, 492)
        Me.Controls.Add(Me.PictureBoxSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.ButtonCarregar)
        Me.Controls.Add(Me.ContactGrid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "contactos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contactos"
        CType(Me.ContactGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonFechar As System.Windows.Forms.Button
    Friend WithEvents ButtonCarregar As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxSearch As System.Windows.Forms.PictureBox
End Class
