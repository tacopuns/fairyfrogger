using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip collectibleSound;
    public AudioClip winClip;
    public AudioClip loseClip;
    public AudioClip hitSound;
    public GameObject points;
    public Text ScoreText;
    public Text CageText;
    public int Score = 0;
    public bool gameOver = false;
    public GameObject WinPanel;
    public GameObject LosePanel;
     public int Cage = 0;
    public int currentHealth = 3;
    public Text HealthText;
    public static int level;
    float horizontal;
    float vertical;
    Rigidbody2D rigidbody2d;

    Animator animator;
    
    private Rigidbody2D rb;
    public float runSpeed = 20.0f;
    private Vector2 moveVelocity;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        HealthText.text = "Lives:" + currentHealth.ToString();
        CageText.text = "Cage:" + Cage.ToString();
        LosePanel.SetActive(false);
        WinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2d.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

        {   
        horizontal = Input.GetAxisRaw("Horizontal");
         vertical = Input.GetAxisRaw("Vertical"); 
        
        
       }
     if (currentHealth < 1)
        {
           audioSource.PlayOneShot (loseClip,1);
           LosePanel.SetActive(true);
           gameOver = true;
           
		}
            
        if (Score == 1) 
                 {
                    audioSource.PlayOneShot(collectibleSound, 1);
                    SceneManager.LoadScene("Lvl2");
                    level++;
                 }
        if (Cage == 1)
           {
                    audioSource.PlayOneShot(winClip, 1);
                    WinPanel.SetActive(true);
                    gameOver = true;
            
            }
    
    
      if (Input.GetKeyDown(KeyCode.Escape))
    
     {
        Application.Quit();
     }

      if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
    }
    public void ChangeScore (int scoreamount)
    { 
       Score = Score + scoreamount;
       ScoreText.text = "Score: " + Score.ToString();
       
    }
     public void Damage()
   {
     currentHealth -= 1;
     HealthText.text = "Lives: " + currentHealth.ToString();
     audioSource.PlayOneShot(hitSound, 1);
    }
     public void Changecage (int cageamount)
    { 
       Cage = Cage + cageamount;
       CageText.text = "Cage: " + Cage.ToString();
       
    }
}

