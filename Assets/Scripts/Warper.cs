using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
public class Warper : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //If we click and we are not hovering in other UI stuff
        bool shouldwarp = Mouse.current.leftButton.wasPressedThisFrame && 
            !EventSystem.current.IsPointerOverGameObject();
        if (shouldwarp)
        {
            /* Image exists in canvas, it is already in pixel space
             there is no need to change te type to world space
             */
            Vector3 currentMousePosition = Mouse.current.position.ReadValue();
      
            transform.position = currentMousePosition;
        }
    }
}
