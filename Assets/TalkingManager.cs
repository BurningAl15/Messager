using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TalkingManager : MonoBehaviour {

    public string[] messages;
    public int numMessages;
    [SerializeField]
    Text texto;
    [SerializeField]
    float time;
    int i = 0;

    //public GameObject[] objects;

    MeManager me;

    GameManager gm;

    // Use this for initialization
    void Start()
    {
        numMessages = messages.Length;
        //time = 3f;
        StartCoroutine(SceneControl(time));
        me = FindObjectOfType<MeManager>();
        gm = FindObjectOfType<GameManager>();
        //if(objects != null)
        //{
        //    for (int i = 0; i < objects.Length; i++)
        //    {
        //        objects[i].SetActive(false);
        //    }
        //}
    }

    


    IEnumerator SceneControl(float duration)
    {
        int counter = 0;
        for (int i = 0; i < messages.Length; i++)
        {
            //Seteando texto
            texto.text = messages[i];

            //Fade in del texto
            for (float t = 0; t < duration; t += Time.deltaTime)
            {
                var color = texto.color;
                color.a = Mathf.Lerp(0f, 1f, t / duration);
                texto.color = color;
                yield return null;
            }

            //Esperando input
            while (!Input.anyKey)
            {
                yield return null;

            }
            counter++;
            if (Input.GetMouseButtonDown(0))
            {
                me.anim.SetTrigger("Talk");
            }


            if (counter == messages.Length - 1)
            {
                yield return 3f;
                me.anim.SetTrigger("Smile");
            }

            //Fade out del texto
            for (float t = 0; t < duration; t += Time.deltaTime)
            {
                var color = texto.color;
                color.a = Mathf.Lerp(1f, 0f, t / duration);
                texto.color = color;
                yield return null;
            }
            //if (objects != null)
            //{
            //    if (counter == 0 || counter % 2 == 0)
            //    {
            //        objects[0].SetActive(true);
            //        objects[1].SetActive(true);
            //    }
            //    else
            //    {
            //        objects[0].SetActive(false);
            //        objects[1].SetActive(false);
            //    }
            //}
        }

        yield return 3f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void Quit()
    {
        Application.Quit();
    }
}
