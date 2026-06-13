using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class OnCollisonEnter
    {
        /*
        =================================================
        OnCollisionEnter()
        =================================================

        What is OnCollisionEnter()?

        OnCollisionEnter() is a Unity built-in method.

        It automatically runs ONE TIME when this object
        collides (hits/touches) another object.

        Think:

        Collision Starts
               ↓
        OnCollisionEnter() Runs


        =================================================
        WHEN IS IT USED?
        =================================================

        Examples:

        - Player hits a wall.
        - Bullet hits an enemy.
        - Car crashes into another car.
        - Player lands on the ground.
        - Ball hits a box.

        Whenever the collision starts,
        Unity automatically calls this method.


        =================================================
        REQUIREMENTS
        =================================================

        For OnCollisionEnter() to work:

        1. Both objects need a Collider component.

        Examples:
        - Box Collider
        - Sphere Collider
        - Capsule Collider

        2. At least one object must have a Rigidbody.

        Without Rigidbody,
        OnCollisionEnter() usually will not run.


        =================================================
        SYNTAX
        =================================================

        void OnCollisionEnter(Collision collision)
        {
            // Code Here
        }

        Parts:

        void
        ----
        Returns nothing.

        OnCollisionEnter
        ----------------
        Unity's special collision method.

        Collision collision
        -------------------
        Contains information about
        the object that was hit.


        =================================================
        EXAMPLE
        =================================================

        void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Something touched me!");
        }

        Output:

        Something touched me!

        Runs only once when collision begins.


        =================================================
        KNOW WHICH OBJECT HIT YOU
        =================================================

        void OnCollisionEnter(Collision collision)
        {
            Debug.Log(collision.gameObject.name);
        }

        Example Output:

        Wall
        Enemy
        Ground

        This tells us the name of the object
        that collided with our object.


        =================================================
        CHECK FOR SPECIFIC OBJECT
        =================================================

        void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.name == "Enemy")
            {
                Debug.Log("Enemy Hit!");
            }
        }

        Only runs when the object named
        "Enemy" collides.


        =================================================
        COMMON USES
        =================================================

        Player:
        - Take damage
        - Collect items
        - Open doors

        Enemy:
        - Detect bullets
        - Detect player

        Bullet:
        - Destroy enemy
        - Play explosion effect

        Car:
        - Detect crashes


        =================================================
        COLLISION FLOW
        =================================================

        Object A touches Object B

               ↓

        OnCollisionEnter()

               ↓

        Your Code Executes


        =================================================
        RELATED COLLISION METHODS
        =================================================

        OnCollisionEnter()
        ------------------
        Runs once when collision starts.

        OnCollisionStay()
        -----------------
        Runs every frame while objects
        are still touching.

        OnCollisionExit()
        -----------------
        Runs once when objects stop touching.


        =================================================
        MEMORY TRICK
        =================================================

        Enter = Started Touching

        Stay = Still Touching

        Exit = Stopped Touching


        Example:

        Player touches wall
              ↓
        Enter

        Player keeps touching wall
              ↓
        Stay

        Player moves away
              ↓
        Exit


        =================================================
        IMPORTANT
        =================================================

        Collision = Physical Contact

        Collider = Detects Contact

        Rigidbody = Enables Physics

        OnCollisionEnter() = Runs once when contact begins
        */

        /*
        Quick Revision
            Method	            When It Runs
            OnCollisionEnter()	First touch
            OnCollisionStay()	While touching
            OnCollisionExit()	Stop touching
        */
    }
}
