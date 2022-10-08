using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoSonido : MonoBehaviour
{

    public float tiempoSonido;
    private AudioSource rocket;
    // Start is called before the first frame update
    void Start()
    {
        rocket = gameObject.GetComponent<AudioSource>();
        Destroy(gameObject, tiempoSonido);
    }

    private void Update()
    {
        if(Time.timeScale == 0)
        {
            rocket.mute = true;
        }
        else
        {
            rocket.mute = false;
        }
    }
}
