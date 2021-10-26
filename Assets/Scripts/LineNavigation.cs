using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LineNavigation : MonoBehaviour
{
    [SerializeField, Tooltip("開始位置オブジェクト")]
    private GameObject StartObject;

    [SerializeField, Tooltip("目的位置オブジェクト")]
    private GameObject GoalObject;

    NavMeshAgent Agent;
    LineRenderer PathLineRenderer;

    [SerializeField, Tooltip("ライン描画間隔(s)")]
    private float timeOut = 1.0f;
    private float timeElapsed;

    

    public void GetInfo()
    {
        // 各コンポーネントの参照を取得する
        PathLineRenderer = GetComponent<LineRenderer>();
        Agent = GetComponent<NavMeshAgent>();

        // Agentとオブジェクトの位置同期を無効化する
        Agent.speed = 0f;
        Agent.updatePosition = false;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // 目的地を設定する
            Agent.destination = GoalObject.transform.position;
            // エージェントの位置をスタートオブジェクトの位置に同期する
            Agent.nextPosition = StartObject.transform.position;

            // 経路のパスを取得する
            Vector3[] positions = Agent.path.corners;

            // パスを取得できたか確認する
            if (positions.Length > 1)
            {
                // 経路のパスをラインレンダラーで描画する
                PathLineRenderer.positionCount = positions.Length;
                for (int i = 0; i < positions.Length; i++)
                {
                    Debug.Log("point " + i + "=" + positions[i]);
                    // ラインをパスの位置から50cm上げた位置に配置する
                    Vector3 linePos = new Vector3(positions[i].x, positions[i].y + 0.2f, positions[i].z);
                    PathLineRenderer.SetPosition(i, linePos);
                }
            }

            var endPoint = new Vector3(StartObject.transform.position.x, transform.position.y, StartObject.transform.position.z);
            Agent.destination = endPoint;

            timeElapsed = 0.0f;
        }
    }
}