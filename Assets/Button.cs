using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject newButton;
  
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void ChangeColor()
    {
        newButton.GetComponent<Image>().color = Color.white;
    }
}
