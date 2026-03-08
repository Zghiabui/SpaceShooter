using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI; 
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    public GameObject gameWinUI;

    private void Start()
    {
        gameOverUI.SetActive(false); 
        playerHealth.onDead += OnGameOver; 
    }

    private void Update()
    {
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin(); 
        }
    }
    private void OnGameOver() 
    {
        gameOverUI.SetActive(true); // Bật chữ Game Over 
        bgMusic.SetActive(false);   // Tắt nhạc nền đi cho buồn 
    }

 
    private void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgMusic.SetActive(false);
        playerHealth.gameObject.SetActive(false);
    }

}
