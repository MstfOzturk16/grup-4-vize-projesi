using UnityEngine;

public class Tophareket : MonoBehaviour
{
    // Topa uygulanacak kuvvet miktar�
    public float kuvvetMiktari = 10f;

    // Rigidbody bile�eni
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody bile�enini al
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Space tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Topa kuvvet uygula
            rb.AddForce(10,0,0);
        }
    }
}
