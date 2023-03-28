using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    public float threshold;
    public bool fail;
    public bool nice;
    public bool great;
    public bool perfect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -3f)
        {
            {
                nice = true;
            }
        }
        if (transform.position.x <= -3.5f)
        {
            {
                great = true;
                nice = false;
            }
        }
        if (transform.position.x <= -4f)
        {
            {
                perfect = true;
                great = false;
            }
        }
        if (transform.position.x <= -5f)
        {
            {
                great = true;
                perfect = false;
            }
        }
        if (transform.position.x <= -5.5f)
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
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score++;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 5;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 6;
                }
                Debug.Log("Nice");
            }

            if (canBePressed && great == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 8;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 8;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 10;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 10;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 12;
                }
                Debug.Log("Great");
            }

            if (canBePressed && perfect == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 9;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 9;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 12;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 15;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 15;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 18;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 18;
                }
                Debug.Log("Perfect");
            }

            gameObject.SetActive(false);
            GameObject.Find("Button1").GetComponent<Score>().hit++;
            GameObject.Find("vampire_neutral").GetComponent<Timer>().hits++;
        }

        if (Input.GetKeyDown(keyToPress2))
        {
            if (canBePressed && nice == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim++;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score++;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 5;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 5;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 6;
                }
                Debug.Log("Nice");
            }

            if (canBePressed && great == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 2;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 2;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 4;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 4;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 8;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 8;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 10;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 10;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 12;
                }
                Debug.Log("Great");
            }

            if (canBePressed && perfect == true)
            {
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 3;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 3;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 2)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 6;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 3)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 9;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 9;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 4)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 12;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 5)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 15;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 15;
                }
                if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
                {
                    GameObject.Find("Button1").GetComponent<Score>().victim += 18;
                    GameObject.Find("vampire_neutral").GetComponent<Timer>().score += 18;
                }
                Debug.Log("Perfect");
            }

            gameObject.SetActive(false);
            GameObject.Find("Button1").GetComponent<Score>().hit++;
            GameObject.Find("vampire_neutral").GetComponent<Timer>().hits++;
            
            if (transform.position.x < threshold && fail == false)
            {
                GameObject.Find("Button1").GetComponent<Score>().multiplier = 1;
                GameObject.Find("Button1").GetComponent<Score>().hit = 0;
                fail = true;
                nice = false;
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
