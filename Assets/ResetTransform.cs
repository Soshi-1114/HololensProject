using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3[] childrenPos;
    void Start()
    {
        foreach(Transform child in transform){
        // 子要素の名前を列挙
        // Debug.Log(child.transform.position);

}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
