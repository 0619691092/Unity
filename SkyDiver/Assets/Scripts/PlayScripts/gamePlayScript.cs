using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamePlayScript : MonoBehaviour
{
    public static gamePlayScript instance;
    private Text scoreText;
    private int score;

    public GameObject scorePanel;
    public Text endScore;
    public Text endPoints;
    public Animator endPanelAnim;

    public Button play;
    public Button menu;


    // Start is called before the first frame update
    void Awake()
    {
        MakeInstance();
    }

    void Start()
    {
        
        scoreText = GameObject.Find("metertext").GetComponent<Text>();
        StartCoroutine(CountScore());
    }

    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this; 
            
        }
    }
    

    IEnumerator CountScore()
    {
        yield return new WaitForSeconds(0.1f);
        score++;
        scoreText.text = score.ToString();
        StartCoroutine(CountScore());
    }

    public void GameOver(int puntos)
    {
        scorePanel.SetActive(false);
        endScore.text = "Meters: " + score;
        endPoints.text = "Points: " + puntos;
        endPanelAnim.Play("EndPanel");
    }

    public void Play()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }


}
