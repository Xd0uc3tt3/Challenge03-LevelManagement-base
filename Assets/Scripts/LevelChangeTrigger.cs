using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{

    public LevelManager levelManager;

    public GameObject levelToActivate;
    public Transform spawnLocation;

    private void Start()
    {
        levelManager = ServiceHub.Instance.LevelManager;
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Change");
            levelManager.LevelChange(spawnLocation);
        }

        //
    }

    
}
