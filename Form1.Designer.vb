<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BT = New System.Windows.Forms.Button()
        Me.btnvariables = New System.Windows.Forms.Button()
        Me.PORSCHBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BT
        '
        Me.BT.Location = New System.Drawing.Point(113, 83)
        Me.BT.Name = "BT"
        Me.BT.Size = New System.Drawing.Size(168, 103)
        Me.BT.TabIndex = 0
        Me.BT.Text = "GO"
        Me.BT.UseVisualStyleBackColor = True
        '
        'btnvariables
        '
        Me.btnvariables.Location = New System.Drawing.Point(401, 83)
        Me.btnvariables.Name = "btnvariables"
        Me.btnvariables.Size = New System.Drawing.Size(182, 103)
        Me.btnvariables.TabIndex = 1
        Me.btnvariables.Text = "btn variables"
        Me.btnvariables.UseVisualStyleBackColor = True
        '
        'PORSCHBTN
        '
        Me.PORSCHBTN.BackColor = System.Drawing.Color.OrangeRed
        Me.PORSCHBTN.Location = New System.Drawing.Point(113, 222)
        Me.PORSCHBTN.Name = "PORSCHBTN"
        Me.PORSCHBTN.Size = New System.Drawing.Size(163, 95)
        Me.PORSCHBTN.TabIndex = 2
        Me.PORSCHBTN.Text = "PORSCHE"
        Me.PORSCHBTN.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PORSCHBTN)
        Me.Controls.Add(Me.btnvariables)
        Me.Controls.Add(Me.BT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BT As Button
    Friend WithEvents btnvariables As Button
    Friend WithEvents PORSCHBTN As Button
End Class
