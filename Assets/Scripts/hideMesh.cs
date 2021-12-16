using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;

public class hideMesh : MonoBehaviour
{

    public void meshOcclusion()
    {
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Occlusion;
    }

    public void suspend()
    {
        // var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        // observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Occlusion;
        // Suspend Mesh Observation from all Observers
        CoreServices.SpatialAwarenessSystem.SuspendObservers(); 
    }

    public void visible()
    {
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
    }
    public void meshDestory()
    {
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
        //dalete SpatialMeshCollider
        Destroy(GameObject.Find("Spatial Awareness System"));
        
        observer.Suspend();
    }

    public void meshResumeAndVisible()
    {
        // Resume Mesh Observation from all Observers
        CoreServices.SpatialAwarenessSystem.ResumeObservers();
        var observer = CoreServices.GetSpatialAwarenessSystemDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

        observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
    }
}
