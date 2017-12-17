using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{

    bool startSceneTimer = false;
    float timer = .5f;


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")

         
        Destroy(coll.gameObject,1);
        Debug.Log("ChangeScene");
        SceneManager.LoadScene("123");
    }
}