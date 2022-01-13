using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;



public class TouchSpawnSlate : MonoBehaviour, IMixedRealityTouchHandler
{

    public GameObject spawningObject;
    public GameObject anchorObject;

    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
        spawningObject.transform.position = anchorObject.transform.position;
//        spawningObject.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        //spawningObject.transform.Translate(Vector3.back * 0.1f, anchorObject.transform);
        spawningObject.transform.gameObject.SetActive(true);

    }
    public void OnTouchCompleted(HandTrackingInputEventData eventData) { }
    public void OnTouchUpdated(HandTrackingInputEventData eventData) { }
}

