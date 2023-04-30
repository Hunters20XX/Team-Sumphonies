using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class PressStart : MonoBehaviour
{
    public GameObject startText;
    public GameObject leftText;
    // Start is called before the first frame update
    void Start()
    {
        startText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            startText.SetActive(true);
            leftText.SetActive(false);
        }
    }
}
