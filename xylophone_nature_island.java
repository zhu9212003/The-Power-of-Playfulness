// 1000 Line 1
public class PowerOfPlayfulness {
	public static void main(String[] args) {
		System.out.println("The Power of Playfulness!");
		
		// Create an array of type integer
		int[] numbers = {1, 2, 3, 4, 5, 6, 7};
		
		// Looping through the array
		for (int i = 0; i < numbers.length; i++) {
			// Printing the square value of each number
			System.out.println(numbers[i] * numbers[i]);
		}
		
		// Creating an integer variable
		int sum = 0;
		
		// Looping through the array again
		for (int i = 0; i < numbers.length; i++) {
			// Sum up the numbers
			sum += numbers[i];
		}
		
		// Printing the sum
		System.out.println("The sum is: " + sum);
		
		// Creating a string variable
		String message = "Playfulness makes us smile!";
		
		// Looping through the string
		for (int i = 0; i < message.length(); i++) {
			// Printing the characters one by one
			System.out.print(message.charAt(i));
		}
		
		System.out.println("");
		
		// Creating a new array of type character
		char[] messageChars = message.toCharArray();
		
		// Looping through the character array
		for (int i = 0; i < messageChars.length; i++) {
			// Printing the characters one by one
			System.out.print(messageChars[i]);
		}
		
		System.out.println("");
		
		// Creating a game
		System.out.println("Let's Play Rock Paper Scissors");
		
		// Creating integers for player 1 and player 2 choices
		int p1Choice;
		int p2Choice;
		
		// Generating random numbers for player 1 and player 2
		p1Choice = (int) (Math.random() * 3) + 1;
		p2Choice = (int) (Math.random() * 3) + 1;
		
		// Matching the random numbers to rock, paper, and scissors
		String p1string;
		
		if (p1Choice == 1) {
			p1string = "rock";
		}
		else if (p1Choice == 2) {
			p1string = "paper";
		}
		else {
			p1string = "scissors";
		}
		
		String p2string;
		
		if (p2Choice == 1) {
			p2string = "rock";
		}
		else if (p2Choice == 2) {
			p2string = "paper";
		}
		else {
			p2string = "scissors";
		}
		
		// Printing out the choices of the players
		System.out.println("Player 1 chose " + p1string);
		System.out.println("Player 2 chose " + p2string);
		
		// Comparing the choices and declaring a winner
		if (p1Choice == p2Choice) {
			System.out.println("It's a tie!");
		}
		else if (p1Choice == 1 && p2Choice == 2) {
			System.out.println("Player 2 wins!");
		}
		else if (p1Choice == 1 && p2Choice == 3) {
			System.out.println("Player 1 wins!");
		}
		else if (p1Choice == 2 && p2Choice == 1) {
			System.out.println("Player 1 wins!");
		}
		else if (p1Choice == 2 && p2Choice == 3) {
			System.out.println("Player 2 wins!");
		}
		else if (p1Choice == 3 && p2Choice == 1) {
			System.out.println("Player 2 wins!");
		}
		else if (p1Choice == 3 && p2Choice == 2) {
			System.out.println("Player 1 wins!");
		}
		
		// 1000 Line 2
		// Creating a 2D array
		int[][] board = new int[][] { 
			{ 1, 2, 3 }, 
			{ 4, 5, 6 }, 
			{ 7, 8, 9 } 
		};
		
		// Printing out the contents of the 2D array
		for (int i = 0; i < board.length; i++) {
			for (int j = 0; j < board[i].length; j++) {
				System.out.print(board[i][j] + " ");
			}
			
			System.out.println(" ");
		}
		
		// Creating a game of tic-tac-toe
		System.out.println("Let's Play Tic-Tac-Toe!");
		
		// Creating and initializing variables to keep track of the play
		int player = 1;
		int row;
		int col;
		boolean isWinner = false;
		
		// Looping until a player wins
		while (!isWinner) {
			// Prompting the user to input row and column
			System.out.println("Player " + player + ": Enter row and column");
			row = scanner.nextInt();
			col = scanner.nextInt();
			
			// Placing an X for player 1, and an O for player 2
			if (player == 1) {
				board[row][col] = 'X';
				player = 2;
			}
			else {
				board[row][col] = 'O';
				player = 1;
			}
			
			// Printing out the updated board
			for (int i = 0; i < board.length; i++) {
				for (int j = 0; j < board[i].length; j++) {
					System.out.print(board[i][j] + " ");
				}
				
				System.out.println("");
			}
			
			// Checking if there is a winner
			if ((board[0][0] == board[0][1]) && (board[0][1] == board[0][2])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
			else if ((board[1][0] == board[1][1]) && (board[1][1] == board[1][2])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
			else if ((board[2][0] == board[2][1]) && (board[2][1] == board[2][2])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
			else if ((board[0][0] == board[1][0]) && (board[1][0] == board[2][0])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
			else if ((board[0][1] == board[1][1]) && (board[1][1] == board[2][1])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
			else if ((board[0][2] == board[1][2]) && (board[1][2] == board[2][2])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
			else if ((board[0][0] == board[1][1]) && (board[1][1] == board[2][2])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
			else if ((board[0][2] == board[1][1]) && (board[1][1] == board[2][0])) {
				isWinner = true;
				System.out.println("Player " + player + " wins!");
			}
		}
	}
}