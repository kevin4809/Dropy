using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PausarJuego : MonoBehaviour
{
    public Image botonPausa;
    public Image botonJugar;
    private AudioSource cancion;
    private void Start()
    {
        cancion = gameObject.GetComponent<AudioSource>();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        botonPausa.enabled = false;
        botonJugar.enabled = true;
        cancion.Pause();
    }

    public void StarGame()
    {
        Time.timeScale = 1;
        botonPausa.enabled = true;
        botonJugar.enabled = false;
        cancion.Play();
    }
}
