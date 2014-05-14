<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PBAS_Acad_Act
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
        Me.Acad_Actbox = New System.Windows.Forms.GroupBox
        Me.GI_AQ_No = New System.Windows.Forms.RadioButton
        Me.GI_AQ_Yes = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.GI_Aqyear = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GI2_Combo = New System.Windows.Forms.ComboBox
        Me.GI2_Deletebtn = New System.Windows.Forms.Button
        Me.GI2_Showbtn = New System.Windows.Forms.Button
        Me.GI2_Addbtn = New System.Windows.Forms.Button
        Me.GI_Place = New System.Windows.Forms.TextBox
        Me.GI_SA = New System.Windows.Forms.TextBox
        Me.GI_Dur = New System.Windows.Forms.TextBox
        Me.GI_NOC = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GI_ASC_No = New System.Windows.Forms.RadioButton
        Me.GI_ASC_yes = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.Acad_Actbox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Acad_Actbox
        '
        Me.Acad_Actbox.Controls.Add(Me.Panel1)
        Me.Acad_Actbox.Controls.Add(Me.GI_AQ_No)
        Me.Acad_Actbox.Controls.Add(Me.GI_AQ_Yes)
        Me.Acad_Actbox.Controls.Add(Me.Label19)
        Me.Acad_Actbox.Controls.Add(Me.GI_Aqyear)
        Me.Acad_Actbox.Controls.Add(Me.GroupBox2)
        Me.Acad_Actbox.Controls.Add(Me.GI_Place)
        Me.Acad_Actbox.Controls.Add(Me.GI_SA)
        Me.Acad_Actbox.Controls.Add(Me.GI_Dur)
        Me.Acad_Actbox.Controls.Add(Me.GI_NOC)
        Me.Acad_Actbox.Controls.Add(Me.Label16)
        Me.Acad_Actbox.Controls.Add(Me.Label15)
        Me.Acad_Actbox.Controls.Add(Me.Label14)
        Me.Acad_Actbox.Controls.Add(Me.Label13)
        Me.Acad_Actbox.Controls.Add(Me.Label12)
        Me.Acad_Actbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acad_Actbox.Location = New System.Drawing.Point(24, 12)
        Me.Acad_Actbox.Name = "Acad_Actbox"
        Me.Acad_Actbox.Size = New System.Drawing.Size(568, 582)
        Me.Acad_Actbox.TabIndex = 36
        Me.Acad_Actbox.TabStop = False
        Me.Acad_Actbox.Text = "FORM"
        '
        'GI_AQ_No
        '
        Me.GI_AQ_No.AutoSize = True
        Me.GI_AQ_No.Location = New System.Drawing.Point(481, 53)
        Me.GI_AQ_No.Name = "GI_AQ_No"
        Me.GI_AQ_No.Size = New System.Drawing.Size(46, 21)
        Me.GI_AQ_No.TabIndex = 48
        Me.GI_AQ_No.TabStop = True
        Me.GI_AQ_No.Text = "No"
        Me.GI_AQ_No.UseVisualStyleBackColor = True
        '
        'GI_AQ_Yes
        '
        Me.GI_AQ_Yes.AutoSize = True
        Me.GI_AQ_Yes.Location = New System.Drawing.Point(418, 53)
        Me.GI_AQ_Yes.Name = "GI_AQ_Yes"
        Me.GI_AQ_Yes.Size = New System.Drawing.Size(51, 21)
        Me.GI_AQ_Yes.TabIndex = 47
        Me.GI_AQ_Yes.TabStop = True
        Me.GI_AQ_Yes.Text = "yes"
        Me.GI_AQ_Yes.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(47, 254)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 17)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Year"
        '
        'GI_Aqyear
        '
        Me.GI_Aqyear.Location = New System.Drawing.Point(335, 251)
        Me.GI_Aqyear.Name = "GI_Aqyear"
        Me.GI_Aqyear.Size = New System.Drawing.Size(197, 23)
        Me.GI_Aqyear.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GI2_Combo)
        Me.GroupBox2.Controls.Add(Me.GI2_Deletebtn)
        Me.GroupBox2.Controls.Add(Me.GI2_Showbtn)
        Me.GroupBox2.Controls.Add(Me.GI2_Addbtn)
        Me.GroupBox2.Location = New System.Drawing.Point(75, 390)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 134)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPERATION"
        '
        'GI2_Combo
        '
        Me.GI2_Combo.FormattingEnabled = True
        Me.GI2_Combo.Location = New System.Drawing.Point(50, 77)
        Me.GI2_Combo.Name = "GI2_Combo"
        Me.GI2_Combo.Size = New System.Drawing.Size(141, 24)
        Me.GI2_Combo.TabIndex = 9
        Me.GI2_Combo.Text = "---- Course ----"
        '
        'GI2_Deletebtn
        '
        Me.GI2_Deletebtn.Location = New System.Drawing.Point(221, 30)
        Me.GI2_Deletebtn.Name = "GI2_Deletebtn"
        Me.GI2_Deletebtn.Size = New System.Drawing.Size(106, 23)
        Me.GI2_Deletebtn.TabIndex = 11
        Me.GI2_Deletebtn.Text = "Delete"
        Me.GI2_Deletebtn.UseVisualStyleBackColor = True
        '
        'GI2_Showbtn
        '
        Me.GI2_Showbtn.Location = New System.Drawing.Point(221, 77)
        Me.GI2_Showbtn.Name = "GI2_Showbtn"
        Me.GI2_Showbtn.Size = New System.Drawing.Size(105, 24)
        Me.GI2_Showbtn.TabIndex = 10
        Me.GI2_Showbtn.Text = "Show"
        Me.GI2_Showbtn.UseVisualStyleBackColor = True
        '
        'GI2_Addbtn
        '
        Me.GI2_Addbtn.Location = New System.Drawing.Point(50, 32)
        Me.GI2_Addbtn.Name = "GI2_Addbtn"
        Me.GI2_Addbtn.Size = New System.Drawing.Size(106, 23)
        Me.GI2_Addbtn.TabIndex = 8
        Me.GI2_Addbtn.Text = "Save"
        Me.GI2_Addbtn.UseVisualStyleBackColor = True
        '
        'GI_Place
        '
        Me.GI_Place.Location = New System.Drawing.Point(335, 143)
        Me.GI_Place.Name = "GI_Place"
        Me.GI_Place.Size = New System.Drawing.Size(197, 23)
        Me.GI_Place.TabIndex = 2
        '
        'GI_SA
        '
        Me.GI_SA.Location = New System.Drawing.Point(335, 214)
        Me.GI_SA.Name = "GI_SA"
        Me.GI_SA.Size = New System.Drawing.Size(197, 23)
        Me.GI_SA.TabIndex = 4
        '
        'GI_Dur
        '
        Me.GI_Dur.Location = New System.Drawing.Point(335, 179)
        Me.GI_Dur.Name = "GI_Dur"
        Me.GI_Dur.Size = New System.Drawing.Size(197, 23)
        Me.GI_Dur.TabIndex = 3
        '
        'GI_NOC
        '
        Me.GI_NOC.Location = New System.Drawing.Point(335, 110)
        Me.GI_NOC.Name = "GI_NOC"
        Me.GI_NOC.Size = New System.Drawing.Size(197, 23)
        Me.GI_NOC.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(359, 34)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Whether acquired any degree or fresh academic" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " qualification during the year : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(45, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 17)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Sponsoring Agency"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(45, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Duration"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(45, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Place"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Name Of Course"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GI_ASC_No)
        Me.Panel1.Controls.Add(Me.GI_ASC_yes)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Location = New System.Drawing.Point(6, 305)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 67)
        Me.Panel1.TabIndex = 49
        '
        'GI_ASC_No
        '
        Me.GI_ASC_No.AutoSize = True
        Me.GI_ASC_No.Location = New System.Drawing.Point(474, 34)
        Me.GI_ASC_No.Name = "GI_ASC_No"
        Me.GI_ASC_No.Size = New System.Drawing.Size(46, 21)
        Me.GI_ASC_No.TabIndex = 53
        Me.GI_ASC_No.TabStop = True
        Me.GI_ASC_No.Text = "No"
        Me.GI_ASC_No.UseVisualStyleBackColor = True
        '
        'GI_ASC_yes
        '
        Me.GI_ASC_yes.AutoSize = True
        Me.GI_ASC_yes.Location = New System.Drawing.Point(411, 34)
        Me.GI_ASC_yes.Name = "GI_ASC_yes"
        Me.GI_ASC_yes.Size = New System.Drawing.Size(51, 21)
        Me.GI_ASC_yes.TabIndex = 52
        Me.GI_ASC_yes.TabStop = True
        Me.GI_ASC_yes.Text = "yes"
        Me.GI_ASC_yes.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(37, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(348, 34)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Academic Staff College Orientation / Refresher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Course Attended During The Year :" & _
            ""
        '
        'PBAS_Acad_Act
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 606)
        Me.Controls.Add(Me.Acad_Actbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PBAS_Acad_Act"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACADEMIC ACTIVITIES"
        Me.Acad_Actbox.ResumeLayout(False)
        Me.Acad_Actbox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Acad_Actbox As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GI_Aqyear As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GI2_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents GI2_Deletebtn As System.Windows.Forms.Button
    Friend WithEvents GI2_Showbtn As System.Windows.Forms.Button
    Friend WithEvents GI2_Addbtn As System.Windows.Forms.Button
    Friend WithEvents GI_Place As System.Windows.Forms.TextBox
    Friend WithEvents GI_SA As System.Windows.Forms.TextBox
    Friend WithEvents GI_Dur As System.Windows.Forms.TextBox
    Friend WithEvents GI_NOC As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GI_AQ_No As System.Windows.Forms.RadioButton
    Friend WithEvents GI_AQ_Yes As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GI_ASC_No As System.Windows.Forms.RadioButton
    Friend WithEvents GI_ASC_yes As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
