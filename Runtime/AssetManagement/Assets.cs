/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/**
 * 
 */
public class Asset : Singleton<Asset>
{
    Dictionary<string, GameObject> repository = new Dictionary<string, GameObject>(); //

    /**
	 * 
	 */
    public void Set(string k, GameObject mb) => repository[k] = mb;
    public T Get<T>(string k) where T : MonoBehaviour => repository.GetValueOrDefault(k)?.GetComponent<T>();
    public T[] All<T>() where T : MonoBehaviour
    {
        return repository.Values.Where(x => x.GetComponent<T>() != null).Select(x => x.GetComponent<T>()).ToArray();
    }
}


//Make Asset a Singleton Asset.INSTANCE...