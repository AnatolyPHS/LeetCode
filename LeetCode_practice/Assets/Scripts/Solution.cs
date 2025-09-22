using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
        IList<IList<string>> result = SolveNQueens(4);
        foreach (var row in result)
        {
            foreach (var col in row)
            {
                Debug.Log(col);
            }
        }
    }
    
    public IList<IList<string>> SolveNQueens(int n) {
        IList<IList<string>> final = new List<IList<string>>();

        int[,] board = new int[n,n]; // 0 - empty cell 1 - queen -1 - inaccessible
        
        for (int i = 0; i < n ; i++){
            for (int j = 0; j < n ; j++){
                if (PlaceQueenSucceed(i,j, board, n)){
                    IList<string> result = CalculateResult(board);
                    final.Add(result);
                }
                RefreshBoard(board);
            }
        }

        RemoveDuplications(final);
        
        return final;
    }

    private void RemoveDuplications(IList<IList<string>> final)
    {
        for (int i = final.Count - 1; i >= 0; i--)
        {
            IList<string> targetStrings = final[i];
            for (int j = 0; j < i; j++)
            {
                if (IsSimilar(final[j], targetStrings))
                {
                    final.Remove(final[j]);
                    break;
                }
            }
        }
    }

    private bool IsSimilar(IList<string> list, IList<string> targetStrings)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != targetStrings[i])
            {
                return false;
            }
        }
        
        return true;
    }

    private IList<string> CalculateResult(int[,] board)
    {
        IList<string> result = new List<string>();

        int boardSize = board.GetLength(0);
        for (int i = 0; i < boardSize; i++){
            string row = "";
            for (int j = 0; j < boardSize; j++){
                row += board[i,j] == 1 ? "Q" : ".";
            }
            result.Add(row);
        }

        return result;
    }

    private bool PlaceQueenSucceed(int posX, int posY, int[,] board, int queensLeft){
        board[posX, posY] = 1;
        queensLeft--;
        if (queensLeft <= 0){
            return true;
        }
        RefreshAccessiblePosition(board);
        
        int boardSize = board.GetLength(0);
        for (int i = 0; i < boardSize; i++){
            for (int j = 0; j < boardSize; j++){
                if (board[i,j] == 0 && PlaceQueenSucceed(i, j,  board, queensLeft) == true){
                    return true;
                }
            }
        }

        //redo placement
        board[posX, posY] = 0;
        RefreshAccessiblePosition(board);

        return false;
    }

    private void RefreshAccessiblePosition(int[,] board){
        for (int i = 0; i < board.GetLength(0) ; i++)
        {
            for (int j = 0; j < board.GetLength(1) ; j++)
            {
                board[i,j] = CalculateAccessibility(i, j, board);
            }
        }
    }

    private int CalculateAccessibility(int posX, int posY, int[,] board){
        if (board[posX, posY] == 1){
            return 1;
        }

        int boardSize = board.GetLength(0);

        //check rows and columns
        for (int pos = 0; pos < boardSize; pos++){
            if (board[posX, pos] == 1 || board[pos, posY] == 1){
                return -1;
            }
        }

        //check diagonal
        int i = posX;
        int j = posY;
        while(i < boardSize && j < boardSize){
            if(board[i,j] == 1){
                return -1;
            }

            i++;
            j++;
        }

        i = posX;
        j = posY;
        while(i >= 0 && j >= 0){
            if(board[i,j] == 1){
                return -1;
            }
            
            i--;
            j--;
        }

        i = posX;
        j = posY;
        while(i >= 0 && j < boardSize){
            if(board[i,j] == 1){
                return -1;
            }
            
            i--;
            j++;
        }

        i = posX;
        j = posY;
        while(i < boardSize && j >= 0){
            if(board[i,j] == 1){
                return -1;
            }
            
            i++;
            j--;
        }

        return 0;
    }

    private void RefreshBoard(int[,] board){
        int boardSize = board.GetLength(0);
        
        for (int i = 0; i < boardSize ; i++)
        {
            for (int j = 0; j < boardSize ; j++)
            {
                board[i,j] = 0;
            }
        }
    }
}
