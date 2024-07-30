Public Class emphome

    Private Sub NhvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhvToolStripMenuItem.Click
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

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Hide()
        additem.Show()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Me.Hide()
        viewitems.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        approvedbid.Show()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        viewbidding.Show()
    End Sub
End Class