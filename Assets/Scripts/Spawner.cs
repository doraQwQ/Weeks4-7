using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject spawningPrefab;
    
    public float waitDuration;
    public float destroyDuration;

    public Color pacerColour;
    public float pacerSpeed;

    private float destoryProgress = 3f;
    private float waitprogress = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Destroy(gameObject, destroyDuration);
        /*
        //making empty variables for orgin position and rotation
        Vector3 orginPosition = Vector3.zero;          // origin
        Quaternion originRoation = Quaternion.identity;// makes that it have no rotation

        //Spawning at the position of spawning, with the spawner's rotation
        Instantiate(spawningPrefab, transform.position, transform.rotation);
        //spawning at orgin
        Instantiate(spawningPrefab);
        */
    }

    // Update is called once per frame
    void Update()
    {
        waitprogress += Time.deltaTime;
        if (waitprogress > waitDuration)
        {
            GameObject spawnedObject = Instantiate(spawningPrefab, transform.position, Quaternion.identity);

            //TypeOfComponent variableName = variableOfObject.getComponent,TypeOFComponent>();
            Pacer spawnedPacer = spawnedObject.GetComponent<Pacer>();
            spawnedPacer.speed = pacerSpeed;

            //set the colour of our pacer spawner to be pacerColour
            //SpriteRenderer of the pacer
            SpriteRenderer spawnedRenderer = spawnedObject.GetComponent<SpriteRenderer>();
            spawnedRenderer.color = pacerColour;

            Destroy(spawnedObject, destroyDuration);

            waitprogress = 0f;
        }
        
    }
    public void IncreasePacerSpeed()
    {
        pacerSpeed++;
    }
}
