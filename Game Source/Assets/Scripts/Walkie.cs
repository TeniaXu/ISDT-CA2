using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkie : MonoBehaviour
{
    public GameObject Medkit;

    //When walkie talkie is picked up and brought near the dummy, 1st part of task will be done and
    //medkit will be spawned
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Walkie")
            Medkit.SetActive(true);   
    }
}
