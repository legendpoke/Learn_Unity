# UnityLearn2

UnityLearn2 is a C# learning notes project for Unity basics. It contains beginner-friendly notes written inside `.cs` files, with each file focused on one Unity or C# topic.

This folder is not a full Unity scene project. It is mainly used as a study/reference project for understanding Unity concepts before applying them in game projects like **Obstacle Dodge** and **Rocket Boost**.

## Topics Covered

- Importing assets into Unity
- Why Empty GameObjects are useful
- Namespaces and classes in C#
- Unity Input Actions
- `OnEnable()` and `OnDisable()` lifecycle methods

## Project Structure

```text
UnityLearn2/
+-- EmptyObjectImportance.cs
+-- ImportingAssests.cs
+-- InputActions.cs
+-- NameSpaces_Classes.cs
+-- onEnable_onDisable.cs
+-- UnityLearn2.csproj
+-- UnityLearn2.slnx
+-- readme.md
```

## File Guide

### EmptyObjectImportance.cs

Explains what an Empty GameObject is and why it matters in Unity.

Main ideas:

- Empty GameObjects only have a Transform component.
- They are useful as parent objects.
- They help organize large scenes.
- They can be used as spawn points, waypoints, camera targets, pivot points, and manager objects.

### ImportingAssests.cs

Explains how assets are brought into Unity projects.

Main ideas:

- Assets are files used by a game, such as models, textures, audio, scripts, materials, prefabs, and animations.
- Assets can be imported by drag-and-drop, the Unity import menu, or the Unity Asset Store.
- Organized folders make Unity projects easier to manage.

Note: the file name is currently `ImportingAssests.cs`. The class inside is named `ImportingAssets`.

### InputActions.cs

Explains the newer Unity Input System and the idea of Input Actions.

Main ideas:

- Input Actions represent player commands like move, jump, shoot, pause, or interact.
- Bindings connect actions to keys, mouse buttons, controller buttons, or other devices.
- Action Maps group related actions, such as Player controls or UI controls.
- Input Actions are better for multi-device support and rebinding than checking individual keys everywhere.

### NameSpaces_Classes.cs

Explains basic C# namespaces and classes.

Main ideas:

- Namespaces organize classes.
- Classes organize variables and methods.
- Classes usually focus on one responsibility.
- `using` statements allow access to classes from another namespace.
- Unity scripts usually use one class per script.

### onEnable_onDisable.cs

Explains Unity's `OnEnable()` and `OnDisable()` event methods.

Main ideas:

- `OnEnable()` runs when a GameObject or component becomes active/enabled.
- `OnDisable()` runs when a GameObject or component becomes inactive/disabled.
- These methods are useful for event subscription, cleanup, timers, UI panels, and setup logic.
- `Start()` runs once, while `OnEnable()` can run multiple times.

## How To Use This Project

1. Open `UnityLearn2.slnx` in Visual Studio or another C# editor.
2. Read each `.cs` file as a lesson note.
3. Use the short revision sections inside each file for quick review.
4. Apply the ideas in Unity projects by creating scripts, GameObjects, prefabs, and input controls.

## Learning Path

A good order to read the files:

1. `NameSpaces_Classes.cs`
2. `ImportingAssests.cs`
3. `EmptyObjectImportance.cs`
4. `InputActions.cs`
5. `onEnable_onDisable.cs`

This order starts with basic C# structure, then moves into Unity project organization and gameplay behavior.

## Concepts Practiced

- C# namespaces
- C# classes
- Variables and methods
- Unity assets
- Unity GameObjects
- Empty GameObjects
- Parent-child hierarchy
- Unity Input System
- Input Action bindings
- Unity event methods
- Object enable/disable flow

## Current Status

This project is a learning notes collection. The notes are written clearly for revision and can be expanded as new Unity topics are learned.

## Notes

- The project targets `.NET 10.0` through `UnityLearn2.csproj`.
- Generated folders such as `bin` and `obj` should not be treated as main learning content.
- The useful study material is in the root `.cs` files.
