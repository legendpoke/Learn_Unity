# Unity Learning Projects

This repository is my Unity learning workspace. It combines Unity projects, C# learning notes, gameplay experiments, and project documentation into a single organized repository.

The goal of this repository is to learn Unity through hands-on practice, build small playable projects, explore game development concepts, and maintain detailed notes that can be revisited later for revision.

---

## Repository Structure

```text
Unity/
├── Obstacle Dodge/
├── Rocket Boost/
├── Unity_Learn/
│   ├── UnityLearn1/
│   └── UnityLearn2/
└── README.md
```

---

## Repository Contents

The repository currently contains:

### UnityLearn1

A beginner-friendly collection of Unity and C# learning notes.

Topics include:

* Unity basics
* MonoBehaviour
* Variables and methods
* SerializeField
* Start, Update, and FixedUpdate
* Transform movement
* Rotation
* Time.deltaTime
* Time.time
* Rigidbody physics
* Collisions
* Triggers
* Tags
* Prefabs
* Destroying objects
* Score systems
* Hazards and level design
* Unity execution order
* Cinemachine basics

Location:

```text
Unity_Learn/UnityLearn1
```

README:

```text
Unity_Learn/UnityLearn1/readme.md
```

---

### UnityLearn2

A second collection of Unity learning notes focused on Unity systems, game architecture concepts, input handling, physics, audio, and cameras.

Topics include:

* Namespaces and classes
* Importing assets
* Empty GameObjects
* Scene tools
* Global vs local coordinates
* Unity Input System
* Input Actions
* ReadValue<T>()
* Rigidbody tuning
* AddRelativeForce()
* Rotation input
* Enable / Disable systems
* OnEnable() and OnDisable()
* AudioSource and sound effects
* Cinemachine Position Composer
* Switch statements
* Load Next Scene
* Scene Manager

Location:

```text
Unity_Learn/UnityLearn2
```

README:

```text
Unity_Learn/UnityLearn2/readme.md
```

---

### Obstacle Dodge

A beginner Unity game prototype focused on player movement, collisions, triggers, hazards, and simple gameplay systems.

Features include:

* Keyboard movement
* Collision detection
* Trigger zones
* Projectile activation
* Falling obstacles
* Rotating obstacles
* Materials and prefabs
* Rigidbody interactions
* Console-based score tracking

Main Scene:

```text
Obstacle Dodge/Assets/Scenes/SampleScene.unity
```

README:

```text
Obstacle Dodge/readme.md
```

---

### Rocket Boost

A Unity 3D rocket prototype focused on physics-based movement and Unity's Input System.

Features include:

* Rigidbody movement
* Rocket thrust
* Manual rocket rotation
* Unity Input System
* AddRelativeForce()
* AudioSource sound effects
* FixedUpdate physics handling
* Sandbox testing environment
* Assets
* Added levels 
* Respawn Point in the scene

Main Scene:

```text
Rocket Boost/Assets/Scenes/Sandbox.unity
```

README:

```text
Rocket Boost/readme.md
```

---

## Suggested Learning Order

For someone learning from this repository, the recommended progression is:

### Phase 1 - Unity Foundations

1. UnityLearn1
2. Unity Basics
3. Variables and Methods
4. Transform Movement
5. Time.deltaTime
6. Rigidbody
7. Collisions and Triggers
8. Prefabs
9. Unity Order of Execution

### Phase 2 - Intermediate Unity Concepts

10. UnityLearn2
11. Asset Management
12. Empty GameObjects
13. Scene Tools
14. Unity Input System
15. ReadValue<T>()
16. Enable / Disable Systems
17. OnEnable() and OnDisable()
18. Rigidbody Tuning
19. Load Next Scene or Load Next levels
20. Respawn in the scene

### Phase 3 - Gameplay Projects

21. Obstacle Dodge
22. Rocket Boost

### Phase 4 - Expansion

23. Add new gameplay systems
24. Create larger Unity projects
25. Learn UI systems
26. Learn animation systems
27. Learn particle systems

---

## How To Open The Unity Projects

### Obstacle Dodge

1. Open Unity Hub.
2. Click Add or Open.
3. Select the Obstacle Dodge folder.
4. Wait for Unity to import the project.
5. Open:

```text
Assets/Scenes/SampleScene.unity
```

6. Press Play.

### Rocket Boost

1. Open Unity Hub.
2. Click Add or Open.
3. Select the Rocket Boost folder.
4. Wait for Unity to import the project.
5. Open:

```text
Assets/Scenes/Sandbox.unity
```

6. Press Play.

---

## Technologies Used

* Unity
* Unity Hub
* C#
* Visual Studio
* Git
* Universal Render Pipeline (URP)
* Unity Input System
* Cinemachine
* Rigidbody Physics
* Scene Manager

---

## Git Notes

Unity generates many temporary and editor-specific files that should not be committed.

Usually commit:

```text
Assets/
Packages/
ProjectSettings/
README.md
.gitignore
```

Usually ignore:

```text
Library/
Temp/
Logs/
UserSettings/
.vs/
Builds/
```

---

## Current Status

This repository currently contains:

* Two Unity learning note collections
* One obstacle-dodging prototype
* One rocket movement prototype
* Notes covering Unity fundamentals
* Input System practice
* Rigidbody physics concepts
* Audio basics
* Cinemachine camera concepts
* Project-specific documentation

The repository continues to grow as new Unity topics and projects are learned.

---

## Future Goals

### Learning Notes

* Expand UnityLearn1
* Expand UnityLearn2
* Add advanced Unity topics
* Add AI and enemy behavior notes
* Add animation notes
* Add UI system notes

### Obstacle Dodge

* Win/Lose conditions
* UI system
* Checkpoints
* Audio
* More levels
* Better visuals

### Rocket Boost

* Landing pads
* Success and crash states
* Level progression
* Particle effects
* Fuel system
* Multiple levels
* UI systems

### Long-Term Goals

* Build complete Unity games
* Learn advanced gameplay programming
* Learn optimization techniques
* Learn animation workflows
* Learn shader basics
* Publish finished Unity projects

---

## Learning Philosophy

This repository is built around learning by doing.

The objective is not only to memorize Unity APIs, but to understand:

* What a feature does
* Why it exists
* When it should be used
* How it contributes to game development

Each project and note serves as a stepping stone toward building larger and more complete Unity games in the future.
