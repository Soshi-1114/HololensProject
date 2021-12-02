using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetTracking : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target_1;
    
    // Start is called before the first frame update
    void Start()
    {
        // UnitychanCotroller = GetComponent<Animator>();
    }

    private void Update()
    {
        agent = transform.GetComponent<NavMeshAgent>();
        var agentPoint = new Vector3(agent.transform.position.x, transform.position.y, agent.transform.position.z);
        var targetPoint_1 = new Vector3(target_1.transform.position.x, transform.position.y, target_1.transform.position.z);
        if (Vector3.Distance(agentPoint, targetPoint_1) < 0.5){
                agent.isStopped = true;
            } else {
                agent.isStopped = false;
                agent.destination = targetPoint_1;
        }
        
    }
}