Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class supreg
    Dim pkVar As String
    Dim RandGen As New Random

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico;")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub supreg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox4.Text = "SUP" + RandGen.Next(10000, 99999).ToString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter The Necessary Details")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd0 As New SqlCommand("Select Id from addsup where Id='" & (TextBox4.Text) & "'", Conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This Supplier Is Already Registered")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If
        Dim command As New SqlCommand("insert into addsup(Id,Name,Email,Password,Gender,DOB,Address,Phone,Status,Photo,CompanyName) values(@Id,@Name,@Email,@Password,@Gender,@DOB,@Address,@Phone,@Status,@Photo,@CompanyName)", Conn)
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = TextBox4.Text
        command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = TextBox1.Text
        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = TextBox3.Text
        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = TextBox5.Text
        command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = ComboBox2.Text
        command.Parameters.Add("@DOB", SqlDbType.NVarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = TextBox8.Text
        command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = TextBox7.Text
        command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Waiting"
        command.Parameters.Add("@Photo", SqlDbType.Image).Value = ms.ToArray
        command.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = TextBox2.Text
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Registered Successfully!!! Please wait for the confirmation Mail!")
        Else
            MsgBox("Error!!!")
        End If


        TextBox1.Text = ""
        TextBox4.Text = "SUP" + RandGen.Next(10000, 99999).ToString
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox2.Text = "Select Your Gender"
        DateTimePicker1.Text = ""
        PictureBox1.ImageLocation = "D:\Projects\2. Vb.net Projects\etender\Images\Antu_insert-image.svg_-846x846.png"


        Me.Hide()
        suplogin.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        suplogin.Show()
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Please Enter A Valid Number")
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class