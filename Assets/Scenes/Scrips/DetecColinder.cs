using UnityEngine;

public class DetecColinder : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("End Game...........");
    }
}
