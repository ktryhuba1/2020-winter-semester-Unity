using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CanvasClickIntercept : EventTrigger
{
    protected PrefabPool prefabPool;

    private void Awake()
    {
        prefabPool = GameObject.Find("PrefabPool").GetComponent<PrefabPool>();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(eventData.position);

        if(eventData.button == PointerEventData.InputButton.Right)
        {
            Transform Bloom = prefabPool.Bloom;
            Bloom.position = new Vector3(worldPosition.x, worldPosition.y, 0);
        }
        else
        {
            Transform turret = prefabPool.Turret;
            turret.position = new Vector3(worldPosition.x, worldPosition.y, 0);
        }
        
    }

    

}
