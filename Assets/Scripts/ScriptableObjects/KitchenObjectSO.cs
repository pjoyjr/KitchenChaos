using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SO = Scriptable Object


[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {

    public Transform prefab;
    public Sprite sprite;
    public string objectName;

}
