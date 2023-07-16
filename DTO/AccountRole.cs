namespace LunchManager.DTO
{
    public class AccountRole
    {
        public int Id { get; set; }
        public int AcountId { get; set; }
        public int RoleId { get; set; }

        public AccountRole(int id, int acountId, int roleId)
        {
            Id = id;
            AcountId = acountId;
            RoleId = roleId;
        }
    }
}
