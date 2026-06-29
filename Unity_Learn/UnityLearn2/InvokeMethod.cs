using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class InvokeMethod
    {
        /*
        =================================================
        INVOKE METHOD
        =================================================

        What is Invoke()?

        Invoke() is a Unity method used to
        call another method after a delay.

        Think:

        Wait Some Time

                ↓

        Execute Method

        =================================================
        WHY USE INVOKE()?
        =================================================

        Sometimes we don't want a method
        to execute immediately.

        Examples:

        - Respawn after 2 seconds
        - Load next level after 3 seconds
        - Hide message after 5 seconds
        - Destroy object after delay

        =================================================
        SYNTAX
        =================================================

        Invoke("MethodName", DelayTime);

        MethodName
            ↓

        Name of the method to call.

        ---------------------------------

        DelayTime
            ↓

        Time in seconds before execution.

        =================================================
        EXAMPLE
        =================================================

        Invoke("Respawn", 2f);

        Meaning:

        Wait 2 Seconds

                ↓

        Call Respawn()

        =================================================
        HOW IT WORKS
        =================================================

        Invoke Called

                ↓

        Timer Starts

                ↓

        Delay Completes

                ↓

        Method Executes

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Rocket Crashes

                ↓

        Play Explosion

                ↓

        Invoke Respawn()

                ↓

        Wait 2 Seconds

                ↓

        Reload Scene

        =================================================
        LOAD NEXT LEVEL EXAMPLE
        =================================================

        Rocket Reaches Finish

                ↓

        Play Success Effects

                ↓

        Invoke LoadNextLevel()

                ↓

        Wait 2 Seconds

                ↓

        Load Next Scene

        =================================================
        IMPORTANT RULES
        =================================================

        The method being called:

        - Must exist in the same class.
        - Method name is written as a string.
        - Method must not require parameters.

        Example:

        Good

            Invoke("Respawn", 2f);

        Bad

            Invoke("Respawn(player)", 2f);

        =================================================
        CANCEL INVOKE
        =================================================

        CancelInvoke();

        Used to stop all pending Invoke calls.

        Example:

        Invoke("Respawn", 5f);

                ↓

        CancelInvoke();

                ↓

        Respawn Never Happens

        =================================================
        INVOKE REPEATING
        =================================================

        InvokeRepeating()

        Used to repeatedly call a method.

        Example:

        Every 1 second

                ↓

        Spawn Enemy

                ↓

        Spawn Enemy

                ↓

        Spawn Enemy

        =================================================
        INVOKE VS DIRECT METHOD CALL
        =================================================

        Direct Method Call

                ↓

        Executes Immediately

        Example:

        Respawn();

        ---------------------------------

        Invoke()

                ↓

        Executes After Delay

        Example:

        Invoke("Respawn", 2f);

        =================================================
        COMMON USES
        =================================================

        - Respawning

        - Next Level Loading

        - Delayed Effects

        - Enemy Spawning

        - UI Messages

        - Countdown Systems

        =================================================
        MEMORY TRICK
        =================================================

        Invoke

            ↓

        Wait

            ↓

        Execute Method

        =================================================
        SHORT REVISION
        =================================================

        Invoke()
            -> Call Method After Delay

        Delay Time
            -> Seconds To Wait

        CancelInvoke()
            -> Stop Invoke

        InvokeRepeating()
            -> Repeat Method Calls

        Think:

        Invoke

                =

        Timer + Method Call

        Example:

        Wait 2 Seconds

                ↓

        Execute Method
        =================================================
        */
    }
}