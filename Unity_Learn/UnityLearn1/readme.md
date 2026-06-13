# UnityLearn1

Beginner-friendly Unity and C# learning notes.

This folder is a collection of Unity script notes covering the basics of movement, collisions, triggers, prefabs, physics, timing, tags, object destruction, and Unity's execution order.

Most files are written like study notes. Some scripts may contain more explanation than runnable gameplay code, so treat this folder as a learning reference while you build small Unity scenes.

## What You Will Learn

- How Unity scripts work with `MonoBehaviour`
- How to use `Start()`, `Update()`, `FixedUpdate()`, and other Unity events
- How to move, rotate, and control GameObjects
- How collisions and triggers work
- How Rigidbody physics works
- How to use tags, prefabs, and serialized fields
- How to create simple hazards, projectiles, score logic, and level layouts
- How `Time.time` and `Time.deltaTime` help with timers and smooth movement

## How To Start Unity

1. Open **Unity Hub**.
2. Go to the **Projects** tab.
3. Click **Add** or **Open**.
4. Select your Unity project folder.
5. Wait for Unity to import the project files.
6. Open or create a scene.
7. Create a GameObject, such as a Cube, Sphere, Capsule, or Empty Object.
8. Drag a script onto the GameObject in the Inspector.
9. Press the **Play** button at the top of Unity to test the scene.

If Unity asks for a version, use the version installed with your project or install the recommended Unity Editor version from Unity Hub.

## Basic Unity Workflow

1. Create or open a scene.
2. Add GameObjects to the Hierarchy.
3. Add components in the Inspector, such as Collider, Rigidbody, Camera, or scripts.
4. Edit script values in the Inspector when fields use `[SerializeField]`.
5. Press Play to test.
6. Watch the Console for `Debug.Log()` messages and errors.
7. Stop Play Mode before changing scene objects permanently.

## Recommended Learning Order

Start with these files first:

1. `UnityBasics.cs`
2. `Variable_Serializable.cs`
3. `Methodhs.cs`
4. `IfStatements.cs`
5. `TransformTranslate.cs`
6. `RotateAnObject.cs`
7. `TimeDeltaTime.cs`
8. `TImeDotTime.cs`

Then move into Unity interaction and gameplay:

1. `GetComponent.cs`
2. `Caching_a_Refrence.cs`
3. `RigidBody.cs`
4. `Collision.cs`
5. `OnCollisonEnter.cs`
6. `TriggerProjectile.cs`
7. `UseTags.cs`
8. `DestoryObject.cs`

After that, study game-building topics:

1. `IntroducingPrefabs.cs`
2. `FlyAtPlayer.cs`
3. `ScoreMethodNotes.cs`
4. `LevelLayout.cs`
5. `AddHazardsToLevel.cs`
6. `CineMachines.cs`
7. `UnityOrderofExecution.cs`

## Script Guide

| File | Topic |
| --- | --- |
| `AddHazardsToLevel.cs` | Designing hazards such as spikes, traps, lava, moving dangers, and difficulty progression. |
| `Caching_a_Refrence.cs` | Storing component references instead of repeatedly calling `GetComponent<>()`. |
| `CineMachines.cs` | Notes about Unity's Cinemachine camera system. |
| `Collision.cs` | Basic collision concepts and collision callbacks. |
| `DestoryObject.cs` | Using `Destroy()` to remove GameObjects or components. |
| `FlyAtPlayer.cs` | Moving an object toward the player with `Vector3.MoveTowards()`. |
| `GetComponent.cs` | Accessing components attached to a GameObject. |
| `IfStatements.cs` | Writing conditions with `if`, `else if`, and `else`. |
| `IntroducingPrefabs.cs` | Understanding prefabs and reusable GameObject templates. |
| `LevelLayout.cs` | Planning obstacles, paths, checkpoints, hazards, and level flow. |
| `Methodhs.cs` | Understanding methods, parameters, return types, and calling functions. |
| `OnCollisonEnter.cs` | Using `OnCollisionEnter()` when objects physically collide. |
| `RigidBody.cs` | Rigidbody physics, gravity, mass, and constraints. |
| `RotateAnObject.cs` | Rotating GameObjects with `transform.Rotate()`. |
| `ScoreMethodNotes.cs` | Simple score or collision counting logic. |
| `TimeDeltaTime.cs` | Using `Time.deltaTime` for smooth frame-rate independent movement. |
| `TImeDotTime.cs` | Using `Time.time` for timers and cooldowns. |
| `TransformTranslate.cs` | Moving objects with Transform, Vector3, and input axes. |
| `TriggerProjectile.cs` | Using trigger colliders and `OnTriggerEnter()`. |
| `UnityBasics.cs` | Core Unity concepts like GameObjects, components, scripts, and `MonoBehaviour`. |
| `UnityOrderofExecution.cs` | The order Unity runs methods like `Awake()`, `Start()`, `Update()`, and `OnDestroy()`. |
| `UseTags.cs` | Using tags and `CompareTag()` to identify objects. |
| `Variable_Serializable.cs` | Using `[SerializeField]` to show private fields in the Inspector. |

## How To Use These Scripts In Unity

1. Create a GameObject in the scene.
2. Select the GameObject.
3. In the Inspector, click **Add Component**.
4. Search for the script name.
5. Add the script to the object.
6. If the script has serialized fields, adjust them in the Inspector.
7. Press Play and test the behavior.

For collision or trigger scripts, remember:

- Objects need Colliders.
- Physical collisions usually need at least one Rigidbody.
- Trigger events need **Is Trigger** enabled on one Collider.
- Tags must be created and assigned correctly before checking them in code.

## Common Unity Setup Tips

- Use clear object names like `Player`, `Enemy`, `Coin`, `Hazard`, and `Goal`.
- Keep scripts inside an `Assets/Scripts` folder in a real Unity project.
- Use Prefabs for objects you will reuse many times.
- Use `Debug.Log()` to understand when code is running.
- Check the Console often for errors.
- Save scenes regularly with `Ctrl + S`.
- Stop Play Mode before editing important scene values.

## Small Practice Ideas

- Make a cube move with keyboard input.
- Rotate a coin continuously.
- Destroy a projectile when it hits a wall.
- Add a trigger zone that prints a message.
- Count how many obstacles the player touches.
- Make an enemy move toward the player.
- Create a prefab and spawn copies of it.
- Design a small level with a start point, hazards, checkpoints, and a finish point.

## Notes

This folder is focused on learning. Some filenames contain spelling mistakes because they match the current files in the folder. They are left as-is so links and file references stay simple.

Happy learning, and remember: build small, test often, and let each tiny scene teach one idea clearly.
