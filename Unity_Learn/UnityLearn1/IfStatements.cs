using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class IfStatements
    {
        /*
        =================================================
        IF STATEMENTS
        =================================================

        What is an If Statement?

        An if statement is used to make decisions
        in a program.

        It checks whether a condition is true or false.

        If the condition is TRUE:
            Execute the code.

        If the condition is FALSE:
            Skip the code.

        Think:

        Question
            ↓
        True or False?
            ↓
        Execute or Skip

        =================================================
        SYNTAX
        =================================================

        if(condition)
        {
            // Code to execute
        }

        Read as:

        "If the condition is true,
        run this code."

        =================================================
        EXAMPLE 1
        =================================================

        int health = 100;

        if(health > 0)
        {
            Debug.Log("Player Is Alive");
        }

        Result:

        Player Is Alive

        Because:

        100 > 0 = TRUE

        =================================================
        EXAMPLE 2
        =================================================

        int health = 0;

        if(health > 0)
        {
            Debug.Log("Player Is Alive");
        }

        Result:

        Nothing happens

        Because:

        0 > 0 = FALSE

        =================================================
        COMPARISON OPERATORS
        =================================================

        ==

        Equal To

        Example:

        if(score == 10)

        Meaning:

        score is exactly 10

        ---------------------------------

        !=

        Not Equal To

        Example:

        if(score != 10)

        Meaning:

        score is NOT 10

        ---------------------------------

        >

        Greater Than

        Example:

        if(score > 10)

        Meaning:

        score is greater than 10

        ---------------------------------

        <

        Less Than

        Example:

        if(score < 10)

        Meaning:

        score is less than 10

        ---------------------------------

        >=

        Greater Than Or Equal To

        Example:

        if(score >= 10)

        ---------------------------------

        <=

        Less Than Or Equal To

        Example:

        if(score <= 10)

        =================================================
        BOOLEAN VALUES
        =================================================

        bool gameOver = true;

        if(gameOver)
        {
            Debug.Log("Game Over");
        }

        Meaning:

        If gameOver is true,
        run the code.

        =================================================
        IF ELSE
        =================================================

        if(score >= 100)
        {
            Debug.Log("Level Complete");
        }
        else
        {
            Debug.Log("Keep Playing");
        }

        Meaning:

        If first condition is false,
        run the else block.

        =================================================
        ELSE IF
        =================================================

        if(score >= 100)
        {
            Debug.Log("Gold");
        }
        else if(score >= 50)
        {
            Debug.Log("Silver");
        }
        else
        {
            Debug.Log("Bronze");
        }

        Unity checks from top to bottom.

        First true condition runs.

        =================================================
        UNITY EXAMPLE
        =================================================

        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Jump");
        }

        Meaning:

        If Space Key is pressed,
        execute the code.

        =================================================
        COLLISION EXAMPLE
        =================================================

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Player Hit Enemy");
            }
        }

        Meaning:

        If collided object has the Enemy tag,
        run the code.

        =================================================
        MEMORY TRICK
        =================================================

        IF
            ↓
        Ask Question

        TRUE
            ↓
        Run Code

        FALSE
            ↓
        Skip Code

        =================================================
        EXECUTION FLOW
        =================================================

        if(score >= 10)
        {
            Debug.Log("Win");
        }

        score = 15

            ↓

        15 >= 10 ?

            ↓

        TRUE

            ↓

        Print:

        Win

        =================================================
        SHORT REVISION
        =================================================

        if()
            -> Make decisions

        true
            -> Execute code

        false
            -> Skip code

        else
            -> Run if if() is false

        else if
            -> Check another condition

        Common Operators:

        == Equal To

        != Not Equal To

        > Greater Than

        < Less Than

        >= Greater Than Or Equal To

        <= Less Than Or Equal To

        Think:

        IF = Ask a Question
        =================================================
        */
    }
}