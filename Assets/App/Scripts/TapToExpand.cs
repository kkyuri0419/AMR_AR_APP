using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToExpand : MonoBehaviour
{
    public GameObject AMRSitting;
    public GameObject AMRStanding;


    public void AMRup()
    {
        var position = AMRSitting.transform.position;
        var rotation = AMRSitting.transform.rotation;
        AMRStanding.transform.SetPositionAndRotation(position, rotation);
        AMRSitting.transform.gameObject.SetActive(false);
        AMRStanding.gameObject.SetActive(true);

    }
}
