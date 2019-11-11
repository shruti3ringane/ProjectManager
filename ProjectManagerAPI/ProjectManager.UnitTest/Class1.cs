﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectManagerDAL;

namespace ProjectManager.UnitTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void DemoSampleTest()
        {
            Assert.That(1 == 1);
        }
        [Test]
        public void FindAllTasks()
        {
            TaskDAL pobj = new TaskDAL();
            List<ProjectManagerDAL.Task> tasks = pobj.GetAllTask();
            foreach (var x in tasks)
            {
                Assert.IsNotNull(x.Task_Id);
                Assert.IsNotNull(x.Task_Name);
                Assert.IsNotNull(x.Start_Date);
                Assert.IsNotNull(x.Priority);
                Assert.IsNotNull(x.End_Date);
                Assert.IsNotNull(x.Project_Id);
            }
        }
        [Test]
        public void CheckTaskById()
        {
            TaskDAL pobj = new TaskDAL();
            var p = pobj.GetTaskById(8);

            Assert.AreEqual(p.Task_Id, 8);
            Assert.AreEqual(p.Task_Name, "task1");
            Assert.AreEqual(p.Project_Id, 1);
        }
        [Test]
        public void CheckAllProjects()
        {
            ProjectDAL pobj = new ProjectDAL();
            List<ProjectManagerDAL.Project> project = pobj.GetAllProjects();
            foreach (var x in project)
            {
                Assert.IsNotNull(x.Project_Id);
                Assert.IsNotNull(x.Project_Name);
                Assert.IsNotNull(x.Start_Date);
                Assert.IsNotNull(x.Priority);
                Assert.IsNotNull(x.End_Date);
                Assert.IsNotNull(x.Project_Id);
            }
        }
        [Test]
        public void CheckProjectById()
        {
            ProjectDAL pobj = new ProjectDAL();
            var p = pobj.GetProjectById(1);

            Assert.AreEqual(p.Project_Id, 1);
            Assert.AreEqual(p.Project_Name, "Exotics");            
            Assert.AreEqual(p.Priority, 1);            
        }

    }
}
