using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenzyMode : MonoBehaviour
{
    public int hitsInARow;
    public int frenzyLine;
    public bool frenzyMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hitsInARow >= frenzyLine)
        {
            frenzyMode = true;
        }

        if(hitsInARow <= frenzyLine)
        {
            frenzyMode = false;
        }
    }
}
