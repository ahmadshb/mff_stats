﻿CREATE PROCEDURE [dbo].[Characters_SelectAll]
AS
/*

EXEC Characters_SelectAll

*/
BEGIN
	SELECT 
		ch.[Id]
		, ch.[Name]
		, tp.[Type]
		, sp.[Species]
		, g.[Gender]
		, sd.[Side]
		, ch.[Tier2]
		, ch.[PhysicalAtk]
		, ch.[EnergyAtk]
		, ch.[AtkSpeed]
		, ch.[CritRate]
		, ch.[CritDmg]
		, ch.[IgnoreDef]
		, ch.[IgnoreDodge]
		, ch.[FireDmg]
		, ch.[ColdDmg]
		, ch.[LightningDmg]
		, ch.[PoisonDmg]
		, ch.[MindDmg]
		, ch.[PhysicalDef]
		, ch.[EnergyDef]
		, ch.[HP]
		, ch.[RecoveryRate]
		, ch.[Dodge]
		, ch.[FireResist]
		, ch.[ColdResist]
		, ch.[LightningResist]
		, ch.[PoisonResist]
		, ch.[MindResist]
		, ch.[MoveSpd]
		, ch.[Debuff]
		, ch.[SkillCooldown]
	FROM
		[Characters] ch JOIN [Gender] g ON [GenderId] = g.[Id]
		JOIN [Side] sd ON [SideId] = sd.[Id]
		JOIN [Species] sp ON [SpeciesId] = sp.[Id]
		JOIN [Type] tp ON [TypeId] = tp.[Id]
END