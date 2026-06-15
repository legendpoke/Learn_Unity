using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class EmptyObjectImportance
    {
        /*
        =================================================
        EMPTY GAMEOBJECT IN UNITY
        =================================================

        What is an Empty GameObject?

        An Empty GameObject is a GameObject
        that has only a Transform component.

        It does not contain:

        - Mesh
        - Renderer
        - Collider
        - Rigidbody

        By default it is invisible in the game.

        =================================================
        HOW TO CREATE ONE
        =================================================

        Hierarchy

            ↓

        Right Click

            ↓

        Create Empty

        Unity creates a new Empty GameObject.

        =================================================
        WHY IS IT IMPORTANT?
        =================================================

        Empty GameObjects help organize,
        manage, and control other objects.

        Think:

        Empty GameObject
                ↓

        Manager / Container

        =================================================
        ORGANIZATION EXAMPLE
        =================================================

        Environment

            ├── Trees
            ├── Rocks
            ├── Grass
            └── Buildings

        Environment is an Empty GameObject.

        Purpose:

        Keep Hierarchy organized.

        =================================================
        PARENT OBJECT
        =================================================

        Empty Objects are often used
        as Parent Objects.

        Example:

        Player

            ├── Camera
            ├── Weapon
            └── UI Marker

        Moving the parent can move
        all child objects together.

        =================================================
        SPAWN POINTS
        =================================================

        Empty Objects are commonly used
        as spawn points.

        Example:

        EnemySpawnPoint

                ↓

        Enemy appears here

        The Empty Object marks a location.

        =================================================
        WAYPOINTS
        =================================================

        AI enemies often move between
        waypoint positions.

        Example:

        Waypoint A

                ↓

        Waypoint B

                ↓

        Waypoint C

        Empty GameObjects are perfect
        for storing these positions.

        =================================================
        CAMERA TARGETS
        =================================================

        Sometimes cameras follow an
        Empty GameObject instead of
        directly following the player.

        Benefits:

        - Smoother movement
        - Better camera control

        =================================================
        LEVEL ORGANIZATION
        =================================================

        Level

            ├── Obstacles
            ├── Hazards
            ├── Checkpoints
            └── Collectibles

        Empty Objects make large scenes
        easier to manage.

        =================================================
        ROTATION CENTER
        =================================================

        Empty Objects can act as a pivot point.

        Example:

        Planet

                ↓

        Orbits Around

                ↓

        Empty Object

        Useful for:

        - Solar Systems
        - Rotating Platforms
        - Cameras

        =================================================
        SCRIPT HOLDERS
        =================================================

        Some objects only need scripts.

        Example:

        GameManager

        ScoreManager

        AudioManager

        These can be Empty GameObjects
        with scripts attached.

        =================================================
        REAL PROJECT EXAMPLE
        =================================================

        GameManager

            ↓

        Empty GameObject

            ↓

        Controls:

        - Score
        - UI
        - Level Progress
        - Game State

        =================================================
        BENEFITS
        =================================================

        1. Better Organization

        2. Parent Child Relationships

        3. Spawn Points

        4. Waypoints

        5. Manager Objects

        6. Camera Targets

        7. Pivot Points

        =================================================
        MEMORY TRICK
        =================================================

        Empty GameObject
            ↓
        Invisible Helper Object

        Parent
            ↓
        Organizes Children

        Spawn Point
            ↓
        Marks Position

        Manager
            ↓
        Controls Systems

        =================================================
        SHORT REVISION
        =================================================

        Empty GameObject
            -> Only Transform Component

        Uses

            -> Organization

            -> Parent Objects

            -> Spawn Points

            -> Waypoints

            -> Managers

            -> Camera Targets

        Think:

        Empty GameObject

            =

        Invisible Helper Object
        =================================================
        */
    }
}