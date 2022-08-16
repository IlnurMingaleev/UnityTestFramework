using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed;
    public Movement movement;
    public Animator _animator;
    public SpriteRenderer _spriteRenderer;  
    private void Start()
    {
        movement = new Movement(_speed);
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();   
    
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        float deltaTime = Time.deltaTime;
        if (Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput) < float.Epsilon) return;
        _animator.SetFloat("moveX", horizontalInput);
        _animator.SetFloat("moveY", verticalInput);
        if (horizontalInput < 0)
        {
            _spriteRenderer.flipX = true;
        }
        if(horizontalInput > 0) 
        {
            _spriteRenderer.flipX = false;
        }

        transform.position += movement.Calculate(
            horizontalInput,
            verticalInput, 
            deltaTime);
       
    }
    private void FixedUpdate()
    {
        float lastMoveX = Input.GetAxisRaw("Horizontal");
        float lastMoveY = Input.GetAxisRaw("Vertical");

        if (lastMoveX != 0 || lastMoveY != 0)
        {
            _animator.SetBool("isWalking", true);
            _animator.SetFloat("lastMoveX", lastMoveX);
            _animator.SetFloat("lastMoveY", lastMoveY);
        }
        else 
        {
            _animator.SetBool("isWaling", false);
        }

    }
}
