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

    private int livesCount = 5;
    public Text livesLabel;
    private bool alive = true;

    [SerializeField] private GameObject elimPanel;
    [SerializeField] private GameObject winPanel;
    
    private bool winner = false;
    public float timeRemaining = 10f;
    public Text countdownLabel;

    public static bool lastManStanding = false;

    private void OnEnable()
    {
        index = Random.Range(0, respawnPoints.Length);
        player.transform.position = respawnPoints[index].transform.position;

        alive = true;
    }

    private void Update()
    {
        healthLabel.text = health.ToString();

        if (health <= 10f)
        {
            lifeWarning.SetActive(true);
        }

        livesLabel.text = livesCount.ToString();

       
       
        if (lastManStanding == true && alive == true)
        {
            Winner();
        }

        if(winner == true)
        {
            if (timeRemaining > 0)
            {
                countdownLabel.text = timeRemaining.ToString();
                timeRemaining -= Time.deltaTime;
            }
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
        --livesCount;
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
        if (livesCount <= 0)
        {
            Eliminated();
        }

        if(livesCount > 0)
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
        
    }

   void Eliminated()
    {
        GameManager.Instance.playerEliminated();
        alive = false;
        elimPanel.SetActive(true);
        playerDeathPanel.SetActive(false);
        gameObject.GetComponent<PlayerInput>().hasFired = true;
        gameObject.GetComponent<PlayerInput>().hasPunched = true;
        playerModel.SetActive(false);
        gunModel.SetActive(false);
        arm.SetActive(false);
    }

    public void Winner()
    {
        winner = true;
        winPanel.SetActive(true);
        StartCoroutine(Restart());
        lastManStanding = false;

    }
    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(10f);
        GameManager.Instance.ReloadScene();       
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
