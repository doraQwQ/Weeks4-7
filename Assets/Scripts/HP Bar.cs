using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class HPBar : MonoBehaviour
{
    public UnityEngine.UI.Slider healthBar;
    public float health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = 100;
        healthBar.value = 80;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Mouse.current.leftButton.wasPressedThisFrame)
        //{
        //    healthBar.value += 2;

        //}
  
        healthBar.value -= 7 * Time.deltaTime;
        if (healthBar.value > 100)
        {

        }
    }
    
}
