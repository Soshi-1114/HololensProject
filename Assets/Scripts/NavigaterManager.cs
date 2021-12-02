using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigaterManager : MonoBehaviour
{
    public GameObject agents;

    // Start is called before the first frame update
    void Start()
    {
        agents.SetActive(false);
    }

    public void isNavigate()
    {
        agents.SetActive(true);
    }

    public void isNotNavigate()
    {
        agents.SetActive(false);
    }
}
