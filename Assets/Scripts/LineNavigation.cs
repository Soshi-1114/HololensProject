using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LineNavigation : MonoBehaviour
{
    [SerializeField, Tooltip("�J�n�ʒu�I�u�W�F�N�g")]
    private GameObject StartObject;

    [SerializeField, Tooltip("�ړI�ʒu�I�u�W�F�N�g")]
    private GameObject GoalObject;

    NavMeshAgent Agent;
    LineRenderer PathLineRenderer;

    [SerializeField, Tooltip("���C���`��Ԋu(s)")]
    private float timeOut = 1.0f;
    private float timeElapsed;

    

    public void GetInfo()
    {
        // �e�R���|�[�l���g�̎Q�Ƃ��擾����
        PathLineRenderer = GetComponent<LineRenderer>();
        Agent = GetComponent<NavMeshAgent>();

        // Agent�ƃI�u�W�F�N�g�̈ʒu�����𖳌�������
        Agent.speed = 0f;
        Agent.updatePosition = false;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // �ړI�n��ݒ肷��
            Agent.destination = GoalObject.transform.position;
            // �G�[�W�F���g�̈ʒu���X�^�[�g�I�u�W�F�N�g�̈ʒu�ɓ�������
            Agent.nextPosition = StartObject.transform.position;

            // �o�H�̃p�X���擾����
            Vector3[] positions = Agent.path.corners;

            // �p�X���擾�ł������m�F����
            if (positions.Length > 1)
            {
                // �o�H�̃p�X�����C�������_���[�ŕ`�悷��
                PathLineRenderer.positionCount = positions.Length;
                for (int i = 0; i < positions.Length; i++)
                {
                    Debug.Log("point " + i + "=" + positions[i]);
                    // ���C�����p�X�̈ʒu����50cm�グ���ʒu�ɔz�u����
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