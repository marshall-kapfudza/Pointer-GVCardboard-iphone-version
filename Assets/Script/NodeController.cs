using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeController : MonoBehaviour
{

    [SerializeField]
    private Material Box_Mat;
    [SerializeField]
    private Material Outline;
    private Renderer _myRenderer;
    public bool IsSelected { get; private set; }


    [field: SerializeField]
    public CableStatic CableFront { get; private set; }
    [field: SerializeField]
    public GameObject ConnectionEndPoint { get; private set; }

    private void Start()
    {
        IsSelected = false;
        _myRenderer = GetComponent<Renderer>();
        ConnectionEndPoint = transform.GetChild(1).gameObject;
        CableFront = transform.GetChild(0).gameObject.GetComponent<CableStatic>();
        CableFront.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (!CableFront.HasEndPoint) return;
        Debug.Log("Drawing endpoint");
        CableFront.DrawCable();
    }
    public void ConnectCable(NodeController Other)
    {
        if (CableFront.HasEndPoint) return;
        CableFront.SetEndPoint(Other.ConnectionEndPoint);
        CableFront.gameObject.SetActive(true);
    }

    public void RemoveCable()
    {
        CableFront.SetEndPoint(null);
        CableFront.gameObject.SetActive(false);
    }
    public void OnSelect()
    {
        IsSelected = !IsSelected;
        SetMaterial(IsSelected);
    }

    private void SetMaterial(bool gazedAt)
    {
        if (Box_Mat != null && Outline != null)
        {
            _myRenderer.material = gazedAt ?  Outline : Box_Mat;
        }
    }
}
