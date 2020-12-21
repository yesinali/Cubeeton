using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] Obstacles;
    public bool isGameHasEnded = false;
    public GameObject completeLevelUI;
    public PlayerMovement playerMovementScript;
    public int Barrierlength;
    public Vector3 lastEndPoint;

    private void Start()
    {
        SpawnObstacles();
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        playerMovementScript.enabled = false;
    }
    public void EndGame()
    {
        if (isGameHasEnded== false)
        {
            isGameHasEnded = true;
            Debug.Log("GAMEOVER");
            Invoke("Restrat",1.2f);
        }        
    }
    void Restrat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SpawnObstacles()
    {
        for (int i = 0; i < Barrierlength; i++)
        {
            GameObject cloneObstacle = GameObject.Instantiate(Obstacles[Random.Range(0,Obstacles.Length)]);
            Obstacle obstacleScript = cloneObstacle.GetComponent<Obstacle>();

            cloneObstacle.transform.position = lastEndPoint;

            lastEndPoint = obstacleScript.ReturnEndPoint();
        }
    }
}
