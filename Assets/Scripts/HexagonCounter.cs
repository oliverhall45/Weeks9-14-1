using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class HexagonCounter : MonoBehaviour
{
    public TMP_Text counterText;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCount()
    {
        counter++;
        counterText.text = counter.ToString();
    }

}
