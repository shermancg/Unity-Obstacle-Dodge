using UnityEngine;

public class script_mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 1f;
    void Start()
    {
        PrintInstructions();
    }
 
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
{
    Debug.Log("Welcome to the game!");
    Debug.Log("Move using arrow keys or WASD");
    Debug.Log("Reach the end without bumping into objects");
}

    void MovePlayer()
{
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
}

}
