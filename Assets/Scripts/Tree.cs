using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public AnimationCurve curve;

    private float currentTime = 0f;
    public float duration = 1;
    public List<Transform> appleTransforms;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void StartGrow()
    {
        currentTime = 0f;

        StartCoroutine(Grow());
    }

    public IEnumerator Grow()
    {


        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            float timeRatio = currentTime / duration;

            transform.localScale = Vector3.one * curve.Evaluate(timeRatio);
            yield return null;

        }


        currentTime = 0f;

        int i = 0;
        while (currentTime < duration && i < appleTransforms.Count)
        {

            currentTime += Time.deltaTime;

            float timeRatio = currentTime / duration;
            
            appleTransforms[i].localScale = Vector3.one * curve.Evaluate(timeRatio);

            yield return null;

            if (currentTime >= duration)
            {
                i++;
                currentTime = 0;
            }
        }
    }
}