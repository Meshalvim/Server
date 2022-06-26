using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RequiermentsDto
    {
        public int id_req { get; set; }
        public string name_req { get; set; }

        public RequiermentsDto(int id_req, string name_req)
        {
            this.id_req = id_req;
            this.name_req = name_req;
        }


        public requirement convertTorequirements()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<RequiermentsDto, requirement>());
            var mapper = new Mapper(config);
            return mapper.Map<requirement>(this);
        }
        public static RequiermentsDto convertTorequirements_dto(requirement s)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<requirement, RequiermentsDto>());
            var mapper = new Mapper(config);
            return mapper.Map<RequiermentsDto>(s);
        }
    }
}
