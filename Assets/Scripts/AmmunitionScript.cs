using UnityEngine;

public class AmmunitionScript : MonoBehaviour
{
    Rigidbody2D _rb;

    [SerializeField]
    float ySpeed;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb.AddForceY(ySpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
