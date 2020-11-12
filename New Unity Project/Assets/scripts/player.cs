using UnityEngine;
using UnityEngine.UI;
 public class player : MonoBehaviour
{

    public GameObject final;

    public Text textCount;

    public int count;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送們了");

        if (collision.name == "傳送門")
        {
            final.SetActive(true);
        }
    
        if(collision.tag == "櫻桃")
        {
            Destroy(collision.gameObject);

            count++;

            textCount.text = "道具數量:" + count;

        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
