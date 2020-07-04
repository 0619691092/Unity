
using UnityEngine;
using UnityEngine.UI;


public class PlayerScripts : MonoBehaviour
{
    private Rigidbody2D rigigbody;
    private Animator anim;
    private int puntos;
    private Text puntosText; 


    public int Puntos { get ; set ; }

    // Start is called before the first frame update
    void Awake()
    {
        puntosText = GameObject.Find("pointext").GetComponent<Text>();
        anim = gameObject.GetComponent<Animator>();
        rigigbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //GoMainScene();
    }

    private void Move()
    {
        if (Input.GetKey("up") && transform.position.y <= 1)
        {
            rigigbody.AddForce(new Vector2(0, 150f * Time.deltaTime));

        }

        if (Input.GetKey("down") && transform.position.y <= 3)
        {
            rigigbody.AddForce(new Vector2(0, -50f * Time.deltaTime));

        }

        if (transform.position.y <= 1 && !Input.GetKey("up"))

        {
            rigigbody.AddForce(new Vector2(0, 250f * Time.deltaTime));

        }else 
        {
            rigigbody.AddForce(new Vector2(0, 200f * Time.deltaTime));
        }

        if (Input.GetKey("left"))
        {
            rigigbody.AddForce(new Vector2(-300f * Time.deltaTime, 0));

        }

        if (Input.GetKey("right"))
        {
            rigigbody.GetComponent<Rigidbody2D>().AddForce(new Vector2(300f * Time.deltaTime, 0));
        }


      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Gift")
        {
            puntos++;
            puntosText.text = puntos.ToString();
            collision.gameObject.SetActive(false);
            // poner sonido 
        }else if(collision.tag == "Enemy")
        {
            // muere Skydiver
            PlayerDied();

        }

    }

    private void PlayerDied()
    {
        anim.enabled = true; 
        anim.Play("DieAnimations");
        gamePlayScript.instance.GameOver(puntos);
        Time.timeScale = 0f;
   
    }
    
    /*
    private void GoMainScene()
    {
        if(transform.position.y < -8)
        {
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1f; 
        }
    }
    */
  

  
}
