using UnityEngine;
using UnityEngine.Advertisements;

public class InitializeAds : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] private string _androidGameId;
    [SerializeField] private string _iosGameId;
    [SerializeField] private bool _isTestingMode;

    [Header("AdsType")] 
    [SerializeField] private LoadBanner _loadBanner;
    [SerializeField] private LoadInterstitial _loadInterstitial;
    [SerializeField] private LoadRewarder _loadRewarder;
    

    private string _gameId;

    private void Start()
    { 
            Initialize(); 
            _loadBanner.Initialize();
            _loadInterstitial.Initialize();
            _loadRewarder.Initialize();
    }   

    private void Initialize()
    {
            
#if UNITY_IOS
        _gameId = _iosGameID;
#elif UNITY_ANDROID
        _gameId = _androidGameId;
#elif UNITY_EDITOR
        _gameId = _androidGameId;
#endif
        
        if(!Advertisement.isInitialized && Advertisement.isSupported)
                Advertisement.Initialize(_gameId, _isTestingMode, this);
    }

    public void OnInitializationComplete()
    {
            Debug.Log("Ads initializated");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
            Debug.Log("Fail to initialize");
    }
}
