using Unity.VisualScripting;
using UnityEngine;

public class playerStat : MonoBehaviour
{
    // อันนี้ถ้าโดน บล็อค แท็ค ศัตรูเลือดจะลด
    public int hp = 100;

    public float fallLimit = -10f;

    public Vector3 respawnPoint; //ตัวแปรเพื่อเก็บตำแหน่งจุดเกิดใหม่ของตัวละคร



    void Start()
    {
        // เก็บตำแหน่งเริ่มต้นไว้เป็นจุดเกิดใหม่
        respawnPoint = transform.position;
    }

    void Update()
    {
        // ถ้าตกต่ำเกินกำหนด
        if (transform.position.y < fallLimit) //ถ้าตำแหน่ง y ของตัวละครต่ำกว่า fallLimit (ในที่นี้คือ -10) ให้เกิดใหม่ที่จุดเกิดใหม่
        {
            Respawn();
        }
    }

    void OnTriggerEnter(Collider other) //ถ้าhero ชน ตัวที่มีแท็ค enemy เลือดจะลดลง 10 ถ้าเลือดลดลงเหลือ 0 หรือ น้อยกว่า จะเกิดใหม่ที่จุดเกิดใหม่
    {
        if (other.CompareTag("enemy"))
        {
            hp -= 10;

            if (hp <= 0) //ถ้าเลือดลดลงเหลือ 0 หรือ น้อยกว่า จะเกิดใหม่ที่จุดเกิดใหม่
            {
                Respawn();
            }
        }
    }

    void Respawn() //เมื่อเกิดใหม่ เลือดจะถูกรีเซ็ตเป็น 100 และตำแหน่งจะถูกย้ายไปที่จุดเกิดใหม่
    {
        hp = 100;
        transform.position = respawnPoint;
    }


}