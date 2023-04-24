using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    public float threshold;
    public bool fail = false;
    public bool nice = false;
    public bool great = false;
    public bool perfect = false;
    FrenzyMode frenzy;
    Gameplay game;

    // Start is called before the first frame update
    void Start()
    {
        frenzy = GameObject.Find("vampire_neutral").GetComponent<FrenzyMode>();
        game = GameObject.Find("vampire_neutral").GetComponent<Gameplay>();
    }

    // Update is called once per frame
    void Update()
    {

        if(game.pause == false)
        {
           if (transform.position.x < -2.4)
        {
            {
                nice = true;
            }
        }
        if (transform.position.x < -2.7)
        {
            {
                great = true;
                nice = false;
            }
        }
        if (transform.position.x < -3.3)
        {
            {
                perfect = true;
                great = false;
            }
        }
        if (transform.position.x < -4.13)
        {
            {
                great = true;
                perfect = false;
            }
        }
        if (transform.position.x < -4.4)
        {
            {
                nice = true;
                great = false;
            }
        }

        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed && nice == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim++;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score++;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 5;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6) 
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }

                if(frenzy.frenzyMode == true)
                {
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim++;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score++;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 5;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                    }
                    Debug.Log("Nice Frenzy Hit!");
                }
                Debug.Log("Nice!");

                frenzy.hitsInARow += 1;
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().hit++;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
            }
            if (canBePressed && great == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim +=2;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score +=2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 8;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 8;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 10;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 10;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                }

                if(frenzy.frenzyMode == true)
                {
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 8;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 8;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 10;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 10;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                    }
                    Debug.Log("Great Frenzy Hit!");
                }
                Debug.Log("Great!");

                frenzy.hitsInARow += 1;
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().hit++;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
            }
            if (canBePressed && perfect == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 9;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 9;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 15;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 15;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 18;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 18;
                }

                if(frenzy.frenzyMode == true)
                {
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 9;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 9;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 15;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 15;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 18;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 18;
                    }

                    Debug.Log("Perfect Frenzy Hit!");
                }
                Debug.Log("Perfect!");

                frenzy.hitsInARow += 1;
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().hit++;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
            }
        }

        if (Input.GetKeyDown(keyToPress2))
        {
            if (canBePressed && nice == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim++;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score++;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 5;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }

                if(frenzy.frenzyMode == true)
                {
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim++;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score++;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 5;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                    }
                    Debug.Log("Nice Frenzy Hit!");
                }

                Debug.Log("Nice!");

                frenzy.hitsInARow += 1;
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().hit++;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
            }
            if (canBePressed && great == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 8;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 8;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 10;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 10;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                }

                if(frenzy.frenzyMode == true)
                {
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 2;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 4;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 8;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 8;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 10;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 10;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                    }
                    Debug.Log("Great Frenzy Hit!");
                }

                Debug.Log("Great!");

                frenzy.hitsInARow += 1;
                gameObject.SetActive(false);
                GameObject.Find("Button1").GetComponent<Score>().hit++;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
            }
            if (canBePressed && perfect == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 9;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 9;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 15;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 15;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 18;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 18;
                }

                if(frenzy.frenzyMode == true)
                {
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 3;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 9;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 9;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 15;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 15;
                    }
                    if(GameObject.Find("Button1").GetComponent<Score>().multiplier >= 6)
                    {
                        GameObject.Find("Button1").GetComponent<Score>().victim += 18;
                        GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 18;
                    }
                    Debug.Log("Perfect Frenzy Hit!");
                }

                    Debug.Log("Perfect!");


                    frenzy.hitsInARow += 1;
                    gameObject.SetActive(false);
                    GameObject.Find("Button1").GetComponent<Score>().hit++;
                    GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
                }
            }

            if (transform.position.x < threshold && fail == false)
            {
               GameObject.Find("Button1").GetComponent<Score>().multiplier = 1;
                GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                fail = true;
                frenzy.hitsInARow = 0;
            } 
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.tag == "Activator")
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