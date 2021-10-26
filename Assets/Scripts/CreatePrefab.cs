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
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Unitychan");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(0.0f, 0.0f, 0.5f), Quaternion.identity);
    }

    public void OnClickCreateGoal()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Cube");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(0.3f, 0.0f, 0.3f), Quaternion.identity);
    }
}