using LMNT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Dalton : MonoBehaviour
{
    private LMNTSpeech speech;

    void Start()
    {
        speech = GetComponent<LMNTSpeech>();
    }

    void Update()
    {
        StartCoroutine(speech.Talk());
    }
}
