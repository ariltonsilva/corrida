using UnityEngine;

public class generateEnemy : MonoBehaviour
{
    public GameObject inimigo;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2.0f)
        {
            timer = 0;
            Instantiate(inimigo,new Vector3(Random.Range(-3.51f,3.91f),transform.position.y,transform.position.x),Quaternion.Euler(0,0,-180f));
        }
        
    }
}
