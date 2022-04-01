Imports System.IO
Imports System.Text

Public Class contactos

    Dim table As New DataTable()

    ' Carrega o ficheiro
    Private Sub ButtonCarregar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCarregar.Click

        ' limpa para carregar novo doc
        ' For unbound cases
        '  ContactGrid.Rows.Clear()
        '  ContactGrid.Columns.Clear()
        ' For bound cases
        table.Clear()
        table.Columns.Clear()

        ' Filtro de tipo de ficheiro 
        'OpenFileDialog1.InitialDirectory = "c:\desktop"
        'OpenFileDialog1.Filter = "CSV files (*.csv)|*.CSV"
        Using OpenFile As New OpenFileDialog() With {.Filter = "(Documento .csv)|*.csv", .Multiselect = False, .Title = "Selecione ficheiro em formato .csv"}
            OpenFile.ShowDialog()
            Dim caminho = OpenFile.FileName                                                     'Guarda o caminho do documento

            Try
                table.Columns.Add("Nome", Type.GetType("System.String"))
                table.Columns.Add("Email", Type.GetType("System.String"))

                ContactGrid.DataSource = table.DefaultView

                Dim lines() As String
                Dim vals() As String

                lines = File.ReadAllLines(caminho)


                For i As Integer = 0 To lines.Length - 1 Step +1
                    vals = lines(i).ToString.Split(",")
                    Dim row(vals.Length - 1) As String
                    For j As Integer = 0 To vals.Length - 1 Step +1
                        row(j) = vals(j).Trim()
                    Next j
                    table.Rows.Add(row)
                Next i
            Catch ex As Exception
                MessageBox.Show("Erro ao carregar o documento")
            End Try



            ''Op1
            'Try
            '    For Each Linha As String In IO.File.ReadAllLines(caminho)
            '        Dim row = Split(Linha, ",")
            '        ContactGrid.Rows.Add(row(0), row(1))
            '    Next
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            '    Me.Close()                                                                      ' Fecha a janela atual

            'End Try

            'Op2
            '    Try
            '        Dim file As String = caminho
            '        'Dim file As String = "C:\Users\Joao\Downloads\contacts.csv"
            '        Dim reader As New StreamReader(file, Encoding.Default)                          'Lê o documento                
            '        Dim line As String = ""
            '        Dim r As Integer = 0
            '        line = reader.ReadLine
            '        Do
            '            line = reader.ReadLine
            '            If line Is Nothing Then Exit Do
            '            Dim separador() As String = line.Split(",")
            '            ContactGrid().Rows.Add()
            '            For i As Integer = 0 To ContactGrid.RowCount - 1
            '                ContactGrid.Rows(r).Cells(i).Value = separador(i)
            '            Next
            '            r = r + 1
            '        Loop
            '        reader.Close()
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message)

            '    End Try
            'End Using

            'Op3
            'Dim lines() As String
            'Dim vals() As String
            'Try
            '    lines = File.ReadAllLines(caminho) '"C:\Users\Joao\Downloads\contacts.csv")
            '    For i As Integer = 0 To lines.Length - 1 Step +1

            '        vals = lines(i).ToString().Split(",")   '(";")
            '        Dim rows(vals.Length - 1) As String

            '        For j As Integer = 0 To vals.Length - 1 Step +1
            '            rows(j) = vals(j).Trim
            '        Next j

            '        ContactGrid.Rows.Add(rows)
            '    Next (i)
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try

        End Using
    End Sub

    ' Esconde a janela atual
    Private Sub ButtonFechar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFechar.Click

        Me.Hide()

    End Sub

    'Adicionar email ao bcc
    Public Sub ContactGrid_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ContactGrid.CellDoubleClick

        Try
            Dim selected As DataGridViewRow
            selected = ContactGrid.Rows(e.RowIndex)
            emailBox.TB_BCC.Text = emailBox.TB_BCC.Text + selected.Cells(1).Value + ";"
            MessageBox.Show("Email adicionado")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Tooltip
    Private Sub ContactGrid_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ContactGrid.CellMouseEnter

        Try
            If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Then
                Me.ContactGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = "Duplo clique para adicionar email"
            End If
        Catch
        End Try

    End Sub


    ' Filtrar pelo nome
    Private Sub TextBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged

        Try
            Dim filtro As New DataView(table)
            filtro.RowFilter = String.Format("Nome like '%{0}%'", TextBoxSearch.Text)
            ContactGrid.DataSource = filtro
        Catch ex As Exception
            MessageBox.Show("Erro ao filtrar os contactos")
        End Try

    End Sub
End Class