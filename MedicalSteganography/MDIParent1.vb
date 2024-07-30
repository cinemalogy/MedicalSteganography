Imports System.Windows.Forms

Public Class MDIParent1

   





  



    Private Sub DoctorDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorDetailsToolStripMenuItem.Click
        DoctorDetForm.MdiParent = Me
        DoctorDetForm.Show()
    End Sub

    Private Sub OutPatientDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPatientDetailsToolStripMenuItem.Click
        OutPatientDetailsForm.MdiParent = Me
        OutPatientDetailsForm.Show()
    End Sub

    Private Sub OutPatientConsultationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPatientConsultationToolStripMenuItem.Click
        OutPatientConsulationForm.MdiParent = Me
        OutPatientConsulationForm.Show()
    End Sub

    Private Sub InPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InPToolStripMenuItem.Click
        InPatientDetailsForm.MdiParent = Me
        InPatientDetailsForm.Show()
    End Sub

    Private Sub PatientAdmissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientAdmissionToolStripMenuItem.Click
        AdmissionForm.MdiParent = Me
        AdmissionForm.Show()
    End Sub

    Private Sub PatientBillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientBillingToolStripMenuItem.Click
        InPatientBillingForm.MdiParent = Me
        InPatientBillingForm.Show()
    End Sub

    Private Sub OutPatientDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPatientDetailsToolStripMenuItem1.Click
        OutPatientList.MdiParent = Me
        OutPatientList.Show()
    End Sub

    Private Sub InPatientDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InPatientDetailsToolStripMenuItem.Click
        InPatientListReport.MdiParent = Me
        InPatientListReport.Show()
    End Sub

    Private Sub OutPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPatientToolStripMenuItem.Click
        OutPatientConsList.MdiParent = Me
        OutPatientConsList.Show()
    End Sub

    Private Sub InPatientBillingDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InPatientBillingDetailsToolStripMenuItem.Click
        BillingListReport.MdiParent = Me
        BillingListReport.Show()
    End Sub

    Private Sub MDIParent1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub DepartmentDetailsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentDetailsToolStripMenuItem.Click
        DeptForm.MdiParent = Me
        DeptForm.Show()
    End Sub

   

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SteganographyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        STeganography.MdiParent = Me
        STeganography.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        STeganography.MdiParent = Me
        STeganography.Show()
    End Sub
End Class
