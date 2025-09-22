using System;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
        IList<IList<string>> result = SolveNQueens(5);
        foreach (var row in result)
        {
            foreach (var col in row)
            {
                Debug.Log(col);
            }
        }
    }
    
    private IList<IList<string>> solutions = new List<IList<string>>();
    private int[] resultQueens;
    private int n;
    
    public IList<IList<string>> SolveNQueens(int n)
    {
        this.n = n;
        resultQueens = new int[n];
        PlaceQueen(0);
        return solutions;
    }
    
    private void PlaceQueen(int row)
    {
        if (row == n)
        {
            CreateResultString();
            return;
        }
        
        for (int col = 0; col < n; col++)
        {
            if (CanBePlaced(row, col))
            {
                resultQueens[row] = col;
                PlaceQueen(row + 1);
            }
        }
    }
    
    private bool CanBePlaced(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            if (resultQueens[i] == col || Math.Abs(row - i) == Math.Abs(col - resultQueens[i]))
            {
                return false;
            }
        }
        
        return true;
    }
    
    private void CreateResultString()
    {
        IList<string> solution = new List<string>();
    
        for (int row = 0; row < n; row++)
        {
            char[] rowArray = new char[n];
            for (int col = 0; col < n; col++)
            {
                rowArray[col] = '.';
            }
            
            rowArray[resultQueens[row]] = 'Q';
            solution.Add(new string(rowArray));
        }
    
        solutions.Add(solution);
    }
}
