using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    Rigidbody2D _rb;

    [SerializeField]
    float speedY;

    [SerializeField]
    GameObject ExplosionVFX;

    [SerializeField]
    AudioClip clip;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject explosion = Instantiate(ExplosionVFX, transform.position, Quaternion.identity);

        if (other.transform.tag != "Shredder")
            AudioSource.PlayClipAtPoint(clip, transform.position);

        Destroy(transform.gameObject);
        Destroy(explosion, 0.5f);
    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForceY(-speedY, ForceMode2D.Impulse);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
