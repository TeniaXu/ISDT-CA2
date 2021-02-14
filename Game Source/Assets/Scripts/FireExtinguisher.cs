using UnityEngine;
using System.Collections;

public class FireExtinguisher : MonoBehaviour
{
    // Declare 2 public GameObject for the fire extinguisher steam and fire
    public GameObject FireExtinguisherSteam;
    public GameObject fire;

    private float STEAM_DISTANCE = 10f;

    private float distFire;

    //if the fire extinguisher is within the certain distance from the fire, the steam from the extinguisher will shoot
    void update()
    {
        distFire = Vector3.Distance(FireExtinguisherSteam.transform.position, transform.position);

        if (distFire < STEAM_DISTANCE)
        {
            fire.SetActive(true);
        }
        else
        {
            fire.SetActive(false);
        }
    }

}
