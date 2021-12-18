using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController : MonoBehaviour
{
    [SerializeField]
    private Material Box_Mat;
    [SerializeField]
    private Material Outline;
    private Renderer _myRenderer;
    private bool _isSelected;
    private void Awake()
    {
        _myRenderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _isSelected = false;
    }
    public void OnClick()
    {
        _isSelected = !_isSelected;
        SetMaterial(_isSelected);
    }
    public void OnHover()
    {
        SetMaterial(_isSelected);
    }
    public void OnExit()
    {
        SetMaterial(!_isSelected);
    }
    private void SetMaterial(bool gazedAt)
    {
        if (Box_Mat != null && Outline != null)
        {
            _myRenderer.material = gazedAt ? Box_Mat : Outline;
        }
    }
}
