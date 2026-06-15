# Rocket Boost

Rocket Boost is a small Unity prototype focused on controlling a rocket in a 3D scene. The project currently contains a sandbox level, a rocket movement script, and GameDev.tv sci-fi assets used to build the environment and rocket visuals.

## Project Overview

The main goal of this project is to practice basic Unity gameplay scripting:

- Reading keyboard input
- Moving a GameObject with `transform.Translate`
- Using Unity's Input System package
- Testing simple player controls in a sandbox scene

## Controls

Current controls from `Assets/Scripts/RocketMove.cs`:

| Key | Action |
| --- | --- |
| `Space` | Move the rocket upward |
| `D` | Move the rocket right |
| `W` | Move the rocket forward |

The script also has a serialized `InputAction` named `thrust`, which logs a message while the assigned thrust input is pressed.

## Project Structure

```text
Rocket Boost/
+-- Assets/
|   +-- GameDevTV Assets/      # Models, materials, textures, and prefabs
|   +-- Scenes/
|   |   +-- Sandbox.unity      # Main test scene
|   +-- Scripts/
|   |   +-- RocketMove.cs      # Rocket movement/input script
|   +-- Settings/              # URP and rendering settings
+-- Packages/
|   +-- manifest.json          # Unity package dependencies
+-- ProjectSettings/           # Unity project configuration
+-- readme.md
```

## Requirements

- Unity `6000.4.9f1`
- Universal Render Pipeline
- Unity Input System package

## How to Run

1. Open Unity Hub.
2. Click **Add** or **Open** and select the `Rocket Boost` folder.
3. Open the scene at `Assets/Scenes/Sandbox.unity`.
4. Press **Play** in the Unity Editor.
5. Use the controls listed above to test the rocket movement.

## Current Status

This is an early learning prototype. The rocket can move in simple one-unit steps using keyboard input, and the project is ready for more gameplay features.

## Possible Next Steps

- Replace step movement with smooth physics-based thrust.
- Add left and right rotation controls.
- Add collision detection for obstacles and landing pads.
- Add particle effects and audio for rocket thrust.
- Create multiple levels with win/fail conditions.

## Credits

This project uses GameDev.tv asset files included inside `Assets/GameDevTV Assets`.
