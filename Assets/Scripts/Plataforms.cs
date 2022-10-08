using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plataforms : MonoBehaviour
{

    public GameObject player;
    public GameObject platformPrefab2;
    public GameObject springPrefab;
    public GameObject myPlat;
    public GameObject coin;
    public static int countPlataforms = 0; 
    private float count;
    

    public void Update()
    {

        if (Controller.isStarted)
        {
            StartGamee();
           
        }
       

    }

    private void StartGamee()
    {
        count += Time.deltaTime;
        if (count > 30)
        {
            if (countPlataforms < 5)
            {
                countPlataforms = countPlataforms + 1;
                count = 0;
                print("Cambio de Plataforma-");
            }
            if (countPlataforms >= 5)
            {

                countPlataforms = 0;
                count = 0;

            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name.StartsWith("Platform"))
        {

            if (Random.Range(1, 7) == 1)
            {
                float moveY = Random.Range(0.2f, 1f);
                float moveX = Random.Range(-0.5f, 11.5f);
                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(moveX, player.transform.position.y + (14 + moveY)), Quaternion.identity);

                if(Random.Range(1,4) == 1)
                {
                    Instantiate(coin, new Vector2(moveX, player.transform.position.y + (15 + moveY)), Quaternion.identity);
                }
            } else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-0.5f, 11.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }

        } else if(collision.gameObject.name.StartsWith("Spring")) //Spring
        {

            if (Random.Range(1, 7) == 1)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-0.5f, 11.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }
            else
            {
               
                float moveY = Random.Range(0.2f, 1.0f);
                float movey2 = Random.Range(-0.5f, 11.5f);
                Destroy(collision.gameObject);
                Instantiate(platformPrefab2, new Vector2(movey2, player.transform.position.y + (14 + moveY)), Quaternion.identity);
                
                Instantiate(coin, new Vector2(movey2, player.transform.position.y + (15 + moveY)), Quaternion.identity);
             



            }

        }


       // Destroy(collision.gameObject);


       //  myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 0.8f))), Quaternion.identity);
       //  Debug.Log("Created Normal");

        //    if (Random.Range(1, 6) == 1)
       //       {

        //       Instantiate(springPrefab, new Vector2(myPlat.transform.position.x, myPlat.transform.position.y + 0.4f), Quaternion.identity);

        //   }
    }

}
