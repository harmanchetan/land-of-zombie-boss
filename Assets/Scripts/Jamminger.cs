using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Jamminger : MonoBehaviour
{
    
    [SerializeField]
    GameObject mExplosionPrefab;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.layer == LayerMask.NameToLayer("playerbullet"))
        {
            Destroy (col.gameObject);
            Destroy (gameObject);
            Instantiate (mExplosionPrefab, transform.position, Quaternion.identity);
            

        }
    }

   
    
}
