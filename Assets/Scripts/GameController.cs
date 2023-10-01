using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private List<Answer> answers;

    private List<QuestionData> questions;
    
    public void Initialize(QuestionsData questions)
    {
        List<QuestionData> data = questions.Questions;
        while (data.Count > 0)
        {
            int randomIndex = Random.Range(0, data.Count);
            this.questions.Add(data[randomIndex]);
            data.RemoveAt(randomIndex);
        }
    }

    private void SetNewQuestion()
    {

    }

    private void CheckAnswer()
    {

    }

    private void OnAnswerGood()
    {

    }

    private void OnAnswerBad()
    {

    }
}
