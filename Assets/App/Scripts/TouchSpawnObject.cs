using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;



public class TouchSpawnObject : MonoBehaviour, IMixedRealityTouchHandler
{

    public GameObject spawningObject;
    public GameObject anchorObject;

    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
        spawningObject.transform.position = anchorObject.transform.position;
        //spawningObject.transform.Translate(Vector3.right * 0.5f, anchorObject.transform);
        spawningObject.transform.gameObject.SetActive(true);

    }
    public void OnTouchCompleted(HandTrackingInputEventData eventData) { }
    public void OnTouchUpdated(HandTrackingInputEventData eventData) { }
}

