﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Title
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnCustom = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(10, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(218, 21)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Who Wants to be a Millionaire?"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(14, 62)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(214, 23)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(14, 91)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(214, 23)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(14, 120)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(214, 23)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnCustom
        '
        Me.btnCustom.Location = New System.Drawing.Point(14, 149)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(214, 23)
        Me.btnCustom.TabIndex = 5
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Monotype Corsiva", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(11, 324)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(163, 13)
        Me.lblCopyright.TabIndex = 6
        Me.lblCopyright.Text = "Oklahoma Baptist University - © 2018"
        '
        'Title
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 346)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.btnCustom)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Title"
        Me.Text = "Title Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnCustom As Button
    Friend WithEvents lblCopyright As Label
End Class
