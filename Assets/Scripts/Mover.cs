using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float baseSpeed = 0.001f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use the arrow keys to move the object.");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer() 
    {

        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical");

        float speed = baseSpeed * Time.deltaTime;

        transform.Translate(xValue * speed, yValue * speed, zValue * speed);
    }       
}
