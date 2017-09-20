using MFFStats.Models.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFFStats.Services
{
    public class CharactersService : BaseService
    {
        public int Insert(CharactersAddRequest model)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Characters_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    AddValues(model, cmd);

                    SqlParameter param = new SqlParameter("@Id", SqlDbType.Int);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                    id = (int)cmd.Parameters["@Id"].Value;
                }
                conn.Close();
            }
            return id;
        }

        public void Update(CharactersUpdateRequest model)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Characters_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", model.Id);
                    AddValues(model, cmd);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private static void AddValues(CharactersAddRequest model, SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Name", model.Name);
            cmd.Parameters.AddWithValue("@TypeId", model.TypeId);
            cmd.Parameters.AddWithValue("@SpeciesId", model.SpeciesId);
            cmd.Parameters.AddWithValue("@GenderId", model.GenderId);
            cmd.Parameters.AddWithValue("@SideId", model.SideId);
            cmd.Parameters.AddWithValue("@Tier2", model.Tier2);
            cmd.Parameters.AddWithValue("@PhysicalAtk", model.PhysicalAtk);
            cmd.Parameters.AddWithValue("@EnergyAtk", model.EnergyAtk);
            cmd.Parameters.AddWithValue("@AtkSpeed", model.AtkSpeed);
            cmd.Parameters.AddWithValue("@CritRate", model.CritRate);
            cmd.Parameters.AddWithValue("@CritDmg", model.CritDmg);
            cmd.Parameters.AddWithValue("@IgnoreDef", model.IgnoreDef);
            cmd.Parameters.AddWithValue("@IgnoreDodge", model.IgnoreDodge);
            cmd.Parameters.AddWithValue("@FireDmg", model.FireDmg);
            cmd.Parameters.AddWithValue("@ColdDmg", model.ColdDmg);
            cmd.Parameters.AddWithValue("@LightningDmg", model.LightningDmg);
            cmd.Parameters.AddWithValue("@PoisonDmg", model.PoisonDmg);
            cmd.Parameters.AddWithValue("@MindDmg", model.MindDmg);
            cmd.Parameters.AddWithValue("@PhysicalDef", model.PhysicalDef);
            cmd.Parameters.AddWithValue("@EnergyDef", model.EnergyDef);
            cmd.Parameters.AddWithValue("@HP", model.HP);
            cmd.Parameters.AddWithValue("@RecoveryRate", model.RecoveryRate);
            cmd.Parameters.AddWithValue("@Dodge", model.Dodge);
            cmd.Parameters.AddWithValue("@FireResist", model.FireResist);
            cmd.Parameters.AddWithValue("@ColdResist", model.ColdResist);
            cmd.Parameters.AddWithValue("@LightningResist", model.LightningResist);
            cmd.Parameters.AddWithValue("@PoisonResist", model.PoisonResist);
            cmd.Parameters.AddWithValue("@MindResist", model.MindResist);
            cmd.Parameters.AddWithValue("@MoveSpd", model.MoveSpd);
            cmd.Parameters.AddWithValue("@Debuff", model.Debuff);
            cmd.Parameters.AddWithValue("@SkillCooldown", model.SkillCooldown);
        }
    }
}
