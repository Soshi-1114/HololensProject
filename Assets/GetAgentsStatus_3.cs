using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GetAgentsStatus_3 : MonoBehaviour
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
    [SerializeField] private Tracking_10 Tracking_10;
    [SerializeField] private Tracking_11 Tracking_11;
    [SerializeField] private Tracking_12 Tracking_12;
    [SerializeField] private Tracking_13 Tracking_13;
    [SerializeField] private Tracking_14 Tracking_14;
    [SerializeField] private Tracking_15 Tracking_15;
    [SerializeField] private Tracking_16 Tracking_16;
    [SerializeField] private Tracking_17 Tracking_17;
    [SerializeField] private Tracking_18 Tracking_18;
    [SerializeField] private Tracking_19 Tracking_19;
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
        Tracking_10 = GetComponentInChildren<Tracking_10>();
        Tracking_11 = GetComponentInChildren<Tracking_11>();
        Tracking_12 = GetComponentInChildren<Tracking_12>();
        Tracking_13 = GetComponentInChildren<Tracking_13>();
        Tracking_14 = GetComponentInChildren<Tracking_14>();
        Tracking_15 = GetComponentInChildren<Tracking_15>();
        Tracking_16 = GetComponentInChildren<Tracking_16>();
        Tracking_17 = GetComponentInChildren<Tracking_17>();
        Tracking_18 = GetComponentInChildren<Tracking_18>();
        Tracking_19 = GetComponentInChildren<Tracking_19>();
    }

    // Update is called once per frame
    void Update()
    {
        if(
            TrackingScript.PathStatus & Tracking_1.PathStatus & Tracking_2.PathStatus & 
            Tracking_3.PathStatus & Tracking_4.PathStatus & Tracking_5.PathStatus & 
            Tracking_6.PathStatus & Tracking_7.PathStatus & Tracking_8.PathStatus &
            Tracking_9.PathStatus & Tracking_10.PathStatus & Tracking_11.PathStatus & 
            Tracking_12.PathStatus & Tracking_13.PathStatus & Tracking_14.PathStatus &
            Tracking_15.PathStatus & Tracking_16.PathStatus & 
            Tracking_17.PathStatus & Tracking_18.PathStatus & Tracking_19.PathStatus
        ){
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
        Tracking_5.Agent.transform.position = Tracking_5.ResetPosition;
        Tracking_6.Agent.transform.position = Tracking_6.ResetPosition;
        Tracking_7.Agent.transform.position = Tracking_7.ResetPosition;
        Tracking_8.Agent.transform.position = Tracking_8.ResetPosition;
        Tracking_9.Agent.transform.position = Tracking_9.ResetPosition;
        Tracking_10.Agent.transform.position = Tracking_10.ResetPosition;
        Tracking_11.Agent.transform.position =Tracking_11.ResetPosition;
        Tracking_12.Agent.transform.position =Tracking_12.ResetPosition;
        Tracking_13.Agent.transform.position =Tracking_13.ResetPosition;
        Tracking_14.Agent.transform.position =Tracking_14.ResetPosition;
        Tracking_15.Agent.transform.position = Tracking_15.ResetPosition;
        Tracking_16.Agent.transform.position =Tracking_16.ResetPosition;
        Tracking_17.Agent.transform.position =Tracking_17.ResetPosition;
        Tracking_18.Agent.transform.position =Tracking_18.ResetPosition;
        Tracking_19.Agent.transform.position =Tracking_19.ResetPosition;

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
        Tracking_10.PathStatus = resetStatus;
        Tracking_11.PathStatus = resetStatus;
        Tracking_12.PathStatus = resetStatus;
        Tracking_13.PathStatus = resetStatus;
        Tracking_14.PathStatus = resetStatus;
        Tracking_15.PathStatus = resetStatus;
        Tracking_16.PathStatus = resetStatus;
        Tracking_17.PathStatus = resetStatus;
        Tracking_18.PathStatus = resetStatus;
        Tracking_19.PathStatus = resetStatus;
    }

}
