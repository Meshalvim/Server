using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GenderDto
    {
        public int id_gender { get; set; }
        public string name_gender { get; set; }

        public GenderDto(int id_gender, string name_gender)
        {
            this.id_gender = id_gender;
            this.name_gender = name_gender;
        }

        public gender convertTogender()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<GenderDto, gender>());
            var mapper = new Mapper(config);
            return mapper.Map<gender>(this);
        }
        public static GenderDto convertTogender_dto(gender g)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<gender, GenderDto>());
            var mapper = new Mapper(config);
            return mapper.Map<GenderDto>(g);
        }
    }
}
