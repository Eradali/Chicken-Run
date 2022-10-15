using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGod : MonoBehaviour
{
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
        if (other.gameObject.CompareTag("falling_tree") || other.gameObject.CompareTag("rolling_billet"))
        {
            print("ok");
            int r = Random.Range(0, 2);
            if(r == 1)
            {
                other.gameObject.GetComponent<Rigidbody>().useGravity = true;
                other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
}
