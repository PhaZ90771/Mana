using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image)), ExecuteAlways]
public class UpdateCircleMaterial : MonoBehaviour
{
    public Color LineColor = Color.cyan;
    public float LineWidth = 5f;
    public float Size = 100f;

    private RectTransform rectTransform;
    private Image image;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    private void Update()
    {
        rectTransform.sizeDelta = new Vector2(Size, Size);

        image.material.SetColor("_Color", LineColor);
        image.material.SetFloat("_LineWidth", LineWidth);
        image.material.SetFloat("_Width", Size);
        image.material.SetFloat("_Height", Size);
    }
}
