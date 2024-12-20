using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private bool hasIntantiate = false;
    private float speed = -0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,speed,0);

        if (transform.position.y <= -13.13f)
        {
            Destroy(this.gameObject);
        }else if (transform.position.y <= -1f)
        {
            if (hasIntantiate == false)
            {
                hasIntantiate = true;
                GameObject obj = Instantiate(this.gameObject, new Vector3(transform.position.x,14.54f,transform.position.z), Quaternion.Euler(0,0,0));
            }
        }
        
    }
}
