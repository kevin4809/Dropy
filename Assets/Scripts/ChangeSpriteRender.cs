using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteRender : MonoBehaviour
{
    private SpriteRenderer spriteR;
    public Sprite[] sprites;
    private float count;
    private int countSprites;
    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame  
    void Update()
    {


        if (Controller.isStarted)
        {
            StartGamee();
        }

        spriteR.sprite = sprites[countSprites];
        
    }

    private void StartGamee()
    {
        count += Time.deltaTime;
        if (count > 30)
        {
            if (countSprites <= 5)
            {

                countSprites = countSprites + 1;
                count = 0;
                print("Las palataformas iniciales cambiaron");
            }
            else
            {
                countSprites = 0;
                count = 0;
            }

        }
    }
}
