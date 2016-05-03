using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.ViewModels.Forms
{
    class StartFormViewModel
    {
        public int NextActivityId { get; private set; } = 1;
        public int NextResourceId { get; private set; } = 1;

        public BindingList<ActivityViewModel> Activities { get; private set; } = new BindingList<ActivityViewModel>();
        public BindingList<ResourceViewModel> Resources { get; private set; } = new BindingList<ResourceViewModel>();


        public void AddNewActivity()
        {
            Activities.Add(new ActivityViewModel() { Id = NextActivityId++ });
        }

        public void AddNewResource()
        {
            Resources.Add(new ResourceViewModel() { Id = NextResourceId++ });
        }

        public void RemoveResource(ResourceViewModel resource)
        {
            Resources.Remove(resource);
        }
    }
}
