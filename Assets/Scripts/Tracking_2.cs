using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// using TMPro;


public class Tracking_2 : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform mainTarget;
    public Transform wayPoint;
    // public TextMeshProUGUI _debug;
    private bool pathStatus;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(wayPoint.position);
        agent.stoppingDistance = 0.5f;
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
        } 
    }
    public bool PathStatus{
        get {return pathStatus;}
    }
}