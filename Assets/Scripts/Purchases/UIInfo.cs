using UnityEngine;

public class UIInfo : MonoBehaviour
{
    [SerializeField] private GameObject _removeAds;

    public static UIInfo instance;
    
    private void Start()
    {
        instance = this;
        UpdateRemoveAdsButton();
    }

    public void UpdateRemoveAdsButton()
    {
        bool removeAds = PlayerPrefs.GetInt("removeads") == 1;
        _removeAds.SetActive(!removeAds);
    }
    
}
