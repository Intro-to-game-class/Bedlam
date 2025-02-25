using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanity : MonoBehaviour
{
    // public int sanity = 100;
    // private Coroutine _sanityTick;

    void Start()
    {

    }

    void Update()
    {
        /* WORK IN PROGRESS
        if (_sanityTick != null)
            StopCoroutine(SanityTick());
            _sanityTick = null;
        else
            StartCoroutine(SanityTick());
        */
    }

    /* STILL WORKING ON THIS!!
    IEnumerator SanityTick()
    {
        yield return new WaitForSeconds(1);

        sanity -= 1;

        Debug.Log("Sanity: " + sanity);
    }
    */
}
