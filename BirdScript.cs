using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{   public static bool gameRunning;
    public int score = 0;
    public UnityEngine.UI.Text scoretext;
    public GameObject gameOverTitle;
    public GameObject gameStartTitle;
    // Start is called before the first frame update
    public AudioSource gameBgm;
    void Start()
    {
        gameRunning=false;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        gameStartTitle.transform.localScale = new Vector2(1f, 1f);
        gameOverTitle.transform.localScale = new Vector2(0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {
            if(gameRunning == false)
            {
                gameRunning=true;
            }
            gameStartTitle.transform.localScale = new Vector2(0f, 0f);
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            transform.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 350));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.StartsWith("Pipe") || collision.collider.gameObject.name.StartsWith("floor"))
        {
            gameRunning=false;
            gameObject.SetActive(false);
            gameOverTitle.transform.localScale = new Vector2(1f, 1f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        score++;
        scoretext.text = "SCORE : " + score;
    }
}
