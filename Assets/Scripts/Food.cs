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
    //cosinder making some sentence to9 be instanciate and destoried
    //like "eat, eat ,eat, if I win this. I don;t need to work for 10 years or more!!!"
    //""Ugh, I am full. No, I need to eat more
    //The other contenstioen seems to be behind me on food number, I must'en give up!
    // Just... hang on... a little longer
    //I wish my stomach can share with anyone else, then I can keep eating!!
    //There is no give up in my dictionary.
    // This food is really yummy, I feel like they hire michelin star chefs.
    //Thou these are simple way of cooking, they can be hard to make with the techinques.
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
