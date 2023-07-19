object ThePowerOfPlayfulness {
  // Define a function which allows for the user to print out a phrase with a certain level of playfulness
  def printOutPlayfulPhrase(playfulLevel: Int, phrase: String) = {
    val playfulLevels = List("Zero","Low", "Medium", "High")
    println("Playful Level: " + playfulLevels(playfulLevel) + ", Phrase: " + phrase)
  }

  // Define a function which uses the random module to generate a playful string 
  def generatePlayfulString(items: List[String], length: Int): String = {
    import scala.util.Random
    val stringBuilder: StringBuilder = new StringBuilder()
    for (i <- 0 until length) stringBuilder.append(items(Random.nextInt(items.length)))
    return stringBuilder.toString
  }

  // Define a function which checks for a playfulness 
  def checkPlaylevel(playlevel: Int, phrase: String): String = {
    // Run a regex check on the phrase looking for certain words 
    val regexString = ".*(joke|hilarious|laugh|smile).*"
    phrase match {
      // If we find the words, the playfulness is high
      case regexString() => "High"

      // Else if the level provided is above 1, then it is medium
      case _ if (playlevel > 1) => "Medium"

      // Otherwise the playfullness is low
      case _ => "Low"
    }
  }

  // Main Method
  def main(args: Array[String]): Unit = {
    // Initialize a list of items to use in playlevel phrase 
    val playfulItems = List("silly", "funny", "happy", "playful", "joyful")

    val generatedPhrase = generatePlayfulString(playfulItems, 10)

    // Print the phrase as well as the playfulness
    printOutPlayfulPhrase(0, generatedPhrase)
    val checkPlaylevelReturn = checkPlaylevel(0, generatedPhrase)
    printOutPlayfulPhrase(checkPlaylevelReturn match {
      case "High" => 3
      case "Medium" => 2
      case "Low" => 1
    }, generatedPhrase)
  }
}