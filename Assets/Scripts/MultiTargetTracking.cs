using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MultiTargetTracking : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target_1;
    public GameObject target_2;

    // private Animator UnitychanCotroller;

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
        var targetPoint_2 = new Vector3(target_2.transform.position.x, transform.position.y, target_2.transform.position.z);
        if (Vector3.Distance(agentPoint, targetPoint_1) <= Vector3.Distance(agentPoint, targetPoint_2)){
            agent.destination = targetPoint_1;
            // UnitychanCotroller.SetBool("is_running", true);
            if (Vector3.Distance(agentPoint, targetPoint_1) < 1){
                agent.isStopped = true;
                // UnitychanCotroller.SetBool("is_running", false);
            } else {
                agent.isStopped = false;
            }
        } else {
            agent.destination = targetPoint_2;
            // UnitychanCotroller.SetBool("is_running", true);
            if (Vector3.Distance(agentPoint, targetPoint_2) < 1){
                agent.isStopped = true;
                // UnitychanCotroller.SetBool("is_running", false);
            } else {
                agent.isStopped = false;
            }
        }
        
    }
}