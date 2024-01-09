using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsComponent : MonoBehaviour
{
    [SerializeField] private GameObject _analyticsGameObject;
    
    public static AnalyticsComponent instance;

    private void Start()
    {
        if (instance == null)
        { 
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
             Destroy(_analyticsGameObject);
        }
    }

    public void OnPurchased()
    {
        Analytics.CustomEvent("Purchased");
    }

    public void OnLevelVisited(int numberOfLevel)
    {
        Analytics.CustomEvent("Level Visited", new Dictionary<string, object>()
        {
            {"LevelId", numberOfLevel}
        });
    }
}
