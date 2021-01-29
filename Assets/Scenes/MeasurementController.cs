using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(ARRaycastManager))]
public class MeasurementController : MonoBehaviour
{
    [SerializeField]
    private GameObject measurementPointPrefab;

    [SerializeField]
    private float measurementFactor = 39.37f;

    [SerializeField]
    private Vector3 offsetMeasurement = Vector3.zero;

    [SerializeField]
    private TextMeshPro distanceText;

    [SerializeField]
    private ARCameraManager arCameraManager;
    
    private ARSessionOrigin arOrigin;

    private LineRenderer measureLine;

    private ARRaycastManager arRaycastManager;

    private GameObject startPoint;

    private GameObject endPoint;

    private Vector2 touchPosition = default;
    
    private bool activated = true;

    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake() 
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
        arOrigin = FindObjectOfType<ARSessionOrigin>();

        startPoint = Instantiate(measurementPointPrefab, Vector3.zero, Quaternion.identity);
        endPoint = Instantiate(measurementPointPrefab, Vector3.zero, Quaternion.identity);
        Debug.Log("Started");
   
        measureLine = GetComponent<LineRenderer>();
        Debug.Log("Passed");
        startPoint.SetActive(false);
        endPoint.SetActive(false);

        Debug.Log("Finished awake");
    }
    
    void Update()
    { 
        if(activated && Input.touchCount > 0)
        {
            Debug.Log("Touch detected");
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch began");
                touchPosition = touch.position;

                if(arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    Debug.Log("within plane");
                    startPoint.SetActive(true);

                    Pose hitPose = hits[0].pose;
                    startPoint.transform.SetPositionAndRotation(hitPose.position, hitPose.rotation);
                }
            }

            if(touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Touch moved");
                touchPosition = touch.position;
                
                if(arRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
                {
                    Debug.Log("Within plane2");
                    measureLine.gameObject.SetActive(true);
                    endPoint.SetActive(true);

                    Pose hitPose = hits[0].pose;
                    endPoint.transform.SetPositionAndRotation(hitPose.position, hitPose.rotation);
                }
            }
        }

        if(startPoint.activeSelf && endPoint.activeSelf)
        {
            Debug.Log("Try calc distance");
            distanceText.transform.position = endPoint.transform.position + offsetMeasurement;
            distanceText.transform.rotation = endPoint.transform.rotation;
            measureLine.SetPosition(0, startPoint.transform.position);
            measureLine.SetPosition(1, endPoint.transform.position);

            distanceText.text = $"Distance: {(Vector3.Distance(startPoint.transform.position, endPoint.transform.position) * measurementFactor).ToString("F2")} in";
        }
    }

    public void ActivateMode() {
        activated = true;
    }

    public void DeactivateMode() {
        activated = false;
    }
}