using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_move : MonoBehaviour
{
    [SerializeField]
    public float speed ;

    [SerializeField]
    InputAction speedUp = new InputAction();

    [SerializeField]
    InputAction speedDown = new InputAction();

    [SerializeField]
    InputAction up = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction down = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction left = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction right = new InputAction(type: InputActionType.Button);

    public void OnEnable()
    {
        up.Enable();
        down.Enable();
        left.Enable();
        right.Enable();
    }

    public void OnDisable()
    {
        up.Disable();
        down.Disable();
        left.Disable();
        right.Disable();
    }
    private void Update()
    {

        if (up.IsPressed() && transform.position.y <= 5.1)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (down.IsPressed() && transform.position.y >= -1.6)
        {
            transform.position += new Vector3(0, -1* speed * Time.deltaTime, 0);
        }
        if (left.IsPressed()&&transform.position.x >=-12.6)
        {
            transform.localScale = new Vector3(-1, 0.8364126f, 1);
            transform.position += new Vector3( -1* speed * Time.deltaTime,0, 0);
        }
        if (right.IsPressed()&&transform.position.x <= 13)
        {
            transform.localScale = new Vector3(1,0.8364126f, 1);
            transform.position += new Vector3( speed * Time.deltaTime,0, 0);
        }

    }
    public void speedUpF(){ speed += 2; }
    public void speedDownF() 
    {
        if (speed >= 3)
        {
            speed -= 2;
        } 
    }

}
