using UnityEngine;
using UnityEngine.Advertisements;

public class LoadInterstitial : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
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
        Debug.Log("Loading interstitial");
        Advertisement.Load(_adUnitId, this);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        ShowAd();
        Debug.Log("interstitisl loaded");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log("interstitisl fail to load");
    }

    private void ShowAd()
    {
        Debug.Log("showing ad");
        Advertisement.Show(_adUnitId, this);
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("interstitisl show to fail");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("interstitisl show start");
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("interstitisl clicked");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("interstitisl comleted");
    }
}
