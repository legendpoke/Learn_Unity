using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class SwitchStatements
    {
        /*
        =================================================
        SWITCH STATEMENTS
        =================================================

        What is a Switch Statement?

        A switch statement is used when we
        need to compare one value against
        multiple possible values.

        These are the conditional like If/Else statements 
        Allow us to compare a single variable can change or vary to a series of constants 
        constants : Thinngs that do not change or the vlaue do not change 

        Think:

        One Variable

                ↓

        Many Possible Cases

                ↓

        Execute Matching Code

        =================================================
        WHY USE SWITCH?
        =================================================

        Without Switch:

        if
        else if
        else if
        else if

        Code becomes long and harder to read.

        ---------------------------------

        With Switch:

        Code becomes cleaner and easier
        to understand.

        =================================================
        SYNTAX
        =================================================

        switch(variable)
        {
            case value1:
                Code;
                break;

            case value2:
                Code;
                break;

            default:
                Code;
                break;
        }

        =================================================
        IMPORTANT PARTS
        =================================================

        switch

            ↓

        Checks the variable.

        ---------------------------------

        case

            ↓

        Possible value to match.

        ---------------------------------

        break

            ↓

        Exit the switch statement.

        Prevents checking other cases.

        ---------------------------------

        default

            ↓

        Runs when no case matches.

        Similar to:

        else

        =================================================
        EXAMPLE
        =================================================

        int day = 3;

        switch(day)
        {
            case 1:
                Monday
                break;

            case 2:
                Tuesday
                break;

            case 3:
                Wednesday
                break;

            default:
                Unknown Day
                break;
        }

        Result:

        Wednesday

        =================================================
        FLOW OF EXECUTION
        =================================================

        Variable Value

                ↓

        Switch Checks Cases

                ↓

        Matching Case Found

                ↓

        Execute Code

                ↓

        Break

                ↓

        Exit Switch

        =================================================
        BREAK KEYWORD
        =================================================

        Why is break important?

        It stops execution after
        the matching case.

        Example:

        case 1:
            Code
            break;

        Without break:

        Unity/C# may continue into
        the next case.

        =================================================
        DEFAULT CASE
        =================================================

        default runs when no case matches.

        Example:

        day = 10

                ↓

        No matching case

                ↓

        default executes

        =================================================
        UNITY EXAMPLE
        =================================================

        Game States

        switch(gameState)
        {
            case Playing:
                Run Gameplay
                break;

            case Paused:
                Show Pause Menu
                break;

            case GameOver:
                Show Game Over Screen
                break;
        }

        =================================================
        AUDIO EXAMPLE
        =================================================

        switch(soundType)
        {
            case Jump:
                Play Jump Sound
                break;

            case Explosion:
                Play Explosion Sound
                break;

            case Coin:
                Play Coin Sound
                break;
        }

        =================================================
        LEVEL EXAMPLE
        =================================================

        switch(level)
        {
            case 1:
                Easy Level
                break;

            case 2:
                Medium Level
                break;

            case 3:
                Hard Level
                break;
        }

        =================================================
        SWITCH VS IF
        =================================================

        IF

            ↓

        Better for conditions.

        Example:

        score > 100

        ---------------------------------

        SWITCH

            ↓

        Better for exact values.

        Example:

        level == 1

        level == 2

        level == 3

        =================================================
        WHEN TO USE SWITCH?
        =================================================

        Good For:

        - Menu Selections

        - Game States

        - Level Selection

        - Character States

        - Audio Types

        - Weapon Selection

        =================================================
        MEMORY TRICK
        =================================================

        switch
            ↓
        Check Value

        case
            ↓
        Possible Match

        break
            ↓
        Stop Checking

        default
            ↓
        No Match Found

        =================================================
        SHORT REVISION
        =================================================

        switch
            -> Checks a variable

        case
            -> Matching value

        break
            -> Exit switch

        default
            -> Runs if nothing matches

        Think:

        One Variable

                ↓

        Many Cases

                ↓

        Execute Matching Case
        =================================================
        */
    }
}