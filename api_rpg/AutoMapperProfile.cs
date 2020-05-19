using System.Linq;
using api_rpg.Dtos.Character;
using api_rpg.Models;
using AutoMapper;

namespace api_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>().ForMember(dto => dto.Skills,
                c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));

            CreateMap<AddCharacterDto, Character>();
        }
    }
}