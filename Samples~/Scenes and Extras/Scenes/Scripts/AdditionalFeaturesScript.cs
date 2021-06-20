using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class AdditionalFeaturesScript : MonoBehaviour
{
    public PixelPerfectCamera pixelPerfectCamera;

    public void SetBackgroundColor(GameObject button)
    {
        var img = button.GetComponent<Image>();
        if (img != null)
        {
            pixelPerfectCamera.backgroundColor = img.color;
        }
    }

    public void SetViewportAnchor(int anchor)
    {
        pixelPerfectCamera.anchor = (ViewportAnchor)anchor;
    }
}
