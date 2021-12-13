using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;

namespace CompAndDel.Pipes
{
    public class PipeConditional : IPipe
    {
        private IPipe pipeFalse;
        private IPipe pipeTrue;
        private IFilterConditional filter;

        public PipeConditional (IPipe pipeFalse, IPipe pipeTrue, IFilterConditional filter)
        {
            this.filter = filter;
            this.pipeFalse = pipeFalse;
            this.pipeTrue = pipeTrue;
        }

        public IPicture Send(IPicture picture)
        {
            picture = this.filter.Filter(picture);
            if(this.filter.conditional)
            {
                return this.pipeTrue.Send(picture);
            }
            else
            {
                return this.pipeFalse.Send(picture);
            }
        }
    }
}