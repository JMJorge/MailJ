
Imports System.Net.Mail

Public Class emailBox
    Dim mail As New MailMessage()
    Dim Ficheiro(2) As String
    Dim Guarda(2) As String
    Dim auxFicheiro1 As String
    Dim auxFicheiro2 As String
    Dim auxFicheiro3 As String
    Dim auxGuarda1 As String
    Dim auxGuarda2 As String
    Dim auxGuarda3 As String


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnexar.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Guarda(0) = Ficheiro(0)
            auxGuarda1 = Guarda(0)
            Try
                Guarda(1) = Ficheiro(1)
                auxGuarda2 = Guarda(1)
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                Guarda(2) = Ficheiro(2)
                auxGuarda3 = Guarda(2)
            Catch ex As IndexOutOfRangeException
            End Try

            Ficheiro = Nothing

            Ficheiro = OpenFileDialog1.FileNames
            auxFicheiro1 = Ficheiro(0)
            txtAnexos.Text = "Ficheiros: " & vbCrLf & auxFicheiro1
            Try
                auxFicheiro2 = Ficheiro(1)
                txtAnexos.Text = txtAnexos.Text & vbCrLf & auxFicheiro2
            Catch ex As IndexOutOfRangeException
            End Try
            Try
                auxFicheiro3 = Ficheiro(2)
                txtAnexos.Text = txtAnexos.Text & vbCrLf & auxFicheiro3
            Catch ex As IndexOutOfRangeException
            End Try

            txtAnexos.Text = txtAnexos.Text & vbCrLf & auxGuarda1
            txtAnexos.Text = txtAnexos.Text & vbCrLf & auxGuarda2
            txtAnexos.Text = txtAnexos.Text & vbCrLf & auxGuarda3
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim mail As New MailMessage()
        Dim smtpServer As New SmtpClient("smtp.gmail.com")
        Try
            mail.From = New MailAddress(acesso.email)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try
        If Not txtPara.Text = Nothing Then
            mail.To.Add(txtPara.Text)
        Else
            MessageBox.Show("Destinatário não pode estar vazio")
        End If
        mail.Subject = txtAssunto.Text
        mail.Body = txtCorpo.Text

        Dim anexo As System.Net.Mail.Attachment
        If Not auxFicheiro1 = Nothing Then
            anexo = New System.Net.Mail.Attachment(auxFicheiro1)
            mail.Attachments.Add(anexo)
        End If
        If Not auxFicheiro2 = Nothing Then
            anexo = New System.Net.Mail.Attachment(auxFicheiro2)
            mail.Attachments.Add(anexo)
        End If

        If Not auxFicheiro3 = Nothing Then
            anexo = New System.Net.Mail.Attachment(auxFicheiro3)
            mail.Attachments.Add(anexo)
        End If
        If Not auxGuarda1 = Nothing Then
            anexo = New System.Net.Mail.Attachment(auxGuarda1)
            mail.Attachments.Add(anexo)
        End If
        If Not auxGuarda2 = Nothing Then
            anexo = New System.Net.Mail.Attachment(auxGuarda2)
            mail.Attachments.Add(anexo)
        End If
        If Not auxGuarda3 = Nothing Then
            anexo = New System.Net.Mail.Attachment(auxGuarda3)
            mail.Attachments.Add(anexo)
        End If

        smtpServer.Port = 587
        smtpServer.UseDefaultCredentials = False
        smtpServer.Credentials = New System.Net.NetworkCredential(acesso.email, acesso.pass)
        smtpServer.EnableSsl = True
        Try
            smtpServer.Send(mail)
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try


    End Sub

    Private Sub Btn_Cont_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cont.Click

        'GlobalVariables.doc
        contactos.Show()

    End Sub

    Private Sub btnLimpar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpar.Click

        For i As Int16 = 0 To Ficheiro.Length - 1
            Ficheiro(i) = ""
        Next
        For j As Int16 = 0 To Guarda.Length - 1
            Guarda(j) = ""
        Next
        auxFicheiro1 = Nothing
        auxFicheiro2 = Nothing
        auxFicheiro3 = Nothing
        auxGuarda1 = Nothing
        auxGuarda2 = Nothing
        auxGuarda3 = Nothing
        txtAnexos.Text = ""

    End Sub
End Class
