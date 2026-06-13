# Unity Learning Projects

This repository contains my Unity learning work. It is a place to practice Unity, C#, game logic, movement, collisions, triggers, prefabs, physics, level design, and small gameplay systems.

The main purpose of this repo is to keep learning notes and beginner Unity projects together in one organized place.

## What This Repository Is About

This repo is about learning Unity by building and experimenting.

It contains:

- Unity C# learning notes.
- Small scripts that explain basic Unity concepts.
- A beginner obstacle-dodging game prototype.
- Practice with collisions, triggers, Rigidbody physics, movement, materials, prefabs, and level design.
- README files and `.gitignore` files for better project organization.

## Why This Repository Exists

This repository is made for practice and progress.

The goals are:

- To learn Unity step by step.
- To understand how C# scripts control GameObjects.
- To keep useful notes in one place.
- To build small projects instead of only reading theory.
- To track progress with Git.
- To create a base for future Unity games.

## What This Can Be Used For

You can use this repository to:

- Review Unity basics.
- Study simple C# Unity scripts.
- Open and test a small Unity game project.
- Practice adding features to a game.
- Learn how Unity project folders are organized.
- Track improvement over time.

## Folder Description

```text
Unity/
+-- Obstacle Dodge/
+-- Unity_Learn/
+-- readme.md
```

## Obstacle Dodge

`Obstacle Dodge` is a Unity game prototype.

It is about moving a player through an obstacle course while avoiding hazards, falling objects, and flying projectiles.

Main ideas in this project:

- Player movement with WASD or arrow keys.
- Obstacles that react when the player hits them.
- Collision detection.
- Trigger zones.
- Flying objects.
- Falling objects.
- Rotating objects.
- Simple score/count logic.
- Materials and prefabs.
- A playable Unity scene.

Important folders inside `Obstacle Dodge`:

- `Assets` - main Unity game files.
- `Assets/Scripts` - gameplay C# scripts.
- `Assets/Scenes` - Unity scenes.
- `Assets/Materials` - materials used by objects.
- `Assets/PreFabs` - reusable prefab objects.
- `Packages` - Unity package dependencies.
- `ProjectSettings` - Unity project settings.

To start this project:

1. Open **Unity Hub**.
2. Click **Add** or **Open**.
3. Select the `Obstacle Dodge` folder.
4. Open `Assets/Scenes/SampleScene.unity`.
5. Press the **Play** button in Unity.

## Unity_Learn

`Unity_Learn` contains learning notes and practice scripts.

This folder is for understanding Unity concepts before or while building games.

It currently contains:

- `UnityLearn1` - a collection of beginner Unity C# notes and scripts.

Topics covered in `UnityLearn1` include:

- Unity basics.
- Methods and variables.
- `SerializeField`.
- `Start()` and `Update()`.
- Movement with Transform.
- Rotation.
- `Time.time` and `Time.deltaTime`.
- Rigidbody physics.
- Collisions and triggers.
- Tags.
- Prefabs.
- Destroying objects.
- Score logic.
- Level layout ideas.
- Hazards and difficulty progression.
- Unity execution order.

## How To Start Learning

A good order is:

1. Read the root README file.
2. Open `Unity_Learn/UnityLearn1/readme.md`.
3. Study the beginner scripts in `UnityLearn1`.
4. Open the `Obstacle Dodge` project in Unity.
5. Play the scene and watch the Console.
6. Read the scripts in `Obstacle Dodge/Assets/Scripts`.
7. Try changing small values like speed, fall delay, or rotation speed.
8. Add one small feature at a time.

## Tools Used

- Unity
- Unity Hub
- C#
- Visual Studio or another C# editor
- Git

The `Obstacle Dodge` project also uses Unity packages such as Universal Render Pipeline, Input System, Cinemachine, and other standard Unity packages.

## Git Notes

The `.gitignore` files are set up to avoid committing generated Unity folders and editor files.

Usually keep these in Git:

- `Assets`
- `Packages`
- `ProjectSettings`
- README files
- `.gitignore` files

Usually do not commit these:

- `Library`
- `Temp`
- `Logs`
- `UserSettings`
- `.vs`
- generated `.csproj` and solution files

## Future Goals

Future improvements for this repository:

- Add more Unity learning examples.
- Improve code style and script names.
- Add comments where concepts are difficult.
- Add screenshots or gameplay images.
- Add a better UI to `Obstacle Dodge`.
- Add win and lose conditions.
- Add sound effects and music.
- Add more levels.
- Add checkpoints.
- Add a main menu.
- Build a small complete game from the current prototype.

## Current Status

This repository is currently a learning workspace. It has one main playable Unity prototype and one learning-notes folder.

The next best step is to keep improving `Obstacle Dodge` while using `UnityLearn1` as a reference for Unity concepts.
