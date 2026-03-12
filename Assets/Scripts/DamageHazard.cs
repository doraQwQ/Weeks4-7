using UnityEngine;
using UnityEngine.Events;

public class DamageHazard : MonoBehaviour
{
    public int damage = 20;
    public Player player;
    public UnityEvent OnEnter;
    public UnityEvent OnLeave;

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
            wasinHazard=true;
            OnEnter.Invoke();
        }
        else if( !isInHazard && wasinHazard)
        {
            wasinHazard = false;
            OnLeave.Invoke();
        }
    }
    //if player is in slime hazard turn yes to true
    public void Slow()
    {
        player.speed = 3;
    }
    //if player is in trap hazard turn yes2 to true
    public void Trap()
    {        
        player.health-= damage;
    }
    public void SlowReverse()
    {
        player.speed = 10;
    }

}
