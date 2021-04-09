using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoinManager : MonoBehaviour
{
    public GameObject CameraBeforeJoin;

    public void OnPlayerJoin()
    {
        CameraBeforeJoin.SetActive(false);
        AudioManager.Instance.Stop("LevelTheme");
    }
}
