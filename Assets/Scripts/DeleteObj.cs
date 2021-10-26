using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObj : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y <= -10f)
        {
            Destroy(gameObject);
        }
    }
}