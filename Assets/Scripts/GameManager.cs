using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //cached ref
    [SerializeField] GameObject level1;     //Level1 prefab for spawning only 
    public static GameManager GM;           //Object for this class

    //config para
    GameObject currentLevel1;               //for adding the cords in current level and spawn a new one
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

        xSpawnPos = currentLevel1.transform.position.x + 19.33f;
        ySpawnPos = currentLevel1.transform.position.y + (-1.3f);
        zSpawnPos = currentLevel1.transform.position.z + 196.5f;
        Vector3 spawnPos = new Vector3(xSpawnPos,ySpawnPos,zSpawnPos);

        currentLevel1 = Instantiate(level1, spawnPos, transform.rotation);
    }
}
