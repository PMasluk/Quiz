using System;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionData", menuName = "ScriptableObjects/QuestionData")]

public class QuestionData : ScriptableObject
{
    [SerializeField]
    private string question;
    [SerializeField]
    private AnswerData answerA;
    [SerializeField]
    private AnswerData answerB;
    [SerializeField]
    private AnswerData answerC;
    [SerializeField]
    private AnswerData answerD;

    public string Question => question;
    public AnswerData AnswerA => answerA;
    public AnswerData AnswerB => answerB;
    public AnswerData AnswerC => answerC;
    public AnswerData AnswerD => answerD;
}

[Serializable]
public struct AnswerData
{
    public string Text;
    public bool isCorrect;
}