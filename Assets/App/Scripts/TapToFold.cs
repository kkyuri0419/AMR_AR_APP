using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToFold : MonoBehaviour
{
    public GameObject AMRSitting;
    public GameObject AMRStanding;



    public void AMRdown()
    {
        var position = AMRStanding.transform.position;
        var rotation = AMRStanding.transform.rotation;
        AMRSitting.transform.SetPositionAndRotation(position, rotation);
        AMRStanding.transform.gameObject.SetActive(false);
        AMRSitting.gameObject.SetActive(true);

    }
}
