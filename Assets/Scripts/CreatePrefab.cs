using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefab : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
       
    }

    public void OnClickCreateUnitychan()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("Unitychan");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(0.0f, 0.0f, 0.5f), Quaternion.identity);
    }

    public void OnClickCreateGoal()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("Cube");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(0.3f, 0.0f, 0.3f), Quaternion.identity);
    }
}