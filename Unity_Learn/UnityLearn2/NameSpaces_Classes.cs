using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class NameSpaces_Classes
    {
        /*
        NameSpaces : they are Containers for classes
        Classes : they are containers for variables and methods

        Need to know Basics :
                Where possible we Encapsulate our code: 
                    En-capsule-ating -> putting in a capsule 
                    The goal is to limit what the code can see/ change/be changed by
                    For eg.: Only the Methods in our Movement class can alter our player's movement speed
                These means we...
                    ...typically aim for a class to do one main thing and not multiple things...
                        Easier to read our code 
                        Easier to fix issues
                        Easier to have multiple people work on a project
        Existing Classes :
            Unity has many classes(containing useful methods and variables) already created for us
                Note: to access a Class we need to use the relevant NameSpace (eg. unity unityengine.ui)
            By accessing the Class,we access its content using the dot(.) operator.
            eg.:ClassName.MethodName();

        Classes we create :
            we tend to use one class per script -better encapsulation and organisation 
            Classes tend to be responsible for one thing.Eg.PlayerMovement,score,Enemy etc.
        */
        /*
        =================================================
        NAMESPACES
        =================================================

        What is a Namespace?

        A namespace is used to organize code.

        Think:

        Folder
            ↓
        Stores Files

        Namespace
            ↓
        Stores Classes

        Namespaces help avoid naming conflicts
        between classes that have the same name.

        =================================================
        WHY USE NAMESPACES?
        =================================================

        Imagine:

        Namespace A

            Player

        Namespace B

            Player

        Without namespaces:

        C# would not know which Player class
        you are referring to.

        Namespaces solve this problem.

        =================================================
        SYNTAX
        =================================================

        namespace UnityLearn2
        {

        }

        Everything inside belongs to
        the UnityLearn2 namespace.

        =================================================
        EXAMPLE
        =================================================

        namespace Game.Player
        {
            class Player
            {

            }
        }

        The class belongs to:

        Game.Player

        =================================================
        COMMON NAMESPACES
        =================================================

        System

        System.Collections

        System.Collections.Generic

        UnityEngine

        UnityEngine.UI

        =================================================
        USING KEYWORD
        =================================================

        using UnityEngine;

        Meaning:

        Allow access to classes inside
        the UnityEngine namespace.

        Examples:

        Transform

        Rigidbody

        MonoBehaviour

        Debug

        =================================================
        CLASSES
        =================================================

        What is a Class?

        A class is a blueprint for creating
        objects.

        Think:

        Blueprint
            ↓
        House

        Class
            ↓
        Object

        =================================================
        REAL LIFE EXAMPLE
        =================================================

        Car Blueprint

            ↓

        Car 1

        Car 2

        Car 3

        The blueprint is the class.

        The cars are objects.

        =================================================
        CLASS SYNTAX
        =================================================

        class Player
        {

        }

        Player is the class name.

        =================================================
        WHAT CAN A CLASS CONTAIN?
        =================================================

        Variables

        Methods

        Properties

        Constructors

        Other Classes

        =================================================
        EXAMPLE
        =================================================

        class Player
        {
            int health = 100;

            void Jump()
            {

            }
        }

        health
            ↓
        Variable

        Jump()
            ↓
        Method

        =================================================
        UNITY EXAMPLE
        =================================================

        public class PlayerMove : MonoBehaviour
        {

        }

        PlayerMove
            ↓
        Class Name

        MonoBehaviour
            ↓
        Unity Base Class

        =================================================
        ACCESS MODIFIERS
        =================================================

        public

            ↓

        Accessible from anywhere.

        ---------------------------------

        private

            ↓

        Accessible only inside
        the same class.

        ---------------------------------

        internal

            ↓

        Accessible inside the same project.

        =================================================
        NAMESPACE + CLASS RELATIONSHIP
        =================================================

        Namespace

            ↓

        Contains Classes

            ↓

        Classes Contain

            ↓

        Variables & Methods

        =================================================
        PROJECT EXAMPLE
        =================================================

        UnityLearn2

            ↓

        PlayerMove

        EnemyMove

        CoinCollect

        GameManager

        All classes belong to the
        UnityLearn2 namespace.

        =================================================
        MEMORY TRICK
        =================================================

        Namespace
            ↓
        Folder For Classes

        Class
            ↓
        Blueprint

        Object
            ↓
        Instance Of A Class

        =================================================
        SHORT REVISION
        =================================================

        Namespace
            -> Organizes code

        using
            -> Access a namespace

        Class
            -> Blueprint

        Object
            -> Created from a class

        Class Can Contain:

            -> Variables
            -> Methods

        Think:

        Namespace = Folder

        Class = Blueprint

        Object = Real Thing
        =================================================
        */
    }
}