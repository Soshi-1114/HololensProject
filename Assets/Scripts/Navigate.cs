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
        var endPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        
        if ( Vector3.Distance(endPoint, navigaterPoint) >= 1.0){
            if ( Vector3.Distance( evacueePoint, navigaterPoint ) <= 1.0 ) {
                navigater.destination = endPoint;
                animator.SetBool("walking",true);
            } else if ( Vector3.Distance(evacueePoint, navigaterPoint) > 3.0 ){
                navigater.destination = evacueePoint;
                animator.SetBool("walking",true);
            } else {
                animator.SetBool("walking",false);
            }
        } else {
            animator.SetBool("walking",false);
        }
        
        
    }
}