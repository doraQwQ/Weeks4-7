using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 locate;
    public bool state = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        locate = transform.position;
        locate.z = 0;
        if (state)
        {
            locate.x += speed * Time.deltaTime ;
        }
        transform.position = locate;
    }

    public void OnMoveClick()   //Move the object to the right
    {
        state = true;
    }

    public void OnStopClick()   //Stop the object moving  
    {
        state = false;
    }

    public void OnFlipClick()   //Flip the direction of object if moving
    {
        speed *= -1;
        state = true;
    }
}
