using UnityEngine;
using UnityEngine.InputSystem;
public class Tank : MonoBehaviour
{
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 currentRotation= transform.eulerAngles;
        

        currentPosition.z = 0;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            currentPosition.x -= speed*Time.deltaTime;
        }else if (Keyboard.current.aKey.isPressed)
        {
            currentPosition.x -= speed * Time.deltaTime;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            currentPosition.x += speed * Time.deltaTime;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            currentPosition.x += speed * Time.deltaTime;
        }
            transform.position = currentPosition;

    }
}
