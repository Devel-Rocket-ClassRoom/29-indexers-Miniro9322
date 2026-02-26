using System;

// README.md를 읽고 코드를 작성하세요.

ScoreBoard board = new ScoreBoard(5);
board.Register("김민수", 85);
board.Register("이지영", 92);
board.Register("박서준", 78);

Console.WriteLine($"등록된 학생 수: {board.Count}\n");
for(int i = 0; i < board.Count; i++)
{
    Console.WriteLine($"{i}: {board[i]}");
}
Console.WriteLine();
Console.WriteLine($"김민수 점수: {board["김민수"]}점");
Console.WriteLine($"김민수 점수: {board["이지영"]}점");
Console.WriteLine($"김민수 점수: {board["홍길동"]}점\n");

board["김민수"] = 95;
Console.WriteLine($"김민수 수정된 점수: {board["김민수"]}점");