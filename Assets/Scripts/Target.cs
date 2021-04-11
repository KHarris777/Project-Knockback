using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class Target : MonoBehaviour
{
    public float health = 20f;
    [SerializeField]private Transform player;
    [SerializeField] private Transform[] respawnPoints;
    private int index;

    public GameObject playerModel;
    public GameObject gunModel;

    public GameObject playerDeathPanel;
    //public GameObject playerHUD;

    public Text healthLabel;
    public GameObject lifeWarning;

    [SerializeField] private GameObject arm;

    private int deathCount = 0;
    public Text deathsLabel;
    private void OnEnable()
    {
        index = Random.Range(0, respawnPoints.Length);
        player.transform.position = respawnPoints[index].transform.position;
    }

    private void Update()
    {
        healthLabel.text = health.ToString();

        if (health <= 10f)
        {
            lifeWarning.SetActive(true);
        }

        deathsLabel.text = deathCount.ToString();
       
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

    public void TakeMeleeDamage(float amount)
    {
        Debug.Log("hit");
        AudioManager.Instance.Play("Hit");

        health -= amount;
        if (health <= 0f)
        {
            StartCoroutine(Death());
        }
    }

    public IEnumerator Death()
    {
        Debug.Log("enemy down");
        ++deathCount;
        AudioManager.Instance.Play("Death");
        gameObject.GetComponent<PlayerInput>().hasFired = true;
        gameObject.GetComponent<PlayerInput>().hasPunched = true;
        playerDeathPanel.SetActive(true);
        playerModel.SetActive(false);
        gunModel.SetActive(false);
        arm.SetActive(false);
        index = Random.Range(0, respawnPoints.Length);
        yield return new WaitForSeconds(2f);
        Respawn();
    }

    void Respawn()
    {
        health = 20f;
        playerModel.SetActive(true);
        gunModel.SetActive(true);
        player.transform.position = respawnPoints[index].transform.position;
        Physics.SyncTransforms();
        playerDeathPanel.SetActive(false);
        lifeWarning.SetActive(false);
        arm.SetActive(true);
        gameObject.GetComponent<PlayerInput>().hasFired = false;
        gameObject.GetComponent<PlayerInput>().hasPunched = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillBox"))
        {
            StartCoroutine(Death());
        }

        if (other.gameObject.tag == "MovingPlatform")
        {
            player.transform.parent = other.gameObject.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }
}
