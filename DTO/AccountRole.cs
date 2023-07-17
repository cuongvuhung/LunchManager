using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LunchManager.DTO
{
    [Table("AccountRoles")]
    public class AccountRole
    {
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int RoleId { get; set; }

        public AccountRole(int id, int accountid, int roleid)
        {
            Id = id;
            AccountId = accountid;
            RoleId = roleid;
        }

        public AccountRole()
        {
        }

    }
}
