using System.Security.Cryptography;
using UnityEngine;

public class NormalTravel : MonoBehaviour
{
    private  int health = 10;
    [Range(0f, 1f)] public float speed = 1.0f;
    [SerializeField] string name;
    [SerializeField] GameObject gobj;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.forward * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, gobj.transform.position, 0.3f);

    }
}
