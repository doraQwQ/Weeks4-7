using UnityEngine;
using UnityEngine.InputSystem;
public class HungerBar : MonoBehaviour
{
    public UnityEngine.UI.Slider healthBar;
    public UnityEngine.UI.Slider hungerBar;
    public float hunger = 100;
    public int storeFood = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hungerBar.maxValue = hunger;
        hungerBar.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if( storeFood > 50)         //trigger vomit
        {
            healthBar.value = Random.Range(0, 90);
            storeFood = 0;
        }
        //If the user clicked then hunger bar value ++ and yeah
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            hungerBar.value += 10;
            if(hungerBar.value+10 > 100)
            {
                hungerBar.value = 100;          //Let the extra food be counted 
                storeFood += 100-(int)hungerBar.value;
            }
            healthBar.value+= 5;
            Debug.Log(hungerBar.value);
        }
        hungerBar.value -= 5 * Time.deltaTime;
    }
}
