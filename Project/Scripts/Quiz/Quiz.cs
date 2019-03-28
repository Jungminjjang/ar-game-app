using System;

public abstract class Quiz {

    public string Qid { get; private set; }
    public string Question { get; protected set; }
    public float timeLimit;
    public int score;
    
    protected int? answerdWrong;
    public bool inCooldown = false;

    protected Quiz(string _id, float timeLimit, int score)
    {
        Qid = _id;
        this.timeLimit = timeLimit;
        this.score = score;

        answerdWrong = null;
    }

    //답안평가: 정답여부 리턴
    public abstract bool EvaluateAnswer(string submission);
}
