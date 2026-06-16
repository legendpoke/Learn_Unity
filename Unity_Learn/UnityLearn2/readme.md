# UnityLearn2

UnityLearn2 is a C# learning notes project focused on Unity fundamentals, game development concepts, and Unity's core systems. Each `.cs` file acts as a study note that explains one Unity or C# topic through comments, examples, revision notes, memory tricks, and conceptual diagrams.

This repository is **not a complete Unity game project**. Instead, it serves as a personal knowledge base and revision guide for learning Unity concepts before applying them in practical projects such as **Rocket Boost**, **Obstacle Dodge**, and future Unity games.

---

## Topics Covered

### C# Fundamentals

* Namespaces
* Classes
* Using Directives
* Code Organization

### Unity Fundamentals

* Importing Assets
* Empty GameObjects
* Parent-Child Hierarchy
* Scene View Tools
* Global vs Local Coordinates
* Pivot vs Center
* Grid and Grid Snapping
* Unity Lifecycle Methods

### Unity Input System

* Input Actions
* Action Maps
* Bindings
* Multi-device Support
* Reading Input Values with `ReadValue<T>()`

### Physics & Movement

* Rigidbody Components
* Physics-Based Movement
* `AddRelativeForce()`
* Rotation Input
* Local Space vs World Space
* Frame-Independent Movement Concepts

### GameObject & Component Management

* Enable / Disable GameObjects
* Enable / Disable Components
* `OnEnable()`
* `OnDisable()`
* Object Lifecycle Events

---

## Project Structure

```text
UnityLearn2/
├── AddRelativeForce.cs
├── EmptyObjectImportance.cs
├── Enable_Disable.cs
├── ImportingAssests.cs
├── InputActions.cs
├── NameSpaces_Classes.cs
├── onEnable_onDisable.cs
├── ReadValue.cs
├── RotationInput.cs
├── Scene.cs
├── UnityLearn2.csproj
├── UnityLearn2.slnx
└── README.md
```

---

## File Guide

### NameSpaces_Classes.cs

Introduces the fundamental structure of C# programs.

Topics:

* Namespaces
* Classes
* Using Directives
* Access Modifiers
* Code Organization

---

### ImportingAssests.cs

Explains how external resources are imported into Unity projects.

Topics:

* 3D Models
* Textures
* Audio Files
* Materials
* Animations
* Prefabs
* Project Folder Organization

> Note: The file name is currently `ImportingAssests.cs` while the class name is `ImportingAssets`.

---

### EmptyObjectImportance.cs

Explains the purpose and practical uses of Empty GameObjects.

Topics:

* Transform-only Objects
* Parent Objects
* Scene Organization
* Spawn Points
* Waypoints
* Camera Targets
* Manager Objects

---

### Scene.cs

Explains Unity Scene View tools and object manipulation modes.

Topics:

* Global Coordinates
* Local Coordinates
* Grid System
* Grid Snapping
* Pivot Mode
* Center Mode
* Scene Navigation

---

### InputActions.cs

Introduces Unity's modern Input System.

Topics:

* Input Actions
* Action Maps
* Bindings
* Input Devices
* Multi-device Support

Examples:

* Move
* Jump
* Shoot
* Interact
* Pause

---

### ReadValue.cs

Explains how values are retrieved from Input Actions.

Topics:

* `ReadValue<T>()`
* Generic Types
* Float Inputs
* Vector2 Inputs
* Vector3 Inputs
* Movement Input
* Controller Input

Examples:

```csharp
action.ReadValue<float>();
action.ReadValue<Vector2>();
action.ReadValue<Vector3>();
```

---

### RotationInput.cs

Explains how player input can rotate GameObjects.

Topics:

* Rotation Controls
* Rotation Axes
* Rotation Speed
* Frame-Independent Rotation
* Vehicle Steering
* Rocket Turning
* Spaceship Controls

---

### AddRelativeForce.cs

Explains Rigidbody-based movement using forces.

Topics:

* `AddRelativeForce()`
* Physics-Based Movement
* Local Space Movement
* Rigidbody Requirements
* Acceleration
* Rocket Controls
* Spaceship Movement

Important Concepts:

```csharp
rocketRigidbody.AddRelativeForce(Vector3.up * thrustStrength);
```

and

```csharp
FixedUpdate()
```

for physics calculations.

---

### Enable_Disable.cs

Explains how GameObjects and Components can be turned on and off.

Topics:

* `SetActive(true)`
* `SetActive(false)`
* Component Enabling
* Component Disabling
* MeshRenderer Control
* Collider Control
* Script Enabling
* Difference Between Disable and Destroy

---

### onEnable_onDisable.cs

Explains Unity lifecycle events related to activation.

Topics:

* `OnEnable()`
* `OnDisable()`
* Event Registration
* Event Cleanup
* UI Activation
* Timers
* Component Lifecycle

Comparison:

* `Start()` runs once.
* `OnEnable()` can run multiple times.

---

## How To Use This Project

1. Open `UnityLearn2.slnx` in Visual Studio or another C# editor.
2. Read each `.cs` file as a lesson note.
3. Review the memory tricks and revision sections.
4. Practice the concepts inside Unity projects.
5. Expand the notes as new topics are learned.

---

## Recommended Learning Path

### Beginner Level

1. NameSpaces_Classes.cs
2. ImportingAssests.cs
3. EmptyObjectImportance.cs
4. Scene.cs

### Unity Basics

5. Enable_Disable.cs
6. onEnable_onDisable.cs
7. InputActions.cs
8. ReadValue.cs

### Physics & Gameplay

9. RotationInput.cs
10. AddRelativeForce.cs

This progression moves from C# fundamentals into Unity systems, input handling, object management, and finally physics-based gameplay mechanics.

---

## Concepts Practiced

### C#

* Namespaces
* Classes
* Methods
* Variables
* Access Modifiers
* Code Organization

### Unity Engine

* Assets
* GameObjects
* Components
* Hierarchy
* Scene View
* Lifecycle Methods

### Input System

* Input Actions
* Action Maps
* Bindings
* `ReadValue<T>()`

### Physics

* Rigidbody
* AddRelativeForce()
* Local Space
* World Space
* FixedUpdate()

### Gameplay Programming

* Rocket Controls
* Rotation Systems
* Physics Movement
* Player Input Handling
* Object Activation

---

## Current Status

This project is an expanding Unity learning notebook written entirely in C# files.

Current topics include:

* Unity Fundamentals
* Scene View Tools
* Empty GameObjects
* Input System Basics
* Lifecycle Methods
* Enable / Disable Systems
* Rotation Concepts
* Physics-Based Movement
* Rigidbody Forces

Additional Unity systems and gameplay programming topics will be added as learning progresses.

---

## Notes

* The project targets `.NET 10.0` through `UnityLearn2.csproj`.
* The repository is intended for learning and revision purposes.
* Generated folders such as `bin`, `obj`, and `.vs` are not part of the learning material.
* Most educational content is stored directly inside `.cs` files as commented notes and explanations.
* Concepts are explained using beginner-friendly examples, revision summaries, and memory tricks for long-term retention.