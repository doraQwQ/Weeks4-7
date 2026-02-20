using UnityEngine;

public class Speed : MonoBehaviour
{
    //If players enter, their speed is slowed
    //If player exist, the speed reset

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Player player;

    private SpriteRenderer hazardRenderer;
    private bool wasinHazard = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hazardRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isInHazard = hazardRenderer.bounds.Contains(player.transform.position);
        if (isInHazard && !wasinHazard)
        {
            player.TakeDam();
            wasinHazard = true;
            //Lowers the speed of the player
             
        }
        else if (!isInHazard && wasinHazard)
        {
            wasinHazard = false;
            //Reset the speed of the player
        }
    }
}


