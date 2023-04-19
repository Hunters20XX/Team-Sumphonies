using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;

    public bool hold = false;

    Gameplay game;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();

        game = GameObject.Find("2nd Camera").GetComponent<Gameplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.pause == false)
        {
            if (Input.GetKeyDown(keyToPress) || Input.GetKeyDown(keyToPress2))
            {
                theSR.sprite = pressedImage;
                hold = true;
            }
            if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
            {
                theSR.sprite = defaultImage;
                hold = false;
            }
            if (Input.GetKeyDown(keyToPress) && Input.GetKeyDown(keyToPress2))
            {
                theSR.sprite = pressedImage;
                hold = true;
            }
            if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
            {
                theSR.sprite = defaultImage;
                hold = false;
            }

        }

        if (game.pause)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (hold == false)
                {
                    theSR.sprite = defaultImage;
                }
                if (hold == true)
                {
                    theSR.sprite = pressedImage;
                }
            }
        }
        if (Input.GetKeyDown(keyToPress) || Input.GetKeyDown(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }
        if (Input.GetKeyDown(keyToPress) && Input.GetKeyDown(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }
    }
}