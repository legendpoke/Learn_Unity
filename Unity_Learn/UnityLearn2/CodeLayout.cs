using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class CodeLayout
    {
        /*
        =================================================
        CODE LAYOUT
        =================================================

        What is Code Layout?

        Code Layout is the way we organize
        our code inside a script.

        A good layout makes code:

        - Easy to read
        - Easy to understand
        - Easy to debug
        - Easy to maintain

        =================================================
        WHY IS CODE LAYOUT IMPORTANT?
        =================================================

        Imagine a room.

        Clean Room
                ↓
        Easy to find things

        Messy Room
                ↓
        Hard to find things

        The same applies to code.

        Clean Code
                ↓
        Easy to work with

        Messy Code
                ↓
        Difficult to understand

        =================================================
        COMMON UNITY SCRIPT LAYOUT
        =================================================

        1. Using Directives

        using UnityEngine;
        using UnityEngine.SceneManagement;

        ---------------------------------

        2. Namespace

        namespace UnityLearn2
        {
        }

        ---------------------------------

        3. Class Declaration

        public class Player : MonoBehaviour
        {
        }

        ---------------------------------

        4. Variables

        Store data used by the script.

        Example:

        speed
        health
        score

        ---------------------------------

        5. Cached References

        Store components that will
        be used frequently.

        Example:

        Rigidbody

        AudioSource

        MeshRenderer

        ---------------------------------

        6. Unity Event Methods

        Examples:

        Awake()

        Start()

        Update()

        FixedUpdate()

        OnCollisionEnter()

        ---------------------------------

        7. Custom Methods

        Examples:

        MovePlayer()

        RotatePlayer()

        Respawn()

        LoadNextLevel()

        =================================================
        RECOMMENDED ORDER
        =================================================

        Using Directives

                ↓

        Namespace

                ↓

        Class

                ↓

        Variables

                ↓

        Cached References

                ↓

        Awake()

                ↓

        Start()

                ↓

        Update()

                ↓

        FixedUpdate()

                ↓

        Collision Methods

                ↓

        Custom Methods

        =================================================
        VARIABLE SECTION
        =================================================

        Place variables near the
        top of the class.

        Example Types:

        - int
        - float
        - bool
        - string

        Purpose:

        Easy to find and modify.

        =================================================
        CACHED REFERENCES SECTION
        =================================================

        References to components
        should usually be grouped together.

        Examples:

        Rigidbody

        AudioSource

        Collider

        MeshRenderer

        Think:

        "Objects this script needs."

        =================================================
        UNITY EVENT METHODS
        =================================================

        Keep Unity methods together.

        Common Order:

        Awake()

                ↓

        OnEnable()

                ↓

        Start()

                ↓

        Update()

                ↓

        FixedUpdate()

                ↓

        OnDisable()

        =================================================
        CUSTOM METHODS
        =================================================

        Put your own methods below
        Unity methods.

        Examples:

        ProcessInput()

        MovePlayer()

        RotatePlayer()

        Die()

        Respawn()

        =================================================
        COMMENT SECTIONS
        =================================================

        Comments help explain code.

        Example Sections:

        Variables

        References

        Unity Methods

        Gameplay Methods

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Variables

                ↓

        Rigidbody Reference

                ↓

        Audio Source Reference

                ↓

        Start()

                ↓

        Update()

                ↓

        Process Thrust()

                ↓

        Process Rotation()

                ↓

        Collision Handling()

        =================================================
        BENEFITS OF GOOD LAYOUT
        =================================================

        - Easier Reading

        - Easier Debugging

        - Faster Development

        - Better Teamwork

        - Easier Revision

        =================================================
        MEMORY TRICK
        =================================================

        Top

            ↓

        Variables

            ↓

        References

            ↓

        Unity Methods

            ↓

        Custom Methods

            ↓

        Bottom

        =================================================
        SHORT REVISION
        =================================================

        Code Layout
            -> Organize Code Properly

        Variables
            -> Top Of Script

        References
            -> After Variables

        Unity Methods
            -> Middle

        Custom Methods
            -> Bottom

        Think:

        Organized Code

                ↓

        Easier To Understand

                ↓

        Easier To Maintain
        =================================================
        */
    }
}