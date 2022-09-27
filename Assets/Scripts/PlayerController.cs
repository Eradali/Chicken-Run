using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float input1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 6f);

        input1 = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(input1, 0, 0) * Time.deltaTime * 5f);
    }
}
