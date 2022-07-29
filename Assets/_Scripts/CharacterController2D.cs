using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.EventSystem;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private ScriptableFloat hp;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpPower = 5f;
    [SerializeField] private Transform visual;
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private ScriptableGameEvent hitPlayer;
    [SerializeField] private ScriptableGameEvent playerDeath;
    [SerializeField] private ScriptableGameEvent playerNearDeath;

    private Vector2 movement = default(Vector2);
    private bool tryJump;
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    private void Start()
    {
        hp.Value = 100f;
    }

    private void Update()
    {
        movement.x = Input.GetAxis(HorizontalAxis);
        tryJump = Input.GetAxisRaw(VerticalAxis) > 0;
    }

    private void FixedUpdate()
    {
        movement.y = tryJump && IsGrounded ? jumpPower : rb.velocity.y;
        movement.x *= speed;
        rb.velocity = movement;

        if (movement.x != 0)
        {
            visual.rotation = Quaternion.Euler(0f, movement.x > 0f ? 0f : 180f, 0f);
        }
    }

    private bool IsGrounded => Physics2D.Linecast(transform.position, groundCheck.position, groundLayer);

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            BeHit();
        }
    }

    private void BeHit()
    {
        bool wasNearDeath = hp.Value < 30f;
        hp.Value = Mathf.Clamp(hp.Value - 10f, 0f, 100f);
        
        if (hp.Value == 0f)
        {
            playerDeath.Call();
            return;
        }

        if (!wasNearDeath && hp.Value < 30f)
        {
            playerNearDeath.Call();
        }

        hitPlayer.Call();
    }
}
