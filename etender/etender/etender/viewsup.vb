Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class viewsup
    Dim pkvar
    Private Sub NhvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhvToolStripMenuItem.Click
        Me.Hide()
        adminmain.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Hide()
        addemp.Show()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Me.Hide()
        viewemp.Show()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            main.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("Select * from addsup where Id='" & pkvar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            'TextBox1.Text = D1(0).ToString
            'TextBox2.Text = D1(1).ToString
        Else
            'TextBox1.Text = ""
            'TextBox2.Text = ""
        End If
    End Sub
    Sub disRecords()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select Id as 'Supplier Id',Name ,Email ,Password ,Gender ,DOB ,Address ,Phone ,Status ,Photo ,CompanyName From addsup order by Id", Conn)
        adp.Fill(DS1)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 50
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = DS1.Tables(0)
        imgc = DataGridView1.Columns(9)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub
    Sub disRecords1()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select Id as 'Supplier Id', Name, Email, CompanyName  From approve order by Id", Conn)
        adp.Fill(DS1)
        DataGridView2.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub viewsup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disRecords()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q1var, q2var
        If TextBox1.Text = "" Then
            MsgBox("Please Enter The Necessary Details")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd0 As New SqlCommand("Select Id from approve where Id='" & (TextBox1.Text) & "'", Conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This Supplier Is Already Been Approved")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1var = "Insert into approve("
        q2var = "Values("
        q1var = q1var & "Id" & " , "
        q2var = q2var & "'" & (TextBox1.Text) & " ', "
        q1var = q1var & "Name" & " , "
        q2var = q2var & "'" & (TextBox2.Text) & " ', "
        q1var = q1var & "Email" & " , "
        q2var = q2var & "'" & (TextBox3.Text) & " ', "
        q1var = q1var & "Password" & " , "
        q2var = q2var & "'" & (TextBox4.Text) & " ', "
        q1var = q1var & "CompanyName" & ")"
        q2var = q2var & "'" & (TextBox5.Text) & " ') "

        Dim cmd1 As New SqlCommand(q1var & q2var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        'disRecords()


        TextBox6.AppendText("E- Tender" + vbNewLine)
        TextBox6.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox6.AppendText("Welcome To E- Tender" + vbNewLine)
        TextBox6.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox6.AppendText("User Id : " + TextBox3.Text + vbNewLine)
        TextBox6.AppendText("Password : " + TextBox4.Text + vbNewLine)
        TextBox6.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox6.AppendText("Please Login With These Credentials" + vbNewLine)
        TextBox6.AppendText("----------------------------------------------------------" + vbNewLine)



        Dim Mail As New MailMessage
        Mail.Subject = "Your Account Has Been Approved!!!"
        If TextBox3.Text = "" Then
            MsgBox("Please Enter The E-Mail Address", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error!")
        End If
        Mail.To.Add(TextBox3.Text)
        Mail.From = New MailAddress("ASCTender0@gmail.com")
        Mail.Body = TextBox6.Text


        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("ASCTender0@gmail.com", "rxrhvfllmnyokmtv")
        SMTP.Port = "587"
        SMTP.Send(Mail)
        MsgBox("Approved Successfully")


        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""


        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd2 As New SqlCommand("Delete from addsup where Id='" & pkvar & "'", Conn)
        cmd2.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords1()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        pkvar = DataGridView2.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("Select * from approve where Id='" & pkvar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            'TextBox1.Text = D1(0).ToString
            'TextBox2.Text = D1(1).ToString
        Else
            'TextBox1.Text = ""
            'TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        disRecords()
        disRecords1()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        viewitemsordered.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        approvedbid1.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class