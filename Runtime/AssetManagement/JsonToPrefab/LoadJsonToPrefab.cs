/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Rogue Survivor */
/***************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class LoadJsonToPrefab : MonoBehaviour
{
    Dictionary<string, GameObject> prefabMap = new Dictionary<string, GameObject>();
    Dictionary<string, string> prefabStringMap = new Dictionary<string, string>();
    public RangeUI progress; //

    /**
     * 
     */
    IEnumerator Start()
    {

        var type = Type.GetType("Biome, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
        Debug.Log(type);

        var prefabs = Resources.LoadAll<TextAsset>("Prefabs/");
        var entitys = Resources.LoadAll<TextAsset>("Entities/");

        for (int i = 0; i < prefabs.Length; i++)
        {
            CreatePrefab(prefabs[i]);
            //progress.Change(i + 1, 0, prefabs.Length);
            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 0; i < entitys.Length; i++)
        {
            CreateEntity(entitys[i]);
            //progress.Change(i + 1, 0, entitys.Length);
            yield return new WaitForSeconds(0.01f);
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene("scn-game");
    }



    /**
     * 
     */
    void CreatePrefab(TextAsset json)
    {
        var go = new GameObject(json.name);
        go.transform.SetParent(transform);

        prefabMap[json.name] = go;
        prefabStringMap[json.name] = json.text;
        //currentFile.Change("Loading " + go.name);

        AddComponents(go, JsonUtility.FromJson<JsonObject>(json.text));
        //JsonOverwrite(go, json.text);
        //Save to assets.

        //go.SendMessage("OnPrefabCreated", SendMessageOptions.DontRequireReceiver);

        go.SetActive(false);
    }

    /**
     * 
     */
    void CreateEntity(TextAsset json)
    {
        //Debug.Log("Creating Entity: " + json.name);

        var data = JsonUtility.FromJson<JsonObject>(json.text);
        var name = json.name.Split('.')[0];
        var prfb = json.name.Split('.')[1];

        var go = Instantiate(prefabMap[prfb], transform);

        Asset.INSTANCE.Set(go.name = json.name, go);
        //currentFile.Change("Loading " + go.name);

        var pText = prefabStringMap[prfb];

        //pText = pText.Replace("$slug", name);

        var text = json.text; //.Replace("$slug", name);

        AddComponents(go, data);
        JsonOverwrite(go, pText); //Could move this to CreatePrefab and then get rid of the dictionary.
        JsonOverwrite(go, text);
        go.GetComponent<MonoBehaviour>().InvokeCreated(new PrefData());
    }


    /**
     * 
     */
    void AddComponents(GameObject go, JsonObject jd)
    {
        var jArray = jd.components;

        if (jArray == null)
        {
            return;
        }

        foreach (var c in jArray)
        {
            Debug.Log(Type.GetType(c.ToString()));
            Debug.Log("Adding component: " + c.ToString() + " :: " + Type.GetType(c.ToString()));
            go.AddComponent(Type.GetType(c.ToString() + ", Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"));
        }
    }

    /**
     * 
     */
    void JsonOverwrite(GameObject go, string json)
    {
        foreach (var c in go.GetComponents<IComponent>())
        {
            JsonUtility.FromJsonOverwrite(json, c);
        }
    }
}
