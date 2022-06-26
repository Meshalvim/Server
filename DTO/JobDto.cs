using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace DTO
{
   public class JobDto
    {
        public int      id_job          { get; set; }
        public int      id_comp          { get; set; }
        public int      id_city          { get; set; }
        public string   age_range       { get; set; }
        public int      id_gender       { get; set; }
        public string   seniority_range { get; set; }
        public int      amount          { get; set; }

        public JobDto(int id_job, int id_comp, int id_city, string age_range, int id_gender, string seniority_range, int amount)
        {
            this.id_job = id_job;
            this.id_comp = id_comp;
            this.id_city = id_city;
            this.age_range = age_range;
            this.id_gender = id_gender;
            this.seniority_range = seniority_range;
            this.amount = amount;
        }

        public job convertToJob()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<JobDto, job>());
            var mapper = new Mapper(config);
            return mapper.Map<job>(this);
        }
        public static JobDto convertTojob_dto(job s)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<job, JobDto>());
            var mapper = new Mapper(config);
            return mapper.Map<JobDto>(s);
        }
    }
}
