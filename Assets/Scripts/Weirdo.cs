using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using TMPro;
//This is week 5 Coding Gym Challenge: Control.
public class Weirdo : MonoBehaviour
{
    public TMP_Text text;
  
    public Camera gameCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 omg = Mouse.current.position.ReadValue();
        omg.z = 0;
        Vector3 omg2= Camera.main.ScreenToWorldPoint(omg);
        if (EventSystem.current.IsPointerOverGameObject()) 
        {
            text.text = "Hello, I am a character from Twisted Wonderland." +
                " Im strict as HELL";
        }
        else
        {
            text.text = "...";
        }
        if (omg2.y >-5&&omg2.y<0
            && omg2.x > -9.3 && omg2.x < -4.5)
        {
            text.text = "I am also a character from TwIsTeD WoNdErLaNd. I am a nerd techian.";
        }
    
    }
}
