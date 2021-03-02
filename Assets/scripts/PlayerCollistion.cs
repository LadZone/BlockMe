
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollistion : MonoBehaviour
{
    public playermovement movement;
  

    void OnCollisionEnter (Collision collistionInfo)
    {

       // Debug.Log(collistionInfo.collider.name);

        if (collistionInfo.collider.tag == "Obstacle")
        {
            // Debug.Log("i got u ");
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

           
        }

       
    }



}
