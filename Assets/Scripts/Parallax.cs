using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float AnimationSpeed = 0.25f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.sharedMaterial.mainTextureOffset += new Vector2(AnimationSpeed * Time.deltaTime, 0);
    }
}
