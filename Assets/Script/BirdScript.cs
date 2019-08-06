using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float jumpForce;

    public float jumpDelay;
    private float nextJump;

    private Rigidbody2D bird;
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        bool canShoot = Time.time > nextJump;
        if (Input.GetButton("Fire1") && canShoot)// Выстрел
        {
            nextJump = Time.time + jumpDelay;
            bird.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("PlusScore"))
        {
            ScoreScript.score++;
        }
    }
}
