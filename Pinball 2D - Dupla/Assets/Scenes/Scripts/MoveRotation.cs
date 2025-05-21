using UnityEngine;

public class MoveRotation : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) // Rotaciona para a esquerda
        {
            rb.MoveRotation(rb.rotation - 1f); // Reduz o ângulo
        }
        if (Input.GetKey(KeyCode.RightArrow)) // Rotaciona para a direita
        {
            rb.MoveRotation(rb.rotation + 1f); // Aumenta o ângulo
        }
    }
}
