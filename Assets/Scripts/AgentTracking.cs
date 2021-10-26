using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentTracking : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    public float wanderRange;
    private NavMeshAgent navMeshAgent;
    private NavMeshHit navMeshHit;
    void Start()
    {
        navMeshAgent = GetComponent < NavMeshAgent > ();
        navMeshAgent.destination = agent.transform.position;
        SetDestination();
        navMeshAgent.avoidancePriority = Random.Range(0, 100);
    }

    private void Update()
    {
        double thread = 1.0;
        agent = transform.GetComponent<NavMeshAgent>();
        var endPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        var currentPoint = new Vector3(agent.transform.position.x, transform.position.y, agent.transform.position.z);
        float distance = Vector3.Distance(endPoint, currentPoint);

        if ( distance <= thread){
            agent.destination = endPoint;
        } else {
            RandomWander();
        }

    }

    void RandomWander() {
	//指定した目的地に障害物があるかどうか、そもそも到達可能なのかを確認して問題なければセットする。
	//pathPending 経路探索の準備できているかどうか
	if (!navMeshAgent.pathPending) {
		if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance) {
			//hasPath エージェントが経路を持っているかどうか
			//navMeshAgent.velocity.sqrMagnitudeはスピード
			if (!navMeshAgent.hasPath || navMeshAgent.velocity.sqrMagnitude == 0f) {
				SetDestination();
			}
		}
	}
}

    void SetDestination() {
        Vector3 randomPos = new Vector3(Random.Range( - wanderRange, wanderRange), 0, Random.Range( - wanderRange, wanderRange));
        //SamplePositionは設定した場所から5の範囲で最も近い距離のBakeされた場所を探す。
        NavMesh.SamplePosition(randomPos, out navMeshHit, 5, 1);
        navMeshAgent.destination = navMeshHit.position;
    }
}
