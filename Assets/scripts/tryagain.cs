
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryagain : MonoBehaviour


{

    bool gameHadEnded = false;
    public float restartDelay = 1f;
    public void GameTryAgain()
    {
       
        Debug.Log("game over");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name-1);
        
        Invoke("Restart", .5f);
    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Levels()
    {

        Debug.Log("game over");
        SceneManager.LoadScene("levels");

        Invoke("Restart", 1f);
    }

}
