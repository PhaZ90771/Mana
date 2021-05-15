using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image)), ExecuteAlways]
public class UpdateCircleMaterial : MonoBehaviour
{
    public Color LineColor = Color.cyan;
    public float LineWidth = 5f;
    public float Width = 100f;
    public float Height = 100f;

    private RectTransform rectTransform;
    private Image image;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    private void Update()
    {
        rectTransform.sizeDelta = new Vector2(Width, Height);

        image.material.SetColor("_Color", LineColor);
        image.material.SetFloat("_LineWidth", LineWidth);
        image.material.SetFloat("_Width", Width);
        image.material.SetFloat("_Height", Height);
    }
}
