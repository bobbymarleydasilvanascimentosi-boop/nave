

using UnityEngine;

public class Laser : MonoBehaviour
{
    public float velocidade = 10f;

    void Update()
    {
        // Move o laser para a direita
        transform.position += Vector3.right * velocidade * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

