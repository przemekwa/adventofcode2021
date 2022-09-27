using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode.Days
{
    public class Day4 : IExecute
    {

        List<BoardNumer[,]> boards = new List<BoardNumer[,]>();


        public void Execute()
        {
            var lines = File.ReadAllLines("Day4_input.txt");

            var bingoNumber = lines[0].Split(',').Select(x => int.Parse(x)).ToList();


            var lineCount = 0;
            var boarad = new BoardNumer[5, 5];

            foreach (var line in lines.Skip(2))
            {
                if (line == "")
                {
                    lineCount = 0;
                    continue;
                }

                if (lineCount == 0)
                {
                    boarad = new BoardNumer[5, 5];
                }

                var lineSplit = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < 5; i++)
                {
                    boarad[lineCount, i] = new BoardNumer( int.Parse(lineSplit[i]), false);
                }

                if (lineCount == 4)
                {
                    boards.Add(boarad);
                    lineCount = 0;
                    continue;
                }
                lineCount++;


            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                }
            }

        }
    }

    public record BoardNumer(int Number, bool IsMark)
    {
        
    }
   
}
