Imports System.Data.SqlClient

Public Class viewbidding
    Dim pkvar
    Private Sub NhvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhvToolStripMenuItem.Click
        Me.Hide()
        emphome.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Hide()
        additem.Show()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Me.Hide()
        viewitems.Show()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox9.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox10.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox11.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox12.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim Cmd0 As New SqlCommand("Select * from apply where Id='" & pkvar & "'", Conn)
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
        Dim adp As New SqlDataAdapter("select Id ,SupplierId ,Suppliername ,Company ,Email, NotificationId ,ItemId , ItemName ,BiddingPrice ,Warranty ,ManufacturingYear ,Time as 'Applied Time', Status From apply order by Id", Conn)
        adp.Fill(DS1)
        DataGridView1.DataSource = DS1.Tables(0)
        If Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Private Sub viewbidding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disRecords()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        approvedbid.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q1var, q2var
        If TextBox1.Text = "" Then
            MsgBox("Please Enter The Necessary Details")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd0 As New SqlCommand("Select NotificationId from approvedbit where NotificationId='" & (TextBox1.Text) & "'", Conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("Already Approved")
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Exit Sub
        End If
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        q1var = "Insert into approvedbit("
        q2var = "Values("
        q1var = q1var & "Id" & " , "
        q2var = q2var & "'" & (TextBox7.Text) & " ', "
        q1var = q1var & "SupplierId" & " , "
        q2var = q2var & "'" & (TextBox12.Text) & " ', "
        q1var = q1var & "Suppliername" & " , "
        q2var = q2var & "'" & (TextBox11.Text) & " ', "
        q1var = q1var & "Company" & " , "
        q2var = q2var & "'" & (TextBox10.Text) & " ', "
        q1var = q1var & "Email" & " , "
        q2var = q2var & "'" & (TextBox9.Text) & " ', "
        q1var = q1var & "NotificationId" & " , "
        q2var = q2var & "'" & (TextBox1.Text) & " ', "
        q1var = q1var & "ItemId" & " , "
        q2var = q2var & "'" & (TextBox2.Text) & " ', "
        q1var = q1var & "ItemName" & " , "
        q2var = q2var & "'" & (TextBox3.Text) & " ', "
        q1var = q1var & "BiddingPrice" & " , "
        q2var = q2var & "'" & (TextBox4.Text) & " ', "
        q1var = q1var & "Warranty" & " , "
        q2var = q2var & "'" & (TextBox5.Text) & " ', "
        q1var = q1var & "ManufacturingYear" & " , "
        q2var = q2var & "'" & (TextBox6.Text) & " ', "
        q1var = q1var & "Time" & " , "
        q2var = q2var & "'" & (TextBox8.Text) & " ', "
        q1var = q1var & "Status" & ")"
        q2var = q2var & "'" & "Approved" & " ') "

        Dim cmd1 As New SqlCommand(q1var & q2var, Conn)
        cmd1.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        'disRecords()

        MsgBox("Successfully Approved!")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""

        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()
        Dim cmd2 As New SqlCommand("Delete from apply where Id='" & pkvar & "'", Conn)
        cmd2.ExecuteNonQuery()
        If Conn.State = ConnectionState.Open Then Conn.Close()
        disRecords()
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
End Class