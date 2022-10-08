using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    // Start is called before the first frame update
    private float VolumenAudio;
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        VolumenAudio = PlayerPrefs.GetFloat("MuteAudio");
        AudioListener.volume = VolumenAudio - AudioListener.volume;
    }


    public void ActiveSound()
    {

        PlayerPrefs.SetFloat("MuteAudio", 1);
       
    }

    public void ActiveOffSound()
    {
        PlayerPrefs.SetFloat("MuteAudio", 0);
    }
}
