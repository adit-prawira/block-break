using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Configuration parameter
    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    bool hasStarted = false;
    // Start
    Vector2 paddleToBallVector;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted) { 
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
        
    }
    private void LaunchOnMouseClick(){ 
        if(Input.GetMouseButtonDown(0)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }
    private void LockBallToPaddle() 
    { 
        Vector2 paddlePost = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePost + paddleToBallVector;
    }

    
}
