using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Database.Models
{
    public class AssignmentRepository : IAssignmentRepository
    {
        readonly SchoolDbContext _schoolDbContext;

        public AssignmentRepository(SchoolDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }

        public List<Assignment> All()
        {
            return _schoolDbContext.Assignments.ToList();
        }

        public Assignment Create(Assignment assignment)
        {
            _schoolDbContext.Assignments.Add(assignment);
            _schoolDbContext.SaveChanges();

            return assignment;
        }

        public Assignment Find(int id)
        {
            return _schoolDbContext.Assignments.SingleOrDefault(assignment => assignment.Id == id);
        }

        public Assignment Assign(int assId, int couId)
        {
            ///////// WITH TRACKING /////////
            Course course = _schoolDbContext.Courses.SingleOrDefault(c => c.Id == couId);
            var assignment = Find(assId);
            assignment.Course = course;
            _schoolDbContext.SaveChanges();


            /////// WITH SQL DATA /////////
            //_schoolDbContext.Database.ExecuteSqlRaw(
            //$"Update dbo.Assignments SET CourseForeignKey = {course} WHERE Id = {assId}");

            //var saved = false;
            //while (!saved)
            //{
            //    try
            //    {
            //        // Attempt to save changes to the database
            //        _schoolDbContext.SaveChanges();
            //        saved = true;
            //    }
            //    catch (DbUpdateConcurrencyException failure)
            //    {
            //        foreach (var entry in failure.Entries)
            //        {
            //            if (entry.Entity is Assignment)
            //            {
            //                entry.OriginalValues.SetValues(entry.GetDatabaseValues());
            //            }
            //        }
            //    }
            //}

            return Find(assId);
        }
    }
}
