using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class FoodCount : MonoBehaviour
{
    public TMP_Text text; 
    public float foodCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            foodCount += 1;
            text.text = ""+foodCount;
        }
    }
}
