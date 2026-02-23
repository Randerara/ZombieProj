using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Maze : MonoBehaviour
{
    public GameObject maze;

    private InputAction turn;

    public float turnSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turn = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 turnValue = turn.ReadValue<Vector2>();
        maze.transform.Rotate(new Vector3(-turnValue.x, 0, -turnValue.y) * turnSpeed * Time.deltaTime);
        Debug.Log("Turn wall x: " + turnValue.x + " turn wall y: " + turnValue.y);
    }
}
