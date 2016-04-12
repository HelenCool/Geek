using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {
    public float maxSpeed = 10f;
    private bool isFacingRight = true;
    private Animator anim;
    private Rigidbody2D rb;
    private GameObject player;
    private GameObject death;
    

    [SerializeField]
    private Transform[] groundPoint;
    [SerializeField]
    private float groundRadius;
    [SerializeField]
    private LayerMask whatIsGround;
    public static bool isGrounded = true;

    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<GameObject>();


        death = GameObject.Find("Dead");
        death.GetComponent<Image>().enabled = false;
    }
	

	void FixedUpdate () {

        isGrounded = IsGrounded();

        //Debug.Log(isGrounded);
        if (isGrounded == true)
        {
            rb.velocity += 9 * Vector2.up;
        }



        float move = Input.GetAxis("Horizontal");
        //float move = Input.acceleration.x;
        anim.SetFloat("Speed", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        

        if (move > 0 && !isFacingRight)
            Flip();
        else if (move < 0 && isFacingRight)
            Flip();
	}


    private void Flip () //пoворачивает персонажа в сторону ходьбы
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    } 


    void Update ()
    {
        
    }

    void OnBecameInvisible()
    {
        enabled = false;
        Debug.Log("THE GAME IS ENDED");

        death.GetComponent<Image>().enabled = true;
        Invoke("Reload", 2f);
        

    }


    void OnBecameVisible()
    {
        enabled = true;
        
    }


    public void Reload()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }

    


    public bool IsGrounded()
    {
        if (rb.velocity.y <= 0)
        {
            foreach (Transform point in groundPoint)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    
}
