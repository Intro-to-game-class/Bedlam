using LMNT;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LMNT {

public class DialogueTriggerScript : MonoBehaviour {
    private Animator animator;
    private AudioSource audioSource;
	private LMNTSpeech speech;
    private bool triggered;

    void Start() {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        speech = GetComponent<LMNTSpeech>();
        StartCoroutine(speech.Prefetch());
        triggered = false;
    }

    void Update() {
        // commented out the keybinds that came with this plugin, but didn't delete them outright in case we need it?
        
        /* if (Input.GetKeyDown("q") || Input.GetKeyDown("escape")) {
            Application.Quit();
        } */

        if (!audioSource.isPlaying) {
            triggered = false;
        }
        if (triggered) {
            return;
        }

        /* if (Input.GetKeyDown("return") || Input.GetKeyDown("enter")) {
			StartCoroutine(speech.Talk());
        } */

        if (audioSource.isPlaying) {
            animator.SetTrigger("Talk");
            triggered = true;
        }
    }

    void OnTriggerEnter (Collider coll) {
        if (coll.CompareTag ("Player")) {
            
            if (Input.GetKeyDown("e")) {
                StartCoroutine(speech.Talk());
            }
        }
    }
}

}
