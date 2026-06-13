using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    internal class CachingAReference
    {
        /*
        =================================================
        CACHING A REFERENCE
        =================================================

        What is Caching?

        Caching means storing a reference to a
        component in a variable so we can use it
        later without repeatedly searching for it.

        Cachinng is a technique of storing frequently used 
        data or information in memory,so that it can easily
        be accessed when needs

        Think:

        Instead of asking:

        "Where is the MeshRenderer?"

        every time,

        we find it once and remember it.

        =================================================
        WITHOUT CACHING
        =================================================

        GetComponent<MeshRenderer>().enabled = false;

        Every time this line runs:

        Unity must search for the component.

        If this happens frequently,
        it can be less efficient.

        =================================================
        WITH CACHING
        =================================================

        private MeshRenderer meshRenderer;

        void Start()
        {
            meshRenderer =
                GetComponent<MeshRenderer>();
        }

        Now Unity finds the component once.

        After that:

        meshRenderer.enabled = false;

        We use the stored reference.

        =================================================
        WHY CACHE REFERENCES?
        =================================================

        1. Better Performance

        2. Cleaner Code

        3. Easier To Read

        4. Easier To Maintain

        =================================================
        MESH RENDERER
        =================================================

        MeshRenderer is responsible for
        displaying a 3D object.

        If MeshRenderer is enabled:

        Object is Visible

        If MeshRenderer is disabled:

        Object is Invisible

        =================================================
        MAKE OBJECT INVISIBLE
        =================================================

        meshRenderer.enabled = false;

        Result:

        Object disappears.

        The GameObject still exists.

        Only its visual appearance is hidden.

        =================================================
        MAKE OBJECT VISIBLE
        =================================================

        meshRenderer.enabled = true;

        Result:

        Object appears again.

        =================================================
        HIDE OBJECT AT GAME START
        =================================================

        private MeshRenderer meshRenderer;

        void Start()
        {
            meshRenderer =
                GetComponent<MeshRenderer>();

            meshRenderer.enabled = false;
        }

        Result:

        Object starts invisible.

        =================================================
        SHOW OBJECT AFTER SOME TIME
        =================================================

        void Update()
        {
            if(Time.time > 5f)
            {
                meshRenderer.enabled = true;
            }
        }

        Result:

        After 5 seconds,
        the object becomes visible.

        =================================================
        MEMORY TRICK
        =================================================

        GetComponent()
            ↓
        Find Component

        Cache Reference
            ↓
        Save Component

        enabled = false
            ↓
        Hide Object

        enabled = true
            ↓
        Show Object

        =================================================
        SHORT REVISION
        =================================================

        Caching
            -> Store a component reference

        MeshRenderer
            -> Displays a 3D object

        enabled = false
            -> Invisible

        enabled = true
            -> Visible

        Start()
            -> Good place to cache references

        Goal:
            Find Once, Use Many Times
        =================================================
        */
    }
}