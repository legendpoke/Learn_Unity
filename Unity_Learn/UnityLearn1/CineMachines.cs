using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    class CineMachines
    {
        /*
            Cinemachine

            Cinemachine is an official Unity package
            used to create professional camera systems.

            It can:

            - Follow the player
            - Look at the player
            - Switch between cameras
            - Create smooth camera movement
            - Create cutscenes
            - Add camera shake effects
        */


        /*
            Cinemachine Brain

            Attached to the Main Camera.

            It acts like a manager that controls
            all Cinemachine Virtual Cameras.

            If multiple virtual cameras exist,
            the Brain decides which camera is active.
        */


        /*
            Virtual Camera

            A camera created by Cinemachine.

            It does not directly render the game.

            Instead, it sends instructions to
            the Main Camera through the
            Cinemachine Brain.
        */


        /*
            Follow Offset

            Controls the distance between
            the camera and the player.

            Example:

            Larger Z value:
            Camera moves farther away.

            Smaller Z value:
            Camera moves closer.
        */


        /*
            Position Damping

            Controls how smoothly the camera follows.

            Low Damping:
            Camera follows instantly.

            High Damping:
            Camera follows smoothly with delay.
        */


        /*
            Package Manager

            Used to install Unity packages.

            Location:

            Window
                -> Package Manager

            Examples of packages:

            - Cinemachine
            - Input System
            - ProBuilder
            - Visual Scripting
            - TextMeshPro
        */
    }
}
