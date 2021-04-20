using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int eliminatedPlayers = 0;
    public int totalPlayers = 0;

    private void Update()
    {
        totalPlayers = GameObject.FindGameObjectsWithTag("Player").Length;

        if( totalPlayers == 2)
        {
            if(eliminatedPlayers == 1)
            {
                GameOver();
            }
        }

        if (totalPlayers == 3)
        {
            if (eliminatedPlayers == 2)
            {
                GameOver();
            }
        }

        if (totalPlayers == 4)
        {
            if (eliminatedPlayers == 3)
            {
                GameOver();
            }
        }
    }

    public void PlayerEliminated()
    {
        ++eliminatedPlayers;
    }

    public void GameOver()
    {
        Target.lastManStanding = true;
    }

    public void ReloadScene()
    {
        eliminatedPlayers = 0;
        totalPlayers = 0;
        AudioManager.Instance.Play("LevelTheme");
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

}
