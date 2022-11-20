using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;


public class BackGroundBTN : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
    public int imageNumber ;






    // Update is called once per frame
    public void Start()
    {
        
        imageNumber = PlayerPrefs.GetInt("imageNumber",1);

        if (imageNumber == 1)
            original.sprite = newSprite;

        if (imageNumber == 2)
            original.sprite = newSprite2;

        if (imageNumber == 3)

            original.sprite = newSprite3;


        if (imageNumber == 4)
        {
            original.sprite = newSprite4;
            imageNumber = 0;
        }
    }
    public void SetImage()
    {
        imageNumber ++;
        PlayerPrefs.SetInt("imageNumber", imageNumber);
        if (imageNumber == 1)
            original.sprite = newSprite;
        if (imageNumber == 2)
            original.sprite = newSprite2;
        if (imageNumber == 3)
            original.sprite = newSprite3;
        if (imageNumber == 4)
        {
            original.sprite = newSprite4;
            imageNumber = 0;
        }
    }
}

