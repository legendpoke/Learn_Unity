using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class InputActions
    {
        /*
        Simplest Input System Approach 
            We'll use an approach where we define Input Action bindings in the inspector
            Input Actions allows us to use multiple Input systems(eg.keyboard,controller) to do specific things in our game.
            eg.spacebar or trigger to control thrusting

        Steps in this Approach:
            1.use the UnityEngine.InputSystem namespace 
            2.Create InputAction variables(that are serialized)
            3.Add bindings for each InputAction
            4.Enable each InputAction
            5.Use the Value of the InputAction for gameplay
            6.Disable each InputAction if/when we need to turn off input
        */
        /*
        =================================================
        INPUT ACTIONS (UNITY INPUT SYSTEM)
        =================================================

        What are Input Actions?

        Input Actions are commands that allow
        the player to control the game.

        Think:

        Player Presses Key

                ↓

        Input Action

                ↓

        Character Performs Action

        =================================================
        REAL GAME EXAMPLE
        =================================================

        W Key
            ↓
        Move Forward

        Space Key
            ↓
        Jump

        Mouse Click
            ↓
        Shoot

        E Key
            ↓
        Interact

        =================================================
        OLD INPUT SYSTEM
        =================================================

        Unity traditionally used:

        Input.GetKey()

        Input.GetButton()

        Input.GetAxis()

        Example:

        W Key
            ↓
        Move Player

        =================================================
        NEW INPUT SYSTEM
        =================================================

        Unity's newer Input System uses:

        Input Actions

        Instead of checking individual keys,
        we create actions.

        Example:

        Move

        Jump

        Shoot

        Interact

        Sprint

        =================================================
        WHY USE INPUT ACTIONS?
        =================================================

        Easier To Manage

        Supports Multiple Devices

        Easier Rebinding

        Cleaner Code

        Better For Large Projects

        =================================================
        INPUT ACTION ASSET
        =================================================

        Input Actions are usually stored in:

        Input Action Asset

        Example:

        PlayerControls.inputactions

        This asset stores all player inputs.

        =================================================
        EXAMPLE ACTIONS
        =================================================

        Move

        Jump

        Shoot

        Pause

        Sprint

        Crouch

        Interact

        =================================================
        ACTION MAPS
        =================================================

        Action Maps group related actions.

        Example:

        Player Action Map

            Move
            Jump
            Shoot

        ---------------------------------

        UI Action Map

            Navigate
            Submit
            Cancel

        =================================================
        BINDINGS
        =================================================

        A Binding connects an action
        to a key or button.

        Example:

        Jump

            ↓

        Space Key

        ---------------------------------

        Shoot

            ↓

        Left Mouse Button

        =================================================
        MULTIPLE DEVICES
        =================================================

        Move Action

            ↓

        Keyboard (WASD)

            AND

        Controller Joystick

        Same Action

        Different Inputs

        =================================================
        INPUT FLOW
        =================================================

        Player Presses Key

                ↓

        Binding Detects Input

                ↓

        Action Executes

                ↓

        Game Responds

        =================================================
        COMMON PLAYER ACTIONS
        =================================================

        Move

        Jump

        Shoot

        Sprint

        Interact

        Reload

        Pause

        Attack

        =================================================
        ADVANTAGES
        =================================================

        Easy Key Rebinding

        Controller Support

        Keyboard Support

        Mobile Support

        Better Organization

        =================================================
        OLD SYSTEM VS NEW SYSTEM
        =================================================

        OLD

        Input.GetKey()

        Input.GetAxis()

        Input.GetButton()

        ---------------------------------

        NEW

        Input Actions

        Action Maps

        Bindings

        Better Device Support

        =================================================
        MEMORY TRICK
        =================================================

        Key Press
            ↓
        Binding

        Binding
            ↓
        Action

        Action
            ↓
        Character Response

        =================================================
        SHORT REVISION
        =================================================

        Input Action
            -> Player Command

        Action Map
            -> Group Of Actions

        Binding
            -> Connect Action To Key

        Examples

            Move
            Jump
            Shoot
            Sprint

        Think:

        Key Press
            ↓
        Action
            ↓
        Game Response
        =================================================
        */
    }
}