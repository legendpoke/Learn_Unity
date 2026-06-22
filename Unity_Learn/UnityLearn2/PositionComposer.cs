using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class PositionComposer
    {
        /*
        =================================================
        POSITION COMPOSER (CINEMACHINE)
        =================================================

        What is Position Composer?

        Position Composer is a Cinemachine
        camera component used to keep a target
        at a specific position on the screen.

        Think:

        Player Moves

                ↓

        Camera Follows

                ↓

        Player Stays In Desired Screen Area

        =================================================
        WHY USE POSITION COMPOSER?
        =================================================

        Without Position Composer:

        Camera may feel stiff or unnatural.

        ---------------------------------

        With Position Composer:

        Camera follows smoothly and keeps
        the player framed correctly.

        =================================================
        REQUIREMENT
        =================================================

        Position Composer is used with:

        - Cinemachine Camera
        - Follow Target

        Usually:

        Player

                ↓

        Follow Target

                ↓

        Position Composer

        =================================================
        HOW IT WORKS
        =================================================

        Target Moves

                ↓

        Camera Tracks Target

                ↓

        Position Composer Adjusts Position

                ↓

        Target Remains In Desired Screen Area

        =================================================
        SCREEN POSITION
        =================================================

        Position Composer allows us to decide
        where the target appears on screen.

        Examples:

        Center

                ↓

        Player stays in middle.

        ---------------------------------

        Upper Area

                ↓

        Player stays near top.

        ---------------------------------

        Lower Area

                ↓

        Player stays near bottom.

        =================================================
        SCREEN GUIDES
        =================================================

        Cinemachine displays guides
        in the Scene View.

        These guides show:

        - Dead Zone
        - Soft Zone
        - Screen Position

        =================================================
        DEAD ZONE
        =================================================

        Dead Zone is an area where
        the camera does not move.

        Example:

        Player moves slightly.

                ↓

        Camera does not follow.

        This reduces camera shaking.

        =================================================
        SOFT ZONE
        =================================================

        Soft Zone is an area where
        the camera starts adjusting slowly.

        Example:

        Player leaves Dead Zone.

                ↓

        Camera smoothly follows.

        =================================================
        HARD LIMIT
        =================================================

        If the target moves too far,
        the camera quickly repositions
        to keep the target visible.

        =================================================
        FOLLOW OFFSET
        =================================================

        The camera does not always need
        to stay directly on the player.

        Example:

        Camera

                ↓

        Slightly Behind Player

        This creates better visibility.

        =================================================
        PLATFORMER EXAMPLE
        =================================================

        Player Running

                ↓

        Position Composer

                ↓

        Player remains slightly
        left of center.

        This allows the player to see
        more of the level ahead.

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Rocket Moves Upward

                ↓

        Camera Follows

                ↓

        Rocket Stays Visible

        =================================================
        BENEFITS
        =================================================

        - Smooth Camera Movement

        - Better Framing

        - Less Camera Jitter

        - More Professional Feel

        - Easier Player Tracking

        =================================================
        POSITION COMPOSER VS DIRECT FOLLOW
        =================================================

        Direct Follow

                ↓

        Camera sticks directly
        to the target.

        ---------------------------------

        Position Composer

                ↓

        Camera follows intelligently
        and smoothly.

        =================================================
        COMMON USES
        =================================================

        - Platformer Games

        - Third Person Games

        - Side Scrollers

        - Adventure Games

        - Rocket Games

        =================================================
        MEMORY TRICK
        =================================================

        Position Composer

                ↓

        Keep Target In Good Position

        Dead Zone

                ↓

        No Camera Movement

        Soft Zone

                ↓

        Smooth Camera Movement

        =================================================
        SHORT REVISION
        =================================================

        Position Composer
            -> Cinemachine Camera Tool

        Purpose
            -> Keep target framed properly

        Dead Zone
            -> Ignore small movement

        Soft Zone
            -> Smooth follow area

        Benefits

            -> Smooth Camera
            -> Better Framing
            -> Less Shaking

        Think:

        Position Composer

                =

        Smart Camera Follow System
        =================================================
        */
    }
}