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
    int n = 0;
    void Start()
    {
        navigater = transform.GetComponent<NavMeshAgent>();
        var targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        var evacueePoint = new Vector3(evacuee.transform.position.x, transform.position.y, evacuee.transform.position.z);
        navigater.destination = evacueePoint; 
    }

    private void Update()
    {
        navigater = transform.GetComponent<NavMeshAgent>();
        var navigaterPoint = new Vector3(navigater.transform.position.x, transform.position.y, navigater.transform.position.z);
        var evacueePoint = new Vector3(evacuee.transform.position.x, transform.position.y, evacuee.transform.position.z);
        var targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        var targetDistance = Vector3.Distance( targetPoint, navigaterPoint );
        var evacueeDistance = Vector3.Distance( evacueePoint, navigaterPoint );
        
        if(evacueeDistance <= 0.5f){
            if(targetDistance >= 1f){
                navigater.destination = targetPoint;
                navigater.speed = 1f;
                navigater.updateRotation = true;
            }else{
                //evacueeに近付くと止まる
                navigater.speed = 0f;
                navigater.updateRotation = false;   
            }
            
        }else{
            navigater.destination = evacueePoint;
            navigater.speed = 1f;
            navigater.updateRotation = true;
        }


        // if(targetDistance >= evacueeDistance){
        //     navigater.destination = targetPoint;
        //     // _debug.text = "target\n";
        // } 
        // // else if(targetDistance <= 0.2f){
        // //     navigater.destination = ;
        // // }
        // else{
        //     navigater.destination = evacueePoint;
        //     if(evacueeDistance < 0.05f){
        //         navigater.destination = targetPoint;
        //     }
        //     // _debug.text = "evacuee\n";
        // }
    }
}
