using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "wall")
        {
            Debug.Log("enter");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "wall")
        {
            Debug.Log("stay");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "wall")
        {
            Debug.Log("exit ");
        }
    }
}
