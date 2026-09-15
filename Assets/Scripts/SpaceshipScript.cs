using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpaceshipScript : MonoBehaviour
{
    Rigidbody2D _rb;
    float _xDir;
    float timeLastAttack;

    [SerializeField]
    float xSpeed;

    [SerializeField]
    GameObject ammunitionPrefab;

    [SerializeField]
    float intervalBetweenAttack;

    bool attackBtnPressed = false;

    [SerializeField]
    Slider spaceshipHpSlider;

    void OnTriggerEnter2D(Collider2D other)
    {
        spaceshipHpSlider.value += 0.2f;
        if (spaceshipHpSlider.value >= 1f)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    void Movimentar()
    {
        _rb.linearVelocityX = _xDir * xSpeed * Time.deltaTime;
    }

    public void OnMove(InputValue inputValue)
    {
        Vector2 inputVector = inputValue.Get<Vector2>();
        _xDir = inputVector.x;
    }

    void FixedUpdate()
    {
        Movimentar();
    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Atirar()
    {
        float currentTime = Time.time;

        if ((currentTime - timeLastAttack) >= intervalBetweenAttack)
        {
            Instantiate(ammunitionPrefab, transform.GetChild(0).position, Quaternion.identity);
            timeLastAttack = currentTime;
        }

    }

    public void OnAttack(InputValue inputValue)
    {
        attackBtnPressed = inputValue.isPressed;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (attackBtnPressed)
            Atirar();
    }
}
