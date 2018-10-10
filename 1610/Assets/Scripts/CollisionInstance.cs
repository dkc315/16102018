using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class CollisionInstance : MonoBehaviour
{

    public GameObject XPos, XNeg;
    public GameObject YPos, YNeg;
    public GameObject ZPos, ZNeg;
    public GameObject XYPos, XYNeg;
    public GameObject XZPos, XZNeg;
    public GameObject YZPos, YZNeg;


    private void OnCollisionEnter(Collision other)
    {
        Instantiate(XPos, transform.position, transform.rotation);
        Instantiate(XNeg, transform.position, transform.rotation);
        Instantiate(YPos, transform.position, transform.rotation);
        Instantiate(YNeg, transform.position, transform.rotation);
        Instantiate(ZPos, transform.position, transform.rotation);
        Instantiate(ZNeg, transform.position, transform.rotation);
        Instantiate(XYPos, transform.position, transform.rotation);
        Instantiate(XYNeg, transform.position, transform.rotation);
        Instantiate(XZPos, transform.position, transform.rotation);
        Instantiate(XZNeg, transform.position, transform.rotation);
        Instantiate(YZPos, transform.position, transform.rotation);
        Instantiate(YZNeg, transform.position, transform.rotation);

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}