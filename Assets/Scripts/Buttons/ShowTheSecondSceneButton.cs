using UnityEngine;
using UnityEngine.AddressableAssets;

public class ShowTheSecondsceneButton : MonoBehaviour
{
    [SerializeField] private AssetReference _sceneReference;
    [SerializeField] private int _sceneToLoad;

    public void LoadScene()
    {
        AnalyticsComponent.instance.OnLevelVisited(_sceneToLoad);
        _sceneReference.LoadSceneAsync();
    }
}
