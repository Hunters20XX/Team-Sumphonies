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

        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.pause == false && game.end == false)
        {
            if (Input.GetKey(keyToPress) || Input.GetKey(keyToPress2))
            {
                theSR.sprite = pressedImage;
            }
            if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
            {
                theSR.sprite = defaultImage;
            }
            if (Input.GetKey(keyToPress) && Input.GetKey(keyToPress2))
            {
                theSR.sprite = pressedImage;
            }
            if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
            {
                theSR.sprite = defaultImage;
            }
        }

        if (game.pause && game.end == false)
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
        if (game.pause == false && game.end == false)
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
        if (Input.GetKey(keyToPress) || Input.GetKey(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }
        if (Input.GetKey(keyToPress) && Input.GetKey(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }
    }
}