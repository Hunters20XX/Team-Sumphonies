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
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
        theSR = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyToPress) || Input.GetKey(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKey(keyToPress) && Input.GetKey(keyToPress2))
        {
            hold = true;
        }
        if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }
        if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
        {
            hold = false;
        }

        if (game.pause == false && game.end == false)
        {
            if (Input.GetKey(keyToPress) || Input.GetKey(keyToPress2))
            {
                theSR.sprite = pressedImage;
            }
            if (Input.GetKey(keyToPress) && Input.GetKey(keyToPress2))
            {
                theSR.sprite = pressedImage;
            }
            if (Input.GetKeyUp(keyToPress) || Input.GetKeyUp(keyToPress2))
            {
                theSR.sprite = defaultImage;
            }
            if (Input.GetKeyUp(keyToPress) && Input.GetKeyUp(keyToPress2))
            {
                theSR.sprite = defaultImage;
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && game.pause)
        {
            if (hold == false)
            {
                theSR.sprite = defaultImage;
            }
        }
    }
}