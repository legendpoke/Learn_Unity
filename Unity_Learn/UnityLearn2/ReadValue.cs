using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class ReadValue
    {
        /*
        =================================================
        READVALUE<T>()
        =================================================

        What is ReadValue<T>()?

        ReadValue<T>() is used to read the current
        value of an Input Action.

        Think:

        Player Input

                ↓

        Input Action

                ↓

        ReadValue<T>()

                ↓

        Get The Value

        =================================================
        WHY USE IT?
        =================================================

        Input Actions detect player input.

        ReadValue<T>() allows us to get
        the actual value from that input.

        Examples:

        - Movement Direction
        - Mouse Position
        - Controller Stick Position
        - Trigger Pressure

        =================================================
        SYNTAX
        =================================================

        action.ReadValue<Type>();

        Read as:

        "Read the value from this action
        as the specified type."

        =================================================
        COMMON TYPES
        =================================================

        float

            ↓

        Single Number

        Example:

        0
        0.5
        1

        ---------------------------------

        Vector2

            ↓

        Two Values

        Example:

        (1,0)

        Used for:

        - WASD Movement
        - Joystick Input
        - Mouse Delta

        ---------------------------------

        Vector3

            ↓

        Three Values

        Example:

        (1,0,1)

        =================================================
        MOVEMENT EXAMPLE
        =================================================

        Move Action

                ↓

        ReadValue<Vector2>()

                ↓

        Get Movement Direction

        Example Result:

        (1,0)

        Meaning:

        Move Right

        =================================================
        KEYBOARD EXAMPLE
        =================================================

        W Key

                ↓

        ReadValue<Vector2>()

                ↓

        (0,1)

        Meaning:

        Move Forward

        =================================================
        JOYSTICK EXAMPLE
        =================================================

        Joystick Up Right

                ↓

        ReadValue<Vector2>()

                ↓

        (1,1)

        Meaning:

        Move Forward Right

        =================================================
        FLOAT EXAMPLE
        =================================================

        Trigger Button

                ↓

        ReadValue<float>()

                ↓

        0.75

        Meaning:

        Trigger is pressed 75%.

        =================================================
        INPUT FLOW
        =================================================

        Player Presses Key

                ↓

        Input Action Receives Input

                ↓

        ReadValue<T>()

                ↓

        Value Returned

                ↓

        Game Responds

        =================================================
        COMMON USES
        =================================================

        - Player Movement

        - Camera Movement

        - Mouse Position

        - Controller Input

        - Vehicle Controls

        - Character Controls

        =================================================
        GENERIC TYPE <T>
        =================================================

        T means:

        Type

        Examples:

        ReadValue<float>()

        ReadValue<Vector2>()

        ReadValue<Vector3>()

        Unity needs to know what type
        of value to return.

        =================================================
        MEMORY TRICK
        =================================================

        Input Action

                ↓

        ReadValue<T>()

                ↓

        Get Input Data

        =================================================
        SHORT REVISION
        =================================================

        ReadValue<T>()
            -> Reads input value

        float
            -> Single Number

        Vector2
            -> X and Y Values

        Vector3
            -> X, Y and Z Values

        Common Use
            -> Movement Input

        Think:

        ReadValue<T>()
            =
        "Give me the current value
        of this input action."
        =================================================
        */
    }
}