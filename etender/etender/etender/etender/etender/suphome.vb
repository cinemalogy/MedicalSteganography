Public Class suphome

    Private Sub NhvToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhvToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Hide()
        notifi.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            main.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersToolStripMenuItem.Click
        Me.Hide()
        appliedtender.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        approvedbid2.Show()
    End Sub
End Class