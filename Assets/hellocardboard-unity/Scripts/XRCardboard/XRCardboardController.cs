﻿#if !UNITY_EDITOR
using Google.XR.Cardboard;
using UnityEngine.XR.Management;
#endif
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SpatialTracking;

public class XRCardboardController : MonoBehaviour
{
    [SerializeField]
    Transform cameraTransform = default;
    [SerializeField]
    GameObject vrGroup = default;
    [SerializeField]
    GameObject standardGroup = default;
    [SerializeField]
    XRCardboardInputModule vrInputModule = default;
    [SerializeField]
    StandaloneInputModule standardInputModule = default;
    [SerializeField, Range(.05f, 2)]
    float dragRate = .2f;

//    Gamepad controller;
//    ControllerInputHandler controllerHandler;


    TrackedPoseDriver poseDriver;
    Camera cam;
    Quaternion initialRotation;
    Quaternion attitude;
    Vector2 dragDegrees;
    float defaultFov;

#if UNITY_EDITOR
    Vector3 lastMousePos;
    bool vrActive;
#endif

    void Awake()
    {
//        controllerHandler = gameObject.AddComponent<ControllerInputHandler>() as ControllerInputHandler;
        cam = cameraTransform.GetComponent<Camera>();
        poseDriver = cameraTransform.GetComponent<TrackedPoseDriver>();
        defaultFov = cam.fieldOfView;
        initialRotation = cameraTransform.rotation;
        
    }
    
    void Start()
    {

#if UNITY_EDITOR
    SetObjects(vrActive);
#else
        SetObjects(UnityEngine.XR.XRSettings.enabled);
#endif
    }

    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Escape))
#else
        if (Api.IsCloseButtonPressed)
#endif
            DisableVR();

#if UNITY_EDITOR
        if (vrActive)
            SimulateVR();
        else
        {
            SimulateDrag();
            
        }
        
        
//        controllerHandler.ExcuteInput(Gamepad.current);

#else
        if (UnityEngine.XR.XRSettings.enabled)
            return;

        CheckDrag();
#endif

        attitude = initialRotation * Quaternion.Euler(Mathf.Clamp(dragDegrees.x, -45f, 45f), 0, 0);
        cameraTransform.rotation = Quaternion.Euler(0, Mathf.Clamp(-dragDegrees.y, -90f, 90f), 0) * attitude;
    }

    

    public void ResetCamera()
    {
        cameraTransform.rotation = initialRotation;
        dragDegrees = Vector2.zero;
    }

    public void DisableVR()
    {
#if UNITY_EDITOR
        vrActive = false;
#else
        var xrManager = XRGeneralSettings.Instance.Manager;
        if (xrManager.isInitializationComplete)
        {
            xrManager.StopSubsystems();
            xrManager.DeinitializeLoader();
        }
#endif
        SetObjects(false);
        ResetCamera();
        cam.ResetAspect();
        cam.fieldOfView = defaultFov;
        cam.ResetProjectionMatrix();
        cam.ResetWorldToCameraMatrix();
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
    }

    public void EnableVR() => EnableVRCoroutine();

    public Coroutine EnableVRCoroutine()
    {
        return StartCoroutine(enableVRRoutine());

        IEnumerator enableVRRoutine()
        {
            SetObjects(true);
#if UNITY_EDITOR
            yield return null;
            vrActive = true;
#else
            var xrManager = XRGeneralSettings.Instance.Manager;
            if (!xrManager.isInitializationComplete)
                yield return xrManager.InitializeLoader();
            xrManager.StartSubsystems();
#endif
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            ResetCamera();
        }
    }

    void SetObjects(bool vrActive)
    {
        standardGroup.SetActive(!vrActive);
        vrGroup.SetActive(vrActive);
        standardInputModule.enabled = !vrActive;
        vrInputModule.enabled = vrActive;
        poseDriver.enabled = vrActive;
    }

    void CheckDrag()
    {
        if (Input.touchCount <= 0)
            return;

        Touch touch = Input.GetTouch(0);
        dragDegrees.x += touch.deltaPosition.y * dragRate;
        dragDegrees.y += touch.deltaPosition.x * dragRate;
    }

#if UNITY_EDITOR
    void SimulateVR()
    {
        var mousePos = Input.mousePosition;
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            var delta = mousePos - lastMousePos;
            dragDegrees.x -= delta.y * dragRate;
            dragDegrees.y -= delta.x * dragRate;
        }
        lastMousePos = mousePos;
    }

    void SimulateDrag()
    {
        var mousePos = Input.mousePosition;
        if (Input.GetMouseButton(0))
        {
            var delta = mousePos - lastMousePos;
            dragDegrees.x += delta.y * dragRate;
            dragDegrees.y += delta.x * dragRate;
        }
        lastMousePos = mousePos;
    }

    /*private void ControllerDrag()
    {
        var axis = controller.rightStick.ReadValue();
        Vector3 controllerPos = new Vector3(axis.x, axis.y, lastMousePos.z);
        if (controller.rightStick.IsPressed())
        {
            
            var delta = controllerPos - lastMousePos;
            dragDegrees.x -= delta.y * dragRate;
            dragDegrees.y -= delta.x * dragRate;
        }
        lastMousePos = controllerPos;
    }*/
#endif
}