using UnityEngine;

[RequireComponent(typeof(UpdateCircleMaterial))]
public class OscillateCircleSize: MonoBehaviour
{
    public float MinSize = 150f;
    public float MaxSize = 300f;

    private UpdateCircleMaterial updateCircleMaterial;

    private void Awake()
    {
        updateCircleMaterial = GetComponent<UpdateCircleMaterial>();
    }

    private void Update()
    {
        var t = Mathf.Abs(Mathf.Sin(Time.time));
        var size = Mathf.Lerp(MinSize, MaxSize, t);
        updateCircleMaterial.Size = size;
    }
}
