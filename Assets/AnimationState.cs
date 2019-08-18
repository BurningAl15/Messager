using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour {

    Animator anim;
    GameManager gm;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        gm = FindObjectOfType<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Active", gm.isPaused);
    }
}
