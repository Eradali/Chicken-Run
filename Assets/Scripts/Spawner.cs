using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject rockBridge;


    // Start is called before the first frame update
    void Start()
    {
        int r = Random.Range(0, 3);

        if (r == 0)
            rockBridge.SetActive(false);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
