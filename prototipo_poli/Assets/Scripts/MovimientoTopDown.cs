using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTopDown : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rigidBody;
    private bool mirandoDerecha=true;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        procesarMovimiento();
    }

    void procesarMovimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(inputMovimiento * velocidad, rigidBody.velocity.y);
        gestionarOrientacion(inputMovimiento);
    }

    void gestionarOrientacion(float inputMovimiento)
    {
        if ((mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
        {
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
