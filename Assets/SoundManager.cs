using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance;

    public Text text;
    public string songName;
    public AudioClip[] audios;
    
    AudioClip currentAudio;
    public Sprite[] portraits;
    public Image currentPortrait;

    public int index;
    int maxIndex;
    public AudioSource background;
    private void Awake()
    {
        if (SoundManager.instance == null)
        {
            SoundManager.instance = this;
        }
        else if (SoundManager.instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        maxIndex = audios.Length;
        currentAudio = audios[index];
        currentPortrait.sprite = portraits[index];
        songName = currentAudio.name;
        text.text = songName;
    }

    public void Left()
    {
        if (index >= 0 && index < maxIndex)
        {
            index--;
            if(index<0)
            {
                index = maxIndex - 1;
            }

        }
        currentAudio = audios[index];
        currentPortrait.sprite = portraits[index];
        ChangeSound(currentAudio);
        songName = currentAudio.name;
        text.text = songName;
    }

    public void Right()
    {
        if (index >= 0 && index < maxIndex)
        {
            index++;
            if (index >= maxIndex)
            {
                index = 0;
            }

        }
        currentAudio = audios[index];
        currentPortrait.sprite = portraits[index];
        ChangeSound(currentAudio);
        songName = currentAudio.name;
        text.text = songName;
    }

    public void ChangeSound(AudioClip cs)
    {
        background.clip = cs;
        background.Play();
    }
    

    private void OnDestroy()
    {
        if (SoundManager.instance == this)
        {
            SoundManager.instance = null;
        }
    }
}
