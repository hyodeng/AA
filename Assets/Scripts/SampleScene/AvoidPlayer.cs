using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class AvoidPlayer : MonoBehaviour
{
    public Animator animator;

    public float Speed = 3f;
    private Vector3 direction = Vector3.zero;
    PlayerInputActions actions;

    public GameObject gameover = null;
    public GameObject Mobspoan = null;
    public GameObject Timer = null;
    public GameObject MainButton = null;

    // Start is called before the first frame update
    private void Awake()
    {
        actions = new PlayerInputActions();
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }
    private void LateUpdate()
    {
        transform.transform.position = new Vector3(transform.position.x, -3.62f, 0);
    }
    private void OnEnable()
    {
        actions.Enable();
        actions.Player.Move.performed += OnMove;
        actions.Player.Move.canceled += OnMove;
    }
    private void OnDisable()
    {
        actions.Player.Move.canceled -= OnMove;
        actions.Player.Move.performed -= OnMove;
        actions.Disable();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();
        rigid.MovePosition(transform.position + (direction * Speed * Time.fixedDeltaTime));

        direction = context.ReadValue<Vector2>();
        if (direction.sqrMagnitude > 0)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mob"))
        {
            Destroy(this.gameObject);
            float Tamp = Timer.GetComponent<Score>().Timecurrent;
            gameover.GetComponent<Text>().text = $"Game Over \n 최종 점수:{Tamp}";
            gameover.SetActive(true);
            MainButton.SetActive(true);
            Mobspoan.SetActive(false);
            
            Timer.SetActive(false);
        }
    }

}
