# Flappy Bird – Unity 2D

A simple Flappy Bird clone made in Unity 2D using C#. The player controls a small bird and tries to fly through gaps between pipes without hitting any obstacles. The game includes basic physics, score tracking, and a restartable game over screen.

## Features

- Classic Flappy Bird style gameplay (tap/space to jump).
- Randomly generated pipe positions using a spawner system.
- Score increases each time the bird passes a pipe gap.
- Game Over screen with final score and play/restart button.
- Simple parallax background effect for a moving world feel.

## Project Structure

- `Assets/Scripts/Player.cs` – Handles bird movement, gravity, jump input, sprite animation, and collision with pipes/score triggers.
- `Assets/Scripts/GameManager.cs` – Controls game state (Play, Pause, Game Over), manages score UI, and restarts the game.
- `Assets/Scripts/Spawner.cs` – Periodically spawns pipe prefabs at random heights.
- `Assets/Scripts/Pipes.cs` – Moves pipes left and destroys them when they leave the screen.
- `Assets/Scripts/Parallax.cs` – Scrolls the background texture to create a parallax effect.

## How to Play

1. Open the project in Unity (any compatible 2D version).
2. Load the main scene (e.g., `FlappyBird.unity`).  
3. Press the Play button in Unity.  
4. Press Spacebar or click the mouse to make the bird jump.  
5. Avoid colliding with pipes or the ground.  
6. When you hit an obstacle, the Game Over screen appears with your score and a button to restart.

## Getting Started

- Clone the repository:
  - `git clone https://github.com/<your-username>/<your-repo-name>.git`
- Open the project in Unity Hub and select the project folder
- Press Play in the Unity Editor to run the game.

## Technologies Used

- Unity (2D) game engine.
- C# for game logic and scripting.
- 2D sprites for art assets.

## Future Improvements

- Add sound effects and background music.
- Add difficulty scaling (faster pipes, smaller gaps).
- Add a main menu and high-score system saved between sessions.
[17](https://www.scribd.com/document/782084096/494-t2)
[18](https://github.com/othneildrew/Best-README-Template)
[19](https://github.com/matiassingers/awesome-readme)
[20](https://github.com/banesullivan/README)
[21](https://www.makeareadme.com)
[22](https://www.youtube.com/watch?v=rCt9DatF63I)
