using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    [SerializeField] private Image _image;
    
    public void ChangeColor()
    {
        switch (Random.Range(0, 7))
        {
            case 0:
                _image.color = Color.blue;
                break;
            case 1:
                _image.color = Color.black;
                break;
            case 2:
                _image.color = Color.gray;
                break;
            case 3:
                _image.color = Color.green;
                break;
            case 4:
                _image.color = Color.red;
                break;
            case 5:
                _image.color = Color.yellow;
                break;
            case 6:
                _image.color = Color.magenta;
                break;
            case 7:
                _image.color = Color.cyan;
                break;
        }
    }
}
