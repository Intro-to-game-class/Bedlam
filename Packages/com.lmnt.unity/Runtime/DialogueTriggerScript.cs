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
        private bool nearby;
        private bool lookingAt;

        void Start() {
            animator = GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>();
            speech = GetComponent<LMNTSpeech>();
            StartCoroutine(speech.Prefetch());
            triggered = false;
            nearby = false;
        }

        void Update() {
            if (!audioSource.isPlaying) {
                triggered = false;
            }
            if (triggered) {
                return;
            }
            if (Input.GetKeyDown("e")) {
                if (nearby && lookingAt) {
                    StartCoroutine(speech.Talk());
                }
            }

            if (audioSource.isPlaying) {
                animator.SetTrigger("Talk");
                triggered = true;
            }
        }

        void OnTriggerEnter (Collider coll) {
            if (coll.CompareTag ("Player")) {
                Debug.Log("Player entered speech collider");
                nearby = true;
            }
        }

        void OnTriggerExit(Collider coll) {
            if (coll.CompareTag ("Player")) {
                Debug.Log("Player exited speech collider");
                nearby = false;
            }
        }
        void OnMouseEnter() {
            lookingAt = true;
        }
        void OnMouseExit() {
            lookingAt = false;
        }
    }
}
