using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountdown : MonoBehaviour
{

    public Text text;
    public string message;

    public float elapsedTime = 0f;
    public float countdownLimit = 100f;

    public bool canCount = false;
    public bool countdownFinish = false;


    // Start is called before the first frame update
    void Start()
    {
        if (text is null) Debug.LogError("Atribuir Text");

        message = "Timer: 100s";
    }

    // Update is called once per frame
    void Update()
    {
        if (canCount)
        {
            elapsedTime += Time.deltaTime;

            float diffTime = countdownLimit - elapsedTime;

            text.text = $"Timer: {diffTime:0}";

            if (elapsedTime >= countdownLimit)
            {
                canCount = false;
                countdownFinish = true;
            }
        }
    }

    public void ToogleCounter() {
        canCount = !canCount;
    }
}
