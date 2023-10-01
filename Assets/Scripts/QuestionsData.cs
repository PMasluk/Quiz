using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionsData", menuName = "ScriptableObjects/QuestionsData")]
public class QuestionsData : ScriptableObject
{
    [SerializeField]
    private List<QuestionData> questions;

    public List<QuestionData> Questions => questions;
}
