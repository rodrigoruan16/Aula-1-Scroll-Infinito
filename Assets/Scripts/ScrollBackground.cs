using UnityEngine;

public class ScrollBackground : MonoBehaviour
{

    [SerializeField]
    float velocity;

    private Material material;
    private Vector2 offset;

    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x_offset = Time.deltaTime * velocity;
        offset.x += x_offset;

        material.mainTextureOffset = offset;
    }
}
