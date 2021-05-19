using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image)), ExecuteAlways]
public class UpdateCircleMaterial : MonoBehaviour
{
    public Color32 LineColor;
    public float LineWidth ;
    public float Size;
    public Material material;

    private RectTransform rectTransform;
    private Image image;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        image.material = Instantiate(material);
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
