using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
class LibraryManager 
{ 
    private Dictionary<string, long[]> memberMap = new Dictionary<string, long[]>(); 
    public int addMember(string memberId)
    {
        if(!memberMap.ContainsKey(memberId))
        {
            memberMap[memberId] = new long[3];
        }
        return 1;
    }
     public int imposeFine(string memberId, long amount)
    {
        if(memberMap.ContainsKey(memberId))
        {
            memberMap[memberId][0] += amount;
            memberMap[memberId][1] += amount;
        }
        return 1;
    }
    public int payFine(string memberId, long amount)
    {
        if(memberMap.ContainsKey(memberId))
        {
            long total = memberMap[memberId][0];
            long pay = Math.Min(total, amount);
            memberMap[memberId][0] -= pay;
            memberMap[memberId][2] += pay;
        }
        return 1;
    }
    public string getDetails(string memberId)
    {
        if(memberMap.ContainsKey(memberId))
        {
            long[] data = memberMap[memberId];
            return $"{memberId} {data[0]} {data[1]} {data[2]}";
        }
        else
        {
            return $"Member not found";
        }
    }
}