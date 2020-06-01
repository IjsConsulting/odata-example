using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using odataExample.Models;

namespace odataExample.Controllers
{
    public class StudentController : ControllerBase
    {
        public StudentController()
        { }

        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Student> Get()
        {
            return new List<Student>
            {
                CreateNewStudent("Cody Allen", 130),
                CreateNewStudent("Todd Ostermeier", 160),
                CreateNewStudent("Viral Pandya", 140)
            };
        }

        private Student CreateNewStudent(string name, int score)
        {
            return new Student
            {
                Id = Guid.NewGuid(),
                Name = name,
                Score = score
            };
        }
    }
}