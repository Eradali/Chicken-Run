using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    [SerializeField] GameObject billet1;
    [SerializeField] GameObject billet_pack;

    // Start is called before the first frame update
    void Start()
    {
        int r1 = Random.Range(0, 2);
        int r2 = Random.Range(0, 2);

        if (r1 == 0)
            billet1.SetActive(false);
        if (r2 == 0)
            billet_pack.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
