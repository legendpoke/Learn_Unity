# Rocket Boost

Rocket Boost is a Unity 3D prototype focused on learning rocket movement, player input, and physics-based gameplay. The player controls a rocket using Unity's Input System and Rigidbody physics while navigating a sci-fi environment built with GameDev.tv assets.

## Project Overview

This project is designed to practice fundamental Unity development concepts:

* Unity Input System
* Physics-based movement with Rigidbody
* Applying forces using `AddRelativeForce()`
* Object rotation and player controls
* FixedUpdate for physics calculations
* Scene and level prototyping
* Using `AudioSource()` to play sound effects
* Collision detection using Unity physics
* Scene management with `SceneManager`

## Features

* Physics-based rocket thrust
* Left and right rocket rotation
* Unity Input System integration
* Rigidbody-driven movement
* Sci-fi themed environment assets
* Sandbox testing scene
* Rocket thrust sound
* Manual rotation using `freezeRotation`
* Fuel collection system
* Landing pad detection
* Crash detection and level restart
* Automatic level progression

## Controls

Current controls are configured through Unity's Input System actions.

| Input                      | Action                            |
| -------------------------- | --------------------------------- |
| Thrust Action              | Apply upward thrust to the rocket |
| Rotation Action (Positive) | Rotate rocket clockwise           |
| Rotation Action (Negative) | Rotate rocket counter-clockwise   |

> Input bindings can be modified directly in the Unity Inspector through the serialized `InputAction` fields.

## How Movement Works

### Thrust

When the thrust action is pressed:

```csharp
rocketRigidbody.AddRelativeForce(
    Vector3.up * thrustStrength * Time.fixedDeltaTime
);
```

The rocket applies force relative to its local upward direction, allowing movement in whichever direction it is currently facing.

### Rotation

Rotation input is read using:

```csharp
float inputRotation = Rotation.ReadValue<float>();
```

Positive values rotate the rocket one way, while negative values rotate it in the opposite direction.

### Manual Rotation

Before applying rotation, the Rigidbody's automatic rotation is temporarily disabled:

```csharp
rocketRigidbody.freezeRotation = true;
```

This prevents physics interactions from affecting player-controlled rotation.

After the rotation is applied:

```csharp
rocketRigidbody.freezeRotation = false;
```

Unity physics regains control of the Rigidbody's rotation.

### Audio

When thrust is active, the rocket plays a thrust sound using an AudioSource component.

```csharp
if (!audioSource.isPlaying)
{
    audioSource.Play();
}
```

The sound starts only once while thrust is being applied.

When thrust stops:

```csharp
audioSource.Stop();
```

The thrust sound immediately stops.

### Physics Update

All movement calculations occur inside:

```csharp
FixedUpdate()
```

to ensure smooth and consistent physics behavior.

## Collision System

The rocket reacts differently depending on the object tag it collides with.

### Fuel

When the rocket collides with a Fuel object:

```csharp
Destroy(collision.gameObject);
```

The fuel object is collected and removed from the scene.

### Landing Pad

When the rocket lands on a Landing Pad:

```csharp
NextScene();
```

The next level is loaded.

### Launch Pad

The Launch Pad is considered a safe object and does not trigger a crash.

### Crash Detection

Colliding with any object that is not recognized as Fuel, LandingPad, or LaunchPad causes:

```csharp
ReloadScene();
```

The current scene is restarted.

## Scene Management

The project uses Unity's SceneManager to handle level progression.

### Reload Current Level

```csharp
SceneManager.LoadScene(currentScene);
```

Reloads the active level after a crash.

### Load Next Level

```csharp
SceneManager.LoadScene(nextScene);
```

Loads the next scene in Build Settings.

### Loop Back To First Level

When the final scene is completed:

```csharp
if(nextScene == SceneManager.sceneCountInBuildSettings)
{
    nextScene = 0;
}
```

The game returns to the first level.

## Project Structure

```text
Rocket Boost/
+-- Assets/
|   +-- Assets/
|   |   +-- Models
|   |   +-- Materials
|   |   +-- Textures
|   |   +-- Prefabs
|   |   +-- Sounds
|   |
|   +-- Scenes/
|   |   +-- Sandbox.unity
|   |   +-- Level2.unity
|   |   +-- Level3.unity
|   |
|   +-- Scripts/
|   |   +-- RocketMove.cs
|   |   +-- CollisionDetection.cs
|   |
|   +-- Settings/
|
+-- Packages/
|   +-- manifest.json
|
+-- ProjectSettings/
|
+-- README.md
```

## Script Breakdown

### RocketMove.cs

Responsible for:

* Reading player input
* Enabling Input Actions
* Applying thrust force
* Rotating the rocket
* Managing Rigidbody movement
* Playing thrust audio effects
* Reading rotation values using `ReadValue<float>()`
* Temporarily freezing Rigidbody rotation during manual rotation

### CollisionDetection.cs

Responsible for:

* Detecting rocket collisions
* Fuel collection
* Landing pad detection
* Launch pad detection
* Scene reloading after crashes
* Loading the next level
* Looping levels after the final scene

## Requirements

* Unity 6 (6000.4.9f1)
* Universal Render Pipeline (URP)
* Unity Input System Package

## How to Run

1. Open Unity Hub.

2. Open the project folder.

3. Load:

   `Assets/Scenes/Sandbox.unity`

4. Press Play.

5. Use the configured input actions to control the rocket.

## Current Status

Current implementation includes:

* Physics-based thrust
* Rocket rotation
* Rigidbody movement
* Input System controls
* Sandbox environment testing
* Audio effects
* Thrust audio using AudioSource
* Manual rotation using `freezeRotation`
* Fuel collection
* Landing pad detection
* Crash detection
* Scene reloading
* Level progression system

This project serves as a foundation for building a complete rocket landing and obstacle navigation game.

## Planned Features

* Success and crash effects
* Particle systems
* Fuel system expansion
* Multiple levels
* UI and score tracking
* Level completion effects
* Sound effects for landing and crashes

## Credits

Environment assets, models, textures, materials, and audio assets are provided by GameDev.tv and are used for educational purposes within this project.
