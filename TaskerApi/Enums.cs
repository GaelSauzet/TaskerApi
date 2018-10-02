namespace TaskerApi
{
    public enum BaseTaskType
    {
        Default,
        UserStory,
        Epic,
        Task
    }

    public enum Priority
    {
        NiceToHave,
        Low,
        Medium,
        High,
        Urgent
    }

    public enum Status
    {
        ToDo,
        InProgress,
        Done
    }
}