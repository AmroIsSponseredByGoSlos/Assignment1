using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Input.mousePosition;
        Vector2 MouseWorldPosition = Camera.main.ScreenToWorldPoint(MousePos);
        transform.up = MouseWorldPosition;
    }
}
