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

        currentLevel1 = level1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSpawner()
    {
        Debug.Log("ok");

        xSpawnPos = currentLevel1.transform.position.x + 26.5f;
        ySpawnPos = currentLevel1.transform.position.y + (-1.5f);
        zSpawnPos = currentLevel1.transform.position.z + 196.3f;
        Vector3 spawnPos = new Vector3(xSpawnPos,ySpawnPos,zSpawnPos);

        currentLevel1 = Instantiate(level1, spawnPos, transform.rotation);
    }
}
