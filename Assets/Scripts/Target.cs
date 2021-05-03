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

    public GameObject bluePlayerModel;
    public GameObject redPlayerModel;
    public GameObject blueGunModel;
    public GameObject redGunModel;

    public GameObject playerDeathPanel;
    //public GameObject playerHUD;

    public Text healthLabel;

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
    private bool isDead = false;

    [SerializeField] private GameObject fullHpBat;
    [SerializeField] private GameObject halfHpBat;
    [SerializeField] private GameObject EmptyHpBat;

    private void OnEnable()
    {
        index = Random.Range(0, respawnPoints.Length);
        player.transform.position = respawnPoints[index].transform.position;

        alive = true;
    }

    private void Update()
    {
        healthLabel.text = health.ToString();

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

        blueGunModel.SetActive(false);
        bluePlayerModel.SetActive(false);
        redGunModel.SetActive(true);
        redPlayerModel.SetActive(true);
        
        fullHpBat.SetActive(false);
        halfHpBat.SetActive(true);


            health -= amount;
        
        if (health <= 0f)
        {
            if(isDead == false)
            {
                isDead = true;
                StartCoroutine(Death());
            }
           
        }
    }

    public void TakeMeleeDamage(float amount)
    {
        Debug.Log("hit");
        AudioManager.Instance.Play("Hit");

        blueGunModel.SetActive(false);
        bluePlayerModel.SetActive(false);
        redGunModel.SetActive(false);
        redPlayerModel.SetActive(false);

        if (isDead == false)
        {
            health -= amount;
        }

        if (health <= 0f)
        {
            if (isDead == false)
            {
                isDead = true;
                StartCoroutine(Death());
            }

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
        redPlayerModel.SetActive(false);
        redGunModel.SetActive(false);
        arm.SetActive(false);
        fullHpBat.SetActive(false);
        halfHpBat.SetActive(false);
        EmptyHpBat.SetActive(true);
        index = Random.Range(0, respawnPoints.Length);
        yield return new WaitForSeconds(2f);
        isDead = false;
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        if(livesCount > 0)
        { 
            health = 20f;
            bluePlayerModel.SetActive(true);
            blueGunModel.SetActive(true);
            player.transform.position = respawnPoints[index].transform.position;
            Physics.SyncTransforms();
            playerDeathPanel.SetActive(false);
            arm.SetActive(true);
            EmptyHpBat.SetActive(false);
            fullHpBat.SetActive(true);
            yield return new WaitForSeconds(0.45f);
            gameObject.GetComponent<PlayerInput>().hasFired = false;
            gameObject.GetComponent<PlayerInput>().hasPunched = false;
        }
        
        if (livesCount == 0)
        {
            Eliminated();
        }
    }

   void Eliminated()
    {
        GameManager.Instance.PlayerEliminated();
        player.transform.position = respawnPoints[index].transform.position;
        Physics.SyncTransforms();
        alive = false;
        elimPanel.SetActive(true);
        playerDeathPanel.SetActive(false);
        gameObject.GetComponent<PlayerInput>().hasFired = true;
        gameObject.GetComponent<PlayerInput>().hasPunched = true;
        redPlayerModel.SetActive(false);
        redGunModel.SetActive(false);
        arm.SetActive(false);
        gameObject.GetComponent<PlayerInput>().speed = 0f;
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
