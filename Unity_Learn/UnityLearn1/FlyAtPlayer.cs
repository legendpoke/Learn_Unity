using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class FlyAtPlayer
    {
        /*
            The MoveTowards() Method
                we can use MoveTowards() to make an object move towards a specific point in the world
                MoveTowards() requires 3 parameters:
                    curent: position to move from
                    target:position to move towards
                    maxDistanceDelta: distance to move each time
                  MoveTowards(current,target,maxDistanceDelta)
         */


        /*
        =================================================
        MOVETOWARDS() NOTES
        =================================================

        What is MoveTowards()?

        MoveTowards() moves an object from its
        current position toward a target position.

        Think:

        Current Position
                ↓
        Move Towards Target
                ↓
        Repeat Every Frame
                ↓
        Reach Target

        =================================================
        SYNTAX
        =================================================

        Vector3.MoveTowards(
            current,
            target,
            maxDistanceDelta
        );

        =================================================
        PARAMETERS
        =================================================

        current
            ↓
        Starting position.

        Usually:

        transform.position

        ---------------------------------

        target
            ↓
        Position we want to move to.

        Example:

        player.position

        ---------------------------------

        maxDistanceDelta
            ↓
        How far the object can move
        during this update.

        Usually:

        speed * Time.deltaTime

        =================================================
        EXAMPLE
        =================================================

        transform.position =
            Vector3.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );

        Meaning:

        Move from current position
        towards the player's position.

        =================================================
        REAL GAME EXAMPLE
        =================================================

        Enemy
            ↓
        Sees Player

            ↓

        MoveTowards()

            ↓

        Enemy walks toward Player

        =================================================
        WHY USE MOVETOWARDS()?
        =================================================

        Easy to use.

        Automatically stops when
        the target is reached.

        Great for:

        - Enemy AI
        - Following Objects
        - Moving Platforms
        - Collectibles
        - Homing Objects

        =================================================
        EXECUTION FLOW
        =================================================

        Enemy Position

                ↓

        Player Position

                ↓

        MoveTowards()

                ↓

        Move A Little

                ↓

        Repeat Every Frame

                ↓

        Reach Player

        =================================================
        MOVETOWARDS VS TELEPORTING
        =================================================

        Teleport:

        transform.position =
            player.position;

        Result:

        Instantly appears at player.

        ---------------------------------

        MoveTowards:

        Vector3.MoveTowards(...)

        Result:

        Smooth movement toward player.

        =================================================
        MEMORY TRICK
        =================================================

        current
            ↓
        Where I Am

        target
            ↓
        Where I Want To Go

        maxDistanceDelta
            ↓
        How Fast I Move

        MoveTowards()
            ↓
        Move Closer To Target

        =================================================
        SHORT REVISION
        =================================================

        MoveTowards()
            -> Move toward a position

        current
            -> Current position

        target
            -> Destination

        maxDistanceDelta
            -> Distance moved each update

        Common Use:
            -> Enemy follows Player

        Think:

        MoveTowards =
        Walk to target, don't teleport.
        =================================================
        */
    }
}