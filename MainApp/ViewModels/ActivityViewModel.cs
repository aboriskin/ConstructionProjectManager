using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainApp.ViewModels.Forms;
using Newtonsoft.Json;

namespace MainApp.ViewModels
{
    public class ActivityViewModel
    {
        public ActivityViewModel(StartFormViewModel startForm)
        {
            _startForm = startForm;
        }

        private readonly StartFormViewModel _startForm; 

        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public List<int> PreActivityIds { get; set; } = new List<int>();        
        public bool IsStartLimited { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public List<ActivityResourceViewModel> Resources { get; set; } = new List<ActivityResourceViewModel>();

        #region CalculatedFields

        [JsonIgnore]
        public string PreActivitiesDescription
        {
            get { return String.Join(", ", PreActivityIds); }
        }

        [JsonIgnore]
        public string ResourceDescription
        {
            get
            {
                return String.Join(", ",
                    Resources.Select(r => String.Format("{0}: {1}",
                    _startForm.ResourceMap[r.ResourceId].ResourceName,
                    r.Amount)));
            }
        }

        [JsonIgnore]
        public string TimeConstraintDescription
        {
            get
            {
                if (From == null && To == null)
                {
                    return null;
                }

                string result = "";

                if (From != null)
                {
                    result += String.Format("{0:d} ≤ ", From);
                }

                result += IsStartLimited ? "Start" : "Finish";

                if (To != null)
                {
                    result += String.Format(" ≤ {0:d}", To);
                }

                return result;
            }
        }
        #endregion

        public void RemoveResource(ResourceViewModel resource)
        {
            var itemToRemove = Resources.FirstOrDefault(r => r.ResourceId == resource.Id);
            if (itemToRemove != null)
            {
                Resources.Remove(itemToRemove);
            }
        }

        public void DeletePreactivity(int activityId)
        {
            PreActivityIds.Remove(activityId);
        }
    }
}
