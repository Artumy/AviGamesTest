using UnityEngine;
using UnityEngine.Purchasing;
public class Purchaser : MonoBehaviour
{
    [SerializeField] private Background _background;

    private const string removeAdsString = "com.defaultcompany.testavigames.removeads";
    private const string newColorString = "com.defaultcompany.testavigames.newcolor";
    
    public void OnPurchaseComleted(Product product)
    {
        switch (product.definition.id)
        {
            case removeAdsString :
                RemoveAds();
                break;
            case newColorString :
                ChangeBackgroundColor();
                break;
        }
        
        AnalyticsComponent.instance.OnPurchased();
    }

    private void RemoveAds()
    {
        PlayerPrefs.SetInt("removeads", 1);
        UIInfo.instance.UpdateRemoveAdsButton();
    }

    private void ChangeBackgroundColor()
    {
        _background.ChangeColor();
    }
}
