using System.Collections.Generic;

namespace TaskerApi.Models.TaskModels
{
    public class UserStory : BaseTask
    {
        public override BaseTaskType Type => BaseTaskType.UserStory;
        public virtual List<Epic> Epics { get; set; }
    }
}
