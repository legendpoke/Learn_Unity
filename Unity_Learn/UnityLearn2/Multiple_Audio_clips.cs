using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class Multiple_Audio_clips
    {
        /*
        =================================================
        MULTIPLE AUDIO CLIPS
        =================================================

        What are Multiple Audio Clips?

        Multiple Audio Clips means using
        more than one sound in a game object
        or script.

        Examples:

        Rocket Game

        - Engine Sound
        - Crash Sound
        - Success Sound

        All are different AudioClips.

        =================================================
        WHY USE MULTIPLE AUDIO CLIPS?
        =================================================

        Different game events need
        different sounds.

        Example:

        Rocket Thrust

                ↓

        Engine Sound

        ---------------------------------

        Rocket Crash

                ↓

        Explosion Sound

        ---------------------------------

        Level Complete

                ↓

        Success Sound

        =================================================
        AUDIOCLIP VARIABLES
        =================================================

        We can create multiple AudioClip
        variables in a script.

        Example:

        AudioClip EngineClip

        AudioClip CrashClip

        AudioClip SuccessClip

        Each variable stores a different sound.

        =================================================
        HOW IT WORKS
        =================================================

        Event Happens

                ↓

        Choose Correct AudioClip

                ↓

        AudioSource Plays Clip

                ↓

        Player Hears Sound

        =================================================
        UNITY INSPECTOR
        =================================================

        AudioClip variables appear
        in the Inspector.

        Example:

        Engine Clip
            -> engine.wav

        Crash Clip
            -> explosion.wav

        Success Clip
            -> success.wav

        Drag and drop the audio files
        into the correct fields.

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Space Key Pressed

                ↓

        Play Engine Clip

        ---------------------------------

        Rocket Hits Obstacle

                ↓

        Play Crash Clip

        ---------------------------------

        Rocket Reaches Finish

                ↓

        Play Success Clip

        =================================================
        PLAYONE SHOT()
        =================================================

        Commonly used for multiple clips.

        Why?

        Because it allows different sounds
        to be played without replacing the
        AudioSource's main clip.

        Think:

        AudioSource

                ↓

        PlayOneShot()

                ↓

        Play Specific Clip

        =================================================
        AUDIO FLOW
        =================================================

        Input/Event

                ↓

        Select AudioClip

                ↓

        AudioSource

                ↓

        Play Sound

        =================================================
        BENEFITS
        =================================================

        - Better Feedback

        - Better Gameplay Feel

        - More Professional Sound

        - Easier Audio Management

        =================================================
        COMMON GAME AUDIO CLIPS
        =================================================

        Player

            ↓

        Jump Sound

        Hit Sound

        Death Sound

        ---------------------------------

        Rocket

            ↓

        Engine Sound

        Crash Sound

        Success Sound

        ---------------------------------

        UI

            ↓

        Button Click

        Hover Sound

        Notification Sound

        =================================================
        CACHING AUDIOSOURCE
        =================================================

        Usually we store the AudioSource
        reference once and reuse it.

        Think:

        Find Once

                ↓

        Use Many Times

        Better Performance

        =================================================
        MEMORY TRICK
        =================================================

        Event

            ↓

        Select Clip

            ↓

        AudioSource

            ↓

        Play Sound

        =================================================
        SHORT REVISION
        =================================================

        Multiple Audio Clips
            -> Many Sounds In One Script

        AudioClip
            -> Stores Sound

        AudioSource
            -> Plays Sound

        PlayOneShot()
            -> Play Specific Clip

        Examples

            -> Engine Sound

            -> Crash Sound

            -> Success Sound

        Think:

        Different Events

                ↓

        Different Audio Clips

                ↓

        Better Game Experience
        =================================================
        */
    }
}