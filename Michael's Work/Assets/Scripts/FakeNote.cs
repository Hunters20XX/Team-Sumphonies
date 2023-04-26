using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeNote : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    public bool fail;
    Gameplay game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.pause == false && game.end == false)
        {
            if (Input.GetKeyDown(keyToPress))
            {
                if (canBePressed)
                {
                    gameObject.SetActive(false);
                    GameObject.Find("Button1").GetComponent<Score>().multiplier -= 2;
                    GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                    fail = true;
                    GameObject.Find("vampire_neutral").GetComponent<Health>().heart -= 2;
                }
            }

            if (Input.GetKeyDown(keyToPress2))
            {
                if (canBePressed)
                {
                    gameObject.SetActive(false);
                    GameObject.Find("Button1").GetComponent<Score>().multiplier -= 2;
                    GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                    fail = true;
                    GameObject.Find("vampire_neutral").GetComponent<Health>().heart -= 2;
                }
            }
        }        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
    }

    void OnEnable()
    {
        fail = false;
    }

    void OnDisable()
    {
        fail = true;
    }
}