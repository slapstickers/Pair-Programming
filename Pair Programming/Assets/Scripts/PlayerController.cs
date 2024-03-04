using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalMoveSpeed = 5;
    public float horizontalMoveSpeed = 3;
    public float vInput;
    public float hInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxisRaw("Vertical");
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.up * verticalMoveSpeed * vInput * Time.deltaTime);
        transform.Translate(Vector2.right * horizontalMoveSpeed * hInput * Time.deltaTime);
    }
}
