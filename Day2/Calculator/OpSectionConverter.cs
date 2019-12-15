using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Day2.Resources.Enumerable;
using Day2.Resources.Module;

namespace Day2.Calculator
{
    public class OpSectionConverter
    {
    

    private List<OpSection> ConvertToOpSectionList(int[] sequence)
    {
    return CreateSections(sequence)
        .Select(ConvertToOpSection)
        .ToList();
    }

    private List<int[]> CreateSections(int[] sequence)
    {
    var result = new List<int[]>();
    var counter = 0;

        while (counter < sequence.Length)
    {
        if ((OpCode)sequence[counter] == OpCode.Skip)
        {
            result.Add(new int[]
            {
                sequence[counter]
            });
            counter += 1;
        }
        else if ((OpCode)sequence[counter] == OpCode.Add ||
                 (OpCode)sequence[counter] == OpCode.Multiply)
        {
            result.Add(new int[]
            {
                sequence[counter],
                sequence[counter + 1],
                sequence[counter + 2],
                sequence[counter + 3],
            });
            counter += 4;
        }
        else
        {
            throw new Exception("Invalid Sequence, OpCode not Recognized");
        }
    }

    return result;
    }

    private OpSection ConvertToOpSection(int[] section)
    {
    if (section.Length == 1)
    {
        return new OpSection
        {
            OpCode = (OpCode)section[0]
        };
    }

    return new OpSection
    {
        OpCode = (OpCode)section[0],
        NumFirst = section[1],
        NumSecond = section[2],
        WritePosition = section[3]
    };
    }

    }
}
