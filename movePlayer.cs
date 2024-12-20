using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePlayer : MonoBehaviour
{
    public float velocidade = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3 (movimentoHorizontal,0,movimentoVertical) * velocidade * Time.deltaTime;
        transform.Translate(movimento);

        //if(Input.GetKey("right"))
        //{
          //  transform.position += new Vector3 (0.1f,0,0);
        //}else if (Input.GetKey("left"))
        //{
          // transform.position += new Vector3 (-0.1f,0,0); 
        //}
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("inimigo"))
        {
            // Reinicia a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
