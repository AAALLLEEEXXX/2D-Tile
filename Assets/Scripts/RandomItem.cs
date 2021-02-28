using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _items;

    private void Start()
    {
        var random = Random.Range(0, _items.Length);
        Instantiate(_items[random], transform.position, Quaternion.identity);
    }
}
