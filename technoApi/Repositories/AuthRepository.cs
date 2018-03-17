namespace technoApi.Repositories
{
    public class AuthRepository: IUserRepository
    {
        public UserRepository(TechnoContext technoContext)
            : base(technoContext)
        {}
    }
}