using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelSpawner : MonoBehaviour
{
    [SerializeField] GameObject level1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ok");
            Vector3 spawnPos = new Vector3(level1.transform.position.x + 26.5f, level1.transform.position.y + (-1.5f), level1.transform.position.z + 196.3f);
            Instantiate(level1, spawnPos, transform.rotation);
        }
    }
}
