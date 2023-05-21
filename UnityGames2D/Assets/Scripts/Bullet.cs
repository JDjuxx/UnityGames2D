using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction;
    public float livingTime = 3f;
    public Color initialColor = Color.white;
    public Color finalColor;

    private SpriteRenderer _renderer;
    private float _startingTime;
    //private GameObject player;

    void Awake()
    {
        _renderer = this.GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _startingTime = Time.time;
        //Destruir objetos
        //Destroy(this.gameObject, livingTime);
        //player = GameObject.Find("Player");
        Destroy(this.gameObject, livingTime);
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //Vector2 axisMovement = new Vector2(horizontal, vertical);
        //Vector2 movement = axisMovement.normalized * speed * Time.deltaTime;
        Vector2 movement = direction.normalized * speed * Time.deltaTime;
        //transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);
        transform.Translate(movement);
        //player.transform.Translate(movement);

        float _timeSinceStarted = Time.time - _startingTime;
        float _percentageCompleted = _timeSinceStarted / livingTime;
        _renderer.color = Color.Lerp(initialColor, finalColor, _percentageCompleted);
        this.gameObject.GetComponent<SpriteRenderer>().material.color = _renderer.color;
    }
}
