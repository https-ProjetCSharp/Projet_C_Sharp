using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_d_ecole
{
    internal class OTPCode
    {
       
        public int Id { get; set; }
        public int IdUtilisateur { get; set; }
        public string Code { get; set; }
        public DateTime DateExpiration { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public OTPCode(int id, int idUtilisateur, string code, DateTime dateExpiration)
        {
            Id = id;
            IdUtilisateur = idUtilisateur;
            Code = code;
            DateExpiration = dateExpiration;
        }
        // Méthode pour vérifier si le code est expiré
        public bool EstExpire()
        {
            return DateTime.Now > DateExpiration;
        }
    }
}
