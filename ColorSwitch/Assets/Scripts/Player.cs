using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;

    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public GameObject player;

    public string currentColor;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorPurple;

    private void Start()
    {
        SetRandomColor();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        if(this.player.transform.position.y<-10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorCahnger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != currentColor)
        {
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
            case 3:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
        }
    }
}
