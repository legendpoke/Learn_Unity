using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class RotationInput
    {
        /*
        =================================================
        ROTATION INPUT
        =================================================

        What is Rotation Input?

        Rotation Input means using player input
        (keyboard, controller, etc.) to rotate
        an object.

        Think:

        Player Presses Key

                ↓

        Rotation Input Detected

                ↓

        Object Rotates

        =================================================
        WHY USE ROTATION INPUT?
        =================================================

        Common Uses:

        - Turning a Character
        - Rotating a Rocket
        - Steering a Car
        - Rotating a Turret
        - Controlling a Spaceship

        =================================================
        ROTATION AXES
        =================================================

        X Axis

            ↓

        Tilt Up / Down

        ---------------------------------

        Y Axis

            ↓

        Turn Left / Right

        ---------------------------------

        Z Axis

            ↓

        Roll / Lean

        =================================================
        PLAYER INPUT FLOW
        =================================================

        Player Presses Key

                ↓

        Input Detected

                ↓

        Rotation Value Calculated

                ↓

        Object Rotates

        =================================================
        EXAMPLE CONTROLS
        =================================================

        A Key

            ↓

        Rotate Left

        ---------------------------------

        D Key

            ↓

        Rotate Right

        ---------------------------------

        Left Arrow

            ↓

        Rotate Left

        ---------------------------------

        Right Arrow

            ↓

        Rotate Right

        =================================================
        INPUT AXIS
        =================================================

        Horizontal Input

        A Key

            ↓

        -1

        ---------------------------------

        No Input

            ↓

        0

        ---------------------------------

        D Key

            ↓

        1

        =================================================
        ROTATION SPEED
        =================================================

        Rotation Speed controls
        how fast the object turns.

        Small Value

            ↓

        Slow Rotation

        ---------------------------------

        Large Value

            ↓

        Fast Rotation

        =================================================
        FRAME INDEPENDENT ROTATION
        =================================================

        Rotation should usually use:

        Time.deltaTime

        Why?

        Different computers run
        at different frame rates.

        Using Time.deltaTime helps keep
        rotation speed consistent.

        =================================================
        ROCKET EXAMPLE
        =================================================

        Press A

                ↓

        Rocket Rotates Left

        ---------------------------------

        Press D

                ↓

        Rocket Rotates Right

        =================================================
        CAR EXAMPLE
        =================================================

        Left Arrow

                ↓

        Turn Car Left

        ---------------------------------

        Right Arrow

                ↓

        Turn Car Right

        =================================================
        COMMON USES
        =================================================

        - Rocket Controls

        - Vehicle Steering

        - Character Turning

        - Spaceship Controls

        - Turret Rotation

        =================================================
        ROTATION VS MOVEMENT
        =================================================

        Movement

            ↓

        Changes Position

        ---------------------------------

        Rotation

            ↓

        Changes Direction

        =================================================
        EXAMPLE
        =================================================

        Object Rotates

                ↓

        Position Stays Same

        Only the facing direction changes.

        =================================================
        MEMORY TRICK
        =================================================

        Input

            ↓

        Player Command

        Rotation

            ↓

        Change Direction

        Rotation Input

            ↓

        Player Controls Direction

        =================================================
        SHORT REVISION
        =================================================

        Rotation Input
            -> Rotate object using player input

        Common Keys
            -> A / D
            -> Left / Right Arrows

        Rotation
            -> Change Direction

        Movement
            -> Change Position

        Rotation Speed
            -> Controls turning speed

        Think:

        Rotation Input =
        Player Controls Which Way
        The Object Faces
        =================================================
        */
    }
}