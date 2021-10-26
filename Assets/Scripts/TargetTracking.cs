using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetTracking : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        agent = transform.GetComponent<NavMeshAgent>();
        var endPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        agent.destination = endPoint;
    }
}