using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int victim = 0;
    public TMP_Text scoreText;
    public TMP_Text multiplierText;
    // int multiplier = 1;
    // const int hitInterval = 10;
    // Start is called before the first frame update
    void Start()
    {
        // multiplier = hitInterval;
        scoreText.text = "Score: " + victim.ToString();
       // multiplierText.text = "Multiplier: " + multiplier.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Finish")
        {
            victim++;
            scoreText.text = "Score: " + victim.ToString();
            GameObject.Find("vampire_neutral").GetComponent<Timer>().hits++;
        }
           /*    if (victim >= multiplier && multiplier == 1)
              {
                  victim++;
                   multiplierText.text = "Multiplier: " + multiplier.ToString();
                   multiplier += hitInterval;
              }
               if (victim >= multiplier && multiplier == 2)
                {
                  victim++;
                  multiplierText.text = "Multiplier: " + multiplier.ToString();
                   multiplier += hitInterval;
               }
               if (victim >= multiplier && multiplier == 3)
              {
                   victim++;
                  multiplierText.text = "Multiplier: " + multiplier.ToString();
                   multiplier += hitInterval;
               }
            if (victim >= multiplier && multiplier == 4)
            {
                victim++;
                multiplierText.text = "Multiplier: " + multiplier.ToString();
                multiplier += hitInterval;
            }
*/
        
    }
}
