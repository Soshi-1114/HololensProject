using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GetAgentsStatus_5 : MonoBehaviour
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
    [SerializeField] private Tracking_20 Tracking_20;
    [SerializeField] private Tracking_21 Tracking_21;
    [SerializeField] private Tracking_22 Tracking_22;
    [SerializeField] private Tracking_23 Tracking_23;
    [SerializeField] private Tracking_24 Tracking_24;
    [SerializeField] private Tracking_25 Tracking_25;
    [SerializeField] private Tracking_26 Tracking_26;
    [SerializeField] private Tracking_27 Tracking_27;
    [SerializeField] private Tracking_28 Tracking_28;
    [SerializeField] private Tracking_29 Tracking_29;
    [SerializeField] private Tracking_30 Tracking_30;
    [SerializeField] private Tracking_31 Tracking_31;
    [SerializeField] private Tracking_32 Tracking_32;
    [SerializeField] private Tracking_33 Tracking_33;
    [SerializeField] private Tracking_34 Tracking_34;
    [SerializeField] private Tracking_35 Tracking_35;
    [SerializeField] private Tracking_36 Tracking_36;
    [SerializeField] private Tracking_37 Tracking_37;
    [SerializeField] private Tracking_38 Tracking_38;
    [SerializeField] private Tracking_39 Tracking_39;
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
        Tracking_20 = GetComponentInChildren<Tracking_20>();
        Tracking_21 = GetComponentInChildren<Tracking_21>();
        Tracking_22 = GetComponentInChildren<Tracking_22>();
        Tracking_23 = GetComponentInChildren<Tracking_23>();
        Tracking_24 = GetComponentInChildren<Tracking_24>();
        Tracking_25 = GetComponentInChildren<Tracking_25>();
        Tracking_26 = GetComponentInChildren<Tracking_26>();
        Tracking_27 = GetComponentInChildren<Tracking_27>();
        Tracking_28 = GetComponentInChildren<Tracking_28>();
        Tracking_29 = GetComponentInChildren<Tracking_29>();
        Tracking_30 = GetComponentInChildren<Tracking_30>();
        Tracking_31 = GetComponentInChildren<Tracking_31>();
        Tracking_32 = GetComponentInChildren<Tracking_32>();
        Tracking_33 = GetComponentInChildren<Tracking_33>();
        Tracking_34 = GetComponentInChildren<Tracking_34>();
        Tracking_35 = GetComponentInChildren<Tracking_35>();
        Tracking_36 = GetComponentInChildren<Tracking_36>();
        Tracking_37 = GetComponentInChildren<Tracking_37>();
        Tracking_38 = GetComponentInChildren<Tracking_38>();
        Tracking_39 = GetComponentInChildren<Tracking_39>();
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
            Tracking_17.PathStatus & Tracking_18.PathStatus & Tracking_19.PathStatus & 
            Tracking_20.PathStatus & Tracking_21.PathStatus & 
            Tracking_22.PathStatus & Tracking_23.PathStatus & Tracking_24.PathStatus &
            Tracking_25.PathStatus & Tracking_26.PathStatus & 
            Tracking_27.PathStatus & Tracking_28.PathStatus & Tracking_29.PathStatus &
            Tracking_30.PathStatus & Tracking_31.PathStatus & 
            Tracking_32.PathStatus & Tracking_33.PathStatus & Tracking_34.PathStatus &
            Tracking_35.PathStatus & Tracking_36.PathStatus & 
            Tracking_37.PathStatus & Tracking_38.PathStatus & Tracking_39.PathStatus
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
        Tracking_20.Agent.transform.position = Tracking_20.ResetPosition;
        Tracking_21.Agent.transform.position =Tracking_21.ResetPosition;
        Tracking_22.Agent.transform.position =Tracking_22.ResetPosition;
        Tracking_23.Agent.transform.position =Tracking_23.ResetPosition;
        Tracking_24.Agent.transform.position =Tracking_24.ResetPosition;
        Tracking_25.Agent.transform.position = Tracking_25.ResetPosition;
        Tracking_26.Agent.transform.position =Tracking_26.ResetPosition;
        Tracking_27.Agent.transform.position =Tracking_27.ResetPosition;
        Tracking_28.Agent.transform.position =Tracking_28.ResetPosition;
        Tracking_29.Agent.transform.position =Tracking_29.ResetPosition;
        Tracking_30.Agent.transform.position = Tracking_30.ResetPosition;
        Tracking_31.Agent.transform.position =Tracking_31.ResetPosition;
        Tracking_32.Agent.transform.position =Tracking_32.ResetPosition;
        Tracking_33.Agent.transform.position =Tracking_33.ResetPosition;
        Tracking_34.Agent.transform.position =Tracking_34.ResetPosition;
        Tracking_35.Agent.transform.position = Tracking_35.ResetPosition;
        Tracking_36.Agent.transform.position =Tracking_36.ResetPosition;
        Tracking_37.Agent.transform.position =Tracking_37.ResetPosition;
        Tracking_38.Agent.transform.position =Tracking_38.ResetPosition;
        Tracking_39.Agent.transform.position =Tracking_39.ResetPosition;

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
        Tracking_20.PathStatus = resetStatus;
        Tracking_21.PathStatus = resetStatus;
        Tracking_22.PathStatus = resetStatus;
        Tracking_23.PathStatus = resetStatus;
        Tracking_24.PathStatus = resetStatus;
        Tracking_25.PathStatus = resetStatus;
        Tracking_26.PathStatus = resetStatus;
        Tracking_27.PathStatus = resetStatus;
        Tracking_28.PathStatus = resetStatus;
        Tracking_29.PathStatus = resetStatus;
        Tracking_30.PathStatus = resetStatus;
        Tracking_31.PathStatus = resetStatus;
        Tracking_32.PathStatus = resetStatus;
        Tracking_33.PathStatus = resetStatus;
        Tracking_34.PathStatus = resetStatus;
        Tracking_35.PathStatus = resetStatus;
        Tracking_36.PathStatus = resetStatus;
        Tracking_37.PathStatus = resetStatus;
        Tracking_38.PathStatus = resetStatus;
        Tracking_39.PathStatus = resetStatus;
    }
}
