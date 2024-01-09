using UnityEngine;
using UnityEngine.Advertisements;

public class LoadRewarder : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] private string _androidAdUnitId;
    [SerializeField] private string _iosAdUnitId;

    private string _adUnitId;

    public void Initialize()
    {
        
#if UNITY_IOS
        _adUnitId = _iosAdUnitId;
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif
        
    }

    public void LoadAd()
    {
        Debug.Log("Loading rewarder");
        Advertisement.Load(_adUnitId, this);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        if (placementId.Equals(_adUnitId))
        {
            Debug.Log("rewarder loaded");
            ShowAd();
        }
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log("rewarder fail to load");
    }

    private void ShowAd()
    {
        Debug.Log("showing ad");
        Advertisement.Show(_adUnitId, this);
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("rewarder show to fail");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("rewarder show start");
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("rewarder clicked");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        if(placementId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsCompletionState.COMPLETED))
        Debug.Log("rewarder comleted");
    }
}
