using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnCollisionEnter(Collision colider) 
    {
        if (colider.gameObject.CompareTag("LixeiroVid"))
        {
            score ++;
        }

        else
        {
            score = score + 0;
        }
    }
}
