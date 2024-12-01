using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBuffable
{
    public event Action OnBuffed;
    public event Action OnDebuffed;
}

