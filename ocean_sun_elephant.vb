Public Class PowerOfPlayfulness
 
    Dim PlayEmotions As String  'variable to store emotions from each playful activity
    Dim PlayfulActivities(5) As String   'array to store playful activities
 
    Sub Main()
        Dim i As Integer
        PlayfulActivities(0) = "Laughing"
        PlayfulActivities(1) = "Joking"
        PlayfulActivities(2) = "Dancing"
        PlayfulActivities(3) = "Making Music"
        PlayfulActivities(4) = "Singing"
        PlayfulActivities(5) = "Playing Games"
 
        For i = 0 To 5
            Console.WriteLine(PlayfulActivities(i))
            PlayEmotions = GetEmotionsFromActivity(PlayfulActivities(i))
            Console.WriteLine("Emotions felt while playing: " & PlayEmotions)
        Next
        
        Console.ReadLine()
    End Sub
 
    Function GetEmotionsFromActivity(ByVal Activity As String) As String
        Select Activity
 
            Case "Laughing"
                Return "Joy, Relief, Happiness, Satisfaction"
 
            Case "Joking"
                Return "Amusement, Happiness, Joy, Humor"
 
            Case "Dancing"
                Return "Joy, Excitement, Release"
 
            Case "Making Music"
                Return "Joy, Pride, Accomplishment"
 
            Case "Singing"
                Return "Happiness, Relaxation, Joy, Comfort"
 
            Case "Playing Games"
                Return "Excitement, Fun, Joy, Thrill"
 
            Case Else
                Return "Unknown"
 
        End Select
    End Function

End Class