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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBalloonRides = New System.Windows.Forms.TextBox()
        Me.txtBungeeJumps = New System.Windows.Forms.TextBox()
        Me.txtBalloonCom = New System.Windows.Forms.TextBox()
        Me.txtBungeeCom = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radAUD = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radEU = New System.Windows.Forms.RadioButton()
        Me.radUSA = New System.Windows.Forms.RadioButton()
        Me.radUK = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblIdentify = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales + Commision Record"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(436, 100)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Complete the number of sales of Hot Spot" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "trips in the spaces provided below. Cli" &
    "ck on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the ""Calculate"" button to determine the sales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "commission gained."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(131, 180)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(340, 31)
        Me.txtName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sale Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(318, 475)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Commission"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 519)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Balloon Rides:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 569)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Bungee Jumps:"
        '
        'txtBalloonRides
        '
        Me.txtBalloonRides.Location = New System.Drawing.Point(189, 519)
        Me.txtBalloonRides.Name = "txtBalloonRides"
        Me.txtBalloonRides.Size = New System.Drawing.Size(82, 31)
        Me.txtBalloonRides.TabIndex = 11
        '
        'txtBungeeJumps
        '
        Me.txtBungeeJumps.Location = New System.Drawing.Point(189, 569)
        Me.txtBungeeJumps.Name = "txtBungeeJumps"
        Me.txtBungeeJumps.Size = New System.Drawing.Size(82, 31)
        Me.txtBungeeJumps.TabIndex = 12
        '
        'txtBalloonCom
        '
        Me.txtBalloonCom.Location = New System.Drawing.Point(323, 519)
        Me.txtBalloonCom.Name = "txtBalloonCom"
        Me.txtBalloonCom.Size = New System.Drawing.Size(191, 31)
        Me.txtBalloonCom.TabIndex = 13
        '
        'txtBungeeCom
        '
        Me.txtBungeeCom.Location = New System.Drawing.Point(323, 569)
        Me.txtBungeeCom.Name = "txtBungeeCom"
        Me.txtBungeeCom.Size = New System.Drawing.Size(191, 31)
        Me.txtBungeeCom.TabIndex = 14
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(19, 625)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(252, 53)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Save + Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(353, 625)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(161, 53)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Menu"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblIdentify)
        Me.GroupBox1.Controls.Add(Me.radAUD)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.radEU)
        Me.GroupBox1.Controls.Add(Me.radUSA)
        Me.GroupBox1.Controls.Add(Me.radUK)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 161)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'radAUD
        '
        Me.radAUD.AutoSize = True
        Me.radAUD.Location = New System.Drawing.Point(247, 121)
        Me.radAUD.Name = "radAUD"
        Me.radAUD.Size = New System.Drawing.Size(86, 29)
        Me.radAUD.TabIndex = 4
        Me.radAUD.TabStop = True
        Me.radAUD.Text = "AUS"
        Me.radAUD.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 50)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "I wish to be paid in a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " different currency:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radEU
        '
        Me.radEU.AutoSize = True
        Me.radEU.Location = New System.Drawing.Point(247, 86)
        Me.radEU.Name = "radEU"
        Me.radEU.Size = New System.Drawing.Size(112, 29)
        Me.radEU.TabIndex = 2
        Me.radEU.TabStop = True
        Me.radEU.Text = "Europe"
        Me.radEU.UseVisualStyleBackColor = True
        '
        'radUSA
        '
        Me.radUSA.AutoSize = True
        Me.radUSA.Location = New System.Drawing.Point(247, 51)
        Me.radUSA.Name = "radUSA"
        Me.radUSA.Size = New System.Drawing.Size(86, 29)
        Me.radUSA.TabIndex = 1
        Me.radUSA.TabStop = True
        Me.radUSA.Text = "USA"
        Me.radUSA.UseVisualStyleBackColor = True
        '
        'radUK
        '
        Me.radUK.AutoSize = True
        Me.radUK.Location = New System.Drawing.Point(247, 18)
        Me.radUK.Name = "radUK"
        Me.radUK.Size = New System.Drawing.Size(72, 29)
        Me.radUK.TabIndex = 0
        Me.radUK.TabStop = True
        Me.radUK.Text = "UK"
        Me.radUK.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(163, 226)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(308, 31)
        Me.dtpDate.TabIndex = 18
        '
        'lblIdentify
        '
        Me.lblIdentify.AutoSize = True
        Me.lblIdentify.Location = New System.Drawing.Point(6, 101)
        Me.lblIdentify.Name = "lblIdentify"
        Me.lblIdentify.Size = New System.Drawing.Size(26, 25)
        Me.lblIdentify.TabIndex = 19
        Me.lblIdentify.Text = "S"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 729)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBungeeCom)
        Me.Controls.Add(Me.txtBalloonCom)
        Me.Controls.Add(Me.txtBungeeJumps)
        Me.Controls.Add(Me.txtBalloonRides)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBalloonRides As TextBox
    Friend WithEvents txtBungeeJumps As TextBox
    Friend WithEvents txtBalloonCom As TextBox
    Friend WithEvents txtBungeeCom As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents radEU As RadioButton
    Friend WithEvents radUSA As RadioButton
    Friend WithEvents radUK As RadioButton
    Friend WithEvents radAUD As RadioButton
    Friend WithEvents lblIdentify As Label
End Class
