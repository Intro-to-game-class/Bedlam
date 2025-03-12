using LMNT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Miles : MonoBehaviour
{
    private LMNTSpeech speech;

    void Start()
    {
        speech = GetComponent<LMNTSpeech>();
    }

    void Update()
    {
        // StartCoroutine(speech.Talk());
    }
}