using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //�ۑ�
    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    int score = 0;

    void OnCollisionEnter(Collision other)
    {
        //other.gameObject.tag��tag�̕�����iString�`���j���Ԃ�
        //if( other.gameObject.tag == "LargeStarTag")�ȂǂŎg��

        Debug.Log("�ՓˁF" + other.gameObject.tag);

        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 3;
        }
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 1;
        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 2;
        }

        this.scoreText.GetComponent<Text>().text = "Score " + this.score;
    }

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");

        

       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this. transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
