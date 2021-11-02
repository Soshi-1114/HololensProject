using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigate : MonoBehaviour
{
    public NavMeshAgent navigater;
    public GameObject evacuee;
    public GameObject target;
    [SerializeField] bool isTargetTracking = false;
    // [SerializeField] bool isEvacueeTracking = true;
    [SerializeField] float targetRange = 0.5f;
    [SerializeField] float  evacueeRange = 0.5f;
    [SerializeField] float  agentFeet = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        navigater = transform.GetComponent<NavMeshAgent>();
        var navigaterPoint = new Vector3(navigater.transform.position.x, transform.position.y, navigater.transform.position.z);
        var evacueePoint = new Vector3(evacuee.transform.position.x, transform.position.y, evacuee.transform.position.z);
        var targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        var targetDistance = Vector3.Distance( targetPoint, navigaterPoint );
        var evacueeDistance = Vector3.Distance( evacueePoint, navigaterPoint );
        
        if ( isTargetTracking ){
            if ( evacueeDistance >= evacueeRange ){
                isTargetTracking = false;
                navigater.destination = evacueePoint;
            }
            navigater.destination = targetPoint;
        }
        else {
            if ( targetDistance >= targetRange ){
                isTargetTracking = true;
            }
        }
        
    }
}
