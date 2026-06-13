using System;
using System.Collections.Generic;
using System.Text;

namespace Assets.Scripts
{
    class TransformTranslate
    {

        /*
            transform

            Every GameObject in Unity has a Transform component.

            Transform stores:

            1. Position
               Where the object is located.

            2. Rotation
               Which direction the object is facing.

            3. Scale
               The size of the object.

            Example:

            Position = (0,0,0)
            Rotation = (0,0,0)
            Scale    = (1,1,1)
        */


        /*
            GetAxis()

            Reads player input from the keyboard,
            controller, or other input devices.

            "Horizontal"
            Returns:
            -1 = Left (A key)
             0 = No input
             1 = Right (D key)

            "Vertical"
            Returns:
            -1 = Backward (S key)
             0 = No input
             1 = Forward (W key)
        */


        // Input should be read inside Update()
        // because Update runs every frame and can
        // continuously detect keyboard input.


        /*
            transform.Translate()

            Moves the object relative to its current position.

            Syntax:

            transform.Translate(x, y, z);

            x = Left/Right movement
            y = Up/Down movement
            z = Forward/Backward movement
        */

        /*
        Vector3: 
            Essentially vector3 is a position in the world -it contains values for x,y,z
            we've been using vector3 for our movement
            we can store a vector3 as a variable ... its one variable(eg.Position) that contains 3 values(the x,y and z values)
            eg:
                variable : vector3 position;
        */

        /*
        =================================================
        TRANSFORM NOTES
        =================================================

        What is Transform?

        Transform is the most important component
        in Unity.

        Every GameObject automatically has a
        Transform component.

        Transform controls:

        1. Position
            -> Where the object is.

        2. Rotation
            -> Which direction the object faces.

        3. Scale
            -> How big or small the object is.

        Think:

        GameObject
            |
            |-- Transform

        Without Transform,
        the object cannot exist in the scene.

        =================================================
        POSITION
        =================================================

        Position determines the location
        of an object in the world.

        Example:

        Position (0,0,0)

        Means:

        X = 0
        Y = 0
        Z = 0

        Object is at the world origin.

        =================================================
        ROTATION
        =================================================

        Rotation determines which direction
        the object faces.

        Examples:

        Rotate Left

        Rotate Right

        Turn Around

        Used for:

        - Players
        - Enemies
        - Vehicles
        - Cameras

        =================================================
        SCALE
        =================================================

        Scale determines object size.

        Example:

        Scale (1,1,1)

        Normal Size

        Scale (2,2,2)

        Twice As Large

        Scale (0.5,0.5,0.5)

        Half Size

        =================================================
        TRANSLATE NOTES
        =================================================

        Translate means:

        Move an object from one position
        to another.

        Think:

        Current Position
                ↓
        Move
                ↓
        New Position

        =================================================
        HOW TRANSLATE WORKS
        =================================================

        transform.Translate(x,y,z);

        x
            ↓
        Left / Right

        y
            ↓
        Up / Down

        z
            ↓
        Forward / Backward

        =================================================
        MOVEMENT EXAMPLES
        =================================================

        transform.Translate(1,0,0);

        Move Right

        ---------------------------------

        transform.Translate(-1,0,0);

        Move Left

        ---------------------------------

        transform.Translate(0,1,0);

        Move Up

        ---------------------------------

        transform.Translate(0,-1,0);

        Move Down

        ---------------------------------

        transform.Translate(0,0,1);

        Move Forward

        ---------------------------------

        transform.Translate(0,0,-1);

        Move Backward

        =================================================
        GETAXIS NOTES
        =================================================

        GetAxis() reads player input.

        Unity converts keyboard input
        into values.

        =================================================
        HORIZONTAL AXIS
        =================================================

        Input.GetAxis("Horizontal")

        Keys:

        A
        Left Arrow

        Value = -1

        --------------------

        No Input

        Value = 0

        --------------------

        D
        Right Arrow

        Value = 1

        =================================================
        VERTICAL AXIS
        =================================================

        Input.GetAxis("Vertical")

        Keys:

        S
        Down Arrow

        Value = -1

        --------------------

        No Input

        Value = 0

        --------------------

        W
        Up Arrow

        Value = 1

        =================================================
        WHY USE GETAXIS?
        =================================================

        GetAxis provides smooth movement.

        Instead of instantly jumping
        between values,

        Unity smoothly changes them.

        Example:

        0
        0.2
        0.4
        0.6
        0.8
        1

        This makes movement feel smoother.

        =================================================
        VECTOR3 NOTES
        =================================================

        What is Vector3?

        Vector3 stores 3 values:

        X
        Y
        Z

        Inside a single variable.

        Think:

        Vector3
            ↓
        A container for coordinates.

        =================================================
        EXAMPLE
        =================================================

        Vector3 position;

        Stores:

        position.x

        position.y

        position.z

        =================================================
        REAL EXAMPLE
        =================================================

        Vector3 playerPosition;

        playerPosition.x = 5;

        playerPosition.y = 2;

        playerPosition.z = 10;

        Result:

        Position = (5,2,10)

        =================================================
        WHY USE VECTOR3?
        =================================================

        Unity uses Vector3 for:

        - Position
        - Movement
        - Rotation values
        - Directions

        You will see Vector3 almost everywhere.

        =================================================
        MEMORY TRICK
        =================================================

        Transform
            ↓
        Position + Rotation + Scale

        Translate
            ↓
        Move Object

        GetAxis
            ↓
        Read Input

        Horizontal
            ↓
        A / D

        Vertical
            ↓
        W / S

        Vector3
            ↓
        X + Y + Z values

        =================================================
        SHORT REVISION
        =================================================

        Transform
            -> Controls Position, Rotation, Scale

        Translate
            -> Moves object

        GetAxis("Horizontal")
            -> Left / Right input

        GetAxis("Vertical")
            -> Forward / Backward input

        Vector3
            -> Stores X, Y, Z values

        Think:

        Transform = Object Information

        Translate = Movement

        GetAxis = Input

        Vector3 = Coordinates
        =================================================
        */
    }
}
