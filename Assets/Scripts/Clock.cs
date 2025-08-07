using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Clock : MonoBehaviour
{
    public Transform hourHand, minuteHand;

    public float hourDuration = 4f;

    public UnityEvent<int> onHourReached;

    private float currentTime = 0f;
    private Coroutine activeClockCoroutine;
    private IEnumerator activeHandsCoroutine;
    private int currentHour = 0;
    // Start is called before the first frame update
    void Start()
    {
       

        activeClockCoroutine = StartCoroutine(ClockUpdate());
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Stop()
    {
        Debug.Log("Stopping the coroutine");
        if(activeClockCoroutine != null)
        {
            StopCoroutine(activeClockCoroutine);
        }
        if (activeHandsCoroutine != null)
        {
            StopCoroutine(activeHandsCoroutine);
        }
      
    }

    IEnumerator ClockUpdate()
    {
        Debug.Log("Starting clock update");
        while (true)
        {
            activeHandsCoroutine = MoveHandsAnHour();
            yield return StartCoroutine(activeHandsCoroutine);
        }
        
        Debug.Log("we have reached the end of the ClockUpdate coroutine");
    }

    IEnumerator MoveHandsAnHour()
    {
        currentTime = 0f;
        while (currentTime < hourDuration)
        {
            currentTime += Time.deltaTime;

            hourHand.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration / 12;

            //Vector3.forward gives us just the z value which we can use to rotate the object
            minuteHand.eulerAngles -= Vector3.forward * 360 * Time.deltaTime / hourDuration;

            if (currentTime > hourDuration)
            {
                currentHour++;

                onHourReached.Invoke(currentHour);
               
            }

            yield return null;

            //yield return new WaitForSeconds(0.5f); -- thing that lets you wait a certain amount of time before restarting

        }
        Debug.Log("We have finished MoveHandsAnHour coroutine");
    }
}
