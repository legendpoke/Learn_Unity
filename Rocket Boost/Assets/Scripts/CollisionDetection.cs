using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    void NextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int NextScene = currentScene + 1;
        if(NextScene == SceneManager.sceneCountInBuildSettings)
        {
            NextScene = 0;
        }

        SceneManager.LoadScene(NextScene);
    }
    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag){
            case "Fuel":
                Debug.Log("Collide with Fuel");
                Destroy(collision.gameObject);
                break;

            case "LandingPad":
                NextScene();
                Debug.Log("Rocket Landed Safely");
                break;

            case "LaunchPad":
                Debug.Log("Rocket is on launch pad");
                break;
            default:
                ReloadScene();
                Debug.Log("Rocket is crashed");
                break;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
