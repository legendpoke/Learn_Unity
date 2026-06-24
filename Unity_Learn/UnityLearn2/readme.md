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
* Access Modifiers
* Methods
* Switch Statements

### Unity Fundamentals

* Importing Assets
* Empty GameObjects
* Parent-Child Hierarchy
* Scene View Tools
* Global vs Local Coordinates
* Pivot vs Center
* Grid and Grid Snapping
* Unity Lifecycle Methods
* Scene Management
* Build Profiles
* Build Index
* Scene Loading
* Scene Reloading

### Unity Input System

* Input Actions
* Action Maps
* Bindings
* Multi-device Support
* Reading Input Values with `ReadValue<T>()`

### Physics & Movement

* Rigidbody Components
* Rigidbody Tuning
* Physics-Based Movement
* `AddRelativeForce()`
* Rotation Input
* Local Space vs World Space
* Frame-Independent Movement Concepts

### Audio

* Audio Introduction
* Audio Sources
* Sound Effects (SFX)
* Audio Playback

### Cameras

* Position Composer
* Player Follow Camera
* Camera Framing Concepts

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
├── AudioIntroduction.cs
├── AudioSourceSFX.cs
├── EmptyObjectImportance.cs
├── Enable_Disable.cs
├── ImportingAssests.cs
├── InputActions.cs
├── LoadNextScene.cs
├── NameSpaces_Classes.cs
├── onEnable_onDisable.cs
├── PositionComposer.cs
├── ReadValue.cs
├── RespawnUsingSceneManager.cs
├── RigidBodyTunning.cs
├── RotationInput.cs
├── Scene.cs
├── SwitchStatements.cs
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

### RigidBodyTunning.cs

Explains Rigidbody settings and physics tuning.

Topics:

* Mass
* Linear Damping
* Angular Damping
* Use Gravity
* Is Kinematic
* Interpolate
* Collision Detection
* Constraints
* Layer Overrides

Focus:

* Understanding how Rigidbody settings affect gameplay feel.
* Rocket movement tuning.
* Physics behaviour optimization.

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

### AudioIntroduction.cs

Introduces Unity's audio system.

Topics:

* AudioClip
* AudioSource
* AudioListener
* Sound Effects
* Background Music
* Audio Workflow

---

### AudioSourceSFX.cs

Explains how AudioSource is used for Sound Effects.

Topics:

* Playing Sounds
* Stopping Sounds
* Looping Audio
* Play One Shot Sounds
* Volume
* Pitch
* 2D Audio
* 3D Audio

Examples:

* Rocket Engine Sound
* Collision Sound
* Button Click Sound

---

### PositionComposer.cs

Explains Cinemachine's Position Composer.

Topics:

* Camera Follow Systems
* Target Framing
* Dead Zone
* Soft Zone
* Follow Behaviour
* Camera Smoothing

Examples:

* Rocket Follow Camera
* Platformer Camera
* Third-Person Camera

---

### SwitchStatements.cs

Introduces Switch Statements in C#.

Topics:

* switch
* case
* break
* default
* Comparing Multiple Values
* Alternative to if-else chains

Examples:

* Game States
* Audio States
* Level Selection

---

### RespawnUsingSceneManager.cs

Explains how Unity reloads scenes to respawn a player after failure.

Topics:

* SceneManager
* GetActiveScene()
* buildIndex
* LoadScene()
* Scene Reloading
* Respawning
* Restarting Levels
* Crash Recovery

Examples:

* Rocket Crash
* Player Death
* Falling Off Map
* Restart Level Button

---

### LoadNextScene.cs

Explains how Unity loads the next scene or level.

Topics:

* SceneManager
* GetActiveScene()
* buildIndex
* sceneCountInBuildSettings
* Loading Next Level
* Level Progression
* Scene Navigation
* Game Completion Logic

Examples:

* Level 1 → Level 2
* Main Menu → Game Scene
* Victory Screen
* Story Progression

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

### Gameplay

9. RotationInput.cs
10. AddRelativeForce.cs
11. RigidBodyTunning.cs

### Audio

12. AudioIntroduction.cs
13. AudioSourceSFX.cs

### Camera Systems

14. PositionComposer.cs

### Scene Management
15. RespawnUsingSceneManager.cs
16. LoadNextScene.cs

### C# Logic

17. SwitchStatements.cs

This progression moves from C# fundamentals into Unity systems, input handling, object management, gameplay programming, audio systems, and camera control.

---

## Concepts Practiced

### C#

* Namespaces
* Classes
* Methods
* Variables
* Access Modifiers
* Code Organization
* Switch Statements

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
* Rigidbody Tuning
* AddRelativeForce()
* Local Space
* World Space
* FixedUpdate()

### Audio

* AudioClip
* AudioSource
* AudioListener
* Sound Effects
* Audio Playback

### Cameras

* Position Composer
* Camera Following
* Dead Zones
* Soft Zones
* Camera Framing

### Gameplay Programming

* Rocket Controls
* Rotation Systems
* Physics Movement
* Player Input Handling
* Object Activation
* Player Follow Camera

### Scene Management
* SceneManager
* LoadScene()
* GetActiveScene()
* Build Index
* Scene Reloading
* Scene Progression
* Respawn Systems
* Level Management

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
* Rigidbody Tuning
* Audio Systems
* Sound Effects
* Scene Management
* Respawn Systems
* Level Progression
* Switch Statements
* Player Follow Camera (Position Composer)

Additional Unity systems and gameplay programming topics will be added as learning progresses.

---

## Notes

* The project targets `.NET 10.0` through `UnityLearn2.csproj`.
* The repository is intended for learning and revision purposes.
* Generated folders such as `bin`, `obj`, and `.vs` are not part of the learning material.
* Most educational content is stored directly inside `.cs` files as commented notes and explanations.
* Concepts are explained using beginner-friendly examples, revision summaries, and memory tricks for long-term retention.

---

## Learning Philosophy

The goal of this repository is not just to memorize Unity APIs, but to understand:

* What a feature does.
* Why it exists.
* When it should be used.
* How it connects to real game development projects.

Each note is written so it can be revisited months later and still be understandable without rewatching tutorials.