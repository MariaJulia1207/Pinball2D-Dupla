using UnityEngine;

public class CollisionPontosAMenos : MonoBehaviour
{
    public float velocidade = 0f;
    private Vector2 direcao = Vector2.down;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // Move o objeto constantemente na direção atual
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Menos 5 pontos.");
    }
}
