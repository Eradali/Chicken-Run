using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //cached ref
    Animator chickenAnimator;

    //config para
    [SerializeField] float input1 = 0;
    [SerializeField] float runningSpeed;
    float turnValue = 0f;
    [SerializeField] float turningSpeed;

    // Start is called before the first frame update
    void Start()
    {
        chickenAnimator = GetComponent<Animator>();
        chickenAnimator.SetBool("Run", true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * runningSpeed);       //moving forward

        transform.Rotate(0f, turnValue * turningSpeed, 0f);     //turning left & right

        //input1 = Input.GetAxis("Horizontal");
        //transform.Translate(new Vector3(input1, 0, 0) * Time.deltaTime * turningSpeed);       //turning left & right using keyboard
    }

    public void SetTurnValue(float value)
    {
        turnValue = value;
    }

}
