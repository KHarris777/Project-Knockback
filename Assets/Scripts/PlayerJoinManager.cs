using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoinManager : MonoBehaviour
{
    public GameObject CameraBeforeJoin;

    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private GameObject creditsPanel;

    public void OnPlayerJoin()
    {
        CameraBeforeJoin.SetActive(false);
        AudioManager.Instance.Stop("LevelTheme");
    }

    public void Quit()
    {
        Debug.Log("quiting game");
        Application.Quit();
    }

    public void CreditsMenuOpen()
    {
        creditsPanel.SetActive(true);
    }

    public void CreditsMenuClose()
    {
        creditsPanel.SetActive(false);
    }

    public void ControlsMenuOpen()
    {
        controlsPanel.SetActive(true);
    }

    public void ControlsMenuClose()
    {
        controlsPanel.SetActive(false);
    }
}
