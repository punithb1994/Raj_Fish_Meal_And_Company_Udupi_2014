Public Class frmlockscreen
    Dim i As Integer = 0
    Dim j As Integer = Me.Size.Height
    Private Sub frmlockscreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(frmmdihome.Size.Width, frmmdihome.Size.Height)
        Me.WindowState = FormWindowState.Normal
        Me.Timer2.Enabled = True
        'Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Timer1.Interval = 10 Then
            Me.Timer1.Interval = 10
        End If
        Dim min, hr, str As String
        str = "am"
        If (DateAndTime.Minute(Now) < 10) Then
            min = "0" & DateAndTime.Minute(Now)
        Else
            min = DateAndTime.Minute(Now)
        End If
        hr = DateAndTime.Hour(Now)
        If (hr > 12) Then
            str = "pm"
            hr = hr - 12
        End If
        If (hr < 10) Then
            hr = "0" & hr
        End If
        Me.Label1.Text = hr & ":" & min  ' ControlChars.CrLf &
        Me.Label2.Text = DateAndTime.WeekdayName(DateAndTime.Weekday(Now)) & "," & DateAndTime.MonthName(DateAndTime.Month(Now)) & " " & DateAndTime.Day(Now)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(frmmdihome.Size.Width, frmmdihome.Size.Height)
        Me.WindowState = FormWindowState.Normal
        Me.Timer2.Enabled = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(frmmdihome.Size.Width, frmmdihome.Size.Height)
        Me.WindowState = FormWindowState.Normal
        Me.Timer2.Enabled = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Size(frmmdihome.Size.Width, frmmdihome.Size.Height)
        Me.WindowState = FormWindowState.Normal
        Me.Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        i = i - 20
        Me.Location = New Point(0, i)
        j = j - 5
        If j <= 0 Then
            Me.Close()
        End If
        If Me.Timer2.Interval = 10 Then
            Me.Timer2.Interval = 10
        End If
    End Sub
End Class