using System.Collections.Generic;
using api_rpg.Dtos.Skill;
using api_rpg.Models;

namespace api_rpg.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;

        public Models.Weapon Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }

        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}