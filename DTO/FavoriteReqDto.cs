using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class FavoriteReqDto
    {
        public int id_candidate { get; set; }
        public int id_req       { get; set; }
        public int num_priority { get; set; }

        public FavoriteReqDto(int id_candidate, int id_req, int num_priority)
        {
            this.id_candidate = id_candidate;
            this.id_req = id_req;
            this.num_priority = num_priority;
        }

        public favorite_req convertTofavorite_reqs()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<FavoriteReqDto, favorite_req>());
            var mapper = new Mapper(config);
            return mapper.Map<favorite_req>(this);
        }
        public static FavoriteReqDto convertTofavorite_reqs_dto(favorite_req f)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<favorite_req, FavoriteReqDto>());
            var mapper = new Mapper(config);
            return mapper.Map<FavoriteReqDto>(f);
        }
    }
}
