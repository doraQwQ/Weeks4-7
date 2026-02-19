using Unity.VisualScripting;
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

    private GameObject spawned = null; // store current spawned food
    private Image food = null;         // Image of the current food
    private bool isFoodSpawned = false;

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
            if (isFoodSpawned)
            {
                Destroy(spawned);
                isFoodSpawned = false;
            }
            int num = Random.Range(0, 5); // random number between 0 and 4
            if (num == 0)
            {
                 spawned = Instantiate(chick_Wings, transform.parent);

            }
            else if (num == 1)
            {
                 spawned = Instantiate(chick_Nuggs, transform.parent);

            }
            else if (num == 2)
            {
                 spawned = Instantiate(hamburger, transform.parent);

            }
            else if (num == 3)
            {
                 spawned = Instantiate(cake, transform.parent);
            }
            else
            {
                 spawned = Instantiate(waffle, transform.parent);
            }
            food = spawned.GetComponent<Image>();
            food.color = new Color(1, 1, 1, 1);
            isFoodSpawned = true;



        }
        
    }
}
