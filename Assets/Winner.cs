using UnityEngine;

public class Winner : MonoBehaviour
{
    public GameObject winner;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {

            winner.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Bird")) // Kiểm tra nếu đối tượng rời khỏi là Bird da roi khoi vung hoat dong
        {
            Debug.Log("Player exited trigger zone.");
            winner.SetActive(false);
        }
    }
}
