Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class addemp

    Private Sub NhvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhvToolStripMenuItem.Click
        Me.Hide()
        adminmain.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            main.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Show()
    End Sub
    Private Sub autogenerate_id()
        Dim number As Integer
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd As New SqlCommand(number, Conn)
        cmd.CommandText = "SELECT MAX(Id) FROM addemp"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            Label11.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            Label11.Text = number
        End If
        cmd.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q1var, q2var
        If TextBox1.Text = "" Then
            MsgBox("Please Enter The Necessary Details")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd0 As New SqlCommand("Select EmployeeId from addemp where EmployeeId='" & (TextBox1.Text) & "'", Conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This Employee Is Already Registered")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1var = "Insert into addemp("
        q2var = "Values("
        q1var = q1var & "Id" & " , "
        q2var = q2var & "'" & (Label11.Text) & " ', "
        q1var = q1var & "Password" & " , "
        q2var = q2var & "'" & (TextBox6.Text) & " ', "
        q1var = q1var & "EmployeeId" & " , "
        q2var = q2var & "'" & (TextBox1.Text) & " ', "
        q1var = q1var & "EmployeeName" & " , "
        q2var = q2var & "'" & (TextBox2.Text) & " ', "
        q1var = q1var & "EmployeeEmail" & " , "
        q2var = q2var & "'" & (TextBox3.Text) & " ', "
        q1var = q1var & "Department" & " , "
        q2var = q2var & "'" & (ComboBox1.Text) & " ', "
        q1var = q1var & "Gender" & " , "
        q2var = q2var & "'" & (ComboBox2.Text) & " ', "
        q1var = q1var & "DOB" & " , "
        q2var = q2var & "'" & (DateTimePicker1.Text) & " ', "
        q1var = q1var & "MaritalStatus" & " , "
        q2var = q2var & "'" & (ComboBox3.Text) & " ', "
        q1var = q1var & "Address" & " , "
        q2var = q2var & "'" & (TextBox5.Text) & " ', "
        q1var = q1var & "Phone" & " , "
        q2var = q2var & "'" & (TextBox7.Text) & " ', "
        q1var = q1var & "BloodGroup" & ")"
        q2var = q2var & "'" & (TextBox9.Text) & " ') "

        Dim cmd1 As New SqlCommand(q1var & q2var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        'disRecords()

        MsgBox("Registered Successfully")
        TextBox4.AppendText("E- Tender" + vbNewLine)
        TextBox4.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox4.AppendText("Welcome To E- Tender" + vbNewLine)
        TextBox4.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox4.AppendText("User Id : " + TextBox1.Text + vbNewLine)
        TextBox4.AppendText("Password : " + TextBox6.Text + vbNewLine)
        TextBox4.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox4.AppendText("Please Login With These Credentials" + vbNewLine)
        TextBox4.AppendText("----------------------------------------------------------" + vbNewLine)



        Dim Mail As New MailMessage
        Mail.Subject = "Registration Successful!!!"
        If TextBox3.Text = "" Then
            MsgBox("Please Enter The E-Mail Address", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error!")
        End If
        Mail.To.Add(TextBox3.Text)
        Mail.From = New MailAddress("bosscsk56@gmail.com")
        Mail.Body = TextBox4.Text


        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("bosscsk56@gmail.com", "themonk1919")
        SMTP.Port = "587"
        SMTP.Send(Mail)
        MsgBox("Confirmation Mail Has Been Sent To Your Mail Id", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "E-Tender")


        TextBox9.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = "Please Select The Department"
        ComboBox2.Text = "Select Your Gender"
        ComboBox3.Text = "Select Your Marital Status"
        TextBox7.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
    End Sub

    Private Sub addemp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autogenerate_id()

        Dim Letters As New List(Of Integer)
        'add ASCII codes for numbers
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        'select 8 random integers from number of items in Letters
        'then convert those random integers to characters and
        'add each to a string and display in Textbox
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 5
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
        Next

        TextBox1.Text = SB.ToString
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Please Enter A Valid Number")
        End If
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Me.Hide()
        viewemp.Show()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        Me.Hide()
        viewsup.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        viewitemsordered.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        approvedbid1.Show()
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class