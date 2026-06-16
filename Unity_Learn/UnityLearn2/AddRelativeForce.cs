using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class AddRelativeForce
    {
        /*
        Rigidbody rocketRigidbody;
        rocketRigidbody = GetComponent<Rigidbody>()
        rocketRigidbody.AddRelativeForce(Vector3.up * thrustStrength);

        write this like force in FixedUpdate() method because it is call before the update() method 
        and use Time.fixeddeltaTime(same as Time.deltaTime but this is only used in FixedUpdate()method) if needed
         */
        /*
        =================================================
        ADDRELATIVEFORCE()
        =================================================

        What is AddRelativeForce()?

        AddRelativeForce() applies a force to a
        Rigidbody relative to the object's own
        local axes.

        Think:

        Add Force
                ↓
        Object Moves

        But the force is applied based on the
        object's current facing direction.

        =================================================
        WHY USE ADDRELATIVEFORCE()?
        =================================================

        It is commonly used for:

        - Rockets
        - Spaceships
        - Cars
        - Aircraft
        - Physics-Based Movement

        =================================================
        LOCAL SPACE VS WORLD SPACE
        =================================================

        World Space

            Forward

                ↑

        Always the same world direction.

        ---------------------------------

        Local Space

            Forward

                ↑

        Depends on where the object
        is currently facing.

        =================================================
        ADDRELATIVEFORCE()
        =================================================

        Applies force relative to:

        Object's

        - Forward
        - Right
        - Up

        directions.

        =================================================
        REQUIREMENT
        =================================================

        The GameObject must have:

        Rigidbody

        component attached.

        Without Rigidbody:

        AddRelativeForce() will not work.

        =================================================
        ROCKET EXAMPLE
        =================================================

        Rocket Facing Up

                ↑

        AddRelativeForce()

                ↑

        Rocket Moves Forward

        =================================================
        HOW IT WORKS
        =================================================

        Object Direction

                ↓

        AddRelativeForce()

                ↓

        Rigidbody Receives Force

                ↓

        Object Accelerates

        =================================================
        COMMON PARAMETERS
        =================================================

        Force Value

            ↓

        Determines how strong
        the push is.

        Larger Force

            ↓

        Faster Acceleration

        =================================================
        PHYSICS MOVEMENT
        =================================================

        Unlike direct position movement:

        AddRelativeForce()

            ↓

        Uses Unity Physics

        This creates more realistic motion.

        =================================================
        ADDRELATIVEFORCE VS TRANSLATE
        =================================================

        Translate()

            ↓

        Direct Movement

        Ignores Physics

        ---------------------------------

        AddRelativeForce()

            ↓

        Physics-Based Movement

        Uses Rigidbody

        =================================================
        ADDRELATIVEFORCE VS ADDFORCE
        =================================================

        AddForce()

            ↓

        Uses World Direction

        ---------------------------------

        AddRelativeForce()

            ↓

        Uses Local Direction

        Based on object's rotation.

        =================================================
        ROCKET GAME EXAMPLE
        =================================================

        Rocket Turns Left

                ↓

        Rocket Faces New Direction

                ↓

        AddRelativeForce()

                ↓

        Rocket Moves In That Direction

        =================================================
        COMMON USES
        =================================================

        - Rocket Boosters

        - Spaceships

        - Jetpacks

        - Aircraft

        - Vehicle Physics

        =================================================
        IMPORTANT
        =================================================

        Rigidbody Required

        Physics Based

        Force Depends On:

        - Mass
        - Drag
        - Force Amount

        =================================================
        MEMORY TRICK
        =================================================

        AddRelativeForce()

            ↓

        Push Object

        Relative

            ↓

        Based On Object Direction

        Rigidbody

            ↓

        Required

        =================================================
        SHORT REVISION
        =================================================

        AddRelativeForce()
            -> Apply force using local axes

        Requires
            -> Rigidbody

        Uses
            -> Physics

        Good For
            -> Rockets
            -> Spaceships
            -> Vehicles

        Difference:

        AddForce()
            -> World Direction

        AddRelativeForce()
            -> Object Direction

        Think:

        AddRelativeForce =
        Push the object where it is facing.
        =================================================
        */
    }
}