using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    class Collision
    {
        /*
         ========================================
         COLLISION
         ========================================

         What is Collision?

         Collision means two GameObjects touch each other.

         Examples:
         - Player touches a wall.
         - Bullet hits an enemy.
         - Car crashes into another car.
         - Player picks up a coin.

         Why do we use it?

         We use collision to detect when an object interacts
         with another object and then perform some action.

         Examples:
         - Reduce player's health.
         - Destroy an enemy.
         - Collect a coin.
         - Open a door.

         Requirements:
         1. Both objects need a Collider component.
            (Box Collider, Sphere Collider, Capsule Collider, etc.)

         2. Usually at least one object should have a Rigidbody.

         Common Unity Methods:

         void OnCollisionEnter(Collision collision)
         {
             // Runs once when collision starts.
         }

         void OnCollisionStay(Collision collision)
         {
             // Runs continuously while objects are touching.
         }

         void OnCollisionExit(Collision collision)
         {
             // Runs when objects stop touching.
         }

         Remember:
         Collision = Physical contact between objects.
         */
    }
}
