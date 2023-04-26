/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;

public class ARPlacementMultiple : MonoBehaviour
{
    public GameObject arObjectToSpawm;
    public GameObject placementIndicator;
    private GameObject spawnObject;


    private Pose PlacementPose;
    private ARRaycastManager aRRaycastManager;
    private bool placementPoseIsValid = false;

    void Start()
    {
        aRRaycastManager = FindObjectOfType<ARRaycastManager>();
        placementIndicator.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ARPlaceObject();
        }

        UpdatePlacementPose();
        // UpdatePlacementIndicator();

    }

    void UpdatePlacementIndicator()
    {
        if (spawnObject == null && placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(PlacementPose.position, PlacementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);

        }
    }

    void UpdatePlacementPose()
    {
        var screenCenter = Camera.main.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        aRRaycastManager.Raycast(screenCenter, hits, TrackableType.Planes);

        placementPoseIsValid = hits.Count > 0;
        if (placementPoseIsValid)
        {
            PlacementPose = hits[0].pose;
        }

        if (placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(PlacementPose.position, PlacementPose.rotation);
        }
    }

    void ARPlaceObject()
    {
        // spawnObject = Instantiate(arObjectToSpawm,PlacementPose.position,PlacementPose.rotation);
        var pos = PlacementPose.position;
        var rot = PlacementPose.rotation;
        spawnObject = Instantiate(arObjectToSpawm, pos, rot);
    }
}*/