using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    public int _playerScore;

    public int _computerScore;

    
    public void PlayerScores()
    {
        _playerScore++;
       
        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        _computerScore++;
        Debug.Log(_computerScore);
        this.ball.ResetPosition();
    }


}
