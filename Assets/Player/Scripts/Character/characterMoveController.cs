using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMoveController : MonoBehaviour{
    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    [SerializeField]private float mainSpeed = 3.0f;
    public float normalSpeed = 3.0f;
    public float dashSpped = 6.0f;
    public float mainJampSpeed = 8.0f;
    private float gravity = 20.0f;


    void Start(){
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        CharacterControllerMove();

        if (Input.GetKey(KeyCode.LeftShift)){
            mainSpeed = dashSpped;
        }else{
            mainSpeed = normalSpeed;
        }
    }

    private void CharacterControllerMove()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * mainSpeed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = mainJampSpeed;
            }
        }
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
    }
}
