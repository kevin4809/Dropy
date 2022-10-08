using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagenesLogros : MonoBehaviour
{
    private Image one;
    private Image two;
    private Image three;
    private Image four;
    private Image five;
    private Image six;
    private Image seven;
    private Image eight;
    private Image nine;
    private Image ten;
    private Image eleven;
    private Image twelve;
    private Image thirteen;
    private Image fourteen;
    private Image fivetenn;
    private Image sixtenn;


    private Button one1;
    private Button two1;
    private Button three1;
    private Button four1;
    private Button five1;
    private Button six1;
    private Button seven1;
    private Button eight1;
    private Button nine1;
    private Button ten1;
    private Button eleven1;
    private Button twelve1;
    private Button thirteen1;
    private Button fourteen1;
    private Button fivetenn1;
    private Button sixtenn1;
    public float prueba;
    // Start is called before the first frame update


    void Start()
    {

        one = GameObject.Find("1").GetComponent<Image>();
        two = GameObject.Find("2").GetComponent<Image>();
        three = GameObject.Find("3").GetComponent<Image>();
        four = GameObject.Find("4").GetComponent<Image>();
        five = GameObject.Find("5").GetComponent<Image>();
        six = GameObject.Find("6").GetComponent<Image>();
        seven = GameObject.Find("7").GetComponent<Image>();
        eight = GameObject.Find("8").GetComponent<Image>();
        nine = GameObject.Find("9").GetComponent<Image>();
        ten = GameObject.Find("10").GetComponent<Image>();
        eleven = GameObject.Find("11").GetComponent<Image>();
        twelve = GameObject.Find("12").GetComponent<Image>();
        thirteen = GameObject.Find("13").GetComponent<Image>();
        fourteen = GameObject.Find("14").GetComponent<Image>();
        fivetenn = GameObject.Find("15").GetComponent<Image>();
        sixtenn = GameObject.Find("16").GetComponent<Image>();

        one1 = GameObject.Find("1").GetComponent<Button>();
        two1 = GameObject.Find("2").GetComponent<Button>();
        three1 = GameObject.Find("3").GetComponent<Button>();
        four1 = GameObject.Find("4").GetComponent<Button>();
        five1 = GameObject.Find("5").GetComponent<Button>();
        six1 = GameObject.Find("6").GetComponent<Button>();
        seven1 = GameObject.Find("7").GetComponent<Button>();
        eight1 = GameObject.Find("8").GetComponent<Button>();
        nine1 = GameObject.Find("9").GetComponent<Button>();
        ten1 = GameObject.Find("10").GetComponent<Button>();
        eleven1 = GameObject.Find("11").GetComponent<Button>();
        twelve1 = GameObject.Find("12").GetComponent<Button>();
        thirteen1 = GameObject.Find("13").GetComponent<Button>();
        fourteen1 = GameObject.Find("14").GetComponent<Button>();
        fivetenn1 = GameObject.Find("15").GetComponent<Button>();
        sixtenn1 = GameObject.Find("16").GetComponent<Button>();




    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 1) { one.sprite = Resources.Load<Sprite>("Sprites/1"); one1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 2) { two.sprite = Resources.Load<Sprite>("Sprites/2"); two1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 3) { three.sprite = Resources.Load<Sprite>("Sprites/3"); three1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 4) { four.sprite = Resources.Load<Sprite>("Sprites/4"); four1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 5) { five.sprite = Resources.Load<Sprite>("Sprites/5"); five1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 6) { six.sprite = Resources.Load<Sprite>("Sprites/6"); six1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 7) { seven.sprite = Resources.Load<Sprite>("Sprites/7"); seven1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 8) { eight.sprite = Resources.Load<Sprite>("Sprites/8"); eight1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 9) { nine.sprite = Resources.Load<Sprite>("Sprites/9"); nine1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 10) { ten.sprite = Resources.Load<Sprite>("Sprites/10"); ten1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 11) { eleven.sprite = Resources.Load<Sprite>("Sprites/11"); eleven1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 12) { twelve.sprite = Resources.Load<Sprite>("Sprites/12"); twelve1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 13) { thirteen.sprite = Resources.Load<Sprite>("Sprites/13"); thirteen1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 14) { fourteen.sprite = Resources.Load<Sprite>("Sprites/14"); fourteen1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 15) { fivetenn.sprite = Resources.Load<Sprite>("Sprites/15"); fivetenn1.enabled = true; }
        if (PlayerPrefs.GetInt("contadorParamosTotales") >= 16) { sixtenn.sprite = Resources.Load<Sprite>("Sprites/16"); sixtenn1.enabled = true; }


        prueba = PlayerPrefs.GetInt("contadorParamosTotales");
        print(prueba);
    }

    


}
