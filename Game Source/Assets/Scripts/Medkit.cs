using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medkit : MonoBehaviour
{
    //After picking up medkit, bringing it to the dummy will complete the 2nd part of the task and game will quit
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "medkit")
            Destroy(collider.gameObject);
        Application.Quit();
    }
}
