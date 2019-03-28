using System;
using System.Collections;
using System.Collections.Generic;

//객관식 문제 형식
public class QMultiChoice : Quiz
{
    //TODO: Exception Handling
    public bool hasMultipleAnswer;
    public Choice[] choices;

    public override bool EvaluateAnswer(string picked)
    {
        if (!hasMultipleAnswer) {
            int ans = int.Parse(picked);

            return choices[ans].isAnswer;

        }
        else { //Quiz WITH Multiple Answers
               //TODO:

            throw new NotImplementedException();
        }
    }


    public QMultiChoice(string qid, string[] parsedData, int choiceCount,
        float timeLimit = 0, int score = 0) : base(qid, timeLimit, score)
    {
        base.Question = parsedData[1];
        //HACK: Only works in certain situations (single answer)
        hasMultipleAnswer = false;
        choices = new Choice[choiceCount];

        for (int i = 0; i < choiceCount; ++i) {
            Choice temp = new Choice();
            temp.hadChosen = false;
            temp.text = parsedData[i+2]; // 0...index | 1...Question  | 2~choiceCount+1...choices

            int quizAnswer = int.Parse(parsedData[choiceCount + 2]);
            temp.isAnswer = (quizAnswer == i);
           
            choices[i] = temp;
        }
    }
    
}

//선택지
public struct Choice
{
    public string text;
    public bool isAnswer;
    public bool hadChosen;
}
