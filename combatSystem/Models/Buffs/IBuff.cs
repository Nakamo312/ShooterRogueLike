using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IBuff
{
    string Name { get; }
    string Description { get; }
    IBuffable ApplyBuff(IBuffable stats);
    public event Action OnApplyBuff;
}

