/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T INSTANCE { get; private set; } //

    /**
     * 
     */
    void Awake()
    {
        INSTANCE = this as T;
    }
}