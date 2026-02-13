using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float DestroyDuration = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 currentMouseWorldPosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        currentMouseWorldPosition.z = 0;
        transform.up = currentMouseWorldPosition - transform.position;
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Debug.Log("Fire!");
        }
    }
    
}
