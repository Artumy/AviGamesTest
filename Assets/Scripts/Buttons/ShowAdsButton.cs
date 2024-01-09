using UnityEngine;

public class ShowAdsButton : MonoBehaviour
{
    [SerializeField] private LoadInterstitial _loadInterstitial;
    
    private void OnMouseDown()
    {
        _loadInterstitial.LoadAd();
    }
    
}
