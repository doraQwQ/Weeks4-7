using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int health=100;
    public int speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.position;
        move.z = 0;
        if (Keyboard.current.wKey.isPressed)
        {
            move.y += speed * Time.deltaTime;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            move.x -= speed * Time.deltaTime;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            move.y -= speed * Time.deltaTime;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            move.x += speed * Time.deltaTime;
        }
        transform.position = move;
        Debug.Log(health);
    }

}
