Public Class Form1

Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'Set the title of the form
Me.Text = "The Power of Playfulness"

'Create the UI
Dim lbl As New Label
lbl.Text = "This program demonstrates the power of playfulness."
lbl.Font = New Font("Arial", 14, FontStyle.Bold)
lbl.Location = New Point(20, 20)
Controls.Add(lbl)

Dim btn1 As New Button
btn1.Text = "Start"
btn1.Location = New Point(30, 70)
Controls.Add(btn1)

Dim btn2 As New Button
btn2.Text = "Stop"
btn2.Location = New Point(150, 70)
Controls.Add(btn2)

Dim lbl2 As New Label
lbl2.Text = "Ready to play?"
lbl2.Font = New Font("Arial", 14, FontStyle.Bold)
lbl2.Location = New Point(20, 130)
Controls.Add(lbl2)

Dim btn3 As New Button
btn3.Text = "Yes"
btn3.Location = New Point(30, 170)
Controls.Add(btn3)

Dim btn4 As New Button
btn4.Text = "No"
btn4.Location = New Point(150, 170)
Controls.Add(btn4)

'Create the timer
Dim tmr As New Timer
tmr.Interval = 1000

'Create the counter variable
Dim ctr As Integer = 0

'Add the event handler for start button
AddHandler btn1.Click, Sub()
    If ctr = 0 Then
        btn1.Text = "Restart"
        tmr.Start()
    Else
        btn1.Text = "Start"
        ctr = 0
    End If
End Sub

'Add the event handler for stop button
AddHandler btn2.Click, Sub()
    btn1.Text = "Start"
    tmr.Stop()
End Sub

'Add the event handler for yes button
AddHandler btn3.Click, Sub()
    MessageBox.Show("Great! Let's play!")
End Sub

'Add the event handler for no button
AddHandler btn4.Click, Sub()
    MessageBox.Show("No worries. Maybe later.")
End Sub

'Add the event handler for the timer tick
AddHandler tmr.Tick, Sub()
    ctr += 1
    lbl2.Text = ctr.ToString() & " seconds have passed. Ready to stop?"
End Sub

End Sub

End Class