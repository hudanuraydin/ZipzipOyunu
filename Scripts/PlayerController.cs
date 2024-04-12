using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    public float jumpSpeed;
    bool facingRight = true;
    public bool playerYerde = true;

    public GameObject level1Button;
    public GameObject level2Button;
    public GameObject level3Button;
    public GameObject level4Button;
    public GameObject level5Button;
    AudioSource playerAudioSource;

    public Button rightButton;
    public Button leftButton;
    public Button upButton;
    


    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAudioSource = GetComponent<AudioSource>();
        
        // Dokunmatik giriþi kontrol et
        
    }

   
    void Update()
    {
        
        //playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, playerRB.velocity.y);

        if (playerRB.velocity.x < 0 && facingRight)
        {
            FlipFace();
        }
        else if (playerRB.velocity.x > 0 && !facingRight)
        {
            FlipFace();

        }

    }

     public void Zipla()
    {
        if (playerYerde == true)
        {
            playerRB.AddForce(new Vector2(0, jumpSpeed));
            playerAudioSource.Play();

            playerYerde = false;
            
        }
    }

    public void Right()
    {

        playerRB.transform.Translate(Vector2.right * speed);
    }
    public void Left()
    {
        playerRB.transform.Translate(Vector2.left * speed);
    }

    void FlipFace()
    {
        facingRight = !facingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }
    bool IsJumpButtonTouched(Vector2 touchPosition)
    {
        // Zýplama butonunun pozisyonunu ve boyutunu belirleyin
        Rect jumpButtonRect = new Rect(Screen.width - 100, 0, 100, 100);

        // Zýplama butonuna dokunulup dokunulmadýðýný kontrol et
        return jumpButtonRect.Contains(touchPosition);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            playerYerde = true;
        }


        if (collision.gameObject.tag == "Finish1")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Oyun2");
        }
        if (collision.gameObject.tag == "Finish2")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Oyun3");

        }
        if (collision.gameObject.tag == "Finish3")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Oyun4");

        }
        if (collision.gameObject.tag == "Finish4")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Oyun5");

        }
        if (collision.gameObject.tag == "Finish5")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("OyunSonu");


        }


    }
}
