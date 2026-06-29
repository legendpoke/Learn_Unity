using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{

    private float delayTime = 2f;
    [SerializeField] AudioClip rocketCrashSound;
    [SerializeField] AudioClip LandingSound;
    AudioSource audioSource;

    void EnableRocketMoveScript()
    {
        GetComponent<RocketMove>().enabled = false;// to turn of the script
    }
    void ReloadSameLvl()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    void NextLvl()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int NextScene = currentScene + 1;
        if(NextScene == SceneManager.sceneCountInBuildSettings)
        {
            NextScene = 0;
        }

        SceneManager.LoadScene(NextScene);
    }

    void ReloadSceneAfterCrash()
    {
        EnableRocketMoveScript();
        Invoke("ReloadSameLvl", delayTime);
    }
    
    void CrashSound()
    {
        audioSource.PlayOneShot(rocketCrashSound);
    }

    void landingSound()
    {
        audioSource.PlayOneShot(LandingSound);
    }

    void DelayNxtLvl()
    {
        EnableRocketMoveScript();
        Invoke("NextLvl",delayTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag){
            case "Fuel":
                Debug.Log("Collide with Fuel");
                Destroy(collision.gameObject);
                break;

            case "LandingPad":
                DelayNxtLvl();
                landingSound();
                Debug.Log("Rocket Landed Safely");
                break;

            case "LaunchPad":
                Debug.Log("Rocket is on launch pad");
                break;

            default:
                ReloadSceneAfterCrash();
                CrashSound();
                Debug.Log("Rocket is crashed");
                break;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
