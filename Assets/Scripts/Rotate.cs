using UnityEngine;
using UnityEngine.InputSystem.Android;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 20f;
    private float counter = 0; 
    private bool condition= false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()               //Make a rotate effect for timer
    {
        if(counter > 20)
        {
            condition=!condition;
            counter = 0;
        }
        
        if (condition)  
        {
            rotateSpeed *= -1;
            condition = !condition;
        }
        
        transform.eulerAngles += transform.forward * rotateSpeed * Time.deltaTime;
        counter += Time.deltaTime;
    }
}
