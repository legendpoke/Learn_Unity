using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class UnityOrderOfExecution
    {
        /*
        =================================================
        UNITY ORDER OF EXECUTION
        =================================================

        What is Order Of Execution?

        Unity does not run all methods at random.

        Unity follows a specific order for
        calling methods.

        Understanding this order helps prevent:

        - Null Reference Errors
        - Initialization Problems
        - Unexpected Bugs

        =================================================
        SIMPLE EXECUTION FLOW
        =================================================

        Awake()

            ↓

        OnEnable()

            ↓

        Start()

            ↓

        Update()

            ↓

        LateUpdate()

            ↓

        Object Disabled

            ↓

        OnDisable()

            ↓

        Object Destroyed

            ↓

        OnDestroy()

        =================================================
        AWAKE()
        =================================================

        Runs first.

        Called when the object is created.

        Purpose:

        - Initialize variables
        - Cache references
        - Setup components

        Example:

        private Rigidbody rb;

        void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        Think:

        Awake()
            ↓
        "I Exist"

        =================================================
        ONENABLE()
        =================================================

        Runs whenever the object becomes active.

        Example:

        GameObject Enabled

                ↓

        OnEnable()

        Useful for:

        - Subscribing to events
        - Resetting values

        Think:

        OnEnable()
            ↓
        "I'm Active"

        =================================================
        START()
        =================================================

        Runs once before the first frame.

        Runs after Awake().

        Purpose:

        - Setup gameplay values
        - Initialize data
        - Start timers

        Example:

        void Start()
        {
            Debug.Log("Game Started");
        }

        Think:

        Start()
            ↓
        "Let's Begin"

        =================================================
        UPDATE()
        =================================================

        Runs every frame.

        Example:

        60 FPS

            ↓

        Update runs about
        60 times every second.

        Common Uses:

        - Input
        - Movement
        - Timers
        - Game Logic

        Think:

        Update()
            ↓
        "Main Game Loop"

        =================================================
        FIXEDUPDATE()
        =================================================

        Runs at a fixed interval.

        Mainly used for Physics.

        Common Uses:

        - Rigidbody Movement
        - Physics Forces
        - Physics Calculations

        Think:

        FixedUpdate()
            ↓
        "Physics Update"

        =================================================
        LATEUPDATE()
        =================================================

        Runs after all Update methods.

        Common Uses:

        - Camera Follow Systems
        - Final Adjustments

        Example:

        Player Moves

                ↓

        Update()

                ↓

        Camera Follows

                ↓

        LateUpdate()

        Think:

        LateUpdate()
            ↓
        "Run After Everything Else"

        =================================================
        ONDISABLE()
        =================================================

        Runs when the object becomes inactive.

        Example:

        gameObject.SetActive(false);

                ↓

        OnDisable()

        Think:

        OnDisable()
            ↓
        "I'm Being Turned Off"

        =================================================
        ONDESTROY()
        =================================================

        Runs before an object is destroyed.

        Example:

        Destroy(gameObject);

                ↓

        OnDestroy()

        Useful for:

        - Cleanup
        - Saving Data
        - Removing Event Listeners

        Think:

        OnDestroy()
            ↓
        "Goodbye"

        =================================================
        COMMON BEGINNER FLOW
        =================================================

        Scene Loads

                ↓

        Awake()

                ↓

        Start()

                ↓

        Update()

                ↓

        Update()

                ↓

        Update()

                ↓

        Object Destroyed

                ↓

        OnDestroy()

        =================================================
        AWAKE VS START
        =================================================

        Awake()

            ↓

        Object Initialization

        ---------------------------------

        Start()

            ↓

        Gameplay Initialization

        Example:

        Awake()
        {
            GetComponent<Rigidbody>();
        }

        Start()
        {
            score = 0;
        }

        =================================================
        UPDATE VS FIXEDUPDATE
        =================================================

        Update()

            ↓

        Input
        Movement Logic
        Timers

        ---------------------------------

        FixedUpdate()

            ↓

        Physics
        Rigidbody Operations

        =================================================
        MEMORY TRICK
        =================================================

        Awake()
            ↓
        I Exist

        OnEnable()
            ↓
        I Am Active

        Start()
            ↓
        Begin

        Update()
            ↓
        Every Frame

        FixedUpdate()
            ↓
        Physics

        LateUpdate()
            ↓
        After Update

        OnDisable()
            ↓
        Turned Off

        OnDestroy()
            ↓
        Removed

        =================================================
        SHORT REVISION
        =================================================

        Awake()
            -> First Initialization

        Start()
            -> Setup Before Gameplay

        Update()
            -> Every Frame

        FixedUpdate()
            -> Physics

        LateUpdate()
            -> Runs After Update

        OnDisable()
            -> Object Disabled

        OnDestroy()
            -> Object Destroyed

        Think:

        Awake
            ↓
        Start
            ↓
        Update
            ↓
        Destroy
        =================================================
        */
    }
}