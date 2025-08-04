using UnityEngine;
using UnityEngine.InputSystem;

public class FruitDropper : MonoBehaviour
{
    private PlayerInput _playerInput;
    private InputAction _move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _move = _playerInput.actions.FindAction("Move");
        _playerInput.ActivateInput();
    }

    // Update is called once per frame
    void Update()
    {
        var moveValue = _move.ReadValue<Vector2>();
        
        if (moveValue.x != 0f)
        {
            var fruitDropper = GameObject.Find("fruit-dropper");
            fruitDropper.transform.position += new Vector3(moveValue.x * 0.1f, 0, 0);
            //Debug.Log(moveValue);
        }
    }
}
