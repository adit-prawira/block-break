using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration Parameters
    
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthUnits = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        float mousePostUnits = (Input.mousePosition.x / Screen.width) * screenWidthUnits;
        Vector2 paddlePost = new Vector2(transform.position.x, transform.position.y);
        paddlePost.x = Mathf.Clamp(mousePostUnits, minX, maxX);

        transform.position = paddlePost;
    }
}
