using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerManager : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;

    public static int noOfCoins;
    public Text CoinsText;
    // Start is called before the first frame update
    public GameObject[] wheels;

  

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        noOfCoins = 0;
        AdManager.instance.RequestInterstital();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        CoinsText.text = "Coins: " + noOfCoins;

        if(SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
        if(Random.Range(0,3) == 0)
        {
            AdManager.instance.ShowInterstital();
        }
      
    }
}
