using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private int actualPlataform;
    private SpriteRenderer spriteR;
    public Sprite[] sprites = new Sprite[4];
    private void Start()
    {

        spriteR = gameObject.GetComponent<SpriteRenderer>();
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
          
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 620f);
            collision.gameObject.GetComponent<Animator>().SetTrigger("Ist");
            Controller.deadTime = 0;
            AudioManager.activeSoundOne = true;
            
        }

    }



    private void Update()
    {
        actualPlataform = Plataforms.countPlataforms;
        spriteR.sprite = sprites[actualPlataform];

       
    }

}
   

