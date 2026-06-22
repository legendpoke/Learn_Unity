using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class RigidBodyTunning
    {
        /*
        =================================================
        RIGIDBODY COMPONENT SETTINGS
        =================================================

        Rigidbody allows Unity Physics to affect
        a GameObject.

        Examples:

        - Falling
        - Jumping
        - Collisions
        - Physics Movement

        =================================================
        MASS
        =================================================

        Mass determines how heavy an object is.

        Small Mass

            ↓

        Easy to push

        Easy to move

        ---------------------------------

        Large Mass

            ↓

        Harder to push

        Harder to move

        Example:

        Feather
            ↓
        Low Mass

        Truck
            ↓
        High Mass

        =================================================
        LINEAR DAMPING  == DRAG 
        =================================================

        Linear Damping slows down movement.

        It acts like air resistance.

        Low Value

            ↓

        Object keeps moving longer

        ---------------------------------

        High Value

            ↓

        Object slows down quickly

        Example:

        Rocket
            ↓
        Low Damping

        Moves smoothly through space.

        =================================================
        ANGULAR DAMPING
        =================================================

        Angular Damping slows down rotation.

        Low Value

            ↓

        Keeps spinning longer

        ---------------------------------

        High Value

            ↓

        Stops rotating quickly

        Example:

        Spinning Cube
            ↓
        Higher Angular Damping

        Stops spinning sooner.

        =================================================
        AUTOMATIC TENSOR
        =================================================

        Unity automatically calculates how
        mass is distributed throughout the object.

        Usually leave this enabled.

        Recommended:

        ✔ Enabled

        =================================================
        USE GRAVITY
        =================================================

        Controls whether gravity affects
        the Rigidbody.

        Enabled

            ↓

        Object falls downward

        ---------------------------------

        Disabled

            ↓

        Object floats

        Example:

        Player
            ↓
        Enabled

        Spaceship
            ↓
        Often Disabled

        =================================================
        IS KINEMATIC
        =================================================

        Controls whether physics affects
        the Rigidbody.

        Disabled

            ↓

        Physics controls movement

        ---------------------------------

        Enabled

            ↓

        Scripts control movement

        Physics forces no longer move it.

        Example:

        Moving Platform
            ↓
        Often Kinematic

        =================================================
        INTERPOLATE
        =================================================

        Makes Rigidbody movement smoother.

        Options:

        None
            ↓
        No smoothing

        Interpolate
            ↓
        Smooth movement

        Extrapolate
            ↓
        Predict future movement

        Useful when:

        Camera follows the object.

        =================================================
        COLLISION DETECTION
        =================================================

        Controls how collisions are detected.

        -------------------------------------------------
        Discrete
        -------------------------------------------------

        Default mode.

        Good for most objects.

        Less CPU usage.

        -------------------------------------------------
        Continuous
        -------------------------------------------------

        Better for fast-moving objects.

        Prevents objects from passing
        through walls.

        Examples:

        Bullets
        Rockets
        Fast Vehicles

        =================================================
        CONSTRAINTS
        =================================================

        Constraints lock movement or rotation.

        =================================================
        FREEZE POSITION
        =================================================

        Freeze Position X

            ↓

        Cannot move on X axis

        ---------------------------------

        Freeze Position Y

            ↓

        Cannot move on Y axis

        ---------------------------------

        Freeze Position Z

            ↓

        Cannot move on Z axis

        =================================================
        FREEZE ROTATION
        =================================================

        Freeze Rotation X

            ↓

        Cannot rotate on X axis

        ---------------------------------

        Freeze Rotation Y

            ↓

        Cannot rotate on Y axis

        ---------------------------------

        Freeze Rotation Z

            ↓

        Cannot rotate on Z axis

        Example:

        Rocket Boost

        Freeze Rotation X
        Freeze Rotation Y
        Freeze Rotation Z

        Then control rotation
        using scripts.

        =================================================
        LAYER OVERRIDES
        =================================================

        Controls which layers can interact
        with this Rigidbody.

        =================================================
        INCLUDE LAYERS
        =================================================

        Only collide with selected layers.

        Example:

        Player Layer

        Enemy Layer

        =================================================
        EXCLUDE LAYERS
        =================================================

        Ignore collisions with selected layers.

        Example:

        Ignore UI Layer

        Ignore Decoration Layer

        =================================================
        YOUR ROCKET BOOST SETTINGS
        =================================================

        Mass
            = 1

        Linear Damping
            = 0

        Use Gravity
            = Enabled

        Is Kinematic
            = Disabled

        Interpolate
            = None

        Collision Detection
            = Discrete

        Freeze Rotation
            = X Y Z

        Result:

        - Rocket falls due to gravity
        - Physics controls movement
        - Rocket cannot spin from collisions
        - Rotation is controlled by scripts
        - Suitable for beginner Rocket Boost projects

        =================================================
        MEMORY TRICK
        =================================================

        Mass
            ↓
        Weight

        Linear Damping
            ↓
        Movement Resistance

        Angular Damping
            ↓
        Rotation Resistance

        Use Gravity
            ↓
        Fall

        Is Kinematic
            ↓
        Physics OR Script

        Interpolate
            ↓
        Smooth Movement

        Collision Detection
            ↓
        Detect Hits

        Constraints
            ↓
        Lock Movement/Rotation
        =================================================
        */
    }
}