using UnityEngine;

public class HPBar : MonoBehaviour
{
    public UnityEngine.UI.Slider healthBar;
    public float health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
        health -= 5*Time.deltaTime;
        healthBar.value = health ;
    }
}
