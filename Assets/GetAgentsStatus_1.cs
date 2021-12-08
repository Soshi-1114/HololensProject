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
}
