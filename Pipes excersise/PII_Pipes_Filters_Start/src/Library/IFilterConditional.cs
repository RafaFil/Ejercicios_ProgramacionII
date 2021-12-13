using System;

namespace CompAndDel
{
    public interface IFilterConditional : IFilter
    {
        bool conditional {get;}
    }
}