using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float moveSpeed = 10f; // скорость движения вперед/назад (z)
    public float rotateSpeed = 75f; // скорость поворота по горизонтали (x,y)
    public float jumpVelocity = 5f; // величина силы прыжка

    public float distanceToGround = 0.1f;
    public LayerMask groundLayer;

    private CapsuleCollider _col;

    public GameObject bullet; // переменная для хранения префаба пули
    public float bulletSpeed = 10f;


    // две переменные для хранения координат по осям Vertical и Horizontal
    private float vInput;
    private float hInput;

    private float axeletarionSpeed = 25f;

    private Rigidbody _rb;

    private GameBehaviour _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        // КИНЕТИЧЕСКОЕ ДВИЖЕНИЕ
        // Клавишы уже назначены в классе Input - Horizontal - a/d && Input - Vertical - w/s
        vInput = Input.GetAxis("Vertical") * moveSpeed ; // метод ищет аргумент Vertical в предопределенном классе Input и умножает его значение на 10f
        hInput = Input.GetAxis("Horizontal") * rotateSpeed; // тоже самое для поворота по горизонтали но на 75f


        /* НЕКИНЕТИЧЕСКОЕ ДВИЖЕНИЕ 
        this.transform.Translate(Vector3.forward*vInput*Time.deltaTime); 
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
        */
        if (Input.GetMouseButtonDown(0)) // проверка нажатия левой кнопки мыши где 0 - ЛКМ, 1 - ПКМ, 2 - СКМ.
        {
            GameObject newBullet = Instantiate(bullet, this.transform.position + new Vector3(1, 0, 0), this.transform.rotation) as GameObject;

            Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();

            bulletRB.velocity = this.transform.forward * bulletSpeed;

        }
    }
    void FixedUpdate()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }

        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation*angleRot);
    }

    private bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
        _col.bounds.min.y, _col.bounds.center.z);
        
        bool grounded = Physics.CheckCapsule(_col.bounds.
        center, capsuleBottom, distanceToGround, groundLayer,
        QueryTriggerInteraction.Ignore);
        
        return grounded;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            _gameManager.Health -= 1;
        }
    }


    // Попытка сделать ускорение с шифта. Куда это прикрепить )
    public float Axeleration ()
    {
        do
        {
           float fullSpeed = moveSpeed + axeletarionSpeed;
           return fullSpeed;
        }
        while (Input.GetKey(KeyCode.LeftShift));
    }
}
