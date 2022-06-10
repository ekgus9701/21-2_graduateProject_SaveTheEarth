using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Text field�� ����� �� �ֵ��� �ϴ� header

[System.Serializable] //���� ���� class�� ������ �� �ֵ��� ����. 
public class Dialogue2
{
    [TextArea]//���� ���� ���� �� �� �� �ְ� ����
    public string dialogue;
    // public Sprite cg; // ��ü�� �̹���

}
public class ShowMenu : MonoBehaviour
{
    //SerializeField : inspectorâ���� ���� ������ �� �ֵ��� �ϴ� ������.
    //[SerializeField] private SpriteRenderer sprite_StandingCG; //ĳ���� �̹���(YK)�� �����ϱ� ���� ����
    // [SerializeField] private SpriteRenderer sprite_DialogueBox; //���â �̹���(crop)�� �����ϱ� ���� ����
    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue; // �ؽ�Ʈ�� �����ϱ� ���� ����
    [SerializeField] private Button nextbutton;
    [SerializeField] private Image menu;

    private bool isDialogue = false; //��ȭ�� ���������� �˷��� ����
    private int count = 0; //��簡 �󸶳� ����ƴ��� �˷��� ����

    [SerializeField] private Dialogue[] dialogue;


    public void ShowDialogue()
    {
        ONOFF(true); //��ȭ�� ���۵�
        count = 0;
        NextDialogue(); //ȣ����ڸ��� ��簡 ����� �� �ֵ��� 
    }

    private void ONOFF(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        //sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }

    private void NextDialogue()
    {
        //ù��° ���� ù��° cg���� ��� ���� cg�� ����Ǹ鼭 ȭ�鿡 ���̰� �ȴ�. 
        txt_Dialogue.text = dialogue[count].dialogue;
        //sprite_StandingCG.sprite = dialogue[count].cg;
        count++; //���� ���� cg�� �������� 

    }


    // Update is called once per frame
    /* void Update()
     {
         //spacebar ���� ������ ��簡 ����ǵ���. 
         if (isDialogue) //Ȱ��ȭ�� �Ǿ��� ���� ��簡 ����ǵ���
         {
             //if (Input.GetKeyDown(KeyCode.Space))
                if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
            {
                 //��ȭ�� ���� �˾ƾ���.
                 if (count < dialogue.Length) NextDialogue(); //���� ��簡 �����
                 else ONOFF(false); //��簡 ����

             }
         }

     }*/

    public void ShowNextdialog()
    {

        if (isDialogue) //Ȱ��ȭ�� �Ǿ��� ���� ��簡 ����ǵ���
        {

            //��ȭ�� ���� �˾ƾ���.
            if (count < dialogue.Length) NextDialogue(); //���� ��簡 �����
            else
            {
                ONOFF(false);
                nextbutton.gameObject.SetActive(false);
                menu.gameObject.SetActive(true);
            }//��簡 ����


        }

    }
}