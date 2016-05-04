using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainApp.ViewModels.Forms
{
    public class StartFormViewModel
    {
        public int NextActivityId { get; private set; } = 1;
        public int NextResourceId { get; private set; } = 1;

        public BindingList<ActivityViewModel> Activities { get; private set; } = new BindingList<ActivityViewModel>();
        public BindingList<ResourceViewModel> Resources { get; private set; } = new BindingList<ResourceViewModel>();

        #region Calculated fields
        [JsonIgnore]
        public Dictionary<int, ResourceViewModel> ResourceMap
        {
            get { return Resources.ToDictionary(r => r.Id); }
        }
        #endregion

        public ActivityViewModel CreateNewActivity()
        {
            var activity = new ActivityViewModel(this) { Id = NextActivityId++ };            
            return activity;
        }

        public void AddActivity(ActivityViewModel activity)
        {
            Activities.Add(activity);
        }

        public void DeleteActivity(ActivityViewModel activity)
        {
            Activities.Remove(activity);

            foreach (var model in Activities)
            {
                model.DeletePreactivity(activity.Id);
            }
        }

        public void AddNewResource()
        {
            Resources.Add(new ResourceViewModel() { Id = NextResourceId++ });
        }

        public void RemoveResource(ResourceViewModel resource)
        {
            foreach (var activity in Activities)
            {
                activity.RemoveResource(resource);
            }

            Resources.Remove(resource);
        }
    }
}
