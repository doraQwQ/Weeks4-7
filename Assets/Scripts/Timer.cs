using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text text;
    public float time = 0;
    public float timerCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCount += Time.deltaTime;
        if (timerCount >= 1)
        {
            time++;
            timerCount = 0;
        }
        text.text = "" + time;
    }
}
