using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class Target : MonoBehaviour
{
    public float health = 20f;
    [SerializeField]private Transform player;
    [SerializeField] private Transform respawnPoint;

    public GameObject playerModel;
    public GameObject gunModel;

    public GameObject playerDeathPanel;
    //public GameObject playerHUD;

    public Text healthLabel;
    public GameObject lifeWarning;

    private void Update()
    {
        healthLabel.text = health.ToString();

        if (health <= 10f)
        {
            lifeWarning.SetActive(true);
        }
    }

    public void TakeDamage (float amount)
    {
        Debug.Log("hit");
        
        health -= amount;
        if (health <= 0f)
        {
            StartCoroutine(Death());
        }
    }

    public IEnumerator Death()
    {
        Debug.Log("enemy down");
        gameObject.GetComponent<PlayerInput>().hasFired = true;
        playerDeathPanel.SetActive(true);
        playerModel.SetActive(false);
        gunModel.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        Respawn();
    }

    void Respawn()
    {
        health = 20f;
        playerModel.SetActive(true);
        gunModel.SetActive(true);
        player.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms();
        playerDeathPanel.SetActive(false);
        lifeWarning.SetActive(false);
        gameObject.GetComponent<PlayerInput>().hasFired = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillBox"))
        {
            StartCoroutine(Death());
        }
    }
}
