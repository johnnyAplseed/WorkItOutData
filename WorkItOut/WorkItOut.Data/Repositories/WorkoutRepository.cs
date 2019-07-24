using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkItOut.Data.Interfaces;
using WorkItOut.Data.Models;
using Dapper;
using System.Data;
using System.Configuration;

namespace WorkItOut.Data.Repositories
{
    public static class WorkoutRepository
    {
        //public List<WorkoutModel> workouts = new List<WorkoutModel>();
        

        public static List<WorkoutModel> GetAllWorkouts()
        {
            string connString = ConfigurationManager.ConnectionStrings["workoutsdb"].ConnectionString;
            List<WorkoutModel> workouts = new List<WorkoutModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connString))
            {
                connection.Open();
                workouts = connection.Query<WorkoutModel>("select * from workout").ToList();
                connection.Close();
            };
            return workouts;
        }

        public static List<WorkoutModel> GetWorkout(int id)
        {
            //WorkoutModel workout = new WorkoutModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["workoutsdb"].ConnectionString))
            {
                connection.Open();
                List<WorkoutModel> workout = connection.Query<WorkoutModel>($"select * from workout where workoutid = '{id}'").ToList();
                connection.Close();
                return workout;
            };


        }
        public static List<WorkoutModel> GetWorkoutByCategory(string category)
        {
            //WorkoutModel workout = new WorkoutModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["workoutsdb"].ConnectionString))
            {
                connection.Open();
                List<WorkoutModel> workout = connection.Query<WorkoutModel>($"select * from workout where workoutCategory = '{category}'").ToList();
                connection.Close();
                return workout;
            };


        }

    }
}
