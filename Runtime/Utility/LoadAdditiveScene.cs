/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * 
 */
public class LoadAdditiveScene : MonoBehaviour
{
    public string sceneName; //

    /**
     * 
     */
    void Awake() => SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
}
