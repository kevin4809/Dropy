using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParamosPosition : MonoBehaviour
{
    public Text texto;
    public Text texto2;
    public GameObject activarDesactivar;
    private int count;
    public static int contadorParamosTotales;
    public float timer;
    private bool restText;
    private string[] paramos = { "Paramo del cerro pintado", "Paramo de Belmira", "Paramo de Sonson", "Paramo el Tablazo ", "Paramo Tatama", "Paramo de Cruz Verde", "Paramo de Guerrero", "Paramo de Chili", "Paramo de pisba", "Paramo de Oceta", "Paramo del Sol", "Paramo de Chingaza", "Paramo las hermosas", "Paramo de Saturban", "Paramo del Almorzadero", " Paramo de Sumapaz" };
    private int[] alturaParamos = { 200, 400, 800, 1200, 1500, 1800, 2100, 2400, 2600, 2900, 3200, 3500, 3800, 4100, 4400, 4700 };

    private void Start()
    {
        activarDesactivar.SetActive(false);
        contadorParamosTotales = 0;
    }
    private void Update()
    {
        if (Controller.topScore > alturaParamos[count])
        {
            texto2.text = "Felicitaciones has descubierto: " + paramos[count].ToString();
            count = count + 1;
            contadorParamosTotales = contadorParamosTotales + 1;
            if(PlayerPrefs.GetInt("contadorParamosTotales") < contadorParamosTotales)
            {
               
                PlayerPrefs.SetInt("contadorParamosTotales", contadorParamosTotales);
            }
         
            activarDesactivar.SetActive(true);
            restText = true;
            AlturaParamos(count);


        }
        else
        {
            AlturaParamos(count);
        }

        if (restText)
        {
            timer += Time.deltaTime;
            if (timer > 2f)
            {
                activarDesactivar.SetActive(false);
                timer = 0;
                restText = false;
            }
        }

        if (PlayerPrefs.GetInt("contadorParamosTotales", 0) == 1)
        {
            Debug.Log("SE ACTIVARIA EL PRIMER LOGRO");
        }




    }

    


    private void AlturaParamos(int myIndex)
    {
        texto.text = paramos[myIndex].ToString();
    }
}
