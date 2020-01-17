<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedinaSevenSegment
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GG = New System.Windows.Forms.Button()
        Me.AA = New System.Windows.Forms.Button()
        Me.FF = New System.Windows.Forms.Button()
        Me.CC = New System.Windows.Forms.Button()
        Me.BB = New System.Windows.Forms.Button()
        Me.EE = New System.Windows.Forms.Button()
        Me.DD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Medina, Mark Jason A. BS CpE 5-3"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'GG
        '
        Me.GG.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GG.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.GG.FlatAppearance.BorderSize = 0
        Me.GG.Location = New System.Drawing.Point(99, 221)
        Me.GG.Name = "GG"
        Me.GG.Size = New System.Drawing.Size(137, 23)
        Me.GG.TabIndex = 16
        Me.GG.UseVisualStyleBackColor = False
        '
        'AA
        '
        Me.AA.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.AA.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.AA.FlatAppearance.BorderSize = 0
        Me.AA.Location = New System.Drawing.Point(99, 57)
        Me.AA.Name = "AA"
        Me.AA.Size = New System.Drawing.Size(137, 23)
        Me.AA.TabIndex = 17
        Me.AA.UseVisualStyleBackColor = False
        '
        'FF
        '
        Me.FF.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.FF.Location = New System.Drawing.Point(70, 83)
        Me.FF.Name = "FF"
        Me.FF.Size = New System.Drawing.Size(23, 137)
        Me.FF.TabIndex = 18
        Me.FF.UseVisualStyleBackColor = False
        '
        'CC
        '
        Me.CC.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.CC.Location = New System.Drawing.Point(242, 248)
        Me.CC.Name = "CC"
        Me.CC.Size = New System.Drawing.Size(23, 137)
        Me.CC.TabIndex = 19
        Me.CC.UseVisualStyleBackColor = False
        '
        'BB
        '
        Me.BB.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.BB.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BB.FlatAppearance.BorderSize = 0
        Me.BB.Location = New System.Drawing.Point(242, 83)
        Me.BB.Name = "BB"
        Me.BB.Size = New System.Drawing.Size(23, 137)
        Me.BB.TabIndex = 20
        Me.BB.UseVisualStyleBackColor = False
        '
        'EE
        '
        Me.EE.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.EE.Location = New System.Drawing.Point(70, 248)
        Me.EE.Name = "EE"
        Me.EE.Size = New System.Drawing.Size(23, 137)
        Me.EE.TabIndex = 21
        Me.EE.UseVisualStyleBackColor = False
        '
        'DD
        '
        Me.DD.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.DD.Location = New System.Drawing.Point(99, 388)
        Me.DD.Name = "DD"
        Me.DD.Size = New System.Drawing.Size(137, 23)
        Me.DD.TabIndex = 22
        Me.DD.UseVisualStyleBackColor = False
        '
        'MedinaSevenSegment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 450)
        Me.Controls.Add(Me.DD)
        Me.Controls.Add(Me.EE)
        Me.Controls.Add(Me.BB)
        Me.Controls.Add(Me.CC)
        Me.Controls.Add(Me.FF)
        Me.Controls.Add(Me.AA)
        Me.Controls.Add(Me.GG)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MedinaSevenSegment"
        Me.Text = "Assignment #2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents GG As Button
    Friend WithEvents AA As Button
    Friend WithEvents FF As Button
    Friend WithEvents CC As Button
    Friend WithEvents BB As Button
    Friend WithEvents EE As Button
    Friend WithEvents DD As Button
End Class
