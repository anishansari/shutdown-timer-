Public Class Form1

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label3.Text = TimeOfDay
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = TimeOfDay
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label6.Text = TextBox1.Text
        NotifyIcon1.BalloonTipTitle = "TIME SHUT"
        NotifyIcon1.BalloonTipText = "ACTIVATED;; ACTION TIME IS:-" + Label6.Text
        NotifyIcon1.ShowBalloonTip(20)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Me.ComboBox1.Text = "CHOOSE AN ACTION PLEASE"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Label6.Text = Label3.Text And ComboBox1.Text = "SHUTDOWN" Then
            Shell(("shutdown -s"))
        ElseIf Label6.Text = Label3.Text And ComboBox1.Text = "RESTART" Then
            Shell(("shutdown -r"))
        ElseIf Label6.Text = Label3.Text And ComboBox1.Text = "LOG OFF" Then
            Shell(("shutdown -l"))
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Label8.Text = ""
        Label6.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label8.Text = ComboBox1.Text
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        NotifyIcon1.BalloonTipTitle = "TIME SHUT"
        NotifyIcon1.BalloonTipText = "TIME SHUT IS HIDE,, TO SHOW CLICK ON SHOW"
        NotifyIcon1.ShowBalloonTip(20)
    End Sub

    Private Sub SHOWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOWToolStripMenuItem.Click

        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
        Me.ShowInTaskbar = True
        
    End Sub

    Private Sub EXITToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub HIDEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HIDEToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
        NotifyIcon1.BalloonTipTitle = "TIME SHUT"
        NotifyIcon1.BalloonTipText = "TIME SHUT IS HIDE,, TO SHOW CLICK ON SHOW"
        NotifyIcon1.ShowBalloonTip(20)
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        Me.BringToFront()
        Me.ShowInTaskbar = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub
End Class
