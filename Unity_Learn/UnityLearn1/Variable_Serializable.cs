using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    class Variable_Serializable
    {
        // -----------------------------
        // MOVEMENT VARIABLES
        // -----------------------------

        // float:
        // A data type used for decimal numbers.
        // Example:
        // 1.5f
        // 10.2f
        // 0.01f

        // X-Axis:
        // Controls left and right movement.
        // A key = left
        // D key = right

        //float xValue = 0f;


        // Y-Axis:
        // Controls up and down movement.
        // Usually used for flying, jumping, or moving vertically.

        //float yValue = 0.1f;


        // Z-Axis:
        // Controls forward and backward movement.
        // W key = forward
        // S key = backward

        //float zValue = 0f;


        /*
            [SerializeField]

            This attribute allows a private variable to appear
            in the Unity Inspector.

            Benefits:
            - Keeps the variable private.
            - Allows changing the value from the Inspector.
            - Useful for testing and balancing gameplay.

            Example:

            [SerializeField]
            private float speed = 5f;

            Important:
            It does NOT make the variable public.
            It only shows it in the Inspector.
        */


        // These lines do not work here because Input.GetAxis()
        // must be called while the game is running.

        // Input.GetAxis() reads keyboard/controller input.
        // Since player input changes every frame,
        // it should be used inside Update().

        //float xValue = Input.GetAxis("Horizontal");
        //float yValue = 0.01f;
        //float zValue = Input.GetAxis("Vertical");
    }
}
