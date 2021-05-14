using UnityEngine;

[RequireComponent(typeof(LineRenderer)), ExecuteAlways]
public class DrawManaCircle : MonoBehaviour
{
    public float Radius = 10f;

    [SerializeField]
    private float SegmentsPerRadius = 10f;
    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        Draw();
    }

    private void Draw()
    {
        var vertexCount = (int)Radius * (int)SegmentsPerRadius;
        lineRenderer.positionCount = vertexCount;

        var deltaTheta = (float)(2.0f * Mathf.PI) / vertexCount;
        var theta = 0f;
        for (var i = 0; i < vertexCount; i++)
        {
            float x = Radius * Mathf.Cos(theta);
            float y = Radius * Mathf.Sin(theta);
            Vector3 position = new Vector3(x, y);

            lineRenderer.SetPosition(i, position);
            theta += deltaTheta;
        }
    }
}
