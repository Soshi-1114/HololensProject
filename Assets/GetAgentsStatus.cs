using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GetAgentsStatus : MonoBehaviour
{
    public TextMeshProUGUI _debug;
    [SerializeField] private TargetTracking TrackingScript;
    [SerializeField] private Tracking_1 Tracking_1;
    [SerializeField] private Tracking_2 Tracking_2;
    [SerializeField] private Tracking_3 Tracking_3;
    [SerializeField] private Tracking_4 Tracking_4;
    private bool resetStatus = false;
    // public GameObject Child;
    // public Transform meeple;
    // Start is called before the first frame update
    void Start()
    {
        TrackingScript = GetComponentInChildren<TargetTracking>();
        Tracking_1 = GetComponentInChildren<Tracking_1>();
        Tracking_2 = GetComponentInChildren<Tracking_2>();
        Tracking_3 = GetComponentInChildren<Tracking_3>();
        Tracking_4 = GetComponentInChildren<Tracking_4>();
    }

    // Update is called once per frame
    void Update()
    {
        if(TrackingScript.PathStatus & Tracking_1.PathStatus & Tracking_2.PathStatus & Tracking_3.PathStatus & Tracking_4.PathStatus ){
            _debug.text = "Finish\n";
        } else {
            _debug.text = "Start\n";
        }
        // _debug.text = TrackingScript.PathStatus+"\n";
    }
    public void OnClickReset()
    {
        TrackingScript.Agent.transform.position = TrackingScript.ResetPosition;
        Tracking_1.Agent.transform.position = Tracking_1.ResetPosition;
        Tracking_2.Agent.transform.position = Tracking_2.ResetPosition;
        Tracking_3.Agent.transform.position = Tracking_3.ResetPosition;
        Tracking_4.Agent.transform.position = Tracking_4.ResetPosition;
        TrackingScript.PathStatus = resetStatus;
        Tracking_1.PathStatus = resetStatus;
        Tracking_2.PathStatus = resetStatus;
        Tracking_3.PathStatus = resetStatus;
        Tracking_4.PathStatus = resetStatus;
    }
}
