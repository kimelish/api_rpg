using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using api_rpg.Data;
using api_rpg.Dtos.Character;
using api_rpg.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace api_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService

    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public CharacterService(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            var character = _mapper.Map<Character>(newCharacter);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            throw new NotImplementedException();
        }

        private int GetUserId()
        {
            return int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        }
    }
}