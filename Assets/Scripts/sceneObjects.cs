using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneObjects : MonoBehaviour
{
    public GameObject evacuees;
    public GameObject wanders;
    public GameObject navigaters;

    // Start is called before the first frame update
    void Start()
    {
        evacuees.SetActive(false);
        wanders.SetActive(false);
        navigaters.SetActive(false);
    }

    public void showObject()
    {
        evacuees.SetActive(true);
        wanders.SetActive(true);
        navigaters.SetActive(true);
    }

    public void hideObject()
    {
        evacuees.SetActive(false);
        wanders.SetActive(false);
        navigaters.SetActive(false);
    }
}
