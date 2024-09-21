/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/**
 * 
 */
public class TickManager : Singleton<TickManager>
{
    //public Dictionary<string, Action> idEventMap = new Dictionary<string, Action>();
    //public Dictionary<int, List<string>> events = new Dictionary<int, List<string>>();
    public int tick; // { get; private set; } //Should be a private get public set

    Dictionary<string, Action> tickEventMap = new Dictionary<string, Action>(); //All of these are run every tick.

    public void Register(string key, Action val)
    {
        tickEventMap[key] = val;
    }

    public void Ungister(string key)
    {
        tickEventMap.Remove(key);
    }


    //public Action cbTick; //
    //public Action<Vector2Int> cbInstanceTick; //

    public float timer; //

    //public void RegisterEvent(int tick, string eId, Action cb)
    //{
    //    //Debug.Log("Registering event for tick: " + tick + " with ID: " + eId);

    //    if (idEventMap.ContainsKey(eId))
    //    {
    //        Debug.LogError("This event already exists.");
    //    }
    //    else
    //    {
    //        idEventMap[eId] = cb;
    //        if (events.ContainsKey(tick))
    //        {
    //            events[tick].Add(eId);
    //        }
    //        else
    //        {
    //            events[tick] = new List<string> { eId };
    //        }
    //    }
    //}


    //public void UnregisterEvent(string eId)
    //{
    //    //Debug.Log("Unregistering event with ID: " + eId);

    //    //Do we need to check that the event actually exists?
    //    idEventMap.Remove(eId);
    //}

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            timer = 0;
            tick++;

            var keys = tickEventMap.Keys.ToArray();

            //for (int i = 0; i < values.Count; i++)
            //{
            //    values[i]();
            //}

            foreach (var key in keys)
            {
                tickEventMap[key]();
            }

            //Tick has changed.
            //Run the events in the events dictionary.
            //if (events.ContainsKey(tick))
            //{
            //    foreach (var item in events[tick])
            //    {
            //        if (idEventMap.ContainsKey(item))
            //        {
            //            idEventMap[item]();
            //        }
            //    }
            //}

            ////Also trigger the tick event.
            //cbTick?.Invoke();
        }
    }

}
