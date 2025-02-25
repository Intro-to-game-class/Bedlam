using LMNT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Miles : MonoBehaviour{
    private LMNTSpeech speech;
}
void Start() {
    Speech = GetComponent<LMNTSpeech>();
}
void Update(){

    Speech.dialogue = "Hi I'm Miles";
    StartCoroutine(Speech.Talk());
}
}