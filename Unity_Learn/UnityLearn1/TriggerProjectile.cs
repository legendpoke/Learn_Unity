using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class TriggerProjectile
    {
        /*
        in this the object works as hidden trap 
        like if we pass this and a ball or a sudden hit came 
        to make active this we 
            1.make the trigger or trap object invisible by removing mesh render component or making it uncheck 
            2. in the box collider check the Is Trigger box 
            3. and in the script use the method OnTriggerEnter() 
            4.and make their if the player collide with the Triggered object then execute the code 
            5. in that code we use tag or more things and use the variable to setActive it true
        */
        /*
        =================================================
        TRIGGERS IN UNITY
        =================================================

        What is a Trigger?

        A Trigger is a special Collider that
        detects overlap between objects without
        causing a physical collision.

        Think:

        Collision
            ↓
        Objects physically hit each other.

        Trigger
            ↓
        Objects pass through each other but
        detection still occurs.

        =================================================
        HOW TO CREATE A TRIGGER
        =================================================

        1. Add a Collider component.

        2. In the Inspector.

        3. Enable:

        Is Trigger

        Result:

        Collider becomes a Trigger.

        =================================================
        COLLISION VS TRIGGER
        =================================================

        Collision

        Player Hits Wall

            ↓

        Player Stops

        ---------------------------------

        Trigger

        Player Enters Area

            ↓

        Event Happens

            ↓

        Player Keeps Moving

        =================================================
        OnTriggerEnter()
        =================================================

        Runs once when an object enters
        the Trigger area.

        Syntax:

        private void OnTriggerEnter(Collider other)
        {
        }

        Think:

        Object Enters Trigger
                ↓
        OnTriggerEnter Runs

        =================================================
        PARAMETER
        =================================================

        Collider other

        other
            ↓
        The object that entered
        the Trigger.

        Example:

        other.gameObject.name

        Gets the object's name.

        =================================================
        PROJECTILE EXAMPLE
        =================================================

        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
        }

        Result:

        Projectile enters Trigger

                ↓

        Projectile destroyed

        =================================================
        DESTROY PROJECTILE AND TARGET
        =================================================

        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);

            Destroy(gameObject);
        }

        Result:

        Target destroyed

                ↓

        Projectile destroyed

        =================================================
        USING TAGS
        =================================================

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);

                Destroy(gameObject);
            }
        }

        Meaning:

        Only destroy objects tagged Enemy.

        =================================================
        REQUIREMENTS
        =================================================

        For Triggers to work:

        1. Collider component.

        2. Is Trigger enabled.

        3. At least one object should have
           a Rigidbody.

        =================================================
        COMMON USES
        =================================================

        - Bullets
        - Projectiles
        - Coins
        - Checkpoints
        - Damage Zones
        - Finish Lines
        - Detection Areas

        =================================================
        TRIGGER FLOW
        =================================================

        Projectile Moves

                ↓

        Enters Trigger Area

                ↓

        OnTriggerEnter()

                ↓

        Code Executes

                ↓

        Destroy Projectile

        =================================================
        RELATED METHODS
        =================================================

        OnTriggerEnter()

            ↓

        Runs once when entering.

        ---------------------------------

        OnTriggerStay()

            ↓

        Runs while inside.

        ---------------------------------

        OnTriggerExit()

            ↓

        Runs when leaving.

        =================================================
        MEMORY TRICK
        =================================================

        Trigger
            ↓
        Detect without blocking

        OnTriggerEnter()
            ↓
        Enter Trigger

        OnTriggerStay()
            ↓
        Stay Inside Trigger

        OnTriggerExit()
            ↓
        Leave Trigger

        =================================================
        SHORT REVISION
        =================================================

        Trigger
            -> Detect overlap

        Is Trigger
            -> Enable Trigger mode

        OnTriggerEnter()
            -> Runs when entering

        Collider other
            -> Object entering Trigger

        Common Use:
            -> Projectiles and Coins

        Think:

        Trigger = Detect
        Collision = Physically Hit
        =================================================
        */
    }
}