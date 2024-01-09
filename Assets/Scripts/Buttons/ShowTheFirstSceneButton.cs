using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowTheFirstSceneButton : MonoBehaviour
{
    [SerializeField] private int _sceneToLoad;
    private void OnMouseDown()
    {
        AnalyticsComponent.instance.OnLevelVisited(_sceneToLoad);
        SceneManager.LoadScene(_sceneToLoad);
    }
}
