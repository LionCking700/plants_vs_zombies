using UnityEngine;
using UnityEngine.Events;

public class House : MonoBehaviour
{
    [SerializeField]
    private string enemyTag = "Enemy";
    [SerializeField]
    private UnityEvent onLosegame;
    private void OntriggerEnter(Collider other)
    {
        if(other .CompareTag(enemyTag))
        {
            gameObject.GetComponent<Collider>().enabled = false;
            onLosegame?.Invoke();
        }
    }
}
