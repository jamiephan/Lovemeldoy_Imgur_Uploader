Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Threading
Imports System.Threading.Tasks

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUpload.Enabled = False
        GroupBox1.Visible = False
        btnPreview.Enabled = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        btnUpload.Visible = False
        Me.Width = 552
        btnAdvanceOpen.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        checkproxy()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try
            Using ofd As New OpenFileDialog
                ofd.Filter = "Lovemelody's Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.apng;*.tiff;*.pdf;*.xcf;*.gimp"
                ofd.Title = "Select File"

                If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    txtboxImagePath.Text = ofd.FileName
                    pbImagePreview.ImageLocation = txtboxImagePath.Text
                    btnUpload.Enabled = True
                    GroupBox1.Visible = True
                    GroupBox2.Visible = True
                    GroupBox3.Visible = True
                    btnUpload.Visible = True
                    btnAdvanceOpen.Visible = True
                End If
            End Using
        Catch ex As Exception
            MsgBox("There is an Error !! " & Environment.NewLine & ex.Message, "Jamie found an error :(")
            txtboxImagePath.Text = ex.Message
        End Try
    End Sub
    Sub checkproxy()

        If txtboxProxyServer.Text <> "" And txtboxProxyUsername.Text <> "" And txtboxProxyPort.Text <> "" And txtboxProxyPassword.Text <> "" Then
            UploadWithProxy(txtboxImagePath.Text)
        Else
            UploadNoProxy(txtboxImagePath.Text)
        End If
    End Sub
#Region "Force Port to be numberic data"
    Private Sub txtboxProxyPort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxProxyPort.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region
#Region "Main upload Function"

    Function clientid()
        If txtboxCustomClientID.TextLength = 0 Then
            Dim ID As String = "906ce2cb57a3e3a"
            Return ID
        Else
            Dim ID As String = txtboxCustomClientID.Text
            Return ID
        End If
    End Function

    Public Sub UploadWithProxy(ByVal image As String)
        Dim w As New WebClient()
        Dim port As Integer = txtboxProxyPort.Text
        w.Proxy = New System.Net.WebProxy(txtboxProxyServer.Text, port)
        w.Proxy.Credentials = New NetworkCredential(txtboxProxyUsername.Text, txtboxProxyPassword.Text)
        w.Headers.Add("Authorization", "Client-ID " & clientid())
        Dim Keys As New System.Collections.Specialized.NameValueCollection
        Try
            Keys.Add("image", Convert.ToBase64String(File.ReadAllBytes(image)))
            Dim responseArray As Byte() = w.UploadValues("https://api.imgur.com/3/image", Keys)
            Dim result = Encoding.ASCII.GetString(responseArray)
            Dim reg As New System.Text.RegularExpressions.Regex("link"":""(.*?)""")
            Dim match As Match = reg.Match(result)
            Dim url As String = match.ToString.Replace("link"":""", "").Replace("""", "").Replace("\/", "/")
            txtboxReturnURL.Text = url
            btnPreview.Enabled = True
            MsgBox("Upload Sucess!!!")
        Catch s As Exception
            MessageBox.Show("There is an Error !! " & Environment.NewLine & s.Message, "Jamie found an error :(")
            txtboxReturnURL.Text = "Failed! ERROR : " & s.Message
        End Try
    End Sub

    Public Sub UploadNoProxy(ByVal image As String)
        Dim w As New WebClient()
        w.Headers.Add("Authorization", "Client-ID " & clientid())
        Dim Keys As New System.Collections.Specialized.NameValueCollection
        Try
            Keys.Add("image", Convert.ToBase64String(File.ReadAllBytes(image)))
            Dim responseArray As Byte() = w.UploadValues("https://api.imgur.com/3/image", Keys)
            Dim result = Encoding.ASCII.GetString(responseArray)
            Dim reg As New System.Text.RegularExpressions.Regex("link"":""(.*?)""")
            Dim match As Match = reg.Match(result)
            Dim url As String = match.ToString.Replace("link"":""", "").Replace("""", "").Replace("\/", "/")
            txtboxReturnURL.Text = url
            btnPreview.Enabled = True
            MsgBox("Upload Sucess!!!")
        Catch s As Exception
            MessageBox.Show("There is an Error !! " & Environment.NewLine & s.Message, "Jamie found an error :(")
            txtboxReturnURL.Text = "Failed! ERROR : " & s.Message
        End Try
    End Sub
#End Region
#Region "password Shower"
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        txtboxProxyPassword.PasswordChar = "*"

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        txtboxProxyPassword.PasswordChar = ""
    End Sub
#End Region

    Private Sub btnLookProxy_Click(sender As Object, e As EventArgs) Handles btnLookProxy.Click
        Try
            Shell("C:\Windows\System32\rundll32.exe shell32.dll,Control_RunDLL inetcpl.cpl,,4")
        Catch ex As Exception
            MsgBox("Somthing Error : " & Environment.NewLine & ex.Message)
        End Try
    End Sub
#Region "Copy to clipboard event"
    Sub CopyToClipboard(ByVal a As String)
        Try
            My.Computer.Clipboard.SetText(a)
            MsgBox("Copied to Clipboard.")
        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub txtboxReturnURL_Click(sender As Object, e As EventArgs) Handles txtboxReturnURL.Click
        CopyToClipboard(txtboxReturnURL.Text)
    End Sub
#End Region
    Sub ScreenShot()
        Dim graph As Graphics = Nothing
        Try
            ' gets the upper left hand coordinate of the form
            Dim frmleft As System.Drawing.Point = Me.Bounds.Location

            'use the commented out version for the full screen
            'Dim bmp As New Bitmap(Screen.PrimaryScreen.Bounds.Width, _Screen.PrimaryScreen.Bounds.Height)
            'this version get the size of the form1
            'The + 8 adds a little to right and bottom of what is captured.
            Dim bmp As New Bitmap(Me.Bounds.Width, Me.Bounds.Height)

            'creates the grapgic
            graph = Graphics.FromImage(bmp)

            'Gets the x,y coordinates from the upper left start point
            'used below Dim screenx As Integer = frmleft.X
            Dim screeny As Integer = frmleft.Y
            Dim screenx As Integer = frmleft.X

            ' The - 5 here allows more of the form to be shown for the top and left sides.
            graph.CopyFromScreen(screenx, screeny, 0, 0, bmp.Size)

            ' Save the Screenshot to a file
            bmp.Save(My.Computer.FileSystem.SpecialDirectories.MyPictures & "\Lovemelody_temp.png")

            'Open File and load in MS Paint Dim filepath As String
            Dim filepath = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\Lovemelody_temp.png"
            Process.Start("mspaint.exe ", filepath)

            bmp.Dispose()
            graph.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Following is a temp storage for scrrenshot function
    Private Sub GetScreenshot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetScreenshot.Click
        lblFool.Visible = True
        ScreenShot()
        Me.Cursor = Cursors.No
        Threading.Thread.Sleep(1000)
        If MessageBox.Show(no123.Text, no123.Text, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            lblFool.Visible = False
            Me.Cursor = Cursors.Default
        Else
            Return
        End If
    End Sub


    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim webpage As String = txtboxReturnURL.Text
        Process.Start(webpage)
    End Sub


    Private Sub btnAdvanceClose_Click(sender As Object, e As EventArgs) Handles btnAdvanceClose.Click
        Me.Width = 552
        btnAdvanceClose.Visible = False
        btnAdvanceOpen.Visible = True
    End Sub

    Private Sub btnAdvanceOpen_Click(sender As Object, e As EventArgs) Handles btnAdvanceOpen.Click
        Me.Width = 1075
        btnAdvanceClose.Visible = True
        btnAdvanceOpen.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbProgramTopMost.CheckedChanged
        If chbProgramTopMost.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
    Sub LangCHT()
        Me.Text = "戀愛の旋律♪ Imgur 圖片上傳器 - http://goo.gl/E5kTUH"
        Label7.Text = "圖片路徑 ："
        btnOpen.Text = "打開圖片"
        btnUpload.Text = "上傳"
        '=============
        GroupBox3.Text = "傳回的訊息"
        Label5.Text = "傳回 URL / 錯誤訊息 :"
        btnPreview.Text = "在瀏覽器檢視"
        '=============
        btnAdvanceOpen.Text = "進階設定》》"
        btnAdvanceClose.Text = "進階設定《《"
        '=============
        GroupBox1.Text = "Proxy 連接設定 （機構，學校，學院等可能需要。)，如不需要，留空白即可)"
        Label2.Text = "伺服器 :"
        Label3.Text = "連接埠 :"
        Label4.Text = "使用者名稱 :"
        Label1.Text = "密碼 :"
        btnLookProxy.Text = "查看 Proxy 設定 [區域網絡設定]"
        Label6.Text = "點一下看看密碼"
        '========================
        GroupBox2.Text = "自訂Imgur的Client ID（如沒有，留空白即可，預設使用戀愛の旋律♪的Client ID。）"
        LinkLabel1.Text = "什麼是Client ID ？"
        '========================
        GroupBox4.Text = "一般設定"
        chbProgramTopMost.Text = "置頂程式"
        Label9.Text = "透明度："
        Label10.Text = "標題："
        GetScreenshot.Text = "沒用的按鈕...乖孩子不要按喔！！"
        '========================
        Label8.Text = "程式製作者："
        LinkLabel2.Text = "戀愛の旋律♪"
        lblFool.Text = "糟糕阿!叫了你不要按了!"
        no123.Text = "反省了嗎?"
        lblNo.Text = "想不到更多的功能了.....大家給我點建議吧..."
    End Sub
    Sub LangEng()
        Me.Text = "Lovemelody Imgur Image Uploader - http://goo.gl/E5kTUH"
        Label7.Text = "Image Path :"
        btnOpen.Text = "Open Image"
        btnUpload.Text = "Upload"
        '=============
        GroupBox3.Text = "Return Message"
        Label5.Text = "Return URL / Error Message :"
        btnPreview.Text = "Preview in Browser"
        '=============
        btnAdvanceOpen.Text = "Advance >>>"
        btnAdvanceClose.Text = "Advance <<<"
        '=============
        GroupBox1.Text = "Proxy Connection (Organisation, School, Collage may required), If not required, just leave blank)"
        Label2.Text = "Server :"
        Label3.Text = "Port :"
        Label4.Text = "Username :"
        Label1.Text = "Password :"
        btnLookProxy.Text = "Look up Proxy Settings [LAN Settings]"
        Label6.Text = "ClickShowPassword"
        '========================
        GroupBox2.Text = "Custom Imgur Client ID (If none just leave blank, Default use Lovemelody's Client ID)"
        LinkLabel1.Text = "What is Client ID?"
        '========================
        GroupBox4.Text = "General Settings"
        Label9.Text = "Transparency :"
        chbProgramTopMost.Text = "Program stay on top"
        Label10.Text = "Title :"
        '==========================
        Label8.Text = "Program Author :"
        LinkLabel2.Text = "Lovemelody"
        GetScreenshot.Text = "Useless button....Good children don't Press it :)"
        lblFool.Text = "Naughty Children!!!"
        no123.Text = "You Regret?"
        lblNo.Text = "I can't think anymore functions......give me more advice!!"
    End Sub


    Private Sub comboxLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboxLang.SelectedIndexChanged
        If comboxLang.Text = "English" Then
            LangEng()
        ElseIf comboxLang.Text = "繁體中文" Then
            LangCHT()
        Else
            Return
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Process.Start("http://goo.gl/E5kTUH")
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub TrackBar1_Scroll_1(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = TrackBar1.Maximum Then
            LabelOpaticy.Text = "0%"
        ElseIf TrackBar1.Value = TrackBar1.Minimum Then
            LabelOpaticy.Text = "100%"
        Else
            LabelOpaticy.Text = TrackBar1.Maximum - TrackBar1.Value + 1 & "%"
        End If
        Me.Opacity = Val(TrackBar1.Maximum - TrackBar1.Value + 1) / 100
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        If TrackBar1.Value = TrackBar1.Maximum Then
            LabelOpaticy.Text = "0%"
            TrackBar1.Value = TrackBar1.Value - 1
        ElseIf TrackBar1.Value = TrackBar1.Minimum Then
            LabelOpaticy.Text = "100%"
        Else
            LabelOpaticy.Text = TrackBar1.Maximum - TrackBar1.Value + 1 & "%"
            TrackBar1.Value = TrackBar1.Value - 1
        End If
        Me.Opacity = Val(TrackBar1.Maximum - TrackBar1.Value + 1) / 100
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        If TrackBar1.Value = TrackBar1.Maximum Then
            LabelOpaticy.Text = "0%"
            TrackBar1.Value = TrackBar1.Value + 1
        ElseIf TrackBar1.Value = TrackBar1.Minimum Then
            LabelOpaticy.Text = "100%"
        Else
            LabelOpaticy.Text = TrackBar1.Maximum - TrackBar1.Value + 1 & "%"
            TrackBar1.Value = TrackBar1.Value + 1
        End If
        Me.Opacity = Val(TrackBar1.Maximum - TrackBar1.Value + 1) / 100
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If comboxLang.Text = "English" Then
                If TextBox1.TextLength > 10 Then
                    Return
                Else
                    Me.Text = "Lovemelody Always Love you ~ " & TextBox1.Text
                End If
            ElseIf comboxLang.Text = "繁體中文" Then
                If TextBox1.TextLength > 10 Then
                    Return
                Else
                    Me.Text = "戀愛の旋律♪永遠愛你 ～ " & TextBox1.Text
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Try
            If comboxLang.Text = "English" Then
                Me.Text = "Lovemelody Imgur Image Uploader - http://goo.gl/E5kTUH"
            ElseIf comboxLang.Text = "繁體中文" Then
                Me.Text = "戀愛の旋律♪ Imgur 圖片上傳器 - http://goo.gl/E5kTUH"
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.googledrive.com/host/0B2JIawlS8QjdXzUtbTF4VUVhMFU")
    End Sub
End Class
