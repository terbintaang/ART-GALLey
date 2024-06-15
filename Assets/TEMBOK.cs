using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMBOK : MonoBehaviour
{
    private Rigidbody2D rb;

    public float kecepatanGerak;

    public bool berbalik;
    // Start is called before the first frame update
    void Start()
    {
        berbalik = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (berbalik)
        {
         rb.velocity = new Vector2(kecepatanGerak, rb.velocity.y);
        }
        else
        {
         rb.velocity = new Vector2(-kecepatanGerak, rb.velocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Balik"))
        {
            berbalik = !berbalik;
        }
    }
}
