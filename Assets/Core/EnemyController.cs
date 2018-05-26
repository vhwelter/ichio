using UnityEngine;

public class EnemyController : MonoBehaviour {

    public int currentWayPoint;
    public float life;
    public float speed;
    public WaypointController target;

	void Start () {

        life = 100;
        currentWayPoint = 0;
        target = WaypointManager.instance.GetNext(currentWayPoint);

    }
	
	void Update () {

        if (target == null)
        {
            return;
        }
        transform.position = Vector2.MoveTowards(
            transform.position,
            target.transform.position,
            speed * Time.deltaTime
        );

        float distance = Vector2.Distance(
            target.transform.position,
            transform.position
        );

        if (distance <= 0)
        {
            if (target.end)
            {
                GameManager.instance.life -= 1;
                CanvasManager.instance.UpdateHUD();
                Destroy(gameObject);
            } else
            {
                currentWayPoint++;
                target = WaypointManager.instance.GetNext(currentWayPoint);
            }
            
        }
    }

    public void ApplyDamage(float amount)
    {
        life -= amount;
        if (life <= 0)
        {
            life = 0;
            GameManager.instance.score += 20;
            CanvasManager.instance.UpdateHUD();
            Destroy(gameObject);
        }
    }
}
