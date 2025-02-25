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
        speech.dialogue = "Hi I'm Miles";
        StartCoroutine(speech.Talk());
    }
}