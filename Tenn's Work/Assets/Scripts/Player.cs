using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;

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

        if(game.pause == false)
        {
            if (Input.GetKeyDown(keyToPress))
            {
                theSR.sprite = pressedImage;
            }

            if (Input.GetKeyUp(keyToPress))
            {
                theSR.sprite = defaultImage;
            }

            if (Input.GetKeyDown(keyToPress2))
            {
                theSR.sprite = pressedImage;
            }

            if (Input.GetKeyUp(keyToPress2))
            {
                theSR.sprite = defaultImage;
            }
        }
       
    }
}
