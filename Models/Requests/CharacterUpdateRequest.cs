using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFFStats.Models.Requests
{
    public class CharacterUpdateRequest : CharacterAddRequest
    {
        public int Id { get; set; }
    }
}
