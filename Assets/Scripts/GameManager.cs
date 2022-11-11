using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //cached ref
    [SerializeField] GameObject level1;     //Level1 prefab for spawning only 
    public static GameManager GM;           //Object for this class

    //config para
    GameObject nextLevel1;               //for adding the cords in current level and spawn a new one
    GameObject currentLevel1;
    float xSpawnPos;
    float ySpawnPos;
    float zSpawnPos;

    // Start is called before the first frame update
    void Start()
    {
        GM = this;      //referencing to this class

        currentLevel1 = level1;     //for first time only
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSpawner()
    {
        Debug.Log("Next Level Created");

        if (nextLevel1 != null)
        {
            currentLevel1 = nextLevel1;

        }

        xSpawnPos = currentLevel1.transform.position.x + 21.1f;
        ySpawnPos = currentLevel1.transform.position.y + (-1.75f);
        zSpawnPos = currentLevel1.transform.position.z + 196.55f;
        Vector3 spawnPos = new Vector3(xSpawnPos,ySpawnPos,zSpawnPos);

        nextLevel1 = Instantiate(level1, spawnPos, transform.rotation);
    }

    public Transform[] NextLevelAIPath()
    {
        AIPath1 aiPath1;
        aiPath1 = nextLevel1.GetComponentInChildren<AIPath1>();
        print("Got AI paths");
        return aiPath1.patrolPoints;
    }
}
