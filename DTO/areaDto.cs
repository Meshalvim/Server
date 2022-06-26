using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using DTO;
namespace DTO
{
    class areaDto
    {
        public int id_area { get; set; }
        public string name_area { get; set; }

        public areaDto(int id_area, string name_area)
        {
            this.id_area = id_area;
            this.name_area = name_area;
        }
        public area convertTousers()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<areaDto, area>());
            var mapper = new Mapper(config);
            return mapper.Map<area>(this);
        }
        public static areaDto convertTouser_dto(area s)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<area, areaDto>());
            var mapper = new Mapper(config);
            return mapper.Map<areaDto>(s);
        }
    }
}
