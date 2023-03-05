using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fro : MonoBehaviour
{
    public Rigidbody2D RDB;

    public float salto = 3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RDB.AddForce(Vector2.up * salto, ForceMode2D.Impulse);

        }
    }

}
