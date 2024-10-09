using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceAndAttack : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;

    public Animator a1;

    void Update()
    {
        if(Vector3.Distance(cactus1.transform.position, cactus2.transform.position) < 0.25f)
        {
            a1.SetBool("attack", true);
        }
        else
        {
            a1.SetBool("attack", false);
        }
    }
}
