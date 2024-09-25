using System.Collections;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private float rotationDuration = 0.5f; // ��]�ɂ����鎞��
    private bool isRotating = false;
    [SerializeField] private int rotationAngle = 90;

    public void RightTurn()
    {
        if (!isRotating) StartCoroutine(RotateCamera(rotationAngle));
    }

    public void LeftTurn()
    {
        if (!isRotating) StartCoroutine(RotateCamera(-rotationAngle));
    }

    private IEnumerator RotateCamera(float angle)
    {
        //��]���ɉ�]���J�n���Ȃ����߂̃t���O
        isRotating = true;

        //�J�n�p�x�ƍŏI�p�x���v�Z
        float startAngle = mainCamera.transform.eulerAngles.y;
        float endAngle = startAngle + angle;
        float elapsedTime = 0;

        //�o�ߎ��Ԃ�0.5�ȉ��̎��J��Ԃ�
        while (elapsedTime < rotationDuration)
        {
            //�J�n�p�x�ƍŏI�p�x�̊Ԃ���
            float currentAngle = Mathf.Lerp(startAngle, endAngle, elapsedTime / rotationDuration);
            //��Ԃ��ꂽ�p�x��]����
            mainCamera.transform.eulerAngles = new Vector3(8.5f, currentAngle, 0);
            //�o�ߎ��Ԃ𑫂�
            elapsedTime += Time.deltaTime;
            //����Ԃ�
            yield return null;
        }

        // �Ō�ɐ��m�Ȋp�x�ɒ���
        mainCamera.transform.eulerAngles = new Vector3(mainCamera.transform.eulerAngles.x, endAngle, mainCamera.transform.eulerAngles.z);

        //�t���O������
        isRotating = false;
    }
}
