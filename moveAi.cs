using UnityEngine;

public class moveAi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,-0.2f,0);
        if(transform.position.y <= -13.13f)
        {
            Destroy(this.gameObject);
        }
        
    }
}
