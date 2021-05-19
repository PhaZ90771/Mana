using UnityEngine;

[ExecuteAlways]
public class ManaCircle : MonoBehaviour
{
    public float MinDiameter;
    public float MaxDiameter;
    public float MinTargetDiameter;
    public float MaxTargetDiameter;
    public float BreathWidth;

    public GameObject Background;
    private UpdateCircleMaterial backgroundUpdateCircleMaterial;

    public GameObject Breath;
    private UpdateCircleMaterial breathUpdateCircleMaterial;
    private OscillateCircleSize breathOscillateCircleSize;

    public GameObject TargetArea;
    private UpdateCircleMaterial targetUpdateCircleMateial;

    private void Awake()
    {
        SetupData();
    }

    private void Update()
    {
#if UNITY_EDITOR
        if (!Application.isPlaying)
        {
            SetupData();
        }
#endif
    }
    
    private void SetupData()
    {
        backgroundUpdateCircleMaterial = Background.GetComponent<UpdateCircleMaterial>();

        backgroundUpdateCircleMaterial.LineWidth = MaxDiameter - MinDiameter;
        backgroundUpdateCircleMaterial.Size = MaxDiameter;

        targetUpdateCircleMateial = TargetArea.GetComponent<UpdateCircleMaterial>();

        targetUpdateCircleMateial.LineWidth = MaxTargetDiameter - MinTargetDiameter;
        targetUpdateCircleMateial.Size = MaxTargetDiameter;

        breathUpdateCircleMaterial = Breath.GetComponent<UpdateCircleMaterial>();
        breathOscillateCircleSize = Breath.GetComponent<OscillateCircleSize>();

        breathUpdateCircleMaterial.LineWidth = BreathWidth;
        breathUpdateCircleMaterial.Size = MinDiameter + BreathWidth;

        breathOscillateCircleSize.MinSize = MinDiameter + BreathWidth;
        breathOscillateCircleSize.MaxSize = MaxDiameter;
    }
}
