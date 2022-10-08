using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void EmpezarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void Logros()
    {
        SceneManager.LoadScene("Logros");
    }

    public void Regresar()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        Plataforms.countPlataforms = 0;

  
     
    }
}
