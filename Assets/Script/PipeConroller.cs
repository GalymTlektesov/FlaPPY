using System.Collections;
using UnityEngine;

public class PipeConroller : MonoBehaviour
{
    public GameObject Pipe;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(true)
        {
            Instantiate(Pipe, new Vector2(transform.position.x, Random.Range(-3 ,1)), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}
