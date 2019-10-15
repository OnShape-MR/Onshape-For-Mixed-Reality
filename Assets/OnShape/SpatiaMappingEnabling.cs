using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatiaMappingEnabling : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowMapping()
    {
        // Cast the Spatial Awareness system to IMixedRealityDataProviderAccess to get an Observer
        var access = CoreServices.SpatialAwarenessSystem as IMixedRealityDataProviderAccess;

        // Get the first Mesh Observer available, generally we have only one registered
        var observer = access.GetDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        // Resumes observation of spatial mesh data
        observer.DisplayOption=SpatialAwarenessMeshDisplayOptions.Visible;

    }
    public void HideMapping()
    {
        // Cast the Spatial Awareness system to IMixedRealityDataProviderAccess to get an Observer
        var access = CoreServices.SpatialAwarenessSystem as IMixedRealityDataProviderAccess;

        // Get the first Mesh Observer available, generally we have only one registered
        var observer = access.GetDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        // Resumes observation of spatial mesh data
        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
