using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    class UnityBasics {
        //using UnityEngine;
        // Gives access to Unity's built-in tools and features.
        //
        // Without UnityEngine, Unity-specific things such as:
        // - MonoBehaviour
        // - Input
        // - GameObject
        // - Debug.Log
        // cannot be used.

        //public class PlayerMove : MonoBehaviour
        // A class is like a blueprint.
        //
        // We create classes to store variables and functions
        // related to a specific object or task.
        //
        // This script can be attached to a GameObject.
        //
        // MonoBehaviour is Unity's base class for scripts.
        // It allows Unity to automatically run special functions
        // like Start() and Update().
        /*{
            // ACCESS MODIFIERS
            // ----------------

            // public:
            // Can be accessed from other scripts.
            // Visible in the Unity Inspector.

            // private:
            // Can only be used inside this script.
            // Hidden from the Inspector.


            // Stores the player's movement speed.
            //
            // float:
            // Used to store decimal numbers.
            //
            // Example:
            // 5.5
            // 10.0
            // 2.75
            //
            // The 'f' at the end means the value is a float.
            private float PlayerMoveSpeed = 10f;


            // START FUNCTION
            // ----------------
            //
            // Start() runs only ONE TIME.
            //
            // It runs when:
            // - The game starts.
            // - The object becomes active.
            //
            // Common uses:
            // - Assign starting values.
            // - Find GameObjects.
            // - Load data.
            // - Initialize variables.
            void Start()
            {
                // Nothing is needed here right now.
            }


            // UPDATE FUNCTION
            // ----------------
            //
            // Update() runs every frame.
            //
            // Example:
            // If the game runs at 60 FPS,
            // Update() runs about 60 times every second.
            //
            // Common uses:
            // - Read keyboard input.
            // - Read mouse input.
            // - Move characters.
            // - Check game conditions.
            void Update()
            {
                // INPUT
                // -----
                //
                // Input.GetAxis() reads player input.
                //
                // "Horizontal"
                // A/D Keys
                // Left/Right Arrow Keys
                //
                // Returns a value between -1 and 1.
                //
                // -1 = Left
                //  0 = No input
                //  1 = Right
                float xValue = Input.GetAxis("Horizontal") * PlayerMoveSpeed;


                // Y movement is disabled.
                //
                // 0 means no movement on the Y axis.
                float yValue = 0f;


                // "Vertical"
                // W/S Keys
                // Up/Down Arrow Keys
                //
                // Returns a value between -1 and 1.
                //
                // -1 = Backward
                //  0 = No input
                //  1 = Forward
                float zValue = Input.GetAxis("Vertical") * PlayerMoveSpeed;


                // Moves the player using the values
                // calculated above.
            }
        }*/

        /*
        GameObject : it is a type 
        gameObject : it is reffering to itself 
        */
    }

}
