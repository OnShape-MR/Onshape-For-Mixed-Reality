using IO.Swagger.Model;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceBehavior : MonoBehaviour, IMixedRealityInputHandler
{
    public PartStudiosGetBodyDetailsResponse200Faces Details;

    public OnShapeMain Main;

    private MeshRenderer _meshRenderer;
    private Material _faceMaterial;

    public void OnInputDown(InputEventData eventData)
    {
        Main.SelectFace(this);
    }

    public void OnInputUp(InputEventData eventData)
    {
        
    }

    public void Unselect()
    {
        SetMaterial(_faceMaterial);
    }

    public void SetMaterial(Material material)
    {
        GetComponent<MeshRenderer>().material = material;
    }

    public void Initialize(PartStudiosGetBodyDetailsResponse200Faces bodyDetail, Mesh m, Material faceMaterial, OnShapeMain main)
    {
        var meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = m;

        this.Details = bodyDetail;
        this.Main = main;

        var collider = GetComponent<MeshCollider>();
        collider.sharedMesh = m;

        _faceMaterial = faceMaterial;

        SetMaterial(faceMaterial);
    }
}
