using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject fire;
    public GameObject five_agents;
    public GameObject ten_agents;
    public GameObject fifteen_agents;
    public GameObject twenty_agents;

    public GameObject flor;

    // Start is called before the first frame update
    void Start()
    {
        fire.SetActive(false);
        five_agents.SetActive(false);
        ten_agents.SetActive(false);
        fifteen_agents.SetActive(false);
        twenty_agents.SetActive(false);

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
        five_agents.SetActive(true);
    }

    public void hideAgent()
    {
        five_agents.SetActive(false);
    }
    public void showTenAgent()
    {
        ten_agents.SetActive(true);
    }

    public void hideTenAgent()
    {
        ten_agents.SetActive(false);
    }
    public void showFifteenAgent()
    {
        fifteen_agents.SetActive(true);
    }

    public void hideFifteenAgent()
    {
        fifteen_agents.SetActive(false);
    }
    public void showTwentyAgent()
    {
        twenty_agents.SetActive(true);
    }

    public void hideTwentyAgent()
    {
        twenty_agents.SetActive(false);
    }
}

