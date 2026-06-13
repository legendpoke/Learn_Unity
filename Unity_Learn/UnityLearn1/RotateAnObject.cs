using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class RotateAnObject
    {
        /*
        =================================================
        ROTATING AN OBJECT IN UNITY
        =================================================

        What is Rotation?

        Rotation means turning an object around
        an axis.

        Examples:

        - Spinning Coin
        - Rotating Fan
        - Turning Car
        - Rotating Planet
        - Opening Door

        =================================================
        THE 3 AXES
        =================================================

                 Y
                 ↑
                 |
                 |
                 |
                 |
        X <------O------> X
                /
               /
              /
             Z

        X Axis
            -> Left / Right Tilt

        Y Axis
            -> Turn Left / Right

        Z Axis
            -> Forward / Backward Tilt

        =================================================
        ROTATION VALUES
        =================================================

        360 Degrees

            ↓

        One Full Rotation

        Examples:

        90  = Quarter Turn

        180 = Half Turn

        360 = Full Turn

        =================================================
        SIMPLE ROTATION
        =================================================

        transform.Rotate(0f, 50f, 0f);

        Meaning:

        Rotate around the Y axis.

        X = 0

        Y = 50

        Z = 0

        =================================================
        ROTATING EVERY FRAME
        =================================================

        void Update()
        {
            transform.Rotate(0f, 50f, 0f);
        }

        Result:

        Object continuously spins.

        =================================================
        USING Time.deltaTime
        =================================================

        void Update()
        {
            transform.Rotate(
                0f,
                50f * Time.deltaTime,
                0f
            );
        }

        Why?

        Makes rotation smooth and
        frame-rate independent.

        Different computers rotate
        at the same speed.

        =================================================
        EXAMPLE:
        SPINNING COIN
        =================================================

        private float rotateSpeed = 100f;

        void Update()
        {
            transform.Rotate(
                0f,
                rotateSpeed * Time.deltaTime,
                0f
            );
        }

        Result:

        Coin continuously spins.

        =================================================
        EXAMPLE:
        ROTATING FAN
        =================================================

        private float fanSpeed = 300f;

        void Update()
        {
            transform.Rotate(
                0f,
                0f,
                fanSpeed * Time.deltaTime
            );
        }

        Result:

        Fan blades spin.

        =================================================
        WHAT DOES transform.Rotate() DO?
        =================================================

        Rotate()
            ↓

        Changes the object's rotation.

        It rotates relative to its
        current rotation.

        =================================================
        ROTATE SPECIFIC AXIS
        =================================================

        X Axis

        transform.Rotate(
            50f * Time.deltaTime,
            0f,
            0f
        );

        ---------------------------------

        Y Axis

        transform.Rotate(
            0f,
            50f * Time.deltaTime,
            0f
        );

        ---------------------------------

        Z Axis

        transform.Rotate(
            0f,
            0f,
            50f * Time.deltaTime
        );

        =================================================
        COMMON USES
        =================================================

        - Rotating Coins
        - Rotating Platforms
        - Windmills
        - Fans
        - Turrets
        - Doors
        - Character Turning

        =================================================
        MEMORY TRICK
        =================================================

        Rotate()
            ↓
        Turn Object

        X
            ↓
        Tilt Left / Right

        Y
            ↓
        Turn Left / Right

        Z
            ↓
        Tilt Forward / Backward

        =================================================
        EXECUTION FLOW
        =================================================

        Update()

            ↓

        Rotate()

            ↓

        Every Frame

            ↓

        Object Spins

        =================================================
        SHORT REVISION
        =================================================

        Rotation
            -> Turning an object

        Rotate()
            -> Rotates object

        X
            -> Left/Right Tilt

        Y
            -> Left/Right Turn

        Z
            -> Forward/Backward Tilt

        Time.deltaTime
            -> Smooth rotation

        Think:

        Rotate() = Turn the object
        =================================================
        */
    }
}