using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class Scene
    {
        /*
        =================================================
        SCENE VIEW TOOLS IN UNITY
        =================================================

        What is a Scene?

        A Scene is the area where we build
        and design our game world.

        It contains:

        - GameObjects
        - Lights
        - Cameras
        - Terrain
        - UI Elements

        Think:

        Scene
            ↓
        The Level Or World Of The Game

        =================================================
        GLOBAL AND LOCAL
        =================================================

        These options affect how the
        Move, Rotate and Scale tools behave.

        =================================================
        GLOBAL
        =================================================

        Global uses the World's axes.

        The direction never changes.

        World Axes:

                Y
                ↑
                |
                |
                |
        X -------+------→ Z

        Example:

        Rotate an object.

        Move tool still points to the
        world's X, Y and Z directions.

        Think:

        Global
            ↓
        World Direction

        =================================================
        LOCAL
        =================================================

        Local uses the object's own axes.

        The direction changes when the
        object rotates.

        Example:

        Rotate a rocket 90 degrees.

        The Move tool also rotates and
        follows the rocket's direction.

        Think:

        Local
            ↓
        Object Direction

        =================================================
        GLOBAL VS LOCAL
        =================================================

        Global

            ↓

        Uses World Axes

        Does Not Rotate With Object

        ---------------------------------

        Local

            ↓

        Uses Object Axes

        Rotates With Object

        =================================================
        GRID
        =================================================

        What is Grid?

        Grid is the set of lines visible
        in the Scene View.

        It helps place objects accurately.

        Example:

        Place:

        - Walls
        - Floors
        - Platforms

        in straight positions.

        Think:

        Grid
            ↓
        Ruler For Building Levels

        =================================================
        GRID SNAPPING
        =================================================

        Grid snapping allows objects
        to automatically align to the grid.

        Benefits:

        - Cleaner Levels
        - Better Alignment
        - Faster Level Design

        =================================================
        PIVOT
        =================================================

        What is Pivot?

        Pivot is the actual center point
        of the selected GameObject.

        Rotation and scaling happen around
        the Pivot point.

        Example:

        Door

            Pivot Here
                 ↓
            ┌───────┐
            │ Door  │
            └───────┘

        Rotate Door

                ↓

        Door rotates around Pivot.

        Think:

        Pivot
            ↓
        Real Object Center Point

        =================================================
        CENTER
        =================================================

        What is Center?

        Center places the tool handle
        in the center of all selected objects.

        Example:

        Cube A       Cube B

            □           □

                ↓

             Center

        The move tool appears between them.

        Think:

        Center
            ↓
        Middle Of Selection

        =================================================
        PIVOT VS CENTER
        =================================================

        Pivot

            ↓

        Uses Actual Pivot Point
        Of Selected Object

        ---------------------------------

        Center

            ↓

        Uses Center Of Selection

        =================================================
        EXAMPLE
        =================================================

        Select Two Cubes

            □       □

        Pivot Mode

            ↓

        Handle appears on the selected
        object's own pivot.

        ---------------------------------

        Center Mode

            ↓

        Handle appears between both cubes.

        =================================================
        MEMORY TRICK
        =================================================

        Global
            ↓
        World Direction

        Local
            ↓
        Object Direction

        Grid
            ↓
        Level Building Guide

        Pivot
            ↓
        Object's Actual Center Point

        Center
            ↓
        Middle Of Selection

        =================================================
        SHORT REVISION
        =================================================

        Global
            -> World Axes

        Local
            -> Object Axes

        Grid
            -> Placement Guide

        Pivot
            -> Rotate Around Object Pivot

        Center
            -> Tool Appears At Selection Center

        Think:

        Global = World

        Local = Object

        Grid = Guide

        Pivot = Object Center

        Center = Selection Center
        =================================================
        */
    }
}