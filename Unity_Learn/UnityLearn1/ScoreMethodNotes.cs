using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class ScoreMethodNotes
    {
        /*
        =================================================
        SCORE METHOD NOTES
        =================================================

        Purpose:
        Count how many times the player collides with
        other objects and display the result in the
        Unity Console.

        =================================================
        CODE
        =================================================

        public class ScoreMethod : MonoBehaviour
        {
            int count = 0;

            private void OnCollisionEnter(Collision collision)
            {
                count++;

                Debug.Log(
                "Player have bumped into a thing this many times: "
                + count);
            }
        }

        =================================================
        BREAKDOWN
        =================================================

        int count = 0;

        int
        ---
        Stores whole numbers.

        count
        -----
        Variable name.

        = 0
        ---
        Starting value.

        Purpose:
        Store the total number of collisions.

        Example:

        Game Starts

        count = 0

        =================================================
        OnCollisionEnter()
        =================================================

        private void OnCollisionEnter(Collision collision)
        {
        }

        This is a Unity Event Method.

        Unity automatically calls it when:

        This Object
                +
        Another Object

        Start touching each other.

        Requirements:

        1. Both objects need Colliders.

        2. At least one object should have
           a Rigidbody.

        Think:

        Collision Starts
                ↓
        OnCollisionEnter Runs

        =================================================
        Collision collision
        =================================================

        Collision collision

        Collision
        ---------
        Unity type that stores information
        about the collision.

        collision
        ---------
        Variable name.

        It can tell us:

        - What object was hit
        - Contact points
        - Collision information

        Example:

        collision.gameObject.name

        Gets the name of the object hit.

        =================================================
        count++
        =================================================

        count++;

        Means:

        count = count + 1;

        Increases count by 1.

        Example:

        count = 0

        First Collision

        count = 1

        Second Collision

        count = 2

        Third Collision

        count = 3

        =================================================
        Debug.Log()
        =================================================

        Debug.Log("Message");

        Used to print messages in the
        Unity Console.

        Useful for:

        - Testing
        - Debugging
        - Checking variable values

        Example:

        Debug.Log("Hello");

        Console Output:

        Hello

        =================================================
        STRING CONCATENATION
        =================================================

        Debug.Log("Count : " + count);

        +

        Joins values together.

        Example:

        count = 5

        Output:

        Count : 5

        =================================================
        EXECUTION FLOW
        =================================================

        Game Starts

        count = 0

                ↓

        Player Hits Wall

                ↓

        OnCollisionEnter()

                ↓

        count++

                ↓

        count = 1

                ↓

        Debug.Log()

                ↓

        Console:

        Player have bumped into a thing this many times: 1

                ↓

        Player Hits Another Object

                ↓

        count = 2

                ↓

        Console:

        Player have bumped into a thing this many times: 2

        =================================================
        REAL GAME USES
        =================================================

        Count:

        - Coins Collected
        - Enemies Defeated
        - Number of Crashes
        - Number of Hits Taken
        - Checkpoints Reached

        =================================================
        MEMORY TRICK
        =================================================

        count
            ↓
        Stores total collisions

        count++
            ↓
        Add 1

        OnCollisionEnter()
            ↓
        Runs when collision starts

        Debug.Log()
            ↓
        Print message in Console

        Collision collision
            ↓
        Information about what was hit

        =================================================
        SHORT REVISION
        =================================================

        int count = 0;
            -> Stores score/collision count

        OnCollisionEnter()
            -> Runs when collision starts

        count++;
            -> Increase by 1

        Debug.Log()
            -> Show message in Console

        Collision collision
            -> Information about the object hit
        =================================================
        */
    }
}