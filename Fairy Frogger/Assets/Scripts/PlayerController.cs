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



    public bool gameOver = false;
    public Text WinText;

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
        HealthText.text = currentHealth.ToString();

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
           audioSource.PlayOneShot (loseClip,2);
                    WinText.text = "You Lose! Press R to restart.";
                    gameOver = true;
                    Destroy(gameObject);

		}

    
    if (Input.GetKey(KeyCode.R))
     {
        if(gameOver == true)
    
      {
        SceneManager.LoadScene("One");
        }
    
      if (Input.GetKey("escape"))
    
     {
        Application.Quit();
     }
    
    }

   
   }
}
