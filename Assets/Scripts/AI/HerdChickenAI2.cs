using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HerdChickenAI2 : MonoBehaviour
{
    //cached ref
    NavMeshAgent herdChicken;
    Animator chickenAnimator;

    //config para
    [SerializeField] Transform[] patrolPoints;
    int patrolPointIndex;

    // Start is called before the first frame update
    void Start()
    {
        herdChicken = GetComponent<NavMeshAgent>();

        chickenAnimator = GetComponent<Animator>();
        chickenAnimator.SetBool("Run", true);

        patrolPointIndex = 0;
        SetDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (herdChicken.remainingDistance <= 2.0f)
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        herdChicken.SetDestination(patrolPoints[patrolPointIndex].position);
        patrolPointIndex++;
        if (patrolPointIndex >= patrolPoints.Length)
        {
            patrolPointIndex = 0;
        }
    }
}
