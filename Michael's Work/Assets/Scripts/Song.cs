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
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();

        theMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.end == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && game.pause == false)
            {
                theMusic.Pause();
            }

            if (Input.GetKeyDown(KeyCode.LeftShift) && game.pause == true)
            {
                theMusic.Play();
            }
        }
    }
}
