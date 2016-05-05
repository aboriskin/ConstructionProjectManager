using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;

namespace MainApp.Helpers
{
    class CsvExporter
    {
        public void Export(
            string fileName,
            List<Activity> activities,
            string separator = ";")
        {
            using (var writer = new StreamWriter(fileName))
            {
                writer.WriteLine(String.Join(separator, new[] { "Id", "Name", "Start Date", "Finish Date" }));
                foreach (var activity in activities.OrderBy(a => a.StartDate))
                {
                    writer.WriteLine(
                        String.Join(separator,
                        new[] { activity.Id.ToString(),
                            activity.Name,
                            activity.StartDate.Value.ToShortDateString(),
                            activity.FinishDate.Value.ToShortDateString()}
                        )
                    );
                }
                writer.Close();
            }
        }
    }
}
