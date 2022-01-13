using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandSpawnTooltip : MonoBehaviour
{
    // public List<string> tooltipText = "New ToolTip";
    [SerializeField] private List<GameObject> tooltips = default;

    // Start is called before the first frame update

    public void SpawnTooltips()
    {
        foreach (var item in tooltips)
        {
            item.gameObject.SetActive(true);
        }
        Invoke("deactivateTooltips", 5.0f);
    }

    public void deactivateTooltips()
    {
        foreach (var item in tooltips)
        {
            item.gameObject.SetActive(false);
        }
    }
}
