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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtboxImagePath = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtboxReturnURL = New System.Windows.Forms.TextBox()
        Me.GetScreenshot = New System.Windows.Forms.Button()
        Me.pbImagePreview = New System.Windows.Forms.PictureBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtboxProxyServer = New System.Windows.Forms.TextBox()
        Me.txtboxProxyPort = New System.Windows.Forms.TextBox()
        Me.txtboxProxyUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLookProxy = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtboxProxyPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblFool = New System.Windows.Forms.Label()
        Me.txtboxCustomClientID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAdvanceOpen = New System.Windows.Forms.Button()
        Me.btnAdvanceClose = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.no123 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonMinus = New System.Windows.Forms.Button()
        Me.ButtonPlus = New System.Windows.Forms.Button()
        Me.LabelOpaticy = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.chbProgramTopMost = New System.Windows.Forms.CheckBox()
        Me.comboxLang = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        CType(Me.pbImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtboxImagePath
        '
        Me.txtboxImagePath.Location = New System.Drawing.Point(85, 11)
        Me.txtboxImagePath.Name = "txtboxImagePath"
        Me.txtboxImagePath.ReadOnly = True
        Me.txtboxImagePath.Size = New System.Drawing.Size(346, 22)
        Me.txtboxImagePath.TabIndex = 0
        Me.txtboxImagePath.Text = "http://i.imgur.com/AQbJxMJ.png"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(12, 321)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(517, 23)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'txtboxReturnURL
        '
        Me.txtboxReturnURL.Location = New System.Drawing.Point(9, 36)
        Me.txtboxReturnURL.Name = "txtboxReturnURL"
        Me.txtboxReturnURL.Size = New System.Drawing.Size(387, 22)
        Me.txtboxReturnURL.TabIndex = 2
        '
        'GetScreenshot
        '
        Me.GetScreenshot.Location = New System.Drawing.Point(546, 422)
        Me.GetScreenshot.Name = "GetScreenshot"
        Me.GetScreenshot.Size = New System.Drawing.Size(515, 21)
        Me.GetScreenshot.TabIndex = 17
        Me.GetScreenshot.Text = "Useless button....Good children don't Press it :)"
        Me.GetScreenshot.UseVisualStyleBackColor = True
        '
        'pbImagePreview
        '
        Me.pbImagePreview.Image = CType(resources.GetObject("pbImagePreview.Image"), System.Drawing.Image)
        Me.pbImagePreview.Location = New System.Drawing.Point(12, 44)
        Me.pbImagePreview.Name = "pbImagePreview"
        Me.pbImagePreview.Size = New System.Drawing.Size(517, 271)
        Me.pbImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagePreview.TabIndex = 4
        Me.pbImagePreview.TabStop = False
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(437, 9)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(92, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open Image"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtboxProxyServer
        '
        Me.txtboxProxyServer.AcceptsTab = True
        Me.txtboxProxyServer.Location = New System.Drawing.Point(56, 19)
        Me.txtboxProxyServer.Name = "txtboxProxyServer"
        Me.txtboxProxyServer.Size = New System.Drawing.Size(100, 22)
        Me.txtboxProxyServer.TabIndex = 7
        '
        'txtboxProxyPort
        '
        Me.txtboxProxyPort.AcceptsTab = True
        Me.txtboxProxyPort.Location = New System.Drawing.Point(209, 19)
        Me.txtboxProxyPort.Name = "txtboxProxyPort"
        Me.txtboxProxyPort.Size = New System.Drawing.Size(39, 22)
        Me.txtboxProxyPort.TabIndex = 8
        '
        'txtboxProxyUsername
        '
        Me.txtboxProxyUsername.AcceptsTab = True
        Me.txtboxProxyUsername.Location = New System.Drawing.Point(82, 47)
        Me.txtboxProxyUsername.Name = "txtboxProxyUsername"
        Me.txtboxProxyUsername.Size = New System.Drawing.Size(101, 22)
        Me.txtboxProxyUsername.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Server :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Port :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Username :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLookProxy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyPort)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyServer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(546, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 73)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proxy Connection (Organisation, School, Collage may required), If not required, j" & _
    "ust leave blank)"
        '
        'btnLookProxy
        '
        Me.btnLookProxy.Location = New System.Drawing.Point(305, 17)
        Me.btnLookProxy.Name = "btnLookProxy"
        Me.btnLookProxy.Size = New System.Drawing.Size(195, 21)
        Me.btnLookProxy.TabIndex = 11
        Me.btnLookProxy.Text = "Look up Proxy Settings [LAN Settings]"
        Me.btnLookProxy.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(360, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 12)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ClickShowPassword"
        '
        'txtboxProxyPassword
        '
        Me.txtboxProxyPassword.AcceptsTab = True
        Me.txtboxProxyPassword.Location = New System.Drawing.Point(254, 47)
        Me.txtboxProxyPassword.Name = "txtboxProxyPassword"
        Me.txtboxProxyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtboxProxyPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtboxProxyPassword.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 12)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Return URL / Error Message :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Image Path :"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(402, 34)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(107, 21)
        Me.btnPreview.TabIndex = 3
        Me.btnPreview.Text = "Preview in Browser"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.txtboxCustomClientID)
        Me.GroupBox2.Location = New System.Drawing.Point(546, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 49)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Custom Imgur Client ID (If none just leave blank, Default use Lovemelody's Client" & _
    " ID)"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(417, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 12)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "What is Client ID?"
        '
        'lblFool
        '
        Me.lblFool.AutoSize = True
        Me.lblFool.BackColor = System.Drawing.Color.Yellow
        Me.lblFool.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFool.Font = New System.Drawing.Font("PMingLiU", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblFool.ForeColor = System.Drawing.Color.Red
        Me.lblFool.Location = New System.Drawing.Point(17, 147)
        Me.lblFool.Name = "lblFool"
        Me.lblFool.Size = New System.Drawing.Size(799, 96)
        Me.lblFool.TabIndex = 24
        Me.lblFool.Text = "Naughty Children!!!"
        Me.lblFool.Visible = False
        '
        'txtboxCustomClientID
        '
        Me.txtboxCustomClientID.Location = New System.Drawing.Point(9, 18)
        Me.txtboxCustomClientID.Name = "txtboxCustomClientID"
        Me.txtboxCustomClientID.Size = New System.Drawing.Size(402, 22)
        Me.txtboxCustomClientID.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtboxReturnURL)
        Me.GroupBox3.Controls.Add(Me.btnPreview)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(518, 66)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Return Message"
        '
        'btnAdvanceOpen
        '
        Me.btnAdvanceOpen.Location = New System.Drawing.Point(437, 422)
        Me.btnAdvanceOpen.Name = "btnAdvanceOpen"
        Me.btnAdvanceOpen.Size = New System.Drawing.Size(92, 21)
        Me.btnAdvanceOpen.TabIndex = 19
        Me.btnAdvanceOpen.Text = "Advance >>>"
        Me.btnAdvanceOpen.UseVisualStyleBackColor = True
        '
        'btnAdvanceClose
        '
        Me.btnAdvanceClose.Location = New System.Drawing.Point(437, 422)
        Me.btnAdvanceClose.Name = "btnAdvanceClose"
        Me.btnAdvanceClose.Size = New System.Drawing.Size(92, 21)
        Me.btnAdvanceClose.TabIndex = 6
        Me.btnAdvanceClose.Text = "Advance <<<"
        Me.btnAdvanceClose.UseVisualStyleBackColor = True
        Me.btnAdvanceClose.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.lblNo)
        Me.GroupBox4.Controls.Add(Me.no123)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.ButtonMinus)
        Me.GroupBox4.Controls.Add(Me.ButtonPlus)
        Me.GroupBox4.Controls.Add(Me.LabelOpaticy)
        Me.GroupBox4.Controls.Add(Me.TrackBar1)
        Me.GroupBox4.Controls.Add(Me.chbProgramTopMost)
        Me.GroupBox4.Location = New System.Drawing.Point(546, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(515, 266)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "General Settings"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.Location = New System.Drawing.Point(235, 166)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "."
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(104, 187)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(273, 12)
        Me.lblNo.TabIndex = 26
        Me.lblNo.Text = "I can't think anymore functions......give me more advice!!"
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'no123
        '
        Me.no123.AutoSize = True
        Me.no123.Location = New System.Drawing.Point(447, 251)
        Me.no123.Name = "no123"
        Me.no123.Size = New System.Drawing.Size(64, 12)
        Me.no123.TabIndex = 25
        Me.no123.Text = "You Regret?"
        Me.no123.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.Location = New System.Drawing.Point(235, 238)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.Location = New System.Drawing.Point(235, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(235, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(235, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(235, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(235, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(235, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("PMingLiU", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(235, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(171, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 12)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Title :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(196, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 12)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Transparency :"
        '
        'ButtonMinus
        '
        Me.ButtonMinus.Location = New System.Drawing.Point(483, 21)
        Me.ButtonMinus.Name = "ButtonMinus"
        Me.ButtonMinus.Size = New System.Drawing.Size(25, 25)
        Me.ButtonMinus.TabIndex = 14
        Me.ButtonMinus.Text = "-"
        Me.ButtonMinus.UseVisualStyleBackColor = True
        '
        'ButtonPlus
        '
        Me.ButtonPlus.Location = New System.Drawing.Point(9, 21)
        Me.ButtonPlus.Name = "ButtonPlus"
        Me.ButtonPlus.Size = New System.Drawing.Size(25, 25)
        Me.ButtonPlus.TabIndex = 13
        Me.ButtonPlus.Text = "+"
        Me.ButtonPlus.UseVisualStyleBackColor = True
        '
        'LabelOpaticy
        '
        Me.LabelOpaticy.AutoSize = True
        Me.LabelOpaticy.Location = New System.Drawing.Point(271, 54)
        Me.LabelOpaticy.Name = "LabelOpaticy"
        Me.LabelOpaticy.Size = New System.Drawing.Size(32, 12)
        Me.LabelOpaticy.TabIndex = 2
        Me.LabelOpaticy.Text = "100%"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(40, 21)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(437, 45)
        Me.TrackBar1.TabIndex = 1
        '
        'chbProgramTopMost
        '
        Me.chbProgramTopMost.AutoSize = True
        Me.chbProgramTopMost.Location = New System.Drawing.Point(9, 81)
        Me.chbProgramTopMost.Name = "chbProgramTopMost"
        Me.chbProgramTopMost.Size = New System.Drawing.Size(118, 16)
        Me.chbProgramTopMost.TabIndex = 15
        Me.chbProgramTopMost.Text = "Program stay on top"
        Me.chbProgramTopMost.UseVisualStyleBackColor = True
        '
        'comboxLang
        '
        Me.comboxLang.FormattingEnabled = True
        Me.comboxLang.Items.AddRange(New Object() {"English", "繁體中文"})
        Me.comboxLang.Location = New System.Drawing.Point(310, 422)
        Me.comboxLang.Name = "comboxLang"
        Me.comboxLang.Size = New System.Drawing.Size(121, 20)
        Me.comboxLang.TabIndex = 5
        Me.comboxLang.Text = "繁體中文"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 425)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 12)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Program Author :"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(111, 426)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(64, 12)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Lovemelody"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 449)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.lblFool)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.comboxLang)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnAdvanceClose)
        Me.Controls.Add(Me.btnAdvanceOpen)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.pbImagePreview)
        Me.Controls.Add(Me.GetScreenshot)
        Me.Controls.Add(Me.txtboxImagePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lovemelody Imgur Image Uploader - http://goo.gl/E5kTUH"
        CType(Me.pbImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxImagePath As System.Windows.Forms.TextBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents txtboxReturnURL As System.Windows.Forms.TextBox
    Friend WithEvents GetScreenshot As System.Windows.Forms.Button
    Friend WithEvents pbImagePreview As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtboxProxyServer As System.Windows.Forms.TextBox
    Friend WithEvents txtboxProxyPort As System.Windows.Forms.TextBox
    Friend WithEvents txtboxProxyUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtboxProxyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLookProxy As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtboxCustomClientID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdvanceOpen As System.Windows.Forms.Button
    Friend WithEvents btnAdvanceClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chbProgramTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents comboxLang As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents LabelOpaticy As System.Windows.Forms.Label
    Friend WithEvents ButtonMinus As System.Windows.Forms.Button
    Friend WithEvents ButtonPlus As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblFool As System.Windows.Forms.Label
    Friend WithEvents no123 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
