using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static GameManager instance;
    public Transform[] spawnPoints;
    public GamePhase phase;
    public Timer timer;
    public PlayerController victor;
    //List of active players
    public List<PlayerController> player;

    public void Awake()
    {
        //Singleton intialization
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        //
        timer.enabled = false;
    }

    // Update is called once per frame
    public void OnPlayerJoined(PlayerInput input)
    {
        //Using
        Transform nextSpawnPosition = spawnPoints[players.cont];
        // move
        input.transform.position = nextSpawnPosition.position;
        //add
        players.Add(input.GetComponent<PlayerController>());
        //if
        if (players.Count == 2)
            timer.enabled = true;
    }

    public void KillAll()
    {

        foreach (PlayerController player  in players)
        {

        }
    }
}

public enum gamePhase
{
    starting,
    started,
    ending
}
