/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public class DontDestroyOnLoad : MonoBehaviour
{
    /**
     * 
     */
    void Awake() => DontDestroyOnLoad(gameObject);
}
