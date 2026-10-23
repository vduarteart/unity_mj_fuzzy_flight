using UnityEngine;

public class CartoonFaceController : MonoBehaviour
{
    [Header("Boca")]
    public SkinnedMeshRenderer face;
    public string mouthShapeName = "Mouth_Open";
    [Min(0.01f)]
    public float cyclesPerSecond = 1.5f;

    [Header("Olho esquerdo")]
    public Transform leftEyeSphere;
    public Transform leftPupilBone;
    public float leftEyeRadius = 0.5f;

    [Header("Olho direito")]
    public Transform rightEyeSphere;
    public Transform rightPupilBone;
    public float rightEyeRadius = 0.5f;

    [Header("Movimento dos olhos")]
    [Range(0f, 0.8f)]
    public float horizontalRange = 0.35f;

    [Range(0f, 0.8f)]
    public float verticalRange = 0.25f;

    public float pupilOffset = 0.005f;
    public float moveSpeed = 5f;
    public float changeDirectionEvery = 1.5f;

    private int mouthIndex = -1;
    private Vector2 lookTarget;
    private Vector2 lookCurrent;
    private float nextChange;

    void Start()
    {
        if (face != null && face.sharedMesh != null)
        {
            mouthIndex = face.sharedMesh
                .GetBlendShapeIndex(mouthShapeName);
        }

        ChooseTarget();

        Debug.Log("CartoonFaceController iniciado.");

Debug.Log("Face: " + (face != null ? face.name : "NÃO ATRIBUÍDA"));
Debug.Log("Olho esquerdo: " + (leftEyeSphere != null ? leftEyeSphere.name : "NÃO ATRIBUÍDO"));
Debug.Log("Osso esquerdo: " + (leftPupilBone != null ? leftPupilBone.name : "NÃO ATRIBUÍDO"));
Debug.Log("Olho direito: " + (rightEyeSphere != null ? rightEyeSphere.name : "NÃO ATRIBUÍDO"));
Debug.Log("Osso direito: " + (rightPupilBone != null ? rightPupilBone.name : "NÃO ATRIBUÍDO"));

    }

    void Update()
    {
        AnimateMouth();
        AnimateEyes();
    }

    void AnimateMouth()
    {
        if (face == null || mouthIndex < 0)
            return;

        // Ciclo contínuo: peso de 0 a 100.
        float weight = (1f -
            Mathf.Cos(Time.time * cyclesPerSecond *
            Mathf.PI * 2f)) * 50f;

        face.SetBlendShapeWeight(mouthIndex, weight);
    }

    void AnimateEyes()
    {
        if (Time.time >= nextChange)
            ChooseTarget();

        lookCurrent = Vector2.Lerp(
            lookCurrent,
            lookTarget,
            Time.deltaTime * moveSpeed
        );

        MovePupil(leftEyeSphere, leftPupilBone,
            leftEyeRadius);

        MovePupil(rightEyeSphere, rightPupilBone,
            rightEyeRadius);
    }

  void MovePupil(
    Transform eye,
    Transform pupilBone,
    float radius)
{
    if (eye == null || pupilBone == null)
        return;

    // X negativo aponta para a frente do Fuzzy.
    Vector3 forward = -eye.right;

    // Y é o eixo lateral e Z é o eixo vertical.
    Vector3 horizontal = eye.up;
    Vector3 vertical = -eye.forward;

    Vector3 direction = (
        forward
        + horizontal * lookCurrent.x * horizontalRange
        + vertical * lookCurrent.y * verticalRange
    ).normalized;

    pupilBone.position = eye.position + direction * radius;
}

    void ChooseTarget()
    {
        lookTarget = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        );

        nextChange = Time.time + changeDirectionEvery;
    }
}