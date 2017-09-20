﻿namespace MFFStats.Models.Domain
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Side { get; set; }
        public bool Tier2 { get; set; }
        public int PhysicalAtk { get; set; }
        public int EnergyAtk { get; set; }
        public decimal AtkSpeed { get; set; }
        public decimal CritRate { get; set; }
        public decimal CritDmg { get; set; }
        public decimal IgnoreDef { get; set; }
        public decimal IgnoreDodge { get; set; }
        public decimal FireDmg { get; set; }
        public decimal ColdDmg { get; set; }
        public decimal LightningDmg { get; set; }
        public decimal PoisonDmg { get; set; }
        public decimal MindDmg { get; set; }
        public int PhysicalDef { get; set; }
        public int EnergyDef { get; set; }
        public int HP { get; set; }
        public decimal RecoveryRate { get; set; }
        public decimal Dodge { get; set; }
        public decimal FireResist { get; set; }
        public decimal ColdResist { get; set; }
        public decimal LightningResist { get; set; }
        public decimal PoisonResist { get; set; }
        public decimal MindResist { get; set; }
        public decimal MoveSpd { get; set; }
        public decimal Debuff { get; set; }
        public decimal SkillCooldown { get; set; }
    }
}
