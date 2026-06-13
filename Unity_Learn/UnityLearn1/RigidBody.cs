using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    class RigidBody
    {
        /*
        ========================================
        RIGIDBODY
        ========================================

        What is Rigidbody?

        Rigidbody is a component that gives an object
        physics properties.

        Without Rigidbody:
        - Object stays still unless moved by code.
        - Gravity does not affect it.
        - Physics collisions do not behave realistically.

        With Rigidbody:
        - Gravity can pull the object down.
        - Forces can move the object.
        - Unity physics system controls movement.

        Examples:
        - Player character
        - Ball
        - Car
        - Falling box

        How to Add Rigidbody?

        1. Select the GameObject.
        2. Inspector Window.
        3. Add Component.
        4. Search "Rigidbody".
        5. Click Rigidbody.

        Important Properties:

        Mass
        - How heavy the object is.

        Use Gravity
        - If enabled, gravity affects the object.

        Is Kinematic
        - Physics engine will not move the object.
        - You control movement through code.

        Freeze Constraints

        Used to stop movement or rotation.

        Freeze Position:
        - X → Cannot move left/right.
        - Y → Cannot move up/down.
        - Z → Cannot move forward/backward.

        Freeze Rotation:
        - X → Cannot rotate around X-axis.
        - Y → Cannot rotate around Y-axis.
        - Z → Cannot rotate around Z-axis.

        Example:
        For a player character,
        freeze X and Z rotation so the player
        does not fall sideways when hitting objects.

        Remember:
        Rigidbody = Makes an object behave according to physics.
        */


        /*
            Collider → "Can I touch something?"
            Rigidbody → "Can physics move me?"
            Collision → "Something touched me."
            Trigger → "Something entered my area."
         */
    }
}
