using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    public AudioSource theMusic;

    public BeatScroller theBS;

    Gameplay game;

    // Start is called before the first frame update
    void Start()
    {
        theMusic.Play();
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.end == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && game.pause == true)
            {
                theMusic.Pause();
                AudioListener.pause = true;
            }

            if (Input.GetKeyDown(KeyCode.LeftShift) && game.pause == false)
            {
                theMusic.Play();
                AudioListener.pause = false;
            }
        }
        if (game.end == true)
        {
            theMusic.Pause();
            AudioListener.pause = true;
        }
    }
}
