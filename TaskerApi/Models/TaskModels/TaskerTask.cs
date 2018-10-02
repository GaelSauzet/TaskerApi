namespace TaskerApi.Models.TaskModels
{
    public class TaskerTask:BaseTask
    {
        public override BaseTaskType Type => BaseTaskType.Task;
        public virtual Epic Epic { get; set; }
    }
}