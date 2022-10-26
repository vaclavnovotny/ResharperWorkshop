using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ResharperWorkshop.Helpers
{
    internal class GetData : IRequest<IEnumerable<object>>
    {
    }
}
