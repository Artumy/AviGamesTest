using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class LoadBanner : MonoBehaviour
{
    [SerializeField] private string _androidAdUnitId;
    [SerializeField] private string _iosAdUnitId;

    private string _adUnitId;

    private BannerPosition _bannerPosition = BannerPosition.BOTTOM_CENTER;

    public void Initialize()
    {
        
#if UNITY_IOS
        _adUnitId = _iosAdUnitId;
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif
        
        Advertisement.Banner.SetPosition(_bannerPosition);
    }

    public void LoadAd()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerLoadError
        };
        
        Advertisement.Banner.Load(_adUnitId, options);
    }

    private void OnBannerLoaded()
    {
        Debug.Log("Banner loaded");
        ShowBannerAd();
    }

    private void OnBannerLoadError(string error)
    {
        Debug.Log("Banner failed to load " + error);
    }

    private void ShowBannerAd()
    {
        BannerOptions options = new BannerOptions
        {
            showCallback = OnBannerShow,
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden
        };
        
        Advertisement.Banner.Show(_adUnitId, options);
    }

    private void OnBannerShow()
    {
        
    }

    private void OnBannerClicked()
    {
        
    }

    private void OnBannerHidden()
    {
        
    }

    private void HideBannerAd()
    {
        Advertisement.Banner.Hide();
    }
}
