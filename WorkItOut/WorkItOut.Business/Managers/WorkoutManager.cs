using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkItOut.Business.Items;
using WorkItOut.Data.Models;
using WorkItOut.Data.Repositories;

namespace WorkItOut.Business.Managers
{
    public static class WorkoutManager
    {
        public static List<WorkoutItem> GetAllWorkouts()
        {
            List<WorkoutItem> result = new List<WorkoutItem>();

            List<WorkoutModel> dbWorkouts = WorkoutRepository.GetAllWorkouts();
            foreach (WorkoutModel dbWorkout in dbWorkouts)
            {
                result.Add(new WorkoutItem()
                {
                    WorkoutName = dbWorkout.workoutName
                });
            }

            return result;
        }

        public static WorkoutItem GetWorkoutById(int id)
        {
            return new WorkoutItem();
        }

        public static WorkoutItem GetWorkoutByCategory(string category)
        {
            return new WorkoutItem();
        }

        public static void SaveProfile(ProfileItem profile)
        {

        }
    }
}
