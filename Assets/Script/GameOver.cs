using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.collider.CompareTag("Player"))
        {
            ScoreScript.score = 0;
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
