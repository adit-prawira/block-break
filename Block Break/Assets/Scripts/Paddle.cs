using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthUnits = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePostUnits = (Input.mousePosition.x / Screen.width) * screenWidthUnits;
        Vector2 paddlePost = new Vector2(mousePostUnits, transform.position.y);
        transform.position = paddlePost;
    }
}
