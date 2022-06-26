using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SchedulingDto
    {
        public int id_schedule { get; set; }
        public int id_candidate { get; set; }
        public int id_job { get; set; }

        public SchedulingDto(int id_schedule, int id_candidate, int id_job)
        {
            this.id_schedule = id_schedule;
            this.id_candidate = id_candidate;
            this.id_job = id_job;
        }

        public scheduling convertToscheduling()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<SchedulingDto, scheduling>());
            var mapper = new Mapper(config);
            return mapper.Map<scheduling>(this);
        }
        public static SchedulingDto convertToscheduling_dto(scheduling c)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<scheduling, SchedulingDto>());
            var mapper = new Mapper(config);
            return mapper.Map<SchedulingDto>(c);
        }
    }
}
