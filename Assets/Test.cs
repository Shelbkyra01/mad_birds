using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    [SerializeField] private GameObject _cloudParticlePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
    
        if (col.gameObject.tag == "Floor") 
            {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy (gameObject);
            }
         
    }

}
