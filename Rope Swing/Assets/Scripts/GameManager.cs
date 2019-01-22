using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {
    [Header("Player Properties")]
    public GameObject player;
    public int coins, highScore;

    [Header("HUD Properties")]
    public GameObject coinsData;
    public GameObject highScoreData;
    public TextMeshProUGUI coinsText, highScoreText;

    [Header("Game Over UI Properties")]
    public GameObject gameOverUI;
    public TextMeshProUGUI totalCoinsText, totalScoreText;
    public Button mainMenuButton, retryButton;

    bool isDead = false;

    private void Awake() {
        //coins = 0;
        //highScore = 0;
        DisplayHUD();
    }

    private void Update() {
        if (player.transform.position.y <= -2.5f) { 
            isDead = true;
        }
        Debug.Log("Is Dead: " + isDead);

        if (isDead) {
            GameOver();
        }
    }

    void DisplayHUD() {
        coinsText.text = coins.ToString();
        highScoreText.text = highScore.ToString() + "m";
        gameOverUI.SetActive(false);
    }

    void HideHUD() {
        coinsData.SetActive(false);
        highScoreData.SetActive(false);
    }

    public void MainMenu() {

    }

    public void Retry() {

    }

    void GameOver() {
        HideHUD();
        gameOverUI.SetActive(true);
        totalCoinsText.text = coins.ToString();
        totalScoreText.text = highScore.ToString() + "m";
    }

}
