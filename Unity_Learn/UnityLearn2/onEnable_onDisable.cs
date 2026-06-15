using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class OnEnable_OnDisable
    {
        /*
        =================================================
        OnEnable() AND OnDisable()
        =================================================

        What are OnEnable() and OnDisable()?

        These are special Unity methods that
        Unity automatically calls when a
        GameObject or Component is enabled
        or disabled.

        They are called Event Functions.

        =================================================
        OnEnable()
        =================================================

        OnEnable() runs when:

        - A GameObject becomes active
        - A Component becomes enabled
        - The scene starts and the object is active

        Think:

        Object Turned ON

                ↓

        OnEnable()

        =================================================
        SYNTAX
        =================================================

        private void OnEnable()
        {

        }

        Unity automatically calls it.

        We do not call it manually.

        =================================================
        EXAMPLE
        =================================================

        private void OnEnable()
        {
            Debug.Log("Object Enabled");
        }

        Result:

        When object becomes active,
        the message appears.

        =================================================
        OnDisable()
        =================================================

        OnDisable() runs when:

        - GameObject becomes inactive
        - Component becomes disabled
        - Object is removed from the scene

        Think:

        Object Turned OFF

                ↓

        OnDisable()

        =================================================
        SYNTAX
        =================================================

        private void OnDisable()
        {

        }

        Unity automatically calls it.

        =================================================
        EXAMPLE
        =================================================

        private void OnDisable()
        {
            Debug.Log("Object Disabled");
        }

        Result:

        Message appears when the object
        is disabled.

        =================================================
        EXECUTION FLOW
        =================================================

        Game Starts

                ↓

        Object Active

                ↓

        OnEnable()

                ↓

        Gameplay

                ↓

        Object Disabled

                ↓

        OnDisable()

        =================================================
        WHEN ARE THEY USED?
        =================================================

        Common Uses:

        - Register Events
        - Unregister Events
        - Reset Variables
        - Start Timers
        - Stop Timers
        - Enable UI
        - Disable UI

        =================================================
        EVENT SUBSCRIPTION EXAMPLE
        =================================================

        OnEnable()

            ↓

        Start Listening

        ---------------------------------

        OnDisable()

            ↓

        Stop Listening

        This helps prevent bugs and memory issues.

        =================================================
        UI PANEL EXAMPLE
        =================================================

        Pause Menu Opens

                ↓

        OnEnable()

                ↓

        Show Menu

        ---------------------------------

        Pause Menu Closes

                ↓

        OnDisable()

                ↓

        Hide Menu

        =================================================
        OnEnable() VS Start()
        =================================================

        OnEnable()

            ↓

        Runs every time the object
        becomes enabled.

        ---------------------------------

        Start()

            ↓

        Runs only once before the
        first frame update.

        =================================================
        EXAMPLE
        =================================================

        Enable Object

                ↓

        OnEnable()

        Disable Object

                ↓

        OnDisable()

        Enable Again

                ↓

        OnEnable()

        Start() would NOT run again.

        =================================================
        OnDisable() VS OnDestroy()
        =================================================

        OnDisable()

            ↓

        Object turned off.

        ---------------------------------

        OnDestroy()

            ↓

        Object permanently removed.

        =================================================
        MEMORY TRICK
        =================================================

        OnEnable()
            ↓
        Object Turned ON

        OnDisable()
            ↓
        Object Turned OFF

        =================================================
        SHORT REVISION
        =================================================

        OnEnable()
            -> Runs when enabled

        OnDisable()
            -> Runs when disabled

        Unity calls them automatically.

        Common Uses:

        - Events
        - UI
        - Timers
        - Setup/Cleanup

        Think:

        ON
            ↓
        OnEnable()

        OFF
            ↓
        OnDisable()
        =================================================
        */
    }
}