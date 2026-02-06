using UnityEngine;
using UnityEngine.UI;
public class IceCreamClock : MonoBehaviour
{
    public GameObject warperObject;
    public UnityEngine.UI.Slider rainbowIceCreamSlider;
    public float clockDuration=10;
    private float timeWaiting = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rainbowIceCreamSlider.maxValue = clockDuration;
    }

    // Update is called once per frame
    void Update()
    {
        rainbowIceCreamSlider.value = timeWaiting;
        timeWaiting += Time.deltaTime*1;
        if(timeWaiting>clockDuration )
        {
            timeWaiting = 0f;
            //Destroy(gameObject);
            bool shouldTurnOff = warperObject.activeInHierarchy;
            bool shouldTurnOn=!warperObject.activeInHierarchy;
            if (shouldTurnOn)
            {
                warperObject.SetActive(true);
            }
            if (shouldTurnOff)
            {
                warperObject.SetActive(false);
            }
        }
    }
}
