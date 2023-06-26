Public Class PowerOfPlayfulness
    Inherits System.Windows.Forms.Form
    
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'Set up the form
        Me.Text = "The Power of Playfulness"
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.CornflowerBlue


'Create the menu
        Dim mainMenu As New System.Windows.Forms.MainMenu()
        
        Dim fileMenu As New System.Windows.Forms.MenuItem()
        fileMenu.Text = "&File"

        Dim openMenu As New System.Windows.Forms.MenuItem()
        openMenu.Text = "&Open"
        openMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        
        Dim saveMenu As New System.Windows.Forms.MenuItem()
        saveMenu.Text = "&Save"
        saveMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        
        Dim closeMenu As New System.Windows.Forms.MenuItem()
        closeMenu.Text = "&Close"
        closeMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        
        fileMenu.MenuItems.Add(openMenu)
        fileMenu.MenuItems.Add(saveMenu)
        fileMenu.MenuItems.Add(closeMenu)

        mainMenu.MenuItems.Add(fileMenu)
        Me.Menu = mainMenu        

'Create the list box
        Dim listBox As New System.Windows.Forms.ListBox
        listBox.Location = New System.Drawing.Point(25, 25)
        listBox.Size = New System.Drawing.Size(200, 200)
        listBox.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Controls.Add(listBox)

'Populate the list box
        Dim s As String
        For s = 1 To 20
            listBox.Items.Add("Item " &amp; s)
        Next
    End Sub

'Create the button
    Dim btn As Button
    btn.Location = New System.Drawing.Point(250, 25)
    btn.Size = New System.Drawing.Size(200, 50)
    btn.Text = "Play!"
    btn.BackColor = System.Drawing.Color.Teal
    Me.Controls.Add(btn)

'Create the ComboBox
    Dim cmb As New System.Windows.Forms.ComboBox
    cmb.Location = New System.Drawing.Point(250, 100)
    cmb.Size = New System.Drawing.Size(200, 50)
    cmb.BackColor = System.Drawing.Color.Azure
    Me.Controls.Add(cmb)

'Populate the ComboBox
    Dim i As Integer
    For i = 1 To 10
        cmb.Items.Add("Option " &amp; i)
    Next
End Class

Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

'Play the game
    Dim r As New Random
    Dim i As Integer
    Dim selected As String

    i = r.Next(1, cmb.Items.Count)
    selected = cmb.Items.Item(i)

    MessageBox.Show("You selected: " &amp; selected)

End Sub