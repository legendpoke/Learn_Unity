using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class TImeDotTime
    {
        /*
            Problem and Solution
                Problem to solve: Make an object fall after 3 seconds has passed
            Solution:
                1.A time : Time.time
                2. a mechanism to 'do a thing if 3 seconds has elapsed' - if statement
                3. a way to start the object falling after 3 seconds - disable /enable gravity
        */
        /*
        use a variable for Time to Wait
            Instead of "hard coding" 3 seconds ,use a VARIABLE for the time to wait that can be easily changed in the INSPECTOR
         */

        /*
        =================================================
        Time.time
        =================================================

        What is Time.time?

        Time.time returns the total amount of time
        (in seconds) since the game started.

        Think:

        Game Starts
             ↓
        Timer Begins

        Time.time keeps increasing while
        the game is running.


        =================================================
        EXAMPLE
        =================================================

        Game Starts

        Time.time = 0

        After 1 second

        Time.time = 1

        After 5 seconds

        Time.time = 5

        After 10 seconds

        Time.time = 10

        After 60 seconds

        Time.time = 60


        =================================================
        SYNTAX
        =================================================

        float currentTime = Time.time;

        currentTime now stores the number of
        seconds since the game started.


        =================================================
        EXAMPLE
        =================================================

        void Update()
        {
            Debug.Log(Time.time);
        }

        Console Output:

        0.1
        0.2
        0.3
        0.4
        ...

        The value keeps increasing.


        =================================================
        COMMON USES
        =================================================

        1. Timers

        2. Cooldowns

        3. Spawn Systems

        4. Delayed Actions

        5. Measuring Time


        =================================================
        TIMER EXAMPLE
        =================================================

        void Update()
        {
            if(Time.time > 5)
            {
                Debug.Log("5 Seconds Passed");
            }
        }

        After 5 seconds:

        Output:

        5 Seconds Passed


        =================================================
        COOLDOWN EXAMPLE
        =================================================

        float nextFireTime = 0f;

        void Update()
        {
            if(Time.time > nextFireTime)
            {
                Debug.Log("Fire");

                nextFireTime = Time.time + 2f;
            }
        }

        Result:

        Fire every 2 seconds.


        =================================================
        IMPORTANT
        =================================================

        Time.time

        DOES NOT mean:

        Time between frames.

        It means:

        Total game time since startup.


        =================================================
        Time.time VS Time.deltaTime
        =================================================

        Time.time

        Current game running time.

        Example:

        12.5 seconds


        Time.deltaTime

        Time between two frames.

        Example:

        0.016 seconds


        Think:

        Time.time
             ↓
        Stopwatch

        Time.deltaTime
             ↓
        Gap between frames


        =================================================
        MEMORY TRICK
        =================================================

        Time.time

        "What time is it in the game?"

        Time.deltaTime

        "How much time passed since
        the previous frame?"


        =================================================
        SHORT REVISION
        =================================================

        Time.time
            -> Total game running time

        Starts at:
            -> 0

        Increases:
            -> Every second

        Used for:
            -> Timers
            -> Cooldowns
            -> Delays
            -> Spawn Systems

        Think:

        Time.time = Game Stopwatch
        =================================================
        */
    }
}
