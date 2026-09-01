using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class score_count : MonoBehaviour
{
    public static int score;
    public Text scoretext;
    public sound sm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("counter"))
        {
            
            score++;
            sm.play_pointt();
            scoretext.text = score.ToString();
        }
   
    }
}
