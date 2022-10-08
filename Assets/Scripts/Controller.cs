
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq.Expressions;

public class Controller : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;
    public GameObject playerDead;
    public GameObject plataformasIniciales;
    public GameObject imageCoins;
    public GameObject ButtomJetpack;

    public static float deadTime = 0;
    public static int numeroMonedas;
    Animator anim;

    public static bool isStarted = false;
    public static float topScore = 0.0f;
    private bool resetJetpack;

    public Text scoreText;
    public Text startText;
    public GameObject tutorialAnimation;
    public Text coins;
    public Text numeroTotalMonedas;
    public Text nuneroTotalJetpacks;
    public Text maxPoints;

    private int numJecpaks;
    private int saveCoins;
    private int saveJetpacks;

    private float countResetJetpack;
    private bool isDeadShop;

    private AudioSource sounds;
    public AudioClip SoundDead;
    private int limitadorSonidoDeMuerte;
    private GameObject interfazJuego;
    private SpriteRenderer spriteRenderJugador;
    //Pausar Juego


    private float VolumenAudio;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        rb2d.gravityScale = 0;
        rb2d.velocity = Vector3.zero;
        interfazJuego = GameObject.Find("AnyBottons");
        saveCoins = PlayerPrefs.GetInt("SaveCoins");
        saveJetpacks = PlayerPrefs.GetInt("SaveJetpacks");
        spriteRenderJugador = gameObject.GetComponent<SpriteRenderer>();
        isDeadShop = false;
        maxPoints.text = "Mejor Puntuacion: " + GetMaxScore().ToString();
        sounds = GetComponent<AudioSource>();
        //Mutear audio 

     
    }

    void Update()
    {
        Debug.Log(VolumenAudio = PlayerPrefs.GetFloat("MuteAudio"));
       



        if (resetJetpack)
        {
            countResetJetpack += Time.deltaTime;

            if(countResetJetpack > 2f)
            {
                countResetJetpack = 0;
                resetJetpack = false;

            }
            
            anim.SetBool("Jetpack", true);
            
        }
        else
        {
            anim.SetBool("Jetpack", false);
        }
 
        if (Input.GetKeyDown("e"))
        {
            saveJetpacks += 1;
            PlayerPrefs.SetInt("SaveJetpacks", saveJetpacks);
        }

            if (Input.GetKeyDown(KeyCode.Mouse0) && isStarted == false)
        {

            isStarted = true;
            startText.gameObject.SetActive(false);
            tutorialAnimation.SetActive(false);
            rb2d.gravityScale = 5f;
            deadTime = 0f;


        }

        deadTime += Time.deltaTime;

        if (deadTime > 4f && isStarted == true && isDeadShop == false)
        {
            PlayerIsDead();
        }

        if (isStarted == true)
        {

            if (moveInput < 0)
            {
  
                if (resetJetpack)
                {
                    this.GetComponent<SpriteRenderer>().flipX = false;
                }
                else
                {
                    this.GetComponent<SpriteRenderer>().flipX = true;
                }
            }
            else
            {

                if (resetJetpack)
                {
                    this.GetComponent<SpriteRenderer>().flipX = true;
                }
                else
                {

                    this.GetComponent<SpriteRenderer>().flipX = false;
                }

            }

            if (rb2d.velocity.y > 0 && transform.position.y > topScore)

            {

                topScore = transform.position.y;
                if(topScore > GetMaxScore())
                {
                    maxPoints.text = "Mejor Puntuacion: " + GetMaxScore().ToString();
                    SaveScore(topScore);
                    Debug.Log("Felicidade¡¡ Superaste tu record");
                }

            }

            scoreText.text = "Altura:" + Mathf.Round(topScore).ToString();

        }

        numeroTotalMonedas.text = PlayerPrefs.GetInt("SaveCoins", 0).ToString();
        nuneroTotalJetpacks.text = PlayerPrefs.GetInt("SaveJetpacks", 0).ToString();

       
    }

    void FixedUpdate()
    {
        coins.text = numeroMonedas.ToString();

        if (isStarted == true)
        {
           

            moveInput = Input.acceleration.x*300f*Time.deltaTime;
           // moveInput = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
            

        }
    }
    //Funcion que se ejecuta cuando el jugador esta muerto
    public void PlayerIsDead()
    {
       
        if (limitadorSonidoDeMuerte < 1)
        {
            print("Se Reproduce La Musica De Muerte");
            playerDead.SetActive(true);
            Time.timeScale = 0;
            saveCoins += numeroMonedas;
            PlayerPrefs.SetInt("SaveCoins", saveCoins);
            numeroMonedas = 0;
            ButtomJetpack.SetActive(false);
            sounds.clip = SoundDead;
            sounds.Play();
            sounds.loop = false;
            limitadorSonidoDeMuerte = limitadorSonidoDeMuerte + 1;
            interfazJuego.SetActive(false);
            spriteRenderJugador.enabled = false;
        }
       

    }
    //Funcion con la que reinicio el juego 
    public void Reiniciar()
    {
       
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        Plataforms.countPlataforms = 0;
        isStarted = false;
        topScore = 0;
        numeroMonedas = 0;
        limitadorSonidoDeMuerte = 0;
        interfazJuego.SetActive(true);
        spriteRenderJugador.enabled = true;
     
        //Pausar juego
    }
    // Funcion con la que salgo a el menu principal del juego 
    public void Salir()
    {

        SceneManager.LoadScene("Intro Game");

        /*Time.timeScale = 1;
        topScore = 0;
        numeroMonedas = 0;
        interfazJuego.SetActive(true);
        spriteRenderJugador.enabled = true;
        playerDead.SetActive(false);*/

        Plataforms.countPlataforms = 0;
        isStarted = false;
        topScore = 0;
        numeroMonedas = 0;
        limitadorSonidoDeMuerte = 0;
        interfazJuego.SetActive(true);
        spriteRenderJugador.enabled = true;
       




    }

    public void Logros()
    {
        SceneManager.LoadScene("Logros");
    
    }

   

    public int GetMaxScore()
    {
        return PlayerPrefs.GetInt("Max Points", 0);
    }
    

    public void SaveScore (float CurrentPoints)
    {
        PlayerPrefs.SetInt("Max Points",(int)CurrentPoints);
       
    }    
    public void HeBuyAJectpakc()
    {
        if (PlayerPrefs.GetInt("SaveCoins") > 50)
        {
            saveCoins = saveCoins - 50;
            PlayerPrefs.SetInt("SaveCoins", saveCoins);
            saveJetpacks += 1;
            PlayerPrefs.SetInt("SaveJetpacks", saveJetpacks);
        }
        else
        {
            print("No hay suficiente dinero");
        }
        
    }

    public void JetpackActive()
    {
        if (PlayerPrefs.GetInt("SaveJetpacks") > 0 &&  resetJetpack == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 2200f);
            deadTime = 0;
            saveJetpacks -= 1;
            resetJetpack = true;
            PlayerPrefs.SetInt("SaveJetpacks", saveJetpacks);
            AudioManager.activeSoundFour = true;
           

        }
    }

    public void tienda()
    {
        isDeadShop = true;
        playerDead.SetActive(false);
        imageCoins.SetActive(false);

    }
}
