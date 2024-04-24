using UnityEngine;

public class Tophareket : MonoBehaviour
{
    // Topa uygulanacak kuvvet miktarý
    public float kuvvetMiktari = 10f;

    // Rigidbody bileþeni
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody bileþenini al
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Space tuþuna basýldýðýnda
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Topa kuvvet uygula
            rb.AddForce(10,0,0);
        }
    }
}
