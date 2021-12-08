using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// using TMPro;


public class Tracking_17 : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform mainTarget;
    public Transform wayPoint;
    // public TextMeshProUGUI _debug;
    // private NavMeshPathStatus pathStatus;
    private bool pathStatus;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        // UnitychanCotroller = GetComponent<Animator>();
        agent.SetDestination(wayPoint.position);
        agent.stoppingDistance = 0.5f;
    }

    private void Update()
    {
        // agent = transform.GetComponent<NavMeshAgent>();
        // var agentPoint = new Vector3(agent.transform.position.x, transform.position.y, agent.transform.position.z);
        // var mainPoint = new Vector3(mainTarget.transform.position.x, transform.position.y, mainTarget.transform.position.z);
        // if (Vector3.Distance(agentPoint, mainPoint) < 0.5){
        //         agent.isStopped = true;
        //         pathStatus = agent.isStopped;
        //         // pathStatus = agent.pathStatus;
        //         // _debug.text = "StopsStatusT:"+agent.pathStatus+"\n";
        //     } else {
        //         agent.isStopped = false;
        //         agent.destination = mainPoint;
        //         pathStatus = agent.isStopped;
        //         // pathStatus = agent.pathStatus;
        //         // _debug.text = "StopsStatusF:"+agent.pathStatus+"\n";
        // }
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            pathStatus = true;
            // 目的地を次の場所に設定
            agent.SetDestination(mainTarget.position);
        }
        
    }
    public bool PathStatus{
        get {return pathStatus;}
    }
}