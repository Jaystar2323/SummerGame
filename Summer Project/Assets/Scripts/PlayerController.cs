using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float controllerDeadzone = 0.1f;
    [SerializeField] private float smoothening = 50f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shotDelay = 0.3f;
    private Rigidbody2D rb;

    private float bullCount = 0f;

    PlayerControls controls;
    Vector2 movementVec;
    Vector2 rotVec;
    bool shooting;

    void Start()
    {
        movementVec = new Vector2();
        shooting = false;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bullCount += Time.deltaTime;
        
        //transform.Translate(move, Space.World);

        if (Mathf.Abs(rotVec.x) > controllerDeadzone || Mathf.Abs(rotVec.y) > controllerDeadzone)
        {
            Vector3 playerDir = Vector3.right * rotVec.x + Vector3.forward * rotVec.y;
            if(playerDir.sqrMagnitude > 0.0f)
            {
                Quaternion newRot = Quaternion.LookRotation(playerDir, Vector3.up);
                newRot.z = -newRot.y;
                newRot.y = 0;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, newRot, smoothening * Time.deltaTime);
            }
        }
        if(bullCount >= shotDelay && shooting)
        {
            Instantiate(bullet, transform.position + transform.up/2.3f, transform.rotation);
            bullCount = 0;
        }

    }

    void FixedUpdate()
    {
        Vector2 move = new Vector2(movementVec.x, movementVec.y) * Time.deltaTime * playerSpeed;
        rb.MovePosition(new Vector2(transform.position.x, transform.position.y) + move);
    }

    void Awake()
    {
        controls = new PlayerControls();

        controls.GameControls.Move.performed += ctx => movementVec = ctx.ReadValue<Vector2>();
        controls.GameControls.Shoot.performed += ctx => shooting = true;
        controls.GameControls.Rotate.performed += ctx => rotVec = ctx.ReadValue<Vector2>();

        controls.GameControls.Move.canceled += ctx => movementVec = Vector2.zero;
        controls.GameControls.Shoot.canceled += ctx => shooting = false;
        controls.GameControls.Rotate.canceled += ctx => rotVec = Vector2.zero;
    }

    void OnEnable()
    {
        controls.GameControls.Enable();
    }
    void OnDisable()
    {
        controls.GameControls.Disable();
    }

}

