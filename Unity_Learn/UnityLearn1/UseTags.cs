using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class UseTags
    {
        /*
        =================================================
        TAGS IN UNITY
        =================================================

        What are Tags?

        Tags are labels that can be assigned
        to GameObjects.

        They help us identify objects quickly.

        Think:

        Tag = Name Label

        Examples:

        Player
        Enemy
        Coin
        Ground
        Checkpoint

        =================================================
        WHY USE TAGS?
        =================================================

        Imagine:

        You have 100 enemies.

        Without Tags:

        You must check every object by name.

        With Tags:

        You simply check:

        "Is this an Enemy?"

        Much easier.

        =================================================
        HOW TO ADD A TAG
        =================================================

        1. Select a GameObject.

        2. Inspector Window.

        3. At the top click Tag.

        4. Choose an existing tag.

        OR

        5. Add Tag.

        6. Create your own tag.

        Example:

        Enemy

        =================================================
        COMMON TAGS
        =================================================

        Player

        Enemy

        Coin

        Ground

        Finish

        Checkpoint

        =================================================
        COMPARE TAG
        =================================================

        Unity provides:

        CompareTag()

        Example:

        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Hit!");
        }

        Meaning:

        If the object has the tag Enemy,
        execute the code.

        =================================================
        COLLISION EXAMPLE
        =================================================

        private void OnCollisionEnter(
            Collision collision)
        {
            if(collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Enemy Hit!");
            }
        }

        Result:

        Only runs when colliding with
        an object tagged Enemy.

        =================================================
        TRIGGER EXAMPLE
        =================================================

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Coin"))
            {
                Debug.Log("Coin Collected");
            }
        }

        Result:

        Runs only when touching a Coin.

        =================================================
        FIND OBJECT WITH TAG
        =================================================

        GameObject player =
            GameObject.FindWithTag("Player");

        Meaning:

        Find the GameObject that has
        the Player tag.

        =================================================
        FIND MULTIPLE OBJECTS
        =================================================

        GameObject[] enemies =
            GameObject.FindGameObjectsWithTag("Enemy");

        Meaning:

        Find all objects with the Enemy tag.

        =================================================
        WHY CompareTag()?
        =================================================

        Better:

        CompareTag("Enemy")

        Instead of:

        gameObject.tag == "Enemy"

        Because:

        - Faster
        - Safer
        - Recommended by Unity

        =================================================
        REAL GAME EXAMPLES
        =================================================

        Enemy hits Player

        Coin collection

        Bullet hits Enemy

        Checkpoint detection

        Level completion

        Damage systems

        Quest systems

        =================================================
        MEMORY TRICK
        =================================================

        Tag
            ↓
        Label

        Player
            ↓
        Object marked as Player

        Enemy
            ↓
        Object marked as Enemy

        CompareTag()
            ↓
        Check object's label

        =================================================
        SHORT REVISION
        =================================================

        Tag
            -> Label for a GameObject

        CompareTag()
            -> Check a tag

        FindWithTag()
            -> Find one object

        FindGameObjectsWithTag()
            -> Find multiple objects

        Common Tags:

        Player
        Enemy
        Coin
        Ground

        Think:

        Tags help identify objects quickly.
        =================================================
        */
    }
}