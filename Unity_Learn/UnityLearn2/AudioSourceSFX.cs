using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class AudioSourceSFX
    {
        /*
        =================================================
        AUDIOSOURCE FOR SOUND EFFECTS (SFX)
        =================================================

        What is SFX?

        SFX stands for Sound Effects.

        Sound effects are short sounds that
        play when something happens in the game.

        Examples:

        - Jump
        - Explosion
        - Coin Collection
        - Button Click
        - Gun Shot
        - Player Death
        - Rocket Engine

        =================================================
        WHAT IS AN AUDIOSOURCE?
        =================================================

        AudioSource is the component that
        plays audio in Unity.

        Think:

        AudioClip
            ↓
        Sound File

        AudioSource
            ↓
        Speaker

        =================================================
        HOW SFX WORKS
        =================================================

        Event Happens

                ↓

        AudioSource Plays Sound

                ↓

        Player Hears Sound

        Example:

        Rocket Crashes

                ↓

        Explosion SFX Plays

        =================================================
        ADDING AN AUDIOSOURCE
        =================================================

        Select GameObject

                ↓

        Add Component

                ↓

        AudioSource

        =================================================
        ASSIGNING A SOUND
        =================================================

        Import Audio File

                ↓

        Drag Audio File

                ↓

        AudioClip Slot

        =================================================
        PLAY ON AWAKE
        =================================================

        Enabled

                ↓

        Sound automatically plays
        when the scene starts.

        ---------------------------------

        Disabled

                ↓

        Sound only plays when
        triggered by code.

        Usually:

        SFX = Disabled

        =================================================
        LOOP
        =================================================

        Enabled

                ↓

        Sound repeats forever.

        Useful for:

        - Engine Sounds
        - Background Music

        ---------------------------------

        Disabled

                ↓

        Sound plays once.

        Useful for:

        - Coin Collection
        - Explosion
        - Jump

        =================================================
        PLAY()
        =================================================

        Play() starts the assigned AudioClip.

        Think:

        AudioSource

                ↓

        Play Sound

        =================================================
        STOP()
        =================================================

        Stop() immediately stops the sound.

        Example:

        Rocket Engine Stops

                ↓

        Engine Sound Stops

        =================================================
        PLAYONE SHOT()
        =================================================

        PlayOneShot() plays a sound once.

        Useful for:

        - Explosions
        - Coin Collection
        - Button Clicks

        It does not interrupt
        the currently playing sound.

        =================================================
        VOLUME
        =================================================

        Controls sound loudness.

        0

            ↓

        Silent

        ---------------------------------

        1

            ↓

        Full Volume

        =================================================
        PITCH
        =================================================

        Controls sound frequency.

        Lower Value

            ↓

        Deeper Sound

        ---------------------------------

        Higher Value

            ↓

        Higher Sound

        =================================================
        2D SFX
        =================================================

        Same volume everywhere.

        Examples:

        - UI Buttons
        - Menu Sounds
        - Notifications

        =================================================
        3D SFX
        =================================================

        Volume depends on distance
        from the AudioListener.

        Examples:

        - Explosions
        - Engines
        - Footsteps
        - Gunshots

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Space Key Pressed

                ↓

        Rocket Thrust

                ↓

        Engine Sound Plays

        ---------------------------------

        Rocket Crashes

                ↓

        Explosion Sound Plays

        =================================================
        COMMON SFX EVENTS
        =================================================

        Jump

        Shoot

        Hit

        Collect Coin

        Open Door

        Explosion

        Win Level

        Lose Level

        =================================================
        CACHING AUDIOSOURCE
        =================================================

        Instead of repeatedly using:

        GetComponent<AudioSource>()

        We often store it in a variable.

        Think:

        Find Once

                ↓

        Reuse Many Times

        This improves performance.

        =================================================
        MEMORY TRICK
        =================================================

        AudioClip
            ↓
        Sound File

        AudioSource
            ↓
        Speaker

        Play()
            ↓
        Start Sound

        Stop()
            ↓
        Stop Sound

        PlayOneShot()
            ↓
        Play Once

        =================================================
        SHORT REVISION
        =================================================

        SFX
            -> Sound Effects

        AudioSource
            -> Plays Sound

        Play()
            -> Start Audio

        Stop()
            -> Stop Audio

        PlayOneShot()
            -> Play Once

        Loop
            -> Repeat Forever

        Volume
            -> Loudness

        Pitch
            -> Sound Height

        Think:

        Event Happens

                ↓

        AudioSource

                ↓

        Play SFX

                ↓

        Player Hears Sound
        =================================================
        */
    }
}