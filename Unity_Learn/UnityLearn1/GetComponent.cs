using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class GetComponent
    {
        //GetComponent<>()
        /*
        =================================================
        GetComponent<>()
        =================================================

        What is GetComponent<>()?

        GetComponent<>() is used to get access to another
        component attached to the same GameObject.

        Think:

        GameObject
            |
            |-- Transform
            |-- Rigidbody
            |-- Box Collider
            |-- PlayerMove Script

        If PlayerMove wants to use Rigidbody,
        it can get it using GetComponent<Rigidbody>().


        =================================================
        WHY DO WE USE IT?
        =================================================

        Components contain data and functions.

        To use those data and functions,
        we first need a reference to the component.

        GetComponent<>() helps us find that component.


        =================================================
        REAL LIFE EXAMPLE
        =================================================

        Imagine a person has:

        - Phone
        - Wallet
        - Keys

        You want the keys.

        Instead of creating new keys,
        you get the existing keys.

        GetComponent works similarly.

        It gets an existing component.


        =================================================
        SYNTAX
        =================================================

        ComponentType variableName;

        variableName = GetComponent<ComponentType>();

        Example:

        Rigidbody rb;

        rb = GetComponent<Rigidbody>();


        =================================================
        EXAMPLE 1 : GET RIGIDBODY
        =================================================

        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        Now rb can access Rigidbody properties
        and functions.


        =================================================
        EXAMPLE 2 : GET COLLIDER
        =================================================

        private BoxCollider box;

        void Start()
        {
            box = GetComponent<BoxCollider>();
        }

        Now box refers to the Box Collider
        attached to this GameObject.


        =================================================
        EXAMPLE 3 : GET ANOTHER SCRIPT
        =================================================

        public class Health : MonoBehaviour
        {
        }

        public class Player : MonoBehaviour
        {
            private Health health;

            void Start()
            {
                health = GetComponent<Health>();
            }
        }

        Now Player can use the Health script.


        =================================================
        WHAT DOES <> MEAN?
        =================================================

        The angle brackets tell Unity
        which component to find.

        Example:

        GetComponent<Rigidbody>()

        Find a Rigidbody.

        GetComponent<BoxCollider>()

        Find a Box Collider.

        GetComponent<PlayerMove>()

        Find the PlayerMove script.


        =================================================
        WHERE IS IT COMMONLY USED?
        =================================================

        Start()
        Awake()

        Because we usually get the component once
        and store it for later use.


        Example:

        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        After that we use rb whenever needed.


        =================================================
        PROBLEM IF COMPONENT DOES NOT EXIST
        =================================================

        Rigidbody rb = GetComponent<Rigidbody>();

        If no Rigidbody is attached,
        rb becomes null.

        null means:

        "No object found."


        Example:

        if(rb == null)
        {
            Debug.Log("No Rigidbody Found");
        }


        =================================================
        COMMON UNITY COMPONENTS
        =================================================

        GetComponent<Rigidbody>()

        GetComponent<BoxCollider>()

        GetComponent<CapsuleCollider>()

        GetComponent<AudioSource>()

        GetComponent<Animator>()

        GetComponent<MeshRenderer>()

        GetComponent<PlayerMove>()


        =================================================
        MEMORY TRICK
        =================================================

        Get
            ↓
        Find

        Component
            ↓
        Attached Unity Component

        GetComponent
            ↓
        Find an attached component


        Example:

        GetComponent<Rigidbody>()

        Meaning:

        "Give me the Rigidbody attached
        to this GameObject."


        =================================================
        IMPORTANT
        =================================================

        GetComponent does NOT create a component.

        It only finds an already existing component.

        Wrong Thinking:
        GetComponent<Rigidbody>()
        creates a Rigidbody.

        Correct Thinking:
        GetComponent<Rigidbody>()
        finds an existing Rigidbody.
        */
    }
}
