using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float PlayerMoveSpeed = 10f;

    void PlayerInstructions()
    {
        //debug,log is used to print the statement in the console tab
        Debug.Log("Welcome to the game");
        Debug.Log("Move the player bby using arrow keys or WASD");
        Debug.Log("enjoy the game");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * PlayerMoveSpeed;

        float yValue = 0f;

        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * PlayerMoveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
    void Start()
    {
        PlayerInstructions();
    }

    void Update()
    {
        MovePlayer();
    }
}