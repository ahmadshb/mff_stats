# MFF Stats
Stat calculator for Marvel Future Fight

# Features
- Character list view
- UI route to view by affinity
- Character details view (always view stats)
- UI route to view:
  1. Gear
  2. Skill (possibly not needed to display)
  3. ISO
  4. Custom Gear (possibly merge with 1.Gear)
  5. Uniform
- Native stats (possibly view on character details view)
- Card stats view

# DB Tables
1. Character
    - ID
    - Name
    - Tier
    - Level
    - Rank
    - Mastery
    - Type (affinity)
    - Species
    - Gender
    - Side
    - Stats
    - Gear/Custom Gear
    - Uru
    - Skill
    - ISO-8
    - Uniform
2. Stats
    - Ability (hero specific ability)
    - Attack
        - Physical Atk
        - Energy Atk
        - Atk Speed
        - Critical Rate
        - Critical Damage
        - Ignore Defense
        - Ignore Dodge
        - Fire Damage
        - Cold Damage
        - Lightning Damage
        - Poison Damage
        - Mind Damange
    - Defense
        - Physical Def
        - Energy Def
        - HP
        - Recovery Rate
        - Dodge
        - Fire Resist
        - Cold Resist
        - Lightning Resist
        - Poison Resist
        - Mind Resist
    - Debuff
        - Movement speed
        - Reduce Debuff Duration
        - Reduce Cooldown Duration
3. Gear/Custom Gear
    - Slot 1 (3 static stats)
    - Slot 2 (3 static stats)
    - Slot 3 (3 static stats)
    - Slot 4 (2 static, 1 changeable stats)
        - Critical Rate
        - Critical Damage
        - Attack Speed
        - Skill Cooldown
        - Recovery Rate
    - Custom Gear
4. Custom Gear
    - Rank
    - Primary Stat
    - Secondary Stat
    - Tertiary Stat
5. Uru
    - Rank
    - Slot 1
    - Slot 2
    - Slot 3
    - Slot 4
    - Slot 5
    - Is Amplified?
6. Skill
    - Leader
    - Passive
    - T2 Passive
    - 1
    - 2
    - 3
    - 4
    - 5
7. ISO-8 (need input)
8. Uniform (need input)
