<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DepartmentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutPatientDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutPatientConsultationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientAdmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientBillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutPatientDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InPatientDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InPatientBillingDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 674)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1488, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentDetailsToolStripMenuItem, Me.DoctorDetailsToolStripMenuItem, Me.OutToolStripMenuItem, Me.InPatientToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1488, 31)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DepartmentDetailsToolStripMenuItem
        '
        Me.DepartmentDetailsToolStripMenuItem.Name = "DepartmentDetailsToolStripMenuItem"
        Me.DepartmentDetailsToolStripMenuItem.Size = New System.Drawing.Size(207, 27)
        Me.DepartmentDetailsToolStripMenuItem.Text = "Department Details"
        '
        'DoctorDetailsToolStripMenuItem
        '
        Me.DoctorDetailsToolStripMenuItem.Name = "DoctorDetailsToolStripMenuItem"
        Me.DoctorDetailsToolStripMenuItem.Size = New System.Drawing.Size(159, 27)
        Me.DoctorDetailsToolStripMenuItem.Text = "Doctor Details"
        '
        'OutToolStripMenuItem
        '
        Me.OutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutPatientDetailsToolStripMenuItem, Me.OutPatientConsultationToolStripMenuItem})
        Me.OutToolStripMenuItem.Name = "OutToolStripMenuItem"
        Me.OutToolStripMenuItem.Size = New System.Drawing.Size(128, 27)
        Me.OutToolStripMenuItem.Text = "Out Patient"
        '
        'OutPatientDetailsToolStripMenuItem
        '
        Me.OutPatientDetailsToolStripMenuItem.Name = "OutPatientDetailsToolStripMenuItem"
        Me.OutPatientDetailsToolStripMenuItem.Size = New System.Drawing.Size(313, 28)
        Me.OutPatientDetailsToolStripMenuItem.Text = "Out Patient Details"
        '
        'OutPatientConsultationToolStripMenuItem
        '
        Me.OutPatientConsultationToolStripMenuItem.Name = "OutPatientConsultationToolStripMenuItem"
        Me.OutPatientConsultationToolStripMenuItem.Size = New System.Drawing.Size(313, 28)
        Me.OutPatientConsultationToolStripMenuItem.Text = "Out Patient Consultation"
        '
        'InPatientToolStripMenuItem
        '
        Me.InPatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InPToolStripMenuItem, Me.PatientAdmissionToolStripMenuItem, Me.PatientBillingToolStripMenuItem})
        Me.InPatientToolStripMenuItem.Name = "InPatientToolStripMenuItem"
        Me.InPatientToolStripMenuItem.Size = New System.Drawing.Size(114, 27)
        Me.InPatientToolStripMenuItem.Text = "In Patient"
        '
        'InPToolStripMenuItem
        '
        Me.InPToolStripMenuItem.Name = "InPToolStripMenuItem"
        Me.InPToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.InPToolStripMenuItem.Text = "In Patient Details"
        '
        'PatientAdmissionToolStripMenuItem
        '
        Me.PatientAdmissionToolStripMenuItem.Name = "PatientAdmissionToolStripMenuItem"
        Me.PatientAdmissionToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.PatientAdmissionToolStripMenuItem.Text = "Patient Admission"
        '
        'PatientBillingToolStripMenuItem
        '
        Me.PatientBillingToolStripMenuItem.Name = "PatientBillingToolStripMenuItem"
        Me.PatientBillingToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.PatientBillingToolStripMenuItem.Text = "Patient Billing"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutPatientDetailsToolStripMenuItem1, Me.InPatientDetailsToolStripMenuItem, Me.OutPatientToolStripMenuItem, Me.InPatientBillingDetailsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(102, 27)
        Me.ReportsToolStripMenuItem.Text = " Reports"
        '
        'OutPatientDetailsToolStripMenuItem1
        '
        Me.OutPatientDetailsToolStripMenuItem1.Name = "OutPatientDetailsToolStripMenuItem1"
        Me.OutPatientDetailsToolStripMenuItem1.Size = New System.Drawing.Size(386, 28)
        Me.OutPatientDetailsToolStripMenuItem1.Text = "Out Patient Details"
        '
        'InPatientDetailsToolStripMenuItem
        '
        Me.InPatientDetailsToolStripMenuItem.Name = "InPatientDetailsToolStripMenuItem"
        Me.InPatientDetailsToolStripMenuItem.Size = New System.Drawing.Size(386, 28)
        Me.InPatientDetailsToolStripMenuItem.Text = "InPatient Details"
        '
        'OutPatientToolStripMenuItem
        '
        Me.OutPatientToolStripMenuItem.Name = "OutPatientToolStripMenuItem"
        Me.OutPatientToolStripMenuItem.Size = New System.Drawing.Size(386, 28)
        Me.OutPatientToolStripMenuItem.Text = "Out Patient Consultation Details"
        '
        'InPatientBillingDetailsToolStripMenuItem
        '
        Me.InPatientBillingDetailsToolStripMenuItem.Name = "InPatientBillingDetailsToolStripMenuItem"
        Me.InPatientBillingDetailsToolStripMenuItem.Size = New System.Drawing.Size(386, 28)
        Me.InPatientBillingDetailsToolStripMenuItem.Text = "In patient Billing Report"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 27)
        Me.ToolStripMenuItem1.Text = "Steganography"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1488, 699)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "Hospital Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPatientDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPatientConsultationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientAdmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientBillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPatientDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InPatientDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InPatientBillingDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
