using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            int lastTick = 0;
            while(true)
            {
                #region 프레임 관리
                // 만약에 경과한 시간이 1/30초보다 작다면(1/30초마다 코드를 실행시키기 위해)
                int currentTick = System.Environment.TickCount;
                if(currentTick - lastTick < WAIT_TICK)
                {
                    continue;
                }

                lastTick = currentTick;
                #endregion

                // 입력
                // 로직
                // 렌더링
                Console.SetCursorPosition(0, 0);
                
                for(int i = 0; i < 25; ++i)
                {
                    for(int j = 0; j < 25; ++j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
