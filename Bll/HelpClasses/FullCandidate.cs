using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;

namespace Bll.HelpClasses
{
    public class FullCandidate
    {
        public CandidaleDto Candidate { get; set; }
        public List<FavoriteReqDto> FavoriteReqs { get; set; }
    }
}