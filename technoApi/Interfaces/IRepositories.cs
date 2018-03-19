using technoApi.Interfaces;
using technoApi.Models.User;
using technoApi.Models.Profile;

namespace technoApi.Repositories
{
    public interface IProfileRepository : IEntityBaseRepository<Profile> { }
    public interface IUserRepository : IEntityBaseRepository<User> { }
    public interface ITitleRepository : IEntityBaseRepository<Title> { }
    public interface IJobTypeRepository : IEntityBaseRepository<JobType> { }
    public interface IJobTitleRepository : IEntityBaseRepository<JobTitle> { }
    public interface IQualificationRepository : IEntityBaseRepository<Qualification> { }
    public interface IJobHistoryRepository : IEntityBaseRepository<JobHistory> { }
}