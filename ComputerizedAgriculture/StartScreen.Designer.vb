<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
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
        Me.lblStartTitle = New System.Windows.Forms.Label()
        Me.lblSubStart = New System.Windows.Forms.Label()
        Me.btnSprinklers = New System.Windows.Forms.Button()
        Me.btnFarmer = New System.Windows.Forms.Button()
        Me.btnTractor = New System.Windows.Forms.Button()
        Me.pbTractor = New System.Windows.Forms.PictureBox()
        Me.pbFarmer = New System.Windows.Forms.PictureBox()
        Me.pbSprinklers = New System.Windows.Forms.PictureBox()
        CType(Me.pbTractor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFarmer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSprinklers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStartTitle
        '
        Me.lblStartTitle.AutoSize = True
        Me.lblStartTitle.Font = New System.Drawing.Font("Agency FB", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblStartTitle.Name = "lblStartTitle"
        Me.lblStartTitle.Size = New System.Drawing.Size(365, 53)
        Me.lblStartTitle.TabIndex = 0
        Me.lblStartTitle.Text = "Computerized Agriculture"
        '
        'lblSubStart
        '
        Me.lblSubStart.AutoSize = True
        Me.lblSubStart.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubStart.Location = New System.Drawing.Point(13, 62)
        Me.lblSubStart.Name = "lblSubStart"
        Me.lblSubStart.Size = New System.Drawing.Size(248, 44)
        Me.lblSubStart.TabIndex = 1
        Me.lblSubStart.Text = "Farming of the Future"
        '
        'btnSprinklers
        '
        Me.btnSprinklers.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSprinklers.Location = New System.Drawing.Point(90, 436)
        Me.btnSprinklers.Name = "btnSprinklers"
        Me.btnSprinklers.Size = New System.Drawing.Size(188, 64)
        Me.btnSprinklers.TabIndex = 2
        Me.btnSprinklers.Text = "Sprinkler Control"
        Me.btnSprinklers.UseVisualStyleBackColor = True
        '
        'btnFarmer
        '
        Me.btnFarmer.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFarmer.Location = New System.Drawing.Point(305, 436)
        Me.btnFarmer.Name = "btnFarmer"
        Me.btnFarmer.Size = New System.Drawing.Size(188, 64)
        Me.btnFarmer.TabIndex = 3
        Me.btnFarmer.Text = "Farmer Information"
        Me.btnFarmer.UseVisualStyleBackColor = True
        '
        'btnTractor
        '
        Me.btnTractor.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTractor.Location = New System.Drawing.Point(520, 436)
        Me.btnTractor.Name = "btnTractor"
        Me.btnTractor.Size = New System.Drawing.Size(188, 64)
        Me.btnTractor.TabIndex = 4
        Me.btnTractor.Text = "Tractor Courses"
        Me.btnTractor.UseVisualStyleBackColor = True
        '
        'pbTractor
        '
        Me.pbTractor.BackgroundImage = Global.ComputerizedAgriculture.My.Resources.Resources.tractor
        Me.pbTractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTractor.Location = New System.Drawing.Point(520, 128)
        Me.pbTractor.Name = "pbTractor"
        Me.pbTractor.Size = New System.Drawing.Size(188, 302)
        Me.pbTractor.TabIndex = 7
        Me.pbTractor.TabStop = False
        '
        'pbFarmer
        '
        Me.pbFarmer.BackgroundImage = Global.ComputerizedAgriculture.My.Resources.Resources.farmers
        Me.pbFarmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFarmer.Location = New System.Drawing.Point(305, 128)
        Me.pbFarmer.Name = "pbFarmer"
        Me.pbFarmer.Size = New System.Drawing.Size(188, 302)
        Me.pbFarmer.TabIndex = 6
        Me.pbFarmer.TabStop = False
        '
        'pbSprinklers
        '
        Me.pbSprinklers.BackgroundImage = Global.ComputerizedAgriculture.My.Resources.Resources.sprinklers
        Me.pbSprinklers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSprinklers.Location = New System.Drawing.Point(90, 128)
        Me.pbSprinklers.Name = "pbSprinklers"
        Me.pbSprinklers.Size = New System.Drawing.Size(188, 302)
        Me.pbSprinklers.TabIndex = 5
        Me.pbSprinklers.TabStop = False
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.pbTractor)
        Me.Controls.Add(Me.pbFarmer)
        Me.Controls.Add(Me.pbSprinklers)
        Me.Controls.Add(Me.btnTractor)
        Me.Controls.Add(Me.btnFarmer)
        Me.Controls.Add(Me.btnSprinklers)
        Me.Controls.Add(Me.lblSubStart)
        Me.Controls.Add(Me.lblStartTitle)
        Me.Name = "StartScreen"
        Me.Text = "Computerized Agriculture"
        CType(Me.pbTractor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFarmer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSprinklers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStartTitle As Label
    Friend WithEvents lblSubStart As Label
    Friend WithEvents btnSprinklers As Button
    Friend WithEvents btnFarmer As Button
    Friend WithEvents btnTractor As Button
    Friend WithEvents pbSprinklers As PictureBox
    Friend WithEvents pbFarmer As PictureBox
    Friend WithEvents pbTractor As PictureBox
End Class
