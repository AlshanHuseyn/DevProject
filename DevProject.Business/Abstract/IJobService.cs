using DevProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevProject.Business.Abstract
{
    public interface IJobService
    {
        /// <summary>
        /// İşçiləri listələmək
        /// </summary>
        /// <returns></returns>
        List<Job> List();
        /// <summary>
        /// Personal id-yə görə işçiləri listələmək
        /// </summary>
        /// <returns></returns>
        List<Job> GetByPersonnalId(int personalId);
        /// <summary>
        /// Department id-yə görə  işçiləri listələmək
        /// </summary>
        /// <returns></returns>
        List<Job> GetByDepId(int departmentId);
        /// <summary>
        /// Job id-yə görə işçi gətirmək
        /// </summary>
        /// <returns></returns>
        Job GetById(int jobId);

        /// <summary>
        /// İşçi əlavə etmək
        /// </summary>
        /// <returns></returns>
        void Add(Job job);
        /// <summary>
        /// İşçi məlumatlarında dəyişiklik etmək
        /// </summary>
        /// <returns></returns>
        void Update(Job job);
        /// <summary>
        /// İşçi silmək
        /// </summary>
        /// <returns></returns>
        void Delete(Job job);

        /// <summary>
        /// Job name-yə görə işçi gətirmək
        /// </summary>
        /// <returns></returns>
        List<Job> GetJobsByName(string name);
        List<Job> GetJobsByUserId(int userId);
        Job getirDepIdile(int Id);
        List<Job> butunCedveler();
        List<Job> butunCedveler(Expression<Func<Job, bool>> filter);

        public List<Job> butunCedvelerTamamlanmayan
            (out int umumiSehife, int userId, int aktivSehife = 1);
        int JobSayiTamamlanan(int userId);
        int TamamlanmayanJobSayi(int userId);
        int TeyinEdilmemisJobSayi();
        int TamamlanmisIsSayi();
    }
}
