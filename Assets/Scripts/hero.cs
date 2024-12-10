using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    private Animator anim;

    public GameObject gameOver;

    public LayerMask pipeLayer;

    private bool isGrounded = false;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rig.linearVelocity = Vector2.up * speed; 
            anim.SetBool("fly", true); 
            anim.SetBool("walk", false); 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("fly", false); 
        }


        if (isGrounded)
        {
            anim.SetBool("walk", true);
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {

        if (((1 << colisor.gameObject.layer) & pipeLayer) != 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0; 
        }

        else if (colisor.gameObject.layer == 8)
        {
            isGrounded = true; 
            anim.SetBool("walk", true); 
        }
    }

    void OnCollisionExit2D(Collision2D colisor)
    {
  
        if (colisor.gameObject.layer == 8)
        {
            isGrounded = false;  
            anim.SetBool("walk", false); 
        }
    }
}
