using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{
    // Declare 2 public GameObject for the fire and steam
    public GameObject Steam;
    public GameObject FireSmoke;

    private float FIRE_DISTANCE = 20f;

    private float distFire;

    // if the steam from the fire extinguisher is lesser than the stated distance from the fire, the fire will be set to off.
    void update()
    {
        distFire = Vector3.Distance(Steam.transform.position, transform.position);


        if (distFire < FIRE_DISTANCE)
        {
            FireSmoke.SetActive(false);
        }
        else
        {
            FireSmoke.SetActive(true);
        }
    }

}
