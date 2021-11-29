using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject CheckPointCanvas;

    public float damageAmount = 10.0f;
    public bool damageOnTrigger = true;
    public bool damageOnCollision = false;
    public bool continuousDamage = false;
    public float continuousTimeBetweenHits = 0;

    public bool destroySelfOnImpact = false;    // variables dealing with exploding on impact (area of effect)
    public float delayBeforeDestroy = 0.0f;
    public GameObject explosionPrefab;

    private float savedTime = 0;
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentSceneName = currentScene.name;

        if (currentSceneName == "Rocket1")
        {
            SceneManager.LoadScene("Rocket2");
        }

        else if (currentSceneName == "Rocket2")
        {
            gameState = GameStates.GameOver;
            MainCanvas.SetActive(false);
            CheckPointCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
