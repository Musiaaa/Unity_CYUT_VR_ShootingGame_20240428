using UnityEngine;

public class FireSystem : MonoBehaviour
{
    [SerializeField, Header("�l�u�w�s��")]
    private GameObject prefabBullet;
    [SerializeField, Header("�l�u�ͦ��I")]
    private Transform firePoint;
    [SerializeField, Header("�o�g�t��"), Range(8, 3000)]
    private float fireSpeed = 500;

    private void Update()
    {
        // �p�G ���U���� �N�o�g�l�u
        if (Input.GetKeyDown(KeyCode.Mouse0)) FireBullet();
    }

    private void FireBullet()
    {
        // �ͦ�(����A�y�СA����)
        // �ͦ�(�l�u�w�m���A�ͦ��I���y�СA�s����)
        GameObject temp = Instantiate(prefabBullet, firePoint.position, Quaternion.identity);

        // ����b�V X transform.right
        // ���b�V Y transform.up
        // �Ŧ�b�V Z transform.forward
        // �Ȧs�l�u ���o���� �K�[���O(�Z�����e�� * �t��)
        temp.GetComponent<Rigidbody>().AddForce(transform.forward * -fireSpeed);
    }
}