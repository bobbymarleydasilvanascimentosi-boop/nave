
using UnityEngine;

public class NaveMovimento : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade = 5f;

    [Header("Tiro")]
    public GameObject laser;
    public Transform pontoDeTiroEsquerdo;
    public Transform pontoDeTiroDireito;

    private Rigidbody2D rb;
    private Vector2 movimento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movimento
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movimento = new Vector2(horizontal, vertical).normalized;

        // Atirar com Espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Atirar();
        }
    }

    void FixedUpdate()
    {
        // Move a nave
        rb.MovePosition(
            rb.position + movimento * velocidade * Time.fixedDeltaTime
        );
    }

    void Atirar()
    {
        // Laser esquerdo
        Instantiate(
            laser,
            pontoDeTiroEsquerdo.position,
            pontoDeTiroEsquerdo.rotation
        );

        // Laser direito
        Instantiate(
            laser,
            pontoDeTiroDireito.position,
            pontoDeTiroDireito.rotation
        );
    }
}

