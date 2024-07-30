Imports System.Data.SqlClient

Public Class additem
    Dim RandGen As New Random
    Private Sub NhvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhvToolStripMenuItem.Click
        emphome.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            main.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub additem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autogenerate_id()

        TextBox1.Text = "2018/TENDER/" + RandGen.Next(1000, 10000).ToString
        TextBox6.Text = "ITEM" + RandGen.Next(10000, 99999).ToString
    End Sub
    Private Sub autogenerate_id()
        Dim number As Integer
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd As New SqlCommand(number, Conn)
        cmd.CommandText = "SELECT MAX(Id) FROM additem"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TextBox4.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox4.Text = number
        End If
        cmd.Dispose()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim i As Integer
        TextBox8.Text = Today & vbNewLine & TimeOfDay
        i = i + 1
        If i > 5 Then
            Timer2.Enabled = False
            TextBox8.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q1var, q2var
        If TextBox1.Text = "" Then
            MsgBox("Please Enter The Necessary Details")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd0 As New SqlCommand("Select IdemId from additem where IdemId='" & (TextBox6.Text) & "'", Conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This Item Is Already Added")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1var = "Insert into additem("
        q2var = "Values("
        q1var = q1var & "Id" & " , "
        q2var = q2var & "'" & (TextBox4.Text) & " ', "
        q1var = q1var & "NotificationId" & " , "
        q2var = q2var & "'" & (TextBox1.Text) & " ', "
        q1var = q1var & "IdemId" & " , "
        q2var = q2var & "'" & (TextBox6.Text) & " ', "
        q1var = q1var & "ItemName" & " , "
        q2var = q2var & "'" & (TextBox2.Text) & " ', "
        q1var = q1var & "Description" & " , "
        q2var = q2var & "'" & (TextBox3.Text) & " ', "
        q1var = q1var & "Quantity" & " , "
        q2var = q2var & "'" & (TextBox5.Text) & " ', "
        q1var = q1var & "District" & " , "
        q2var = q2var & "'" & (TextBox7.Text) & " ', "
        q1var = q1var & "BidStart" & " , "
        q2var = q2var & "'" & (DateTimePicker1.Text) & " ', "
        q1var = q1var & "BidEnd" & " , "
        q2var = q2var & "'" & (DateTimePicker2.Text) & " ', "
        q1var = q1var & "Time" & " , "
        q2var = q2var & "'" & (TextBox8.Text) & " ', "
        q1var = q1var & "Status" & " , "
        q2var = q2var & "'" & "Active" & " ', "
        q1var = q1var & "ItemAddedBy" & ")"
        q2var = q2var & "'" & logname & " ') "

        Dim cmd1 As New SqlCommand(q1var & q2var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        'disRecords()
        autogenerate_id()

        MsgBox("Item Added Successfully")
        TextBox1.Text = "2018/TENDER/" + RandGen.Next(1000, 10000).ToString
        TextBox6.Text = "ITEM" + RandGen.Next(10000, 99999).ToString
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Me.Hide()
        viewitems.Show()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        Me.Hide()
        viewbidding.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        approvedbid.Show()
    End Sub
End Class