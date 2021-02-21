using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private Vector2 _moveVelocity;

    private static readonly int Speed = Animator.StringToHash("Speed");
    private static readonly int Strike = Animator.StringToHash("Strike");

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        var moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        _moveVelocity = moveInput.normalized * _speed;

        _animator.SetFloat(Speed, Mathf.Abs(_moveVelocity.x));

        _spriteRenderer.flipX = _moveVelocity.x < 0;

        if (Input.GetKeyDown(KeyCode.F))
            _animator.SetTrigger(Strike);
    }
}
