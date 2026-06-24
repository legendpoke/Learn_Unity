using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class LoadNextScene
    {
        /*
        =================================================
        LOAD NEXT SCENE
        =================================================

        What is Loading Next Scene?

        Loading the next scene means moving
        from the current level to another level.

        Examples:

        - Level 1 → Level 2
        - Level 2 → Level 3
        - Main Menu → Game Scene
        - Game Scene → Win Screen

        =================================================
        WHY LOAD NEXT SCENE?
        =================================================

        Games are usually divided into
        multiple scenes.

        Example:

        Main Menu

                ↓

        Level 1

                ↓

        Level 2

                ↓

        Level 3

                ↓

        Victory Screen

        =================================================
        REQUIREMENT
        =================================================

        Namespace Required:

        using UnityEngine.SceneManagement;

        =================================================
        BUILD INDEX
        =================================================

        Every scene added to Build Profiles
        gets a Build Index.

        Example:

        Index 0 -> Main Menu

        Index 1 -> Level 1

        Index 2 -> Level 2

        Index 3 -> Level 3

        =================================================
        GET CURRENT SCENE
        =================================================

        SceneManager.GetActiveScene()

        Used to get the scene currently
        running in the game.

        Think:

        "Which level am I currently in?"

        =================================================
        GET CURRENT BUILD INDEX
        =================================================

        SceneManager.GetActiveScene().buildIndex

        Used to get the current scene number.

        Example:

        Level 1

                ↓

        Build Index = 1

        =================================================
        LOAD NEXT SCENE
        =================================================

        To move to the next level:

        Current Index

                ↓

        Add 1

                ↓

        Load New Scene

        Example:

        Current Scene = Level 1

        Build Index = 1

                ↓

        Load Scene 2

                ↓

        Level 2 Opens

        =================================================
        GET TOTAL NUMBER OF SCENES
        =================================================

        SceneManager.sceneCountInBuildSettings

        Used to get the total number of scenes
        added in Build Profiles (Build Settings).

        Example:

        Build Profiles

        Index 0 -> Main Menu

        Index 1 -> Level 1

        Index 2 -> Level 2

        Index 3 -> Level 3

        Total Scenes

                ↓

        4

        =================================================

        Why is it useful?

        Before loading the next scene,
        we can check if another scene exists.

        Example:

        Current Scene = Level 3

        Build Index = 3

        Total Scenes = 4

                ↓

        Level 3 is the last level.

                ↓

        Instead of loading another level:

        - Load Main Menu
        - Load Victory Screen
        - Restart Game

        =================================================

        FLOW

        Current Scene

                ↓

        Get Build Index

                ↓

        Get Total Scene Count

                ↓

        Check If Next Scene Exists

                ↓

        Load Next Scene

        OR

        Show Win Screen

        =================================================

        MEMORY TRICK

        sceneCountInBuildSettings

                ↓

        Total Number Of Scenes
                In The Game

        Example:

        5 Scenes Added

                ↓

        sceneCountInBuildSettings = 5


        =================================================
        FLOW
        =================================================

        Player Completes Level

                ↓

        Success Logic Runs

                ↓

        Get Current Build Index

                ↓

        Add 1

                ↓

        Load Next Scene

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Rocket Reaches Finish Pad

                ↓

        Success Sound

                ↓

        Success Particle Effect

                ↓

        Load Next Level

        =================================================
        DELAY BEFORE LOADING
        =================================================

        Sometimes we wait before
        loading the next level.

        Example:

        Reach Finish Pad

                ↓

        Play Success Effects

                ↓

        Wait 2 Seconds

                ↓

        Load Next Scene

        Makes the game feel smoother.

        =================================================
        COMMON USES
        =================================================

        - Next Level

        - Victory Screen

        - Main Menu

        - Game Completion

        - Story Progression

        =================================================
        IMPORTANT
        =================================================

        All scenes must be added to:

        File

            ↓

        Build Profiles

            ↓

        Scenes In Build

        Otherwise Unity cannot load them.

        =================================================
        NEXT SCENE LOGIC
        =================================================

        Current Scene

                ↓

        Build Index

                ↓

        +1

                ↓

        Next Scene

        =================================================
        MEMORY TRICK
        =================================================

        Current Level

            ↓

        Build Index

            ↓

        +1

            ↓

        Next Level

        =================================================
        SHORT REVISION
        =================================================

        SceneManager
            -> Controls Scenes

        GetActiveScene()
            -> Current Scene

        buildIndex
            -> Scene Number

        Next Scene
            -> Current Index + 1

        Think:

        Finish Level

                ↓

        Get Build Index

                ↓

        Add 1

                ↓

        Load Next Level
        =================================================
        */
    }
}