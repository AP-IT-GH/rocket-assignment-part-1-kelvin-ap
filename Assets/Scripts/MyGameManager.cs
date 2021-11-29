using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;

    private Health healtPlayer;

    public enum GameStates
    {
        Playing,
        Complete,
        GameOver
    }
    public GameStates gameState = GameStates.Playing;


    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        healtPlayer = Player.GetComponent<Health>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //State Machine of the game
        switch (gameState)
        {
            case GameStates.Playing:
                if (!healtPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                break;
        }
    }

}
