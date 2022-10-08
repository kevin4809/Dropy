using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float destroyGameobject;
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            Debug.Log("GameObject2 collided with " + col.name);
            AudioManager.activeSoundThree = true;
            Destroy(gameObject);
            Controller.numeroMonedas = Controller.numeroMonedas + 1;
        }
        
    }

    public void Update()
    {
        destroyGameobject += Time.deltaTime;

        if(destroyGameobject >=4f)
        {
            Destroy(gameObject);
        }
    }


}


