namespace TaskerApi.Models.TaskModels
{
    public abstract class BaseTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Estimate { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public abstract BaseTaskType Type { get; }
    }
}