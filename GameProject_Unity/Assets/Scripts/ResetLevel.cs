using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    //[SerializeField] private Transform Player;

    //   void OnTriggerEnter(Collider other)
    //  {
    //     SceneManager.LoadScene("Level1");
    // }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
