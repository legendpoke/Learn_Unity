# UnityLearn2

UnityLearn2 is a C# learning notes project focused on Unity fundamentals and beginner-friendly game development concepts. Each `.cs` file acts as a study note that explains one Unity or C# topic through comments, examples, revision notes, and conceptual diagrams.

This repository is not a complete Unity game project. Instead, it serves as a personal knowledge base and revision guide for learning Unity concepts before applying them in practical projects such as Rocket Boost, Obstacle Dodge, and future Unity games.

## Topics Covered

### C# Fundamentals

* Namespaces
* Classes
* Using directives
* Code organization

### Unity Fundamentals

* Importing assets
* Empty GameObjects
* Parent-child hierarchy
* Unity lifecycle methods

### Unity Input System

* Input Actions
* Reading input values with `ReadValue<T>()`
* Action enabling and disabling

### Physics & Movement

* Rigidbody components
* Physics-based movement
* `AddRelativeForce()`
* Rotation input
* Frame-independent movement concepts

## Project Structure

```text
UnityLearn2/
+-- AddRelativeForce.cs
+-- EmptyObjectImportance.cs
+-- ImportingAssests.cs
+-- InputActions.cs
+-- NameSpaces_Classes.cs
+-- onEnable_onDisable.cs
+-- ReadValue.cs
+-- RotationInput.cs
+-- UnityLearn2.csproj
+-- UnityLearn2.slnx
+-- README.md
```

## File Guide

### NameSpaces_Classes.cs

Introduces basic C# structure and organization.

Topics:

* Namespaces
* Classes
* Responsibilities of classes
* Using directives
* Script organization

---

### ImportingAssests.cs

Explains how assets are imported into Unity projects.

Topics:

* Models
* Textures
* Audio
* Materials
* Prefabs
* Animations
* Project folder organization

Note: The file name is currently `ImportingAssests.cs`, while the class name is `ImportingAssets`.

---

### EmptyObjectImportance.cs

Explains the purpose and usefulness of Empty GameObjects.

Topics:

* Transform-only GameObjects
* Scene organization
* Parent objects
* Spawn points
* Waypoints
* Camera targets
* Manager objects

---

### InputActions.cs

Introduces Unity's modern Input System.

Topics:

* Input Actions
* Action Maps
* Bindings
* Multi-device support
* Input abstraction

Examples:

* Move
* Jump
* Shoot
* Interact
* Pause

---

### ReadValue.cs

Explains how input values are retrieved from Input Actions.

Topics:

* `ReadValue<T>()`
* Generic types
* Reading floats
* Reading Vector2 values
* Reading Vector3 values
* Movement input
* Controller input

Common examples:

```csharp
action.ReadValue<float>();
action.ReadValue<Vector2>();
action.ReadValue<Vector3>();
```

---

### RotationInput.cs

Explains how player input can be used to rotate objects.

Topics:

* Rotation controls
* Rotation axes
* Rotation speed
* Frame-independent rotation
* Vehicle steering
* Rocket turning
* Spaceship controls

Examples:

* A / D keys
* Arrow keys
* Controller input

---

### AddRelativeForce.cs

Explains Unity physics-based movement using Rigidbody forces.

Topics:

* `AddRelativeForce()`
* Local space movement
* Rigidbody requirements
* Physics acceleration
* Rockets and spaceships
* Difference between `AddForce()` and `AddRelativeForce()`
* Difference between `Translate()` and `AddRelativeForce()`

Important concepts:

```csharp
rocketRigidbody.AddRelativeForce(Vector3.up * thrustStrength);
```

and

```csharp
FixedUpdate()
```

for physics calculations.

---

### onEnable_onDisable.cs

Explains Unity lifecycle methods.

Topics:

* `OnEnable()`
* `OnDisable()`
* Event subscriptions
* Event cleanup
* UI activation
* Timers
* Component lifecycle

Comparison:

* `Start()` runs once.
* `OnEnable()` can run multiple times.

## How To Use This Project

1. Open `UnityLearn2.slnx` in Visual Studio or another C# editor.
2. Read each `.cs` file as a lesson note.
3. Review the revision summaries at the bottom of each file.
4. Practice the concepts inside Unity projects.
5. Expand the notes as new topics are learned.

## Recommended Learning Path

### Beginner Level

1. NameSpaces_Classes.cs
2. ImportingAssests.cs
3. EmptyObjectImportance.cs

### Unity Basics

4. InputActions.cs
5. ReadValue.cs
6. onEnable_onDisable.cs

### Physics & Gameplay

7. RotationInput.cs
8. AddRelativeForce.cs

This progression moves from C# fundamentals into Unity systems, input handling, and finally physics-based gameplay mechanics.

## Concepts Practiced

### C#

* Namespaces
* Classes
* Methods
* Variables
* Code organization

### Unity Engine

* Assets
* GameObjects
* Components
* Hierarchy
* Lifecycle methods

### Input System

* Input Actions
* Bindings
* Action Maps
* ReadValue<T>()

### Physics

* Rigidbody
* AddRelativeForce()
* Local Space
* World Space
* FixedUpdate()

### Gameplay Programming

* Rocket controls
* Rotation systems
* Physics movement
* Player input handling

## Current Status

This project is an expanding Unity learning notebook written entirely in C# files.

The notes currently cover:

* Unity fundamentals
* Input System basics
* Lifecycle methods
* Rotation concepts
* Physics-based movement
* Rigidbody forces

More topics will be added as additional Unity systems are studied.

## Notes

* The project targets .NET 10.0 through `UnityLearn2.csproj`.
* The repository is intended for learning and revision purposes.
* Generated folders such as `bin` and `obj` are not part of the learning material.
* Most educational content is stored directly inside the root `.cs` files as commented notes and explanations.
