<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSims
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
        Me.radAbzan = New System.Windows.Forms.RadioButton()
        Me.radAffinity = New System.Windows.Forms.RadioButton()
        Me.radBurn = New System.Windows.Forms.RadioButton()
        Me.radDevoted = New System.Windows.Forms.RadioButton()
        Me.radDredge = New System.Windows.Forms.RadioButton()
        Me.radJeskai = New System.Windows.Forms.RadioButton()
        Me.radGrixis = New System.Windows.Forms.RadioButton()
        Me.radGreenTron = New System.Windows.Forms.RadioButton()
        Me.radFiveColor = New System.Windows.Forms.RadioButton()
        Me.radEldrazi = New System.Windows.Forms.RadioButton()
        Me.radWU = New System.Windows.Forms.RadioButton()
        Me.radMardu = New System.Windows.Forms.RadioButton()
        Me.radTraverse = New System.Windows.Forms.RadioButton()
        Me.radTitanShift = New System.Windows.Forms.RadioButton()
        Me.radStorm = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.lblLoss = New System.Windows.Forms.Label()
        Me.txtGames = New System.Windows.Forms.TextBox()
        Me.radWU2 = New System.Windows.Forms.RadioButton()
        Me.radMardu2 = New System.Windows.Forms.RadioButton()
        Me.radTraverse2 = New System.Windows.Forms.RadioButton()
        Me.radTitan2 = New System.Windows.Forms.RadioButton()
        Me.radStorm2 = New System.Windows.Forms.RadioButton()
        Me.radJeskai2 = New System.Windows.Forms.RadioButton()
        Me.radGrixis2 = New System.Windows.Forms.RadioButton()
        Me.radGreen2 = New System.Windows.Forms.RadioButton()
        Me.radFiveColor2 = New System.Windows.Forms.RadioButton()
        Me.radEldrazi2 = New System.Windows.Forms.RadioButton()
        Me.radDredge2 = New System.Windows.Forms.RadioButton()
        Me.radDevoted2 = New System.Windows.Forms.RadioButton()
        Me.radBurn2 = New System.Windows.Forms.RadioButton()
        Me.radAffinity2 = New System.Windows.Forms.RadioButton()
        Me.radAbzan2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radOther2 = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-44, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You've entered the Arena! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Choose your Match-up"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radAbzan
        '
        Me.radAbzan.AutoSize = True
        Me.radAbzan.Location = New System.Drawing.Point(0, 19)
        Me.radAbzan.Name = "radAbzan"
        Me.radAbzan.Size = New System.Drawing.Size(55, 17)
        Me.radAbzan.TabIndex = 1
        Me.radAbzan.TabStop = True
        Me.radAbzan.Text = "Abzan"
        Me.radAbzan.UseVisualStyleBackColor = True
        '
        'radAffinity
        '
        Me.radAffinity.AutoSize = True
        Me.radAffinity.Location = New System.Drawing.Point(0, 42)
        Me.radAffinity.Name = "radAffinity"
        Me.radAffinity.Size = New System.Drawing.Size(56, 17)
        Me.radAffinity.TabIndex = 2
        Me.radAffinity.TabStop = True
        Me.radAffinity.Text = "Affinity"
        Me.radAffinity.UseVisualStyleBackColor = True
        '
        'radBurn
        '
        Me.radBurn.AutoSize = True
        Me.radBurn.Location = New System.Drawing.Point(0, 65)
        Me.radBurn.Name = "radBurn"
        Me.radBurn.Size = New System.Drawing.Size(47, 17)
        Me.radBurn.TabIndex = 3
        Me.radBurn.TabStop = True
        Me.radBurn.Text = "Burn"
        Me.radBurn.UseVisualStyleBackColor = True
        '
        'radDevoted
        '
        Me.radDevoted.AutoSize = True
        Me.radDevoted.Location = New System.Drawing.Point(0, 88)
        Me.radDevoted.Name = "radDevoted"
        Me.radDevoted.Size = New System.Drawing.Size(113, 17)
        Me.radDevoted.TabIndex = 4
        Me.radDevoted.TabStop = True
        Me.radDevoted.Text = "Devoted Company"
        Me.radDevoted.UseVisualStyleBackColor = True
        '
        'radDredge
        '
        Me.radDredge.AutoSize = True
        Me.radDredge.Location = New System.Drawing.Point(0, 111)
        Me.radDredge.Name = "radDredge"
        Me.radDredge.Size = New System.Drawing.Size(60, 17)
        Me.radDredge.TabIndex = 5
        Me.radDredge.TabStop = True
        Me.radDredge.Text = "Dredge"
        Me.radDredge.UseVisualStyleBackColor = True
        '
        'radJeskai
        '
        Me.radJeskai.AutoSize = True
        Me.radJeskai.Location = New System.Drawing.Point(0, 226)
        Me.radJeskai.Name = "radJeskai"
        Me.radJeskai.Size = New System.Drawing.Size(91, 17)
        Me.radJeskai.TabIndex = 10
        Me.radJeskai.TabStop = True
        Me.radJeskai.Text = "Jeskai Control"
        Me.radJeskai.UseVisualStyleBackColor = True
        '
        'radGrixis
        '
        Me.radGrixis.AutoSize = True
        Me.radGrixis.Location = New System.Drawing.Point(0, 203)
        Me.radGrixis.Name = "radGrixis"
        Me.radGrixis.Size = New System.Drawing.Size(86, 17)
        Me.radGrixis.TabIndex = 9
        Me.radGrixis.TabStop = True
        Me.radGrixis.Text = "Grixis Control"
        Me.radGrixis.UseVisualStyleBackColor = True
        '
        'radGreenTron
        '
        Me.radGreenTron.AutoSize = True
        Me.radGreenTron.Location = New System.Drawing.Point(0, 180)
        Me.radGreenTron.Name = "radGreenTron"
        Me.radGreenTron.Size = New System.Drawing.Size(79, 17)
        Me.radGreenTron.TabIndex = 8
        Me.radGreenTron.TabStop = True
        Me.radGreenTron.Text = "Green Tron"
        Me.radGreenTron.UseVisualStyleBackColor = True
        '
        'radFiveColor
        '
        Me.radFiveColor.AutoSize = True
        Me.radFiveColor.Location = New System.Drawing.Point(0, 157)
        Me.radFiveColor.Name = "radFiveColor"
        Me.radFiveColor.Size = New System.Drawing.Size(114, 17)
        Me.radFiveColor.TabIndex = 7
        Me.radFiveColor.TabStop = True
        Me.radFiveColor.Text = "Five-Color Humans"
        Me.radFiveColor.UseVisualStyleBackColor = True
        '
        'radEldrazi
        '
        Me.radEldrazi.AutoSize = True
        Me.radEldrazi.Location = New System.Drawing.Point(0, 134)
        Me.radEldrazi.Name = "radEldrazi"
        Me.radEldrazi.Size = New System.Drawing.Size(81, 17)
        Me.radEldrazi.TabIndex = 6
        Me.radEldrazi.TabStop = True
        Me.radEldrazi.Text = "Eldrazi Tron"
        Me.radEldrazi.UseVisualStyleBackColor = True
        '
        'radWU
        '
        Me.radWU.AutoSize = True
        Me.radWU.Location = New System.Drawing.Point(0, 341)
        Me.radWU.Name = "radWU"
        Me.radWU.Size = New System.Drawing.Size(115, 17)
        Me.radWU.TabIndex = 15
        Me.radWU.TabStop = True
        Me.radWU.Text = "White/Blue Control"
        Me.radWU.UseVisualStyleBackColor = True
        '
        'radMardu
        '
        Me.radMardu.AutoSize = True
        Me.radMardu.Location = New System.Drawing.Point(0, 318)
        Me.radMardu.Name = "radMardu"
        Me.radMardu.Size = New System.Drawing.Size(114, 17)
        Me.radMardu.TabIndex = 14
        Me.radMardu.TabStop = True
        Me.radMardu.Text = "Mardu Pyromancer"
        Me.radMardu.UseVisualStyleBackColor = True
        '
        'radTraverse
        '
        Me.radTraverse.AutoSize = True
        Me.radTraverse.Location = New System.Drawing.Point(0, 295)
        Me.radTraverse.Name = "radTraverse"
        Me.radTraverse.Size = New System.Drawing.Size(109, 17)
        Me.radTraverse.TabIndex = 13
        Me.radTraverse.TabStop = True
        Me.radTraverse.Text = "Traverse Shadow"
        Me.radTraverse.UseVisualStyleBackColor = True
        '
        'radTitanShift
        '
        Me.radTitanShift.AutoSize = True
        Me.radTitanShift.Location = New System.Drawing.Point(0, 272)
        Me.radTitanShift.Name = "radTitanShift"
        Me.radTitanShift.Size = New System.Drawing.Size(73, 17)
        Me.radTitanShift.TabIndex = 12
        Me.radTitanShift.TabStop = True
        Me.radTitanShift.Text = "Titan Shift"
        Me.radTitanShift.UseVisualStyleBackColor = True
        '
        'radStorm
        '
        Me.radStorm.AutoSize = True
        Me.radStorm.Location = New System.Drawing.Point(0, 249)
        Me.radStorm.Name = "radStorm"
        Me.radStorm.Size = New System.Drawing.Size(52, 17)
        Me.radStorm.TabIndex = 11
        Me.radStorm.TabStop = True
        Me.radStorm.Text = "Storm"
        Me.radStorm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 40)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "VS"
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(12, 446)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 2
        Me.btnExecute.Text = "E&xecute"
        Me.ToolTip1.SetToolTip(Me.btnExecute, "Run the number of games you've entered")
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(332, 446)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(123, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Number of Games:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(123, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Lost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(123, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Won:"
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWin.Location = New System.Drawing.Point(159, 279)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(41, 15)
        Me.lblWin.TabIndex = 38
        Me.lblWin.Text = "Label4"
        Me.ToolTip1.SetToolTip(Me.lblWin, "This is the number of games you've won")
        '
        'lblLoss
        '
        Me.lblLoss.AutoSize = True
        Me.lblLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLoss.Location = New System.Drawing.Point(159, 302)
        Me.lblLoss.Name = "lblLoss"
        Me.lblLoss.Size = New System.Drawing.Size(41, 15)
        Me.lblLoss.TabIndex = 39
        Me.lblLoss.Text = "Label7"
        Me.ToolTip1.SetToolTip(Me.lblLoss, "This is the number of games you have lost")
        '
        'txtGames
        '
        Me.txtGames.Location = New System.Drawing.Point(224, 255)
        Me.txtGames.Name = "txtGames"
        Me.txtGames.Size = New System.Drawing.Size(65, 20)
        Me.txtGames.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtGames, "Enter the number of simulations you would like to run")
        '
        'radWU2
        '
        Me.radWU2.AutoSize = True
        Me.radWU2.Location = New System.Drawing.Point(6, 341)
        Me.radWU2.Name = "radWU2"
        Me.radWU2.Size = New System.Drawing.Size(115, 17)
        Me.radWU2.TabIndex = 55
        Me.radWU2.TabStop = True
        Me.radWU2.Text = "White/Blue Control"
        Me.radWU2.UseVisualStyleBackColor = True
        '
        'radMardu2
        '
        Me.radMardu2.AutoSize = True
        Me.radMardu2.Location = New System.Drawing.Point(6, 318)
        Me.radMardu2.Name = "radMardu2"
        Me.radMardu2.Size = New System.Drawing.Size(114, 17)
        Me.radMardu2.TabIndex = 54
        Me.radMardu2.TabStop = True
        Me.radMardu2.Text = "Mardu Pyromancer"
        Me.radMardu2.UseVisualStyleBackColor = True
        '
        'radTraverse2
        '
        Me.radTraverse2.AutoSize = True
        Me.radTraverse2.Location = New System.Drawing.Point(6, 295)
        Me.radTraverse2.Name = "radTraverse2"
        Me.radTraverse2.Size = New System.Drawing.Size(109, 17)
        Me.radTraverse2.TabIndex = 53
        Me.radTraverse2.TabStop = True
        Me.radTraverse2.Text = "Traverse Shadow"
        Me.radTraverse2.UseVisualStyleBackColor = True
        '
        'radTitan2
        '
        Me.radTitan2.AutoSize = True
        Me.radTitan2.Location = New System.Drawing.Point(6, 272)
        Me.radTitan2.Name = "radTitan2"
        Me.radTitan2.Size = New System.Drawing.Size(73, 17)
        Me.radTitan2.TabIndex = 52
        Me.radTitan2.TabStop = True
        Me.radTitan2.Text = "Titan Shift"
        Me.radTitan2.UseVisualStyleBackColor = True
        '
        'radStorm2
        '
        Me.radStorm2.AutoSize = True
        Me.radStorm2.Location = New System.Drawing.Point(6, 249)
        Me.radStorm2.Name = "radStorm2"
        Me.radStorm2.Size = New System.Drawing.Size(52, 17)
        Me.radStorm2.TabIndex = 51
        Me.radStorm2.TabStop = True
        Me.radStorm2.Text = "Storm"
        Me.radStorm2.UseVisualStyleBackColor = True
        '
        'radJeskai2
        '
        Me.radJeskai2.AutoSize = True
        Me.radJeskai2.Location = New System.Drawing.Point(6, 226)
        Me.radJeskai2.Name = "radJeskai2"
        Me.radJeskai2.Size = New System.Drawing.Size(91, 17)
        Me.radJeskai2.TabIndex = 50
        Me.radJeskai2.TabStop = True
        Me.radJeskai2.Text = "Jeskai Control"
        Me.radJeskai2.UseVisualStyleBackColor = True
        '
        'radGrixis2
        '
        Me.radGrixis2.AutoSize = True
        Me.radGrixis2.Location = New System.Drawing.Point(6, 203)
        Me.radGrixis2.Name = "radGrixis2"
        Me.radGrixis2.Size = New System.Drawing.Size(86, 17)
        Me.radGrixis2.TabIndex = 49
        Me.radGrixis2.TabStop = True
        Me.radGrixis2.Text = "Grixis Control"
        Me.radGrixis2.UseVisualStyleBackColor = True
        '
        'radGreen2
        '
        Me.radGreen2.AutoSize = True
        Me.radGreen2.Location = New System.Drawing.Point(6, 180)
        Me.radGreen2.Name = "radGreen2"
        Me.radGreen2.Size = New System.Drawing.Size(79, 17)
        Me.radGreen2.TabIndex = 48
        Me.radGreen2.TabStop = True
        Me.radGreen2.Text = "Green Tron"
        Me.radGreen2.UseVisualStyleBackColor = True
        '
        'radFiveColor2
        '
        Me.radFiveColor2.AutoSize = True
        Me.radFiveColor2.Location = New System.Drawing.Point(6, 157)
        Me.radFiveColor2.Name = "radFiveColor2"
        Me.radFiveColor2.Size = New System.Drawing.Size(114, 17)
        Me.radFiveColor2.TabIndex = 47
        Me.radFiveColor2.TabStop = True
        Me.radFiveColor2.Text = "Five-Color Humans"
        Me.radFiveColor2.UseVisualStyleBackColor = True
        '
        'radEldrazi2
        '
        Me.radEldrazi2.AutoSize = True
        Me.radEldrazi2.Location = New System.Drawing.Point(6, 134)
        Me.radEldrazi2.Name = "radEldrazi2"
        Me.radEldrazi2.Size = New System.Drawing.Size(81, 17)
        Me.radEldrazi2.TabIndex = 46
        Me.radEldrazi2.TabStop = True
        Me.radEldrazi2.Text = "Eldrazi Tron"
        Me.radEldrazi2.UseVisualStyleBackColor = True
        '
        'radDredge2
        '
        Me.radDredge2.AutoSize = True
        Me.radDredge2.Location = New System.Drawing.Point(6, 111)
        Me.radDredge2.Name = "radDredge2"
        Me.radDredge2.Size = New System.Drawing.Size(60, 17)
        Me.radDredge2.TabIndex = 45
        Me.radDredge2.TabStop = True
        Me.radDredge2.Text = "Dredge"
        Me.radDredge2.UseVisualStyleBackColor = True
        '
        'radDevoted2
        '
        Me.radDevoted2.AutoSize = True
        Me.radDevoted2.Location = New System.Drawing.Point(6, 88)
        Me.radDevoted2.Name = "radDevoted2"
        Me.radDevoted2.Size = New System.Drawing.Size(113, 17)
        Me.radDevoted2.TabIndex = 44
        Me.radDevoted2.TabStop = True
        Me.radDevoted2.Text = "Devoted Company"
        Me.radDevoted2.UseVisualStyleBackColor = True
        '
        'radBurn2
        '
        Me.radBurn2.AutoSize = True
        Me.radBurn2.Location = New System.Drawing.Point(6, 65)
        Me.radBurn2.Name = "radBurn2"
        Me.radBurn2.Size = New System.Drawing.Size(47, 17)
        Me.radBurn2.TabIndex = 43
        Me.radBurn2.TabStop = True
        Me.radBurn2.Text = "Burn"
        Me.radBurn2.UseVisualStyleBackColor = True
        '
        'radAffinity2
        '
        Me.radAffinity2.AutoSize = True
        Me.radAffinity2.Location = New System.Drawing.Point(6, 42)
        Me.radAffinity2.Name = "radAffinity2"
        Me.radAffinity2.Size = New System.Drawing.Size(56, 17)
        Me.radAffinity2.TabIndex = 42
        Me.radAffinity2.TabStop = True
        Me.radAffinity2.Text = "Affinity"
        Me.radAffinity2.UseVisualStyleBackColor = True
        '
        'radAbzan2
        '
        Me.radAbzan2.AutoSize = True
        Me.radAbzan2.Location = New System.Drawing.Point(6, 19)
        Me.radAbzan2.Name = "radAbzan2"
        Me.radAbzan2.Size = New System.Drawing.Size(55, 17)
        Me.radAbzan2.TabIndex = 41
        Me.radAbzan2.TabStop = True
        Me.radAbzan2.Text = "Abzan"
        Me.radAbzan2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radAbzan)
        Me.GroupBox1.Controls.Add(Me.radAffinity)
        Me.GroupBox1.Controls.Add(Me.radBurn)
        Me.GroupBox1.Controls.Add(Me.radDevoted)
        Me.GroupBox1.Controls.Add(Me.radDredge)
        Me.GroupBox1.Controls.Add(Me.radEldrazi)
        Me.GroupBox1.Controls.Add(Me.radFiveColor)
        Me.GroupBox1.Controls.Add(Me.radGreenTron)
        Me.GroupBox1.Controls.Add(Me.radGrixis)
        Me.GroupBox1.Controls.Add(Me.radJeskai)
        Me.GroupBox1.Controls.Add(Me.radStorm)
        Me.GroupBox1.Controls.Add(Me.radTitanShift)
        Me.GroupBox1.Controls.Add(Me.radTraverse)
        Me.GroupBox1.Controls.Add(Me.radMardu)
        Me.GroupBox1.Controls.Add(Me.radWU)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(4, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 382)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(1, 364)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 59
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.ToolTip1.SetToolTip(Me.radOther, "Select this option to simulate the deck you entered")
        Me.radOther.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radOther2)
        Me.GroupBox2.Controls.Add(Me.radAbzan2)
        Me.GroupBox2.Controls.Add(Me.radAffinity2)
        Me.GroupBox2.Controls.Add(Me.radWU2)
        Me.GroupBox2.Controls.Add(Me.radBurn2)
        Me.GroupBox2.Controls.Add(Me.radMardu2)
        Me.GroupBox2.Controls.Add(Me.radDevoted2)
        Me.GroupBox2.Controls.Add(Me.radTraverse2)
        Me.GroupBox2.Controls.Add(Me.radDredge2)
        Me.GroupBox2.Controls.Add(Me.radTitan2)
        Me.GroupBox2.Controls.Add(Me.radEldrazi2)
        Me.GroupBox2.Controls.Add(Me.radStorm2)
        Me.GroupBox2.Controls.Add(Me.radFiveColor2)
        Me.GroupBox2.Controls.Add(Me.radJeskai2)
        Me.GroupBox2.Controls.Add(Me.radGreen2)
        Me.GroupBox2.Controls.Add(Me.radGrixis2)
        Me.GroupBox2.Location = New System.Drawing.Point(295, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 382)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        '
        'radOther2
        '
        Me.radOther2.AutoSize = True
        Me.radOther2.Location = New System.Drawing.Point(6, 365)
        Me.radOther2.Name = "radOther2"
        Me.radOther2.Size = New System.Drawing.Size(51, 17)
        Me.radOther2.TabIndex = 60
        Me.radOther2.TabStop = True
        Me.radOther2.Text = "Other"
        Me.ToolTip1.SetToolTip(Me.radOther2, "Select this option to simulate the deck you entered")
        Me.radOther2.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(172, 330)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 58
        Me.btnReset.Text = "Reset W/L's"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset the number of games you simulated")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmSims
        '
        Me.AcceptButton = Me.btnExecute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(419, 481)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtGames)
        Me.Controls.Add(Me.lblLoss)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSims"
        Me.Text = "Simulation Arena"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radAbzan As System.Windows.Forms.RadioButton
    Friend WithEvents radAffinity As System.Windows.Forms.RadioButton
    Friend WithEvents radBurn As System.Windows.Forms.RadioButton
    Friend WithEvents radDevoted As System.Windows.Forms.RadioButton
    Friend WithEvents radDredge As System.Windows.Forms.RadioButton
    Friend WithEvents radJeskai As System.Windows.Forms.RadioButton
    Friend WithEvents radGrixis As System.Windows.Forms.RadioButton
    Friend WithEvents radGreenTron As System.Windows.Forms.RadioButton
    Friend WithEvents radFiveColor As System.Windows.Forms.RadioButton
    Friend WithEvents radEldrazi As System.Windows.Forms.RadioButton
    Friend WithEvents radWU As System.Windows.Forms.RadioButton
    Friend WithEvents radMardu As System.Windows.Forms.RadioButton
    Friend WithEvents radTraverse As System.Windows.Forms.RadioButton
    Friend WithEvents radTitanShift As System.Windows.Forms.RadioButton
    Friend WithEvents radStorm As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblWin As System.Windows.Forms.Label
    Friend WithEvents lblLoss As System.Windows.Forms.Label
    Friend WithEvents txtGames As System.Windows.Forms.TextBox
    Friend WithEvents radWU2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMardu2 As System.Windows.Forms.RadioButton
    Friend WithEvents radTraverse2 As System.Windows.Forms.RadioButton
    Friend WithEvents radTitan2 As System.Windows.Forms.RadioButton
    Friend WithEvents radStorm2 As System.Windows.Forms.RadioButton
    Friend WithEvents radJeskai2 As System.Windows.Forms.RadioButton
    Friend WithEvents radGrixis2 As System.Windows.Forms.RadioButton
    Friend WithEvents radGreen2 As System.Windows.Forms.RadioButton
    Friend WithEvents radFiveColor2 As System.Windows.Forms.RadioButton
    Friend WithEvents radEldrazi2 As System.Windows.Forms.RadioButton
    Friend WithEvents radDredge2 As System.Windows.Forms.RadioButton
    Friend WithEvents radDevoted2 As System.Windows.Forms.RadioButton
    Friend WithEvents radBurn2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAffinity2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAbzan2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radOther2 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
