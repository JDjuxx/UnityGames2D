using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float max_point;
    public float min_point;
    public float speed = 2f;
    public float waitingTime = 2f;
    private Weapon _weapon;
    private GameObject _target;
    // Start is called before the first frame update
    void Start()
    {
        _weapon = this.GetComponentInChildren<Weapon>();
        UpdateTransform();
        StartCoroutine("PatrolToTarget");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateTransform()
    {
        if(_target == null)
        {
            _target = new GameObject("Target");
            _target.transform.position = new Vector2(min_point, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
            return;
        }

        if (transform.position.x == min_point)
        {
            _target.transform.position = new Vector2(max_point, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
            return;
        }

        if (transform.position.x == max_point)
        {
            _target.transform.position = new Vector2(min_point, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
            return;
        }
    }

    IEnumerator PatrolToTarget()
    {
        while (Vector2.Distance(transform.position, _target.transform.position) > 0.5f)
        {
            Vector2 direction = _target.transform.position - transform.position;
            float xDirection = direction.x;

            transform.Translate(direction.normalized * speed * Time.deltaTime);
            yield return null;
        }

        Debug.Log("Target Reached");
        transform.position = new Vector2(_target.transform.position.x, transform.position.y);

        Debug.Log("Waiting for " + waitingTime + " seconds");
        yield return new WaitForSeconds(waitingTime);

        Debug.Log("Waited enough, let's update the target and move again");
        UpdateTransform();
        StartCoroutine("PatrolToTarget");
        
    }
}
