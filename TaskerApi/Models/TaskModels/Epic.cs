using System.Collections.Generic;

namespace TaskerApi.Models.TaskModels
{
    public class Epic:BaseTask
    {
        public override BaseTaskType Type => BaseTaskType.Epic;
        public virtual UserStory UserStory { get; set; }
        public virtual List<TaskerTask> Tasks { get; set; }
    }
}
