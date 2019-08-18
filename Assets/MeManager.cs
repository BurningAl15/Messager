using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeManager : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetKeyDown(KeyCode.Z))	
        //{
        //    anim.SetTrigger("Smile");   
        //}

        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    anim.SetTrigger("Talk");
        //}

    }
}
