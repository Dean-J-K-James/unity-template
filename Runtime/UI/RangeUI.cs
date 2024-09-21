/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public class RangeUI : MonoBehaviour
{
    public RectTransform bar; //

    /**
     * 
     */
    public void Change(float val, float min, float max)
    {
        bar.sizeDelta = new Vector2((val - min) / (max - min) * (bar.parent.GetComponent<RectTransform>().sizeDelta.x - bar.anchoredPosition.x * 2), bar.sizeDelta.y);
    }
}