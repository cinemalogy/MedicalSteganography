Imports System.Data.SqlClient
Public Class DoctorDetForm
    Dim pkVar As String
    Private Sub EmpDetForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized


        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd1 As New SqlCommand("select Depttab from DeptTab order by Depttab", Conn)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox1.Items.Add(D1(0).ToString)
        End While
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()
    End Sub

    Private Sub butNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearTxtControls(Me, 1)
        TextBox1.Focus()
    End Sub


    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        SaveRecord()


    End Sub
    Sub SaveRecord()
        If TextBox1.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If



        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select DrCode from DoctorTab where DrCode='" & UCase(TextBox1.Text) & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This record is allready present in the database")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1Var = "insert into DoctorTab("
        q2Var = " values("
        q1Var = q1Var & "DrCode" & ","
        q2Var = q2Var & "'" & UCase(TextBox1.Text) & "',"
        q1Var = q1Var & "DrName" & ","
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q1Var = q1Var & "Add1" & ","
        q2Var = q2Var & "'" & TextBox3.Text & "',"
        q1Var = q1Var & "Add2" & ","
        q2Var = q2Var & "'" & TextBox4.Text & "',"
        q1Var = q1Var & "Add3" & ","
        q2Var = q2Var & "'" & TextBox5.Text & "',"
        q1Var = q1Var & "PinCode" & ","
        q2Var = q2Var & "'" & TextBox6.Text & "',"
        q1Var = q1Var & "PhoneNo" & ","
        q2Var = q2Var & "'" & TextBox7.Text & "',"
        q1Var = q1Var & "eMail" & ","
        q2Var = q2Var & "'" & TextBox8.Text & "',"
        q1Var = q1Var & "Departmentname" & ")"
        q2Var = q2Var & "'" & ComboBox1.Text & "')"

        'MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1Var & q2Var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False
    End Sub
    Sub disRecords()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select DrCode,DrName From DoctorTab order by DrCode", Conn)
        adp.Fill(DS1)
        DG1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub DG1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG1.CellContentClick
        pkVar = DG1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("select * from DoctorTab where DrCode='" & pkVar & "'", Conn)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(0).ToString
            TextBox2.Text = D1(1).ToString
            TextBox3.Text = D1(2).ToString
            TextBox4.Text = D1(3).ToString
            TextBox5.Text = D1(4).ToString
            TextBox6.Text = D1(5).ToString
            TextBox7.Text = D1(6).ToString
            TextBox8.Text = D1(7).ToString
            ComboBox1.Text = D1(8).ToString

            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = True
            ButDelete.Enabled = True
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            butNew.Enabled = True
            butSave.Enabled = False
            butModify.Enabled = False
            ButDelete.Enabled = False

        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()

    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Me.Close()
    End Sub

    Private Sub butModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles butModify.Click
        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from DoctorTab where DrCode='" & pkVar & "'", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        SaveRecord()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        If vbNo = MsgBox("Are you sure you want delete this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd1 As New SqlCommand("Delete from DoctorTab where DrCode='" & pkVar & "'", Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()
        butNew.Enabled = True
        butSave.Enabled = False
        butModify.Enabled = False
        ButDelete.Enabled = False

    End Sub

    Private Sub butNew_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles butNew.Click
        ClearTxtControls(Me, 1)

        TextBox1.Focus()
        butNew.Enabled = False
        butSave.Enabled = True
        butModify.Enabled = False
        ButDelete.Enabled = False
    End Sub

    Private Sub butList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butList.Click
        disRecords()
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = UCase(TextBox1.Text)
    End Sub
End Class
