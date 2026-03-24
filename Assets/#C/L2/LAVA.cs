using UnityEngine;

public class LAVA : MonoBehaviour
{
    
    public Transform spawnPoint; //ตัวแปรเพื่อเก็บตำแหน่งจุดเกิดใหม่ของตัวละคร

    void OnTriggerEnter(Collider other)
    {
        // เช็คว่าวัตถุที่ตกลงมาโดน มี Tag ว่า "Player" หรือไม่
        if (other.CompareTag("Hero"))
        {
            // ดึงคอมโพเนนต์ CharacterController มาจากตัวผู้เล่น
            CharacterController charController = other.GetComponent<CharacterController>();

            if (charController != null) //ถ้าพบคอมโพเนนต์ CharacterController ในตัวผู้เล่น ให้ทำการย้ายตำแหน่ง
            {
                // 1. ปิดการทำงานชั่วคราว เพื่อให้ยอมรับการย้ายตำแหน่ง
                charController.enabled = false;

                // 2. ย้ายตำแหน่งตัวผู้เล่นไปที่จุดเกิด
                other.transform.position = spawnPoint.position;

                // 3. เปิดการทำงานกลับมาเหมือนเดิม
                charController.enabled = true;
            }
        }
    }
}