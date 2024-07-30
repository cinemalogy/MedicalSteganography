<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIForm1))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.MasterEntriesToolStripMenuItem, Me.ProductEntryToolStripMenuItem, Me.PurchaseEntryToolStripMenuItem, Me.SalesToolStripMenuItem, Me.StockReportToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip1.Location = New System.Drawing.Point(1382, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(264, 852)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(83, 58)
        Me.ToolStripMenuItem2.Text = "    "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(83, 58)
        Me.ToolStripMenuItem1.Text = "    "
        '
        'MasterEntriesToolStripMenuItem
        '
        Me.MasterEntriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerEntryToolStripMenuItem, Me.SupplierEntryToolStripMenuItem, Me.CategoryEntryToolStripMenuItem, Me.GroupEntryToolStripMenuItem})
        Me.MasterEntriesToolStripMenuItem.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterEntriesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MasterEntriesToolStripMenuItem.Name = "MasterEntriesToolStripMenuItem"
        Me.MasterEntriesToolStripMenuItem.Size = New System.Drawing.Size(258, 58)
        Me.MasterEntriesToolStripMenuItem.Text = "Master Entries"
        '
        'CustomerEntryToolStripMenuItem
        '
        Me.CustomerEntryToolStripMenuItem.Name = "CustomerEntryToolStripMenuItem"
        Me.CustomerEntryToolStripMenuItem.Size = New System.Drawing.Size(349, 58)
        Me.CustomerEntryToolStripMenuItem.Text = "Customer Entry"
        '
        'SupplierEntryToolStripMenuItem
        '
        Me.SupplierEntryToolStripMenuItem.Name = "SupplierEntryToolStripMenuItem"
        Me.SupplierEntryToolStripMenuItem.Size = New System.Drawing.Size(349, 58)
        Me.SupplierEntryToolStripMenuItem.Text = "Supplier Entry"
        '
        'CategoryEntryToolStripMenuItem
        '
        Me.CategoryEntryToolStripMenuItem.Name = "CategoryEntryToolStripMenuItem"
        Me.CategoryEntryToolStripMenuItem.Size = New System.Drawing.Size(349, 58)
        Me.CategoryEntryToolStripMenuItem.Text = "Category Entry"
        '
        'GroupEntryToolStripMenuItem
        '
        Me.GroupEntryToolStripMenuItem.Name = "GroupEntryToolStripMenuItem"
        Me.GroupEntryToolStripMenuItem.Size = New System.Drawing.Size(349, 58)
        Me.GroupEntryToolStripMenuItem.Text = "Group Entry"
        '
        'ProductEntryToolStripMenuItem
        '
        Me.ProductEntryToolStripMenuItem.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductEntryToolStripMenuItem.Name = "ProductEntryToolStripMenuItem"
        Me.ProductEntryToolStripMenuItem.Size = New System.Drawing.Size(254, 58)
        Me.ProductEntryToolStripMenuItem.Text = "Product Entry"
        '
        'PurchaseEntryToolStripMenuItem
        '
        Me.PurchaseEntryToolStripMenuItem.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseEntryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PurchaseEntryToolStripMenuItem.Name = "PurchaseEntryToolStripMenuItem"
        Me.PurchaseEntryToolStripMenuItem.Size = New System.Drawing.Size(269, 58)
        Me.PurchaseEntryToolStripMenuItem.Text = "Purchase Entry"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(110, 58)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'StockReportToolStripMenuItem
        '
        Me.StockReportToolStripMenuItem.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockReportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StockReportToolStripMenuItem.Name = "StockReportToolStripMenuItem"
        Me.StockReportToolStripMenuItem.Size = New System.Drawing.Size(233, 58)
        Me.StockReportToolStripMenuItem.Text = "Stock Report"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseReportToolStripMenuItem, Me.SalesReportToolStripMenuItem, Me.CustomerListToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(151, 58)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'PurchaseReportToolStripMenuItem
        '
        Me.PurchaseReportToolStripMenuItem.Name = "PurchaseReportToolStripMenuItem"
        Me.PurchaseReportToolStripMenuItem.Size = New System.Drawing.Size(356, 58)
        Me.PurchaseReportToolStripMenuItem.Text = "Purchase Report"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(356, 58)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'CustomerListToolStripMenuItem
        '
        Me.CustomerListToolStripMenuItem.Name = "CustomerListToolStripMenuItem"
        Me.CustomerListToolStripMenuItem.Size = New System.Drawing.Size(356, 58)
        Me.CustomerListToolStripMenuItem.Text = "Customer List"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(156, 58)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 830)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1382, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MDIForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1646, 852)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIForm1"
        Me.Text = "Medical Store Inventory Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MasterEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
