using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// using TMPro;


public class Tracking_31 : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform mainTarget;
    public Transform wayPoint;
    // public TextMeshProUGUI _debug;
    // private NavMeshPathStatus pathStatus;
    private bool pathStatus;
    private Vector3 firstPosition;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        firstPosition = agent.transform.position;
        agent.SetDestination(wayPoint.position);
        agent.stoppingDistance = 0.8f;
        pathStatus=false;
    }

    private void Update()
    {
        if (pathStatus)
        {
            agent.SetDestination(mainTarget.position);
            // Debug.Log("main");
        }
        if (Vector3.Distance(wayPoint.position,agent.transform.position) <= agent.stoppingDistance)
        {
            pathStatus = true;
        } else {
            if(!pathStatus){
                agent.SetDestination(wayPoint.position);
            }
        }
    }
    public bool PathStatus{
        get {return pathStatus;}
        set {pathStatus = value;}
    }
    public Vector3 ResetPosition
    {
        // agent.transform.position = firstPosition;
        get {return firstPosition;}
        set {firstPosition = value;}
    }
    public NavMeshAgent Agent
    {
        // agent.transform.position = firstPosition;
        get {return agent;}
    }
}