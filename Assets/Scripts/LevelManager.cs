using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject level01;
    public GameObject level02;

    private Transform player;

    private GameObject currentActiveLevel;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void LevelChange(Transform spawnLocation)
    {
        if (level01.activeInHierarchy && !level02.activeInHierarchy)
        {
            level01.SetActive(false);
            level02.SetActive(true);
        }
        else if (!level01.activeInHierarchy && level02.activeInHierarchy)
        {
            level01.SetActive(true);
            level02.SetActive(false);
        }

        //Yes i am aware of the obvious flaw in this code

        player.position = spawnLocation.position;

    }
}
