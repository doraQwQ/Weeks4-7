using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public GameObject chick_Wings;
    public GameObject chick_Nuggs;
    public GameObject hamburger;
    public GameObject cake;
    public GameObject waffle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            int num= Random.Range(0, 5); // random number between 0 and 4
            if(num==0)
            {
                Instantiate(chick_Wings, new Vector3(0,0,0), Quaternion.identity);
            }
            else if(num == 1)
            {
                Instantiate(chick_Nuggs, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else if(num == 2)
            {
                Instantiate(hamburger, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else if(num == 3)
            {
                Instantiate(cake, transform.position, Quaternion.identity);
            }
            else if(num == 4)
            {
                Instantiate(waffle, transform.position, Quaternion.identity);
            }
        }
        
    }
}
