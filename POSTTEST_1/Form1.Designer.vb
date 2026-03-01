<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblIPSemester = New Label()
        lblIPKumulatif = New Label()
        lblPredikat = New Label()
        txtIPSemester = New TextBox()
        txtIPKumulatif = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' lblIPSemester
        ' 
        lblIPSemester.AutoSize = True
        lblIPSemester.Location = New Point(246, 150)
        lblIPSemester.Name = "lblIPSemester"
        lblIPSemester.Size = New Size(68, 15)
        lblIPSemester.TabIndex = 0
        lblIPSemester.Text = "IP Semester"
        ' 
        ' lblIPKumulatif
        ' 
        lblIPKumulatif.AutoSize = True
        lblIPKumulatif.Location = New Point(246, 242)
        lblIPKumulatif.Name = "lblIPKumulatif"
        lblIPKumulatif.Size = New Size(72, 15)
        lblIPKumulatif.TabIndex = 1
        lblIPKumulatif.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPredikat.Location = New Point(372, 292)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 15)
        lblPredikat.TabIndex = 2
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(372, 147)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(172, 23)
        txtIPSemester.TabIndex = 3
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.Location = New Point(372, 239)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.ReadOnly = True
        txtIPKumulatif.Size = New Size(172, 23)
        txtIPKumulatif.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(372, 192)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(469, 192)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPKumulatif)
        Controls.Add(txtIPSemester)
        Controls.Add(lblPredikat)
        Controls.Add(lblIPKumulatif)
        Controls.Add(lblIPSemester)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPSemester As Label
    Friend WithEvents lblIPKumulatif As Label
    Friend WithEvents lblPredikat As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents txtIPKumulatif As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button

End Class
