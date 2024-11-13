# Math Quiz Game

A console-based math quiz game written in C#. The game presents the user with random math questions, accepts their answers, and provides feedback on correctness. The game also tracks the user's accuracy and allows for restarting the game with resetable statistics.

## Features

- Multiple types of math operations: addition, subtraction, multiplication, and division.
- Randomized questions with multiple-choice answers.
- User feedback for correct or incorrect answers.
- Displays the total number of correct answers, the total questions answered, and accuracy rate.
- Option to play again or reset game statistics.

## Requirements

- .NET Core SDK 3.1 or higher.
- A text editor or IDE for running C# programs (e.g., Visual Studio, Visual Studio Code, JetBrains Rider).

## How to Play

1. Upon starting the game, you will be prompted to enter how many questions you want to answer.
2. The game will present a math question (e.g., `3 + 5 = ?`) and provide four choices labeled **A, B, C, D**.
3. Choose the correct answer by typing the corresponding letter (A, B, C, or D).
4. After completing all the questions, the game will display your performance (correct answers, total questions, accuracy rate).
5. You will then be asked if you want to play again or reset your statistics.

## How to Run the Game

1. Clone or download this repository to your local machine.
2. Open the project in a C# IDE like Visual Studio or Visual Studio Code.
3. Build and run the program. 
4. Follow the on-screen instructions to play.

## Code Structure

- `Program.cs`: The main entry point of the application, containing logic to generate random math problems and handle user interaction.
- `CalculateRightAnswer()`: Computes the correct answer based on the operator.
- `PrintMultipleChoices()`: Displays the multiple-choice options for the user.
- `AskToPlayAgain()`: Prompts the user if they want to play again.
- `GetUserAnswer()`: Validates and returns the user’s selected answer.
- `DisplayGameStats()`: Displays the player's performance after the game.

## Future Improvements

- Add difficulty levels to the questions (easy, medium, hard).
- Implement a timer for each question.
- Allow users to select which math operations they want to be quizzed on.

