using DevProject.Business.Abstract;
using DevProject.DataAccess.Abstract;
using DevProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevProject.Business.Concrete
{
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        public List<Job> List()
        {
            return _jobDal.GetList();
        }

        public List<Job> GetByPersonnalId(int personalId)
        {
            if (personalId <= 0)
            {
                throw new System.NotImplementedException();
            }
            return _jobDal.GetList(M => M.PersonalId == personalId);
        }

        public List<Job> GetByDepId(int departmentId)
        {
            if (departmentId <= 0)
            {
                throw new System.NotImplementedException();
            }
            return _jobDal.GetList(m => m.DepartmentId == departmentId);
        }

        public Job GetById(int jobId)
        {
            if (jobId <= 0)
            {
                throw new System.NotImplementedException();
            }
            return _jobDal.Get(m => m.Id == jobId);
        }

        public void Add(Job job)
        {
            if (job == null)
            {
                throw new System.NotImplementedException();
            }
            _jobDal.Add(job);
        }

        public void Update(Job job)
        {
            if (job == null)
            {
                throw new System.NotImplementedException();
            }

            _jobDal.Update(job);
        }

        public void Delete(Job job)
        {
            if (job == null)
            {
                throw new NotImplementedException();
            }
            _jobDal.Delete(job);
        }

        public List<Job> GetJobsByName(string name)
        {
            if (name == null)
            {
                throw new NotImplementedException();
            }

            return _jobDal.GetList(m => m.Name == name);
        }

        public List<Job> GetJobsByUserId(int userId)
        {
            if (userId <= 0)
            {
                throw new NotImplementedException();
            }

            return _jobDal.GetList(m => m.PersonalId == userId);
        }

        public Job getirDepIdile(int Id)
        {
            return _jobDal.getirDepIdile(Id);
        }

        public List<Job> butunCedveler()
        {
            return _jobDal.butunCedveler();
        }

        public List<Job> butunCedveler(Expression<Func<Job, bool>> filter)
        {
            return _jobDal.butunCedveler(filter);
        }

        public List<Job> butunCedvelerTamamlanmayan(out int umumiSehife, int userId, int aktivSehife)
        {
            return _jobDal.butunCedvelerTamamlanmayan(out umumiSehife, userId, aktivSehife);
        }

        public int JobSayiTamamlanan(int userId)
        {
            return _jobDal.JobSayiTamamlanan(userId);
        }

        public int TamamlanmayanJobSayi(int userId)
        {
            return _jobDal.GetList(m => m.PersonalId == userId && !m.Status).Count;
        }

        public int TeyinEdilmemisJobSayi()
        {
            return _jobDal.GetList(m => m.PersonalId == null && !m.Status).Count;
        }

        public int TamamlanmisIsSayi()
        {
            return _jobDal.GetList(m => m.Status).Count;
        }
    }
}
