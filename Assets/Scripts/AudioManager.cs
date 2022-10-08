using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static bool activeSoundOne;
    public static bool activeSoundTwo;
    public static bool activeSoundThree;
    public static bool activeSoundFour;


    public GameObject sonidoSaltoNormal;
    public GameObject sonidoSaltoPotente;
    public GameObject sonidoMoneda;
    public GameObject sonidoCohete;
    

    // Update is called once per frame
    void Update()
    {
        if (activeSoundOne)
        {
            Instantiate(sonidoSaltoNormal);
            activeSoundOne = false;
         
        }
        if (activeSoundTwo) 
        {
            Instantiate(sonidoSaltoPotente);
            activeSoundTwo = false;
            
        }
        if (activeSoundThree)  {Instantiate(sonidoMoneda); activeSoundThree = false;}

        if (activeSoundFour) { Instantiate(sonidoCohete); activeSoundFour = false; }
       

    }
}
