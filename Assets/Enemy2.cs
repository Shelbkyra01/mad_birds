using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] private GameObject _cloudParticlePrefab;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird bird = collision.collider.GetComponent<Bird>();
        if (bird != null)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }

        Enemy2 enemy = collision.collider.GetComponent<Enemy2>();
        if (enemy != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y > -0.5)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}