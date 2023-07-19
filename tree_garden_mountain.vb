Public Class ThePowerOfPlayfulness
  Inherits System.Windows.Forms.Form

  Private Sub CreateGame(ByVal gameName As String, ByVal gameType As Integer)
    'Create a new game of the specified type
    Dim newGame As New Game(gameName, gameType)
  End Sub
  
  Private Sub PlayGame(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
   
    'If game exists, play it
    game.PlayGame()
  End Sub
  
  Private Sub ModifyGameRules(ByVal gameName As String, ByVal ruleType As Integer)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Set the game rules
    game.ModifyRules(ruleType)
  End Sub
  
  Private Sub DeleteGame(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Delete the game
    DeleteGame(game)
  End Sub
  
  Private Sub CreateLevel(ByVal gameName As String, ByVal levelType As Integer)
     'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Create a new level for the given game
    Dim newLevel As New Level(game, levelType)
  End Sub
  
  Private Sub AddLevelObjects(ByVal gameName As String, ByVal xCoordinate As Integer, ByVal yCoordinate As Integer, ByVal objectType As Integer)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Add level objects to the game
    game.AddObject(xCoordinate, yCoordinate, objectType)
  End Sub
  
  Private Sub ModifyLevelObjects(ByVal gameName As String, ByVal xCoordinate As Integer, ByVal yCoordinate As Integer, ByVal objectType As Integer)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Modify level objects in the game
    game.ModifyObject(xCoordinate, yCoordinate, objectType)
  End Sub
  
  Private Sub DeleteLevelObjects(ByVal gameName As String, ByVal xCoordinate As Integer, ByVal yCoordinate As Integer)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Delete level objects in the game
    game.DeleteObject(xCoordinate, yCoordinate)
  End Sub
  
  Private Sub UnlockLevel(ByVal gameName As String, ByVal levelNumber As Integer)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Unlock the specified level
    game.UnlockLevel(levelNumber)
  End Sub
  
  Private Sub CalculateScore(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Calculate the score for the game
    game.CalculateScore()
  End Sub
  
  Private Sub CreateLeaderboard(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Create a leaderboard for the game
    game.CreateLeaderboard()
  End Sub
  
  Private Sub UpdateLeaderboard(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Update leaderboard rankings for the game
    game.UpdateLeaderboard()
  End Sub
  
  Private Sub CreateAchievement(ByVal gameName As String, ByVal achievementType As Integer)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Create an achievement for the game
    Dim newAchievement As New Achievement(game, achievementType)
  End Sub
  
  Private Sub UnlockAchievement(ByVal gameName As String, ByVal achievement As Achievement)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Unlock the achievement in the game
    game.UnlockAchievement(achievement)
  End Sub
  
  Private Sub MakePlayfulnessVisible(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Make the game's playfulness visible by highlighting the playful aspects
    game.MakePlayfulnessVisible()
  End Sub
  
  Private Sub EncouragePlayfulness(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Encourage playfulness in the game by awarding points and rewards for playful activities
    game.EncouragePlayfulness()
  End Sub
  
  Private Sub CelebratePlayfulness(ByVal gameName As String)
    'Find an existing game with the given name
    Dim game As Game = GetGameByName(gameName)
    
    'Check if game exists
    If game Is Nothing Then
      MessageBox.Show("Sorry, there is no game with this name")
      Return
    End If
    
    'Celebrate playfulness in the game by recognizing and rewarding achievements
    game.CelebratePlayfulness()
  End Sub
End Class