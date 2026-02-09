using UnityEngine;
using UnityEngine.InputSystem;
public class HungerBar : MonoBehaviour
{
    public UnityEngine.UI.Slider hungerBar;
    public float hunger = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hungerBar.maxValue = hunger;
        hungerBar.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //If the user clicked then hunger bar value ++ and yeah
        if(Mouse.current.wasPressedThisFrame)
        {
            hungerBar.value += 10 * Time.deltaTime;
        }
    }
}
