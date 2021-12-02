using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject fire;
    public GameObject agents;
    public GameObject flor;

    // Start is called before the first frame update
    void Start()
    {
        fire.SetActive(false);
        agents.SetActive(false);
    }

    public void showObject()
    {
        fire.SetActive(true);
    }

    public void hideObject()
    {
        fire.SetActive(false);
    }

    public void showFlor()
    {
        flor.SetActive(true);
    }

    public void setPositionUp()
    {
        Vector3 pos = flor.transform.position;
        pos.y += 0.1f;
        flor.transform.position = pos;
    }

    public void setPositionDown() 
    {
        Vector3 pos = flor.transform.position;
        pos.y -= 0.1f;
        flor.transform.position = pos;
    }
    public void showAgent()
    {
        agents.SetActive(true);
    }

    public void hideAgent()
    {
        agents.SetActive(false);
    }
}

