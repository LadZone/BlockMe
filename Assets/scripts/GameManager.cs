
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHadEnded = false;
    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;
    public GameObject CompleteLevelUI2;

    public string nextLevel = "Level";
    public int levelToUnlock = 10;


    


     public  void CompleteLevel()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock + 1);
        CompleteLevelUI.SetActive(true);
        Debug.Log("level 1");
        
    }


 public void EndGame()
    {

        if(gameHadEnded == false)
        {
            gameHadEnded = true;
            // Debug.Log("game over");

            //restart game
            //Invoke( "Restart",restartDelay) ;
            //SceneManager.LoadScene("gameover");
            CompleteLevelUI2.SetActive(true);

        }
        
    }


    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
