using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class DestroyObject
    {
        /*
        =================================================
        DESTROY()
        =================================================

        What is Destroy()?

        Destroy() is a Unity method used to remove
        an object or component from the game.

        Think:

        Object Exists
                ↓
        Destroy()
                ↓
        Object Removed

        =================================================
        WHY USE DESTROY()?
        =================================================

        Common Uses:

        - Destroy bullets after hitting an enemy
        - Remove collected coins
        - Remove enemies when defeated
        - Delete temporary effects
        - Clean up unused objects

        =================================================
        SYNTAX
        =================================================

        Destroy(objectToDestroy);

        Example:

        Destroy(gameObject);

        Meaning:

        Destroy this GameObject.

        =================================================
        DESTROY THIS OBJECT
        =================================================

        Destroy(gameObject);

        gameObject
            ↓
        The GameObject this script is attached to.

        Result:

        Object is removed from the scene.

        =================================================
        DESTROY ANOTHER OBJECT
        =================================================

        Destroy(enemy);

        Result:

        The enemy object is removed.

        =================================================
        DESTROY AFTER A DELAY
        =================================================

        Destroy(gameObject, 3f);

        Meaning:

        Wait 3 seconds

                ↓

        Destroy the object.

        =================================================
        EXAMPLE
        =================================================

        void Start()
        {
            Destroy(gameObject, 5f);
        }

        Result:

        Object disappears after 5 seconds.

        =================================================
        COLLISION EXAMPLE
        =================================================

        private void OnCollisionEnter(
            Collision collision)
        {
            Destroy(gameObject);
        }

        Result:

        When collision occurs,
        this object is destroyed.

        =================================================
        COIN COLLECTION EXAMPLE
        =================================================

        private void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
        }

        Result:

        Coin disappears when collected.

        =================================================
        DESTROY COMPONENT
        =================================================

        Destroy(GetComponent<MeshRenderer>());

        Result:

        Only the MeshRenderer component
        is removed.

        The GameObject still exists.

        =================================================
        DESTROY VS SETACTIVE(FALSE)
        =================================================

        Destroy(gameObject);

        Result:

        Permanently removed.

        Cannot be used again.

        ---------------------------------

        gameObject.SetActive(false);

        Result:

        Temporarily disabled.

        Can be enabled again later.

        =================================================
        EXECUTION FLOW
        =================================================

        Bullet Hits Enemy

                ↓

        OnCollisionEnter()

                ↓

        Destroy(gameObject)

                ↓

        Bullet Removed

        =================================================
        IMPORTANT
        =================================================

        Destroy()

        Removes objects from the game.

        Once destroyed:

        - Object no longer exists
        - Scripts stop running
        - Components are removed

        =================================================
        MEMORY TRICK
        =================================================

        Destroy()
            ↓
        Delete Object

        Destroy(gameObject)
            ↓
        Delete This Object

        Destroy(object, 3f)
            ↓
        Delete After 3 Seconds

        =================================================
        SHORT REVISION
        =================================================

        Destroy()
            -> Remove object/component

        Destroy(gameObject)
            -> Destroy this object

        Destroy(enemy)
            -> Destroy another object

        Destroy(gameObject, 5f)
            -> Destroy after 5 seconds

        Think:

        Destroy = Remove from the game
        permanently.
        =================================================
        */
    }
}