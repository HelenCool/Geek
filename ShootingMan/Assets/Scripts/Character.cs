using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public Rigidbody2D bulletPrefab;
    public Rigidbody2D bulletInstanse;
    public Transform rifflEnd;
    public float moveSpeed = 10f;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        
    }



    void Update() {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            bulletInstanse = Instantiate(bulletPrefab, rifflEnd.position, rifflEnd.rotation) as Rigidbody2D;
            bulletInstanse.AddForce(rifflEnd.up * 600);
            animator.Play("Shooting");

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Right");
            animator.SetFloat("moveSpeed", 0.2f);
            animator.Play("Car", -1, 0f);
            transform.localPosition += new Vector3(0.1f, 0f, 0f);

        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetFloat("moveSpeed", 0);
            animator.Stop();
        }


        

    }
}
