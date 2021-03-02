
using UnityEngine.SceneManagement;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
