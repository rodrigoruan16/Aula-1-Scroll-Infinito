using UnityEngine;
using System.Collections;
using System.Numerics;

public class ScrollBackground : MonoBehaviour
{

    [SerializeField]
    float velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Material material = GetComponent<SpriteRenderer>().material;
        float x_offset = material.mainTextureOffset.x + Time.deltaTime * velocity;
        material.mainTextureOffset = new UnityEngine.Vector2(x_offset, 0);
    }
}
