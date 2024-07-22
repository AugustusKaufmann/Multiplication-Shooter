# Multiplication Shooter!

Multiplication Shooter! is a Unity project designed to help students at Ave Afiadenyigba D/A Basic School in Ghana practice multiplication through an engaging shooting game. The game includes various interactive elements such as lasers, enemies, and questions that test the player's multiplication skills in a timed setting.

## Project Structure

The project is organized into the following directories:

- `.vscode/` - Contains settings and configurations for Visual Studio Code.
- `Assets/` - Contains all the game assets including prefabs, audio sources, and other resources. (Important)
- `Packages/` - Contains package information used in the project.
- `ProjectSettings/` - Contains settings for the Unity project.
- `Scripts/` - Contains all the C# scripts used in the game. (Important)

## Scripts

The `Scripts/` folder includes the following C# files pertaining to game behavior:

- `TraumaInducer.cs` - Manages the trauma effect and explosion particles.
- `StressReceiver.cs` - Handles the stress effect on game objects.
- `question.cs` - Manages the game's questions, scoring, and user inputs.
- `laser.cs` - Controls the behavior of the laser object.
- `enemy.cs` - Manages enemy behavior and interactions with the player.
- `Buttons.cs` - Handles UI button interactions and game state changes.

## How to Run

### Option 1: Running the Game in Unity

1. Clone the repository to your local machine.
2. Open the folder as a project in Unity.
3. Ensure all necessary packages are installed.
4. Press the play button in Unity to start the game. (You will need to assign some variables such as the Canvas, etc. in the Unity Editor)

### Option 2: Running the Built Game

1. Open [this Dropbox link](https://www.dropbox.com/scl/fo/sqgd7r1e5zb541sea039y/APBfCpRe1kyJxkNjPtXm71s?rlkey=ikz5lq713bxqjtlhkyvzrq6dk&st=gzemynyj&dl=0).
2. Download the built game files.
3. Extract the downloaded files.
4. Run the `MultiplicationShooter.exe` file to start the game.

## Gameplay

In Multiplication Shooter!, players need to shoot enemies by answering multiplication questions correctly. Each correct answer fires a laser, and enemies speed up as the player progresses. The player's goal is to maximize their score by destroying enemies.

## Features

- **Random Multiplication Questions**: Players answer multiplication questions to progress.
- **Dynamic Difficulty**: Enemy speed increases as the player scores more points.
- **High Score Tracking**: The game tracks and displays the player's high score.
- **Music**: Background music can be toggled on or off during the game.
- **Wrong Answer Feedback**: Shows the correct answer for any question answered incorrectly at the end of the game.
- **Stress Effects**: Visual effects that simulate stress based on gameplay events.

## Contributing

If you would like to contribute to the project, please fork the repository and submit a pull request. Any contributions are welcome!

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
