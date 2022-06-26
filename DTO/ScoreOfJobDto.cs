using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace DTO
{
    public class ScoreOfJobDto
    {
        public int id_score_of_jobs { get; set; }
        public int id_job { get; set; }
        public double score_time { get; set; }
        public double score_gender { get; set; }
        public double score_age { get; set; }
        public double score_seniority { get; set; }

        public score_of_jobs convertToScoreOfJobs()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<ScoreOfJobDto, score_of_jobs>());
            var mapper = new Mapper(config);
            return mapper.Map<score_of_jobs>(this);
        }
        public static ScoreOfJobDto convertToscore_dto(score_of_jobs s)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<score_of_jobs, ScoreOfJobDto>());
            var mapper = new Mapper(config);
            return mapper.Map<ScoreOfJobDto>(s);
        }
    }
}
