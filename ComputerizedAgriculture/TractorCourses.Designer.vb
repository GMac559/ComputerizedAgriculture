<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TractorCourses
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
        Me.lblTractorSub = New System.Windows.Forms.Label()
        Me.lblTractorTitle = New System.Windows.Forms.Label()
        Me.gbCourses = New System.Windows.Forms.GroupBox()
        Me.txtJob = New System.Windows.Forms.TextBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtField = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDriverPat = New System.Windows.Forms.Label()
        Me.lblTimePat = New System.Windows.Forms.Label()
        Me.lblFieldPat = New System.Windows.Forms.Label()
        Me.lblPatternSelect = New System.Windows.Forms.Label()
        Me.cmbPatterns = New System.Windows.Forms.ComboBox()
        Me.btnStartScreen = New System.Windows.Forms.Button()
        Me.gbCourses.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTractorSub
        '
        Me.lblTractorSub.AutoSize = True
        Me.lblTractorSub.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTractorSub.Location = New System.Drawing.Point(13, 62)
        Me.lblTractorSub.Name = "lblTractorSub"
        Me.lblTractorSub.Size = New System.Drawing.Size(292, 44)
        Me.lblTractorSub.TabIndex = 5
        Me.lblTractorSub.Text = "Computerized Agriculture"
        '
        'lblTractorTitle
        '
        Me.lblTractorTitle.AutoSize = True
        Me.lblTractorTitle.Font = New System.Drawing.Font("Agency FB", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTractorTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTractorTitle.Name = "lblTractorTitle"
        Me.lblTractorTitle.Size = New System.Drawing.Size(245, 53)
        Me.lblTractorTitle.TabIndex = 4
        Me.lblTractorTitle.Text = "Tractor Patterns"
        '
        'gbCourses
        '
        Me.gbCourses.Controls.Add(Me.txtJob)
        Me.gbCourses.Controls.Add(Me.txtDriver)
        Me.gbCourses.Controls.Add(Me.txtTime)
        Me.gbCourses.Controls.Add(Me.txtField)
        Me.gbCourses.Controls.Add(Me.Label1)
        Me.gbCourses.Controls.Add(Me.lblDriverPat)
        Me.gbCourses.Controls.Add(Me.lblTimePat)
        Me.gbCourses.Controls.Add(Me.lblFieldPat)
        Me.gbCourses.Controls.Add(Me.lblPatternSelect)
        Me.gbCourses.Controls.Add(Me.cmbPatterns)
        Me.gbCourses.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCourses.Location = New System.Drawing.Point(156, 131)
        Me.gbCourses.Name = "gbCourses"
        Me.gbCourses.Size = New System.Drawing.Size(482, 320)
        Me.gbCourses.TabIndex = 6
        Me.gbCourses.TabStop = False
        Me.gbCourses.Text = "Tractor Courses"
        '
        'txtJob
        '
        Me.txtJob.Location = New System.Drawing.Point(169, 260)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(284, 36)
        Me.txtJob.TabIndex = 14
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(169, 214)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(284, 36)
        Me.txtDriver.TabIndex = 13
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(169, 169)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(284, 36)
        Me.txtTime.TabIndex = 12
        '
        'txtField
        '
        Me.txtField.Location = New System.Drawing.Point(169, 123)
        Me.txtField.Name = "txtField"
        Me.txtField.Size = New System.Drawing.Size(284, 36)
        Me.txtField.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Job:"
        '
        'lblDriverPat
        '
        Me.lblDriverPat.AutoSize = True
        Me.lblDriverPat.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverPat.Location = New System.Drawing.Point(28, 214)
        Me.lblDriverPat.Name = "lblDriverPat"
        Me.lblDriverPat.Size = New System.Drawing.Size(63, 28)
        Me.lblDriverPat.TabIndex = 9
        Me.lblDriverPat.Text = "Driver:"
        '
        'lblTimePat
        '
        Me.lblTimePat.AutoSize = True
        Me.lblTimePat.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimePat.Location = New System.Drawing.Point(28, 167)
        Me.lblTimePat.Name = "lblTimePat"
        Me.lblTimePat.Size = New System.Drawing.Size(51, 28)
        Me.lblTimePat.TabIndex = 8
        Me.lblTimePat.Text = "Time:"
        '
        'lblFieldPat
        '
        Me.lblFieldPat.AutoSize = True
        Me.lblFieldPat.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFieldPat.Location = New System.Drawing.Point(28, 122)
        Me.lblFieldPat.Name = "lblFieldPat"
        Me.lblFieldPat.Size = New System.Drawing.Size(49, 28)
        Me.lblFieldPat.TabIndex = 7
        Me.lblFieldPat.Text = "Field:"
        '
        'lblPatternSelect
        '
        Me.lblPatternSelect.AutoSize = True
        Me.lblPatternSelect.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatternSelect.Location = New System.Drawing.Point(28, 38)
        Me.lblPatternSelect.Name = "lblPatternSelect"
        Me.lblPatternSelect.Size = New System.Drawing.Size(135, 28)
        Me.lblPatternSelect.TabIndex = 6
        Me.lblPatternSelect.Text = "Select a pattern:"
        '
        'cmbPatterns
        '
        Me.cmbPatterns.FormattingEnabled = True
        Me.cmbPatterns.Location = New System.Drawing.Point(169, 35)
        Me.cmbPatterns.Name = "cmbPatterns"
        Me.cmbPatterns.Size = New System.Drawing.Size(284, 36)
        Me.cmbPatterns.TabIndex = 0
        '
        'btnStartScreen
        '
        Me.btnStartScreen.Font = New System.Drawing.Font("Agency FB", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartScreen.Location = New System.Drawing.Point(624, 12)
        Me.btnStartScreen.Name = "btnStartScreen"
        Me.btnStartScreen.Size = New System.Drawing.Size(172, 59)
        Me.btnStartScreen.TabIndex = 15
        Me.btnStartScreen.Text = "Back to Start"
        Me.btnStartScreen.UseVisualStyleBackColor = True
        '
        'TractorCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(811, 484)
        Me.Controls.Add(Me.btnStartScreen)
        Me.Controls.Add(Me.gbCourses)
        Me.Controls.Add(Me.lblTractorSub)
        Me.Controls.Add(Me.lblTractorTitle)
        Me.Name = "TractorCourses"
        Me.Text = "TractorCourses"
        Me.gbCourses.ResumeLayout(False)
        Me.gbCourses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTractorSub As Label
    Friend WithEvents lblTractorTitle As Label
    Friend WithEvents gbCourses As GroupBox
    Friend WithEvents lblDriverPat As Label
    Friend WithEvents lblTimePat As Label
    Friend WithEvents lblFieldPat As Label
    Friend WithEvents lblPatternSelect As Label
    Friend WithEvents cmbPatterns As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJob As TextBox
    Friend WithEvents txtDriver As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtField As TextBox
    Friend WithEvents btnStartScreen As Button
End Class
