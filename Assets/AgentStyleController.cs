using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;



public class AgentStyleController : MonoBehaviour
{
    public NavMeshAgent agents;
    public TextMeshProUGUI _debug;
    public TextMeshProUGUI _debug_h;

    // Start is called before the first frame update
    void Start()
    {
        agents = GetComponent<NavMeshAgent>();
    }

    public void setRadiusUp()
    {
        float up = agents.radius;
        up += 0.1f;
        agents.radius = up;
        _debug.text = "radius: "+agents.radius+"\n";
    }
    public void setRadiusDown()
    {
        float down = agents.radius;
        down -= 0.1f;
        agents.radius = down;
        _debug.text = "radius: "+agents.radius+"\n";
    }
    public void setHeightUp()
    {
        float up = agents.height;
        up += 0.1f;
        agents.height = up;
        _debug_h.text = "height: "+agents.height+"\n";
    }
    public void setHeightDown()
    {
        float down = agents.height;
        down -= 0.1f;
        agents.height = down;
        _debug_h.text = "height: "+agents.height+"\n";
    }
}
