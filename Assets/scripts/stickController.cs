using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stickController : MonoBehaviour
{
    public float speed = 0.5f;
    Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -6f, 6f);
        transform.position = position;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
}
