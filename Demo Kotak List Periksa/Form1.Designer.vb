<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.clbKota = New System.Windows.Forms.CheckedListBox()
        Me.listPeriksa = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tombolOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clbKota
        '
        Me.clbKota.FormattingEnabled = True
        Me.clbKota.Items.AddRange(New Object() {"Siantar", "Medan", "Pekan Baru", "Padang", "Palembang", "Bengkulu", "Jambi", "Lampung", "Batam", "Bangka Belitung", "Jakarta", "Semarang", "Bandung", "Solo", "Surabaya"})
        Me.clbKota.Location = New System.Drawing.Point(12, 27)
        Me.clbKota.Name = "clbKota"
        Me.clbKota.Size = New System.Drawing.Size(178, 184)
        Me.clbKota.TabIndex = 0
        '
        'listPeriksa
        '
        Me.listPeriksa.FormattingEnabled = True
        Me.listPeriksa.Location = New System.Drawing.Point(206, 27)
        Me.listPeriksa.Name = "listPeriksa"
        Me.listPeriksa.Size = New System.Drawing.Size(154, 186)
        Me.listPeriksa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pilih satu atau lebih kota:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Anda mencentang:"
        '
        'tombolOK
        '
        Me.tombolOK.Location = New System.Drawing.Point(90, 228)
        Me.tombolOK.Name = "tombolOK"
        Me.tombolOK.Size = New System.Drawing.Size(210, 40)
        Me.tombolOK.TabIndex = 4
        Me.tombolOK.Text = "OK"
        Me.tombolOK.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 280)
        Me.Controls.Add(Me.tombolOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listPeriksa)
        Me.Controls.Add(Me.clbKota)
        Me.Name = "Form1"
        Me.Text = "Demo Kotak List Periksa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clbKota As System.Windows.Forms.CheckedListBox
    Friend WithEvents listPeriksa As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tombolOK As System.Windows.Forms.Button

End Class
