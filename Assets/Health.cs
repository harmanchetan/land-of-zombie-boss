using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class Health : MonoBehaviour {

	//[SerializeField]
	//GameObject mExplosionPrefab;
	public Image HealthBar;
	public float Healthy = 1;


	void Update()
	{

		HealthBar.fillAmount = Healthy;
		if (Healthy <= 0f)
		{
			Debug.Log("Hit");



			Destroy(gameObject);
            SceneManager.LoadScene("123");
            // Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            //SceneManager.LoadScene("GameOverPage");

        }
	}



	void TakeDamage(int damage)
	{
		Debug.Log("Taking Damage: " + damage);
	}

	void OnCollisionEnter2D(Collision2D obj)
	{
		if (obj.gameObject.layer == LayerMask.NameToLayer("enemy"))
		{

			Healthy -= .40f;


		}

	}
}