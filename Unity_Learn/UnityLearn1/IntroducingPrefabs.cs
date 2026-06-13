using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class IntroducingPrefabs
    {
        /*
        Prefab : reusable assest that represents a GameObject
                Storing them in hard drive and reuse them when needed 
                if we need to scale a object then it and it's copy will all be scaled 
                
        Instance : specific copy of a prefab in our scene
         */
        /*
        =================================================
        PREFABS IN UNITY
        =================================================

        What is a Prefab?

        A Prefab is a reusable GameObject template.

        Think:

        Prefab
            ↓
        Blueprint

        GameObject
            ↓
        Actual Object

        A Prefab allows us to create multiple
        copies of the same object easily.

        =================================================
        REAL LIFE EXAMPLE
        =================================================

        House Blueprint
                ↓

        Build House #1

        Build House #2

        Build House #3

        The blueprint is reused.

        Prefabs work the same way.

        =================================================
        WHY USE PREFABS?
        =================================================

        Without Prefabs:

        Create every object manually.

        This is slow.

        ---------------------------------

        With Prefabs:

        Create once.

        Reuse many times.

        This is faster and easier.

        =================================================
        HOW TO CREATE A PREFAB
        =================================================

        1. Create a GameObject.

        2. Configure it.

            - Components
            - Scripts
            - Materials
            - Settings

        3. Drag the GameObject into
           the Project Window.

        Unity automatically creates
        a Prefab.

        =================================================
        PREFAB EXAMPLE
        =================================================

        Enemy GameObject

            ↓

        Add:

        - Mesh
        - Rigidbody
        - Scripts
        - Health System

            ↓

        Drag into Assets Folder

            ↓

        Enemy Prefab Created

        =================================================
        BENEFITS OF PREFABS
        =================================================

        1. Reusable

        2. Easy To Update

        3. Saves Time

        4. Keeps Projects Organized

        =================================================
        UPDATE PREFABS
        =================================================

        Change the Prefab once.

        All instances can receive
        the update.

        Example:

        Enemy Prefab

        Health = 100

                ↓

        Change Health = 150

                ↓

        All future enemies use
        the new value.

        =================================================
        INSTANTIATE()
        =================================================

        Instantiate() is commonly used
        with Prefabs.

        It creates a copy of a Prefab
        during gameplay.

        Think:

        Prefab
            ↓
        Instantiate()
            ↓
        New Object Created

        =================================================
        EXAMPLE
        =================================================

        Instantiate(enemyPrefab);

        Result:

        A new enemy is created.

        =================================================
        SPAWNING MULTIPLE ENEMIES
        =================================================

        Enemy Prefab

            ↓

        Instantiate()

            ↓

        Enemy #1

            ↓

        Instantiate()

            ↓

        Enemy #2

            ↓

        Instantiate()

            ↓

        Enemy #3

        =================================================
        COMMON USES
        =================================================

        - Enemies
        - Bullets
        - Coins
        - Pickups
        - Projectiles
        - Effects
        - Obstacles
        - NPCs

        =================================================
        PREFAB WORKFLOW
        =================================================

        Create Object

                ↓

        Turn Into Prefab

                ↓

        Store In Project Folder

                ↓

        Reuse Anywhere

                ↓

        Instantiate During Gameplay

        =================================================
        IMPORTANT
        =================================================

        Prefab

            ≠

        Scene Object

        A Prefab is a template.

        A Scene Object is an actual
        instance of that template.

        =================================================
        MEMORY TRICK
        =================================================

        Prefab
            ↓
        Blueprint

        Instantiate()
            ↓
        Create Copy

        Scene Object
            ↓
        Actual Object

        =================================================
        SHORT REVISION
        =================================================

        Prefab
            -> Reusable GameObject Template

        Why Use It?
            -> Save Time

        Create Prefab
            -> Drag GameObject into Assets

        Instantiate()
            -> Create a copy

        Common Uses:
            -> Enemies
            -> Bullets
            -> Coins
            -> Effects

        Think:

        Prefab = Blueprint

        Instantiate = Build A Copy
        =================================================
        */
    }
}