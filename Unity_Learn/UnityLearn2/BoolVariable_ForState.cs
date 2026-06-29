using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class BoolVariable_ForState
    {
        /*
        =================================================
        BOOL VARIABLE FOR STATE
        =================================================

        What is a State?

        A state describes the current condition
        of an object or game system.

        Examples:

        - Is the player alive?
        - Is the game over?
        - Is the rocket crashing?
        - Is the player jumping?
        - Has the level finished?

        =================================================
        WHAT IS A BOOL?
        =================================================

        bool is a data type that can store
        only two values:

        true

        or

        false

        Think:

        YES or NO

        ON or OFF

        TRUE or FALSE

        =================================================
        WHY USE BOOL FOR STATES?
        =================================================

        Many game situations only need
        two possible answers.

        Example:

        Is Player Alive?

        true
            ↓
        Alive

        false
            ↓
        Dead

        =================================================
        COMMON STATE VARIABLES
        =================================================

        bool isAlive

        bool isDead

        bool isJumping

        bool isGrounded

        bool isGameOver

        bool isPaused

        bool isThrusting

        bool isTransitioning

        =================================================
        HOW IT WORKS
        =================================================

        State Variable

                ↓

        Check Value

                ↓

        Execute Appropriate Logic

        =================================================
        PLAYER EXAMPLE
        =================================================

        isAlive = true

                ↓

        Player Can Move

        ---------------------------------

        isAlive = false

                ↓

        Disable Movement

        Show Game Over

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        bool isTransitioning

        Purpose:

        Prevent multiple collisions
        during level transition.

        Example:

        Rocket Reaches Finish

                ↓

        isTransitioning = true

                ↓

        Ignore Other Collisions

                ↓

        Load Next Level

        =================================================
        GAME OVER EXAMPLE
        =================================================

        bool isGameOver

        false

                ↓

        Continue Playing

        ---------------------------------

        true

                ↓

        Show Game Over Screen

        Stop Gameplay

        =================================================
        PAUSE EXAMPLE
        =================================================

        bool isPaused

        false

                ↓

        Game Runs Normally

        ---------------------------------

        true

                ↓

        Pause Game

        Show Pause Menu

        =================================================
        USING BOOL WITH IF STATEMENTS
        =================================================

        Check State

                ↓

        true?

                ↓

        Run Code

        Example Thinking:

        if(isAlive)

                ↓

        Player Can Move

        =================================================
        STATE CHANGES
        =================================================

        States can change during gameplay.

        Example:

        Start Game

                ↓

        isAlive = true

                ↓

        Player Dies

                ↓

        isAlive = false

        =================================================
        BENEFITS
        =================================================

        - Easy To Understand

        - Easy To Debug

        - Controls Game Logic

        - Prevents Unwanted Actions

        - Makes Code Cleaner

        =================================================
        COMMON UNITY STATES
        =================================================

        Player States

            ↓

        isAlive

        isJumping

        isGrounded

        ---------------------------------

        Game States

            ↓

        isPaused

        isGameOver

        ---------------------------------

        Rocket States

            ↓

        isTransitioning

        isThrusting

        =================================================
        MEMORY TRICK
        =================================================

        bool

            ↓

        Two Choices

            ↓

        TRUE

        or

        FALSE

        =================================================
        SHORT REVISION
        =================================================

        bool
            -> true or false

        State
            -> Current condition

        Examples

            -> isAlive

            -> isDead

            -> isPaused

            -> isGameOver

            -> isTransitioning

        Think:

        State Variable

                ↓

        Controls

                ↓

        Game Behaviour
        =================================================
        */
    }
}