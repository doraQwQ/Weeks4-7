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
