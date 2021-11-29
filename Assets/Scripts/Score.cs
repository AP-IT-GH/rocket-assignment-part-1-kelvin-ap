using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int Count;
    private Rigidbody Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = this.GetComponent<Rigidbody>();
        Count = 0;
        UpdateScoreText();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        UpdateScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            Count++;
        }

        if (other.gameObject.tag == "Bad Coin")
        {
            other.gameObject.SetActive(false);
            Count--;
        }
    }

    void UpdateScoreText()
    {
        ScoreText.text = "Score: " + Count;
    }
}
