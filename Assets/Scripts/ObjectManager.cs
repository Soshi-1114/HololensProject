using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject navigaters;

    // Start is called before the first frame update
    void Start()
    {
        navigaters.SetActive(false);
    }

    public void showObject()
    {
        navigaters.SetActive(true);
    }

    public void hideObject()
    {
        navigaters.SetActive(false);
    }
}
