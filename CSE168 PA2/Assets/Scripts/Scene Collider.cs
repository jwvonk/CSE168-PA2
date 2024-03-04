using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using static OVRPlugin;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]

public class ScenePlaneCollider : MonoBehaviour
{
    private MeshFilter _meshFilter;
    private MeshCollider _meshCollider; // Added MeshCollider field

    // Start is called before the first frame update
    void Start()
    {
        _meshFilter = GetComponent<MeshFilter>();
        _meshCollider = GetComponent<MeshCollider>(); // Get MeshCollider component
    }

    private void UpdateMeshCollider()
    {
        if (_meshCollider == null)
            return;

        _meshCollider.sharedMesh = _meshFilter.sharedMesh;
    }


    private void Update()
    {
        UpdateMeshCollider(); // Update the MeshCollider with the generated mesh
    }
}
