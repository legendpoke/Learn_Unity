# Obstacle Dodge

Obstacle Dodge is a beginner Unity game prototype where the player moves through a small level while avoiding obstacles, falling objects, and trigger-based projectiles.

The project is built as a learning game. It practices Unity fundamentals like player movement, collisions, triggers, Rigidbody physics, prefabs, materials, object rotation, delayed events, and simple score tracking.

## Scene Update

The main scene has been updated. `Assets/Scenes/SampleScene.unity` now includes the current obstacle course layout with the player, obstacle prefabs, rotating objects, falling sky obstacles, trigger projectile setup, materials, and camera setup needed to test the game.

## Game Idea

The main goal is simple:

Move the player, avoid danger, and survive the obstacle course.

The project currently includes:

- A player that moves with keyboard input.
- Obstacles that react when the player hits them.
- A score/count system for player bumps.
- Falling objects that appear after a delay.
- A projectile/flying object prefab.
- Trigger zones that activate projectiles.
- Rotating objects for visual movement and challenge.
- Materials for player, ground, walls, obstacles, and flying objects.

## How To Start The Project

1. Open **Unity Hub**.
2. Click **Add** or **Open**.
3. Select the folder:

   ```text
   D:\Unity\Obstacle Dodge
   ```

4. Wait for Unity to import the project.
5. Open the scene:

   ```text
   Assets/Scenes/SampleScene.unity
   ```

6. Press the **Play** button at the top of Unity.
7. Use the keyboard controls to move the player.

## Controls

| Action | Key |
| --- | --- |
| Move forward/back | `W` / `S` or `Up Arrow` / `Down Arrow` |
| Move left/right | `A` / `D` or `Left Arrow` / `Right Arrow` |
| Start/stop testing | Unity **Play** button |

The movement uses Unity's `Input.GetAxis("Horizontal")` and `Input.GetAxis("Vertical")`.

## Project Structure

```text
Obstacle Dodge/
+-- Assets/
|   +-- Materials/
|   +-- PreFabs/
|   +-- Scenes/
|   +-- Scripts/
|   +-- Settings/
+-- Packages/
+-- ProjectSettings/
+-- .gitignore
+-- readme.md
```

## Main Folders

### Assets

Contains the main game files, including scripts, scenes, materials, prefabs, and render pipeline settings.

### Assets/Scripts

Contains the C# scripts that control gameplay behavior.

### Assets/Scenes

Contains the Unity scene. The current main scene is `SampleScene.unity`.

### Assets/PreFabs

Contains reusable GameObjects. The current project includes a `FlyingObject` prefab.

### Assets/Materials

Contains visual materials for the player, ground, walls, obstacles, and flying objects.

### Packages

Stores Unity package dependencies such as Universal Render Pipeline, Input System, Cinemachine, and other Unity packages.

### ProjectSettings

Stores important Unity project settings. This folder should be committed to Git.

## Script Sections

### PlayerMove.cs

Controls the player movement.

- Prints simple instructions in the Console.
- Uses `Input.GetAxis()` for movement.
- Uses `Time.deltaTime` so movement stays smooth across different frame rates.
- Moves the player with `transform.Translate()`.

### CollisionScript.cs

Handles obstacle collision behavior.

- Detects when the player collides with an object.
- Changes the object's color to white.
- Changes the object's tag to `Hit` after collision.

### ScoreMethod.cs

Tracks how many objects the player has bumped into.

- Increases a counter on collision.
- Uses `Debug.Log()` to show the count in the Console.
- Avoids counting objects already tagged as `Hit`.

### TriggerProjectile.cs

Activates a projectile when the player enters a trigger zone.

- Checks whether the entering object is the player.
- Turns on the projectile GameObject.
- Destroys the trigger object after activation.

### FlyAtPlayer.cs

Moves a flying object toward the player's position.

- Stores the player's position.
- Uses `Vector3.MoveTowards()` to move toward that point.
- Destroys the flying object when it reaches the target position.

### SkyObjectFall.cs

Creates delayed falling-object behavior.

- Hides the object at the start.
- Makes it visible after a few seconds.
- Enables Rigidbody gravity so the object falls.

### RotatingObject.cs

Rotates an object every frame.

- Uses `transform.Rotate()`.
- Creates simple moving obstacle behavior.

## Unity Concepts Practiced

- GameObjects and Components
- C# scripts with `MonoBehaviour`
- `Start()` and `Update()`
- Keyboard input
- `Time.deltaTime`
- Collisions with `OnCollisionEnter()`
- Triggers with `OnTriggerEnter()`
- Rigidbody gravity
- Tags
- Prefabs
- Materials
- `Debug.Log()`
- Basic score counting
- Simple obstacle design

## How To Play

1. Open `SampleScene`.
2. Press Play.
3. Move the player with WASD or arrow keys.
4. Dodge obstacles and flying objects.
5. Watch the Console for score and game messages.
6. Try to reach the end of the level without hitting too many obstacles.

## Development Notes

- Important project folders to keep in Git: `Assets`, `Packages`, and `ProjectSettings`.
- Generated folders like `Library`, `Temp`, `Logs`, and `UserSettings` are ignored by `.gitignore`.
- Some scripts are still early learning versions, so names and code style can be improved later.
- The Console is currently used for feedback instead of a full UI.

## Future Goals

- Add a proper start menu.
- Add a restart button after losing.
- Add a finish line or win condition.
- Add player health or lives.
- Add a visible score UI instead of only Console logs.
- Add sound effects for collisions, hazards, and winning.
- Add background music.
- Add more obstacle types.
- Add moving platforms or rotating hazards.
- Add checkpoints.
- Add multiple levels with increasing difficulty.
- Add particle effects when the player hits an obstacle.
- Improve player movement feel.
- Add mobile controls or controller support.
- Replace placeholder objects with better models and environment art.
- Add game over and victory screens.

## Current Status

This project is a playable learning prototype. The scene has been updated with the current obstacle-dodging setup, and it already has the core building blocks of an obstacle-dodging game.

The best next step is to turn the Console-based feedback into real on-screen UI, then add win/lose conditions so the game has a clear beginning, challenge, and ending.
