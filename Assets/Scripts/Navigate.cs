using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigate : MonoBehaviour
{
    public NavMeshAgent navigater;
    public GameObject evacuee;
    public GameObject target;
    private Animator animator;
    [SerializeField] bool isTargetTracking = false;
    [SerializeField] bool isEvacueeTracking = true;
    [SerializeField] float trackedRange = 0.5f;
    [SerializeField] float  navigatingRange = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        navigater = transform.GetComponent<NavMeshAgent>();
        var navigaterPoint = new Vector3(navigater.transform.position.x, transform.position.y, navigater.transform.position.z);
        var evacueePoint = new Vector3(evacuee.transform.position.x, transform.position.y, evacuee.transform.position.z);
        var targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        // var navigaterPoint = navigater.transform.position;
        // var evacueePoint = evacuee.transform.position;
        // var targetPoint = target.transform.position;

        var NtoTDis = Vector3.Distance( targetPoint, navigaterPoint );
        var NtoEDis = Vector3.Distance( evacueePoint, navigaterPoint );

        if ( NtoTDis >= trackedRange ){
            navigater.destination = targetPoint;
            if ( NtoEDis > navigatingRange ){
                navigater.destination = evacueePoint;
            }
        }
        else {
            if ( NtoEDis > navigatingRange ){
                navigater.destination = evacueePoint;
            }
        }
        
        // if ( NtoTDis >= trackedRange) {
        //     if ( NtoEDis <= trackedRange ) {
        //         animator.SetBool("walking", true);
        //         navigater.destination = targetPoint;
        //     } 
        //     else if ( NtoEDis > navigatingRange ){
        //         animator.SetBool("walking", true);
        //         navigater.destination = evacueePoint;
        //     } 
        //     else {
        //         animator.SetBool("walking", false);
        //     }
        // } 
        // else {
        //     if ( NtoEDis > navigatingRange ){
        //         navigater.destination = evacueePoint;
        //         animator.SetBool("walking", true);
        //     } 
        //     animator.SetBool("walking", false);
        // }

    //     if ( isTargetTracking ){
    //         if ( NtoEDis > trackedRange ){
    //             isTargetTracking = false;
    //             isEvacueeTracking = true;
    //             if ( isEvacueeTracking ){
    //                 if ( NtoEDis <= trackedRange ){
    //                     isTargetTracking = true;
    //                     isEvacueeTracking = false;
    //                 }
    //                 navigater.destination = evacueePoint;
    //                 // animator.SetBool("walking", true);
    //             }
    //         }
    //         navigater.destination = targetPoint;
    //         // animator.SetBool("walking", true);
    //     }
    //     else {
    //         if ( NtoEDis <= trackedRange ){
    //             isTargetTracking = true;
    //         }
    //     }
    }
}
