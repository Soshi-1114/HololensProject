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
    public GameObject thirty_agents;
    public GameObject fourty_agents;

    public GameObject wayPoint;
    public GameObject mainTarget;

    // Start is called before the first frame update
    void Start()
    {
        fire.SetActive(false);
        five_agents.SetActive(false);
        ten_agents.SetActive(false);
        fifteen_agents.SetActive(false);
        twenty_agents.SetActive(false);
        thirty_agents.SetActive(false);
        fourty_agents.SetActive(false);

    }

    public void hideAllAgents()
    {
        five_agents.SetActive(false);
        ten_agents.SetActive(false);
        fifteen_agents.SetActive(false);
        twenty_agents.SetActive(false);
        thirty_agents.SetActive(false);
        fourty_agents.SetActive(false);
    }

    public void showFlor()
    {
        wayPoint.SetActive(true);
    }
    public void hideFlor()
    {
        wayPoint.SetActive(false);
    }

    public void ResetPosition()
    {
        Vector3 waypos = wayPoint.transform.position;
        Vector3 mainpos = mainTarget.transform.position;
        waypos.y = 0.0f;
        mainpos.y = 0.0f;
        wayPoint.transform.position = waypos;
        mainTarget.transform.position = mainpos;
    }
    public void setPositionUp()
    {
        Vector3 pos = wayPoint.transform.position;
        pos.y += 0.1f;
        wayPoint.transform.position = pos;
    }

    public void setPositionDown() 
    {
        Vector3 pos = wayPoint.transform.position;
        pos.y -= 0.1f;
        wayPoint.transform.position = pos;
    }
    public void showAgent()
    {
        five_agents.SetActive(true);
    }

    // public void hideAgent()
    // {
    //     five_agents.SetActive(false);
    // }
    public void showTenAgent()
    {
        ten_agents.SetActive(true);
    }

    // public void hideTenAgent()
    // {
    //     ten_agents.SetActive(false);
    // }
    public void showFifteenAgent()
    {
        fifteen_agents.SetActive(true);
    }

    // public void hideFifteenAgent()
    // {
    //     fifteen_agents.SetActive(false);
    // }
    public void showTwentyAgent()
    {
        twenty_agents.SetActive(true);
    }

    // public void hideTwentyAgent()
    // {
    //     twenty_agents.SetActive(false);
    // }
    public void showThirtyAgent()
    {
        thirty_agents.SetActive(true);
    }

    // public void hideThirtyAgent()
    // {
    //     thirty_agents.SetActive(false);
    // }
    public void showFourtyAgent()
    {
        fourty_agents.SetActive(true);
    }

    // public void hideFourtyAgent()
    // {
    //     fourty_agents.SetActive(false);
    // }
}

