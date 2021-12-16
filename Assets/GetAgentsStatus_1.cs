using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GetAgentsStatus_1 : MonoBehaviour
{
    public TextMeshProUGUI _debug;
    [SerializeField] private TargetTracking TrackingScript;
    [SerializeField] private Tracking_1 Tracking_1;
    [SerializeField] private Tracking_2 Tracking_2;
    [SerializeField] private Tracking_3 Tracking_3;
    [SerializeField] private Tracking_4 Tracking_4;
    [SerializeField] private Tracking_5 Tracking_5;
    [SerializeField] private Tracking_6 Tracking_6;
    [SerializeField] private Tracking_7 Tracking_7;
    [SerializeField] private Tracking_8 Tracking_8;
    [SerializeField] private Tracking_9 Tracking_9;
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
        Tracking_5 = GetComponentInChildren<Tracking_5>();
        Tracking_6 = GetComponentInChildren<Tracking_6>();
        Tracking_7 = GetComponentInChildren<Tracking_7>();
        Tracking_8 = GetComponentInChildren<Tracking_8>();
        Tracking_9 = GetComponentInChildren<Tracking_9>();
    }

    // Update is called once per frame
    void Update()
    {
        if(
            TrackingScript.PathStatus & Tracking_1.PathStatus & Tracking_2.PathStatus & 
            Tracking_3.PathStatus & Tracking_4.PathStatus & Tracking_5.PathStatus & 
            Tracking_6.PathStatus & Tracking_7.PathStatus & Tracking_8.PathStatus &
            Tracking_9.PathStatus){
            _debug.text = "Finish\n";
        } else {
            _debug.text = "Start\n";
        }
    }
    public void OnClickReset()
    {
        TrackingScript.Agent.transform.position = TrackingScript.ResetPosition;
        Tracking_1.Agent.transform.position = Tracking_1.ResetPosition;
        Tracking_2.Agent.transform.position = Tracking_2.ResetPosition;
        Tracking_3.Agent.transform.position = Tracking_3.ResetPosition;
        Tracking_4.Agent.transform.position = Tracking_4.ResetPosition;
        Tracking_5.Agent.transform.position = Tracking_5.ResetPosition;
        Tracking_6.Agent.transform.position = Tracking_6.ResetPosition;
        Tracking_7.Agent.transform.position = Tracking_7.ResetPosition;
        Tracking_8.Agent.transform.position = Tracking_8.ResetPosition;
        Tracking_9.Agent.transform.position = Tracking_9.ResetPosition;

        TrackingScript.PathStatus = resetStatus;
        Tracking_1.PathStatus = resetStatus;
        Tracking_2.PathStatus = resetStatus;
        Tracking_3.PathStatus = resetStatus;
        Tracking_4.PathStatus = resetStatus;
        Tracking_5.PathStatus = resetStatus;
        Tracking_6.PathStatus = resetStatus;
        Tracking_7.PathStatus = resetStatus;
        Tracking_8.PathStatus = resetStatus;
        Tracking_9.PathStatus = resetStatus;
    }

}
