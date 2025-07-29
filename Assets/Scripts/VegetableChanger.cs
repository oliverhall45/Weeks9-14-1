using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VegetableChanger : MonoBehaviour
{
    public Image foodImage;
    public Sprite broccoliSprite, hamburgerSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHover()
    {
        //When we hover over the food
        //it will become a broccoli
        foodImage.sprite = broccoliSprite;
    }

    public void OnUnHover()
    {
        //when we unhover the food
        //it will become a hamburger
        foodImage.sprite = hamburgerSprite;
    }

}
