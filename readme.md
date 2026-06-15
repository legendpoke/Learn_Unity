# Unity Learning Projects

This repository is my Unity learning workspace. It keeps beginner Unity projects, C# notes, gameplay experiments, and project README files together in one organized place.

The main goal is to learn Unity by building small things, testing ideas, and writing notes that are easy to revise later.

## Repository Contents

```text
Unity/
+-- Obstacle Dodge/
+-- Rocket Boost/
+-- Unity_Learn/
|   +-- UnityLearn1/
|   +-- UnityLearn2/
+-- readme.md
```

## Projects

### Obstacle Dodge

`Obstacle Dodge` is a playable Unity prototype where the player moves through an obstacle course while avoiding hazards.

It currently includes:

- Player movement with WASD or arrow keys
- Obstacles that react to collisions
- Score/count tracking through Console logs
- Falling sky obstacles
- Trigger zones
- Flying projectile objects
- Rotating obstacles
- Materials and prefabs
- An updated `SampleScene.unity` scene

Main scene:

```text
Obstacle Dodge/Assets/Scenes/SampleScene.unity
```

Project README:

```text
Obstacle Dodge/readme.md
```

### Rocket Boost

`Rocket Boost` is a Unity prototype focused on controlling a rocket in a 3D scene.

It currently includes:

- A sandbox scene
- A rocket movement script
- Simple keyboard movement
- Unity Input System practice
- GameDev.tv sci-fi assets
- URP project settings

Main scene:

```text
Rocket Boost/Assets/Scenes/Sandbox.unity
```

Project README:

```text
Rocket Boost/readme.md
```

## Learning Notes

### UnityLearn1

`Unity_Learn/UnityLearn1` contains beginner Unity C# notes and practice scripts.

Topics include:

- Unity basics
- Variables and methods
- `SerializeField`
- `Start()` and `Update()`
- Transform movement
- Rotation
- `Time.time` and `Time.deltaTime`
- Rigidbody physics
- Collisions and triggers
- Tags
- Prefabs
- Destroying objects
- Score logic
- Hazards and difficulty progression
- Unity execution order

README:

```text
Unity_Learn/UnityLearn1/readme.md
```

### UnityLearn2

`Unity_Learn/UnityLearn2` is a C# notes project focused on Unity concepts and code structure.

Topics include:

- Importing assets
- Empty GameObjects
- Namespaces and classes
- Unity Input Actions
- `OnEnable()` and `OnDisable()`

README:

```text
Unity_Learn/UnityLearn2/readme.md
```

## How To Open The Unity Projects

1. Open **Unity Hub**.
2. Click **Add** or **Open**.
3. Select either `Obstacle Dodge` or `Rocket Boost`.
4. Wait for Unity to import the project.
5. Open the main scene for that project.
6. Press **Play** in the Unity Editor.

## Suggested Learning Order

1. Read `Unity_Learn/UnityLearn1/readme.md`.
2. Study the beginner scripts in `UnityLearn1`.
3. Read `Unity_Learn/UnityLearn2/readme.md`.
4. Review the UnityLearn2 notes about assets, classes, input actions, and lifecycle methods.
5. Open `Obstacle Dodge` and test the updated scene.
6. Read the scripts in `Obstacle Dodge/Assets/Scripts`.
7. Open `Rocket Boost` and test the sandbox scene.
8. Try changing small values like movement speed, rotation speed, fall delay, or thrust input.

## Tools Used

- Unity
- Unity Hub
- C#
- Visual Studio or another C# editor
- Git
- Universal Render Pipeline
- Unity Input System
- Cinemachine

## Git Notes

Unity creates many generated folders and editor files. The `.gitignore` files are set up to avoid committing most generated content.

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
- generated build output

## Current Status

This repository now contains:

- One playable obstacle-dodging prototype with an updated scene
- One rocket movement prototype
- Two Unity/C# learning note folders
- README files for the root workspace and each main project

## Future Goals

- Improve `Obstacle Dodge` with UI, win/lose conditions, checkpoints, sound, and more levels.
- Improve `Rocket Boost` with physics-based thrust, rotation, collisions, landing pads, particles, and level progression.
- Add more Unity learning notes as new topics are studied.
- Add screenshots or short gameplay previews.
- Keep README files updated as each project changes.
