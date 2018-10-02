using System.Collections.Generic;
using System.Threading.Tasks;
using TaskerApi.Models;
using TaskerApi.Models.TaskModels;

namespace TaskerApi.Interfaces
{
    public interface IProjectService
    {
        Task<Project> Create();
        Task<Project> Update(Project project);
        Task<Project> Delete(long projectId);
        Task<List<BaseTask>> GetAllTask();
        Task<Project> AddTask(List<UserStory> userStories, long projectId);
    }
}