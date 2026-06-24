using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class RespawnUsingSceneManager
    {
        /*
        Adding Scene in Unity : 
            Go to file tab -> Build Profiles -> add the scene which  you want (Eg.Level scene,environment scene)
            And it is having index number starting from ZERO(0)
        */
        /*
        =================================================
        RESPAWN USING SCENEMANAGER
        =================================================

        What is Respawning?

        Respawning means restarting the player
        after death, crash, or failure.

        Examples:

        - Rocket crashes
        - Player falls off map
        - Player loses all health

        Instead of closing the game,
        we restart the level.

        =================================================
        WHAT IS SCENEMANAGER?
        =================================================

        SceneManager is a Unity class used to:

        - Load Scenes
        - Reload Scenes
        - Change Levels

        Namespace Required:

        using UnityEngine.SceneManagement;

        =================================================
        WHY USE SCENEMANAGER FOR RESPAWN?
        =================================================

        Simplest Respawn Method:

        Reload Current Scene

                ↓

        Everything returns to its
        original starting state.

        =================================================
        PROCESS
        =================================================

        Player Dies

                ↓

        Scene Reloads

                ↓

        Player Respawns

                ↓

        Game Continues

        =================================================
        CURRENT SCENE
        =================================================

        Unity keeps track of the
        currently loaded scene.

        We can get it using:

        SceneManager.GetActiveScene()

        Think:

        "Which level is currently open?"

        =================================================
        BuildIndex
        =================================================

        Every scene added to Build Profiles
        (or Build Settings in older Unity versions)
        gets a unique index number.

        Index numbers start from:

        0

        Example:

        Build Profiles

        Index 0  -> MainMenu

        Index 1  -> Level1

        Index 2  -> Level2

        Index 3  -> Level3

        =================================================

        SceneManager can load scenes using
        these index numbers.

        Example:

        Load Scene 1

                ↓

        SceneManager.LoadScene(1);

        =================================================

        CURRENT SCENE BUILD INDEX

        To get the current scene's index:

        SceneManager.GetActiveScene().buildIndex

        Think:

        "What is the index number of the
        scene currently running?"

        =================================================

        RELOAD CURRENT SCENE

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );

        Flow:

        Current Scene

                ↓

        Get Build Index

                ↓

        Load Same Index

                ↓

        Scene Restarts

        =================================================

        NEXT LEVEL EXAMPLE

        Current Scene = Level1

        Build Index = 1

                ↓

        Load Index 2

                ↓

        Level2 Opens

        =================================================

        PREVIOUS LEVEL EXAMPLE

        Current Scene = Level2

        Build Index = 2

                ↓

        Load Index 1

                ↓

        Level1 Opens

        =================================================

        MEMORY TRICK

        Build Index

            ↓

        Scene Number

        0
            ↓
        First Scene

        1
            ↓
        Second Scene

        2
            ↓
        Third Scene

        =================================================
        RELOADING CURRENT SCENE
        =================================================

        Get Current Scene

                ↓

        Load Same Scene Again

                ↓

        Restart Level

        =================================================
        EXAMPLE FLOW
        =================================================

        Rocket Hits Obstacle

                ↓

        OnCollisionEnter()

                ↓

        Crash Logic

                ↓

        Reload Scene

                ↓

        Rocket Back At Start

        =================================================
        DELAY BEFORE RESPAWN
        =================================================

        Sometimes we wait before reloading.

        Example:

        Rocket Crashes

                ↓

        Explosion Sound

                ↓

        Explosion Effect

                ↓

        Wait 2 Seconds

                ↓

        Reload Scene

        This feels more polished.

        =================================================
        COMMON USES
        =================================================

        - Rocket Crash

        - Player Death

        - Falling Off Map

        - Game Over

        - Restart Level Button

        =================================================
        SCENEMANAGER METHODS
        =================================================

        LoadScene()

            ↓

        Load a scene.

        ---------------------------------

        GetActiveScene()

            ↓

        Get current scene.

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Rocket Collides With Obstacle

                ↓

        Play Crash Sound

                ↓

        Show Explosion

                ↓

        Reload Current Scene

                ↓

        Start Again

        =================================================
        IMPORTANT
        =================================================

        Scene must be added to:

        File

            ↓

        Build Settings

            ↓

        Scenes In Build

        Otherwise SceneManager
        cannot load the scene.

        =================================================
        MEMORY TRICK
        =================================================

        Crash

            ↓

        SceneManager

            ↓

        Reload Scene

            ↓

        Respawn

        =================================================
        SHORT REVISION
        =================================================

        Respawn
            -> Restart Player

        SceneManager
            -> Controls Scenes

        GetActiveScene()
            -> Current Scene

        LoadScene()
            -> Load Scene

        Common Uses

            -> Death

            -> Crash

            -> Restart Level

        Think:

        Player Dies

                ↓

        Reload Scene

                ↓

        Player Starts Again
        =================================================
        */
    }
}