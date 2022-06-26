using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;

namespace Project.HelpClasses
{
    public class FullCandidate
    {
        public CandidaleDto candidale { get; set; }
        public List<FavoriteReqDto> MyProperty { get; set; }
    }
}