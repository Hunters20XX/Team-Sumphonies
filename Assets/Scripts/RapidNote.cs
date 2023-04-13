using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidNote : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    public float threshold;
    public float beatTempo;
    public bool moving;
    public float time;
    public bool timer;
    public bool fail = false;
    public bool nice = false;
    public bool great = false;
    public bool perfect = false;


    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
        moving = true;
        timer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -2)
        {
            {
                nice = true;
            }
        }
        if (transform.position.x < -2.6)
        {
            {
                great = true;
                nice = false;
            }
        }
        if (transform.position.x < -3.2)
        {
            {
                perfect = true;
                great = false;
            }
        }
        if (transform.position.x < -4.2)
        {
            {
                great = true;
                perfect = false;
            }
        }
        if (transform.position.x < -4.8)
        {
            {
                nice = true;
                great = false;
            }
        }

        if (moving)
        {
            transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed && nice == true)
            {
                moving = false;
                timer = true;
                
                Debug.Log("Nice!");
            }
            if (canBePressed && great == true)
            {
                moving = false;
                timer = true;

                Debug.Log("Great!");
            }
            if (canBePressed && perfect == true)
            {
                moving = false;
                timer = true;

                Debug.Log("Perfect!");
            }
        }
        if (Input.GetKeyUp(keyToPress))
        {
            moving = true;
            time = 3;
            canBePressed = false;
            nice = false;
            great = false;
            perfect = false;
        }

        if (Input.GetKeyDown(keyToPress2))
        {
            if (canBePressed && nice == true)
            {
                moving = false;
                timer = true;

                Debug.Log("Nice!");
            }
            if (canBePressed && great == true)
            {
                moving = false;
                timer = true;

                Debug.Log("Great!");
            }
            if (canBePressed && perfect == true)
            {
                moving = false;
                timer = true;

                Debug.Log("Perfect!");
            }
        }
        if (Input.GetKeyUp(keyToPress2))
        {
            moving = true;
            time = 3;
            canBePressed = false;
            nice = false;
            great = false;
            perfect = false;
        }

        if (transform.position.x <= threshold && fail == false)
        {
            GameObject.Find("Button1").GetComponent<Score>().multiplier = 1;
            GameObject.Find("Button1").GetComponent<Score>().hit = 0;
            GameObject.Find("vampire_neutral").GetComponent<Health>().heart -= 2;
            fail = true;
        }

        if (timer)
        {
            time -= Time.deltaTime;
        }

        if(time <= 0 && nice == true)
        {
            gameObject.SetActive(false);
            if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 1)
            {
                GameObject.Find("Button1").GetComponent<Score>().victim += 1;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 1;
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
            if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
            {
                GameObject.Find("Button1").GetComponent<Score>().victim += 6;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 6;
            }

            GameObject.Find("Button1").GetComponent<Score>().hit++;
            GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
        }
        if (time <= 0 && great == true)
        {
            gameObject.SetActive(false);
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
            if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
            {
                GameObject.Find("Button1").GetComponent<Score>().victim += 12;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 12;
            }

            GameObject.Find("Button1").GetComponent<Score>().hit++;
            GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
        }
        if (time <= 0 && perfect == true)
        {
            gameObject.SetActive(false);
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
            if (GameObject.Find("Button1").GetComponent<Score>().multiplier == 6)
            {
                GameObject.Find("Button1").GetComponent<Score>().victim += 18;
                GameObject.Find("vampire_neutral").GetComponent<Gameplay>().score += 18;
            }

            GameObject.Find("Button1").GetComponent<Score>().hit++;
            GameObject.Find("vampire_neutral").GetComponent<Gameplay>().hits++;
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