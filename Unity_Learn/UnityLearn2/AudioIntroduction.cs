using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn2
{
    internal class AudioIntroduction
    {
        /*

            Download Audacity for creating self made sound : https://www.audacityteam.org/download/
            and for feee sound source : https://freesound.org/ 
            
        =================================================
        AUDIO IN UNITY
        =================================================

        What is Audio?

        Audio is used to add sound effects,
        background music, voice lines and
        ambient sounds to a game.

        Audio helps make the game feel alive
        and improves the player's experience.

        =================================================
        TYPES OF AUDIO
        =================================================

        1. Sound Effects (SFX)

        Examples:

        - Jump Sound
        - Explosion Sound
        - Coin Collection Sound
        - Button Click Sound
        - Gun Shot Sound

        ---------------------------------

        2. Background Music (BGM)

        Examples:

        - Main Menu Music
        - Level Music
        - Boss Battle Music

        ---------------------------------

        3. Ambient Sounds

        Examples:

        - Wind
        - Rain
        - Birds
        - Ocean Waves

        ---------------------------------

        4. Voice Audio

        Examples:

        - Character Dialogue
        - Narration
        - Announcements

        =================================================
        AUDIO COMPONENTS IN UNITY
        =================================================

        Unity mainly uses:

        AudioClip
            ↓
        The actual sound file

        AudioSource
            ↓
        Plays the sound

        AudioListener
            ↓
        Hears the sound

        =================================================
        AUDIO SYSTEM FLOW
        =================================================

        AudioClip

            ↓

        AudioSource

            ↓

        AudioListener

            ↓

        Player Hears Sound

        =================================================
        AUDIOCLIP
        =================================================

        AudioClip stores audio data.

        Examples:

        jump.wav

        explosion.mp3

        backgroundMusic.wav

        Think:

        AudioClip
            ↓
        Sound File

        =================================================
        AUDIOSOURCE
        =================================================

        AudioSource plays AudioClips.

        Commonly attached to:

        - Player
        - Enemy
        - Buttons
        - Environment Objects

        Think:

        AudioSource
            ↓
        Speaker

        =================================================
        AUDIOLISTENER
        =================================================

        AudioListener receives sounds.

        Usually attached to:

        Main Camera

        Only one AudioListener should
        normally exist in a scene.

        Think:

        AudioListener
            ↓
        Player's Ears

        =================================================
        IMPORTING AUDIO
        =================================================

        Drag audio file into:

        Assets Folder

        Unity automatically imports it.

        Supported Formats:

        - WAV
        - MP3
        - OGG

        =================================================
        PLAYING AUDIO
        =================================================

        Basic Process:

        Import Audio

            ↓

        Create AudioSource

            ↓

        Assign AudioClip

            ↓

        Play Sound

        =================================================
        AUDIO SOURCE SETTINGS
        =================================================

        Play On Awake

            ↓

        Sound plays automatically
        when the game starts.

        ---------------------------------

        Loop

            ↓

        Sound repeats continuously.

        Useful for:

        Background Music

        =================================================
        VOLUME
        =================================================

        Controls sound loudness.

        Low Volume

            ↓

        Quiet Sound

        ---------------------------------

        High Volume

            ↓

        Loud Sound

        =================================================
        PITCH
        =================================================

        Controls sound frequency.

        Lower Pitch

            ↓

        Deep Sound

        ---------------------------------

        Higher Pitch

            ↓

        High Sound

        =================================================
        2D AUDIO
        =================================================

        Sound volume stays the same
        regardless of player position.

        Common Uses:

        - UI Sounds
        - Menu Music
        - Notifications

        =================================================
        3D AUDIO
        =================================================

        Sound changes depending on
        distance from the listener.

        Common Uses:

        - Explosions
        - Footsteps
        - Engines
        - Environmental Sounds

        =================================================
        ROCKET BOOST EXAMPLE
        =================================================

        Rocket Engine Sound

                ↓

        AudioClip

                ↓

        AudioSource

                ↓

        Plays While Thrusting

        ---------------------------------

        Collision Sound

                ↓

        Plays When Rocket Crashes

        =================================================
        COMMON AUDIO USES
        =================================================

        - Background Music

        - Jump Sounds

        - Explosion Sounds

        - Button Clicks

        - Engine Sounds

        - Ambient Sounds

        =================================================
        MEMORY TRICK
        =================================================

        AudioClip
            ↓
        Sound File

        AudioSource
            ↓
        Speaker

        AudioListener
            ↓
        Ears

        =================================================
        SHORT REVISION
        =================================================

        AudioClip
            -> Stores Audio

        AudioSource
            -> Plays Audio

        AudioListener
            -> Hears Audio

        Types Of Audio:

            -> Music

            -> Sound Effects

            -> Ambient Sounds

            -> Voice Audio

        Think:

        AudioClip
            ↓
        AudioSource
            ↓
        AudioListener
            ↓
        Player Hears Sound
        =================================================
        */
    }
}