using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool isPaused;
    public GameObject soundMenu;

    public bool active;

	void Start () {
        soundMenu.SetActive(false);
    }

    public void Paused()
    {
        isPaused = !isPaused;
        if(isPaused)
        {
            Time.timeScale = 0f;
        }
        else if (!isPaused)
        {
            Time.timeScale = 1f;
        }
        
        soundMenu.SetActive(isPaused);
    }

    public void Press()
    {
        active = true;
    }

    public void NotPress()
    {
        active = false;
    }
}
