using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Hexagon : MonoBehaviour
{
    public UnityEvent onColourChange;

    public TMP_Text counterText;
    private SpriteRenderer hexagonRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        hexagonRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnColourizeClick()
    {
        hexagonRenderer.color = Random.ColorHSV();
        onColourChange.Invoke();
    }
}
