using UnityEngine;

public class DamageHazard : MonoBehaviour
{
    public int damage = 20;
    public Player player;

    private SpriteRenderer hazardRenderer;
    private bool wasinHazard= false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hazardRenderer=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isInHazard = hazardRenderer.bounds.Contains(player.transform.position);
        if (isInHazard&&!wasinHazard)
        {
            player.TakeDam (damage);
            wasinHazard=true;
        }
        else if( !isInHazard && wasinHazard)
        {
            wasinHazard = false;
        }
    }
}
