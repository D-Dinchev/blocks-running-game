using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded = false;
    public float RestartDelay = 1f;
    public GameObject LevelCompleteUI;

    public void GameWon()
    {
        LevelCompleteUI.SetActive(true);
    }
    public void GameOver()
    {
        if (!_gameHasEnded)
        {
            _gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", RestartDelay);
        }
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}