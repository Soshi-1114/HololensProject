using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class Navigate : MonoBehaviour
{
    public NavMeshAgent navigater;
    public GameObject evacuee;
    public GameObject target;
    public TextMeshProUGUI _debug;
    // [SerializeField] bool isTargetTracking = false;
    // [SerializeField] bool isEvacueeTracking = true;
    // [SerializeField] float targetRange = 0.5f;
    // [SerializeField] float  evacueeRange = 0.1f;
    // [SerializeField] float  agentFeet = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        navigater = transform.GetComponent<NavMeshAgent>();
        var navigaterPoint = new Vector3(navigater.transform.position.x, transform.position.y, navigater.transform.position.z);
        var evacueePoint = new Vector3(evacuee.transform.position.x, transform.position.y, evacuee.transform.position.z);
        var targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);;
        var targetDistance = Vector3.Distance( targetPoint, navigaterPoint );
        var evacueeDistance = Vector3.Distance( evacueePoint, navigaterPoint );
        
        if(targetDistance >= evacueeDistance){
            navigater.destination = targetPoint;
            // _debug.text = "target\n";
        } 
        // else if(targetDistance <= 0.2f){
        //     navigater.destination = ;
        // }
        else{
            navigater.destination = evacueePoint;
            if(evacueeDistance < 0.1f){
                navigater.destination = targetPoint;
            }
            // _debug.text = "evacuee\n";
        }
        // if ( isTargetTracking ){
        //     if ( evacueeDistance >= evacueeRange ){
        //         isTargetTracking = false;
        //         _debug.text = "\nisTargetTracking:evacueeDistance\n"+isTargetTracking.ToString()+evacueeDistance.ToString();
        //         navigater.destination = evacueePoint;
        //     }
        //     navigater.destination = targetPoint;
        // }
        // else {
        //     if ( targetDistance >= targetRange ){
        //         isTargetTracking = true;
        //         _debug.text = "\nisTargetTracking:targetDistance\n"+isTargetTracking.ToString()+targetDistance.ToString();
        //     }
        //     navigater.destination = evacueePoint;
        // }
        
    }
}
