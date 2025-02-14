using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManeger : MonoBehaviour
{
    [SerializeField] TMP_Text scoreCount;
    [SerializeField] Button RestartGame;
    [SerializeField] Button StartGame;
    [SerializeField] bool Alive = true;
    public int scoreUp = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GameLose()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void GS()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void score()
    {
        scoreUp++;
        scoreCount.text = scoreUp.ToString();
    }

}
