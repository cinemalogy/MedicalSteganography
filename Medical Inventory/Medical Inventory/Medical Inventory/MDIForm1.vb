Imports System.Windows.Forms

Public Class MDIForm1


    Private Sub CustomerEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerEntryToolStripMenuItem.Click
        CustForm.MdiParent = Me
        CustForm.Show()
    End Sub

    Private Sub SupplierEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierEntryToolStripMenuItem.Click
        SupplierForm.MdiParent = Me
        SupplierForm.Show()
    End Sub



    Private Sub CategoryEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryEntryToolStripMenuItem.Click
        mCatForm.MdiParent = Me
        mCatForm.Show()
    End Sub

    Private Sub GroupEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupEntryToolStripMenuItem.Click
        mGroupForm.MdiParent = Me
        mGroupForm.Show()
    End Sub



    Private Sub ProductEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductEntryToolStripMenuItem.Click
        ItemForm.MdiParent = Me
        ItemForm.Show()
    End Sub



    Private Sub PurchaseEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseEntryToolStripMenuItem.Click
        PurchaseForm.MdiParent = Me
        PurchaseForm.Show()
    End Sub



    Private Sub StockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockReportToolStripMenuItem.Click
        StockRep.MdiParent = Me
        StockRep.Show()
    End Sub




    Private Sub PurchaseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        PurchaseRep.MdiParent = Me
        PurchaseRep.Show()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportToolStripMenuItem.Click
        SalesRep.MdiParent = Me
        SalesRep.Show()
    End Sub



    Private Sub RiMDI_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        CounterSalesForm.MdiParent = Me
        CounterSalesForm.Show()
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListToolStripMenuItem.Click
        CustListReport.MdiParent = Me
        CustListReport.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub MDIForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MasterEntriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterEntriesToolStripMenuItem.Click

    End Sub
End Class
