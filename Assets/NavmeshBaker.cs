using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshBaker : MonoBehaviour
{
    [SerializeField] NavMeshSurface navMeshSurface; 

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Bake", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Bake()
    {
        navMeshSurface.BuildNavMesh();
    }

}
