using DevProject.Core.DataAccess.Conctete;
using DevProject.DataAccess.Abstract;
using DevProject.DataAccess.Concrete.EntityFramework.Context;
using DevProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevProject.DataAccess.Concrete.EntityFramework
{
    public class EfAppUserDal : EFEntityRepositoryBase<AppUser, DevProjectContext>, IAppUserDal
    {
        public List<AppUser> GetListNotAdmin()
        {
            /*select*from AspNetUsers inner join AspNetUserRoles 
             on AspNetUsers.Id=AspNetUserRoles.UserId
             inner join AspNetRoles 
             on AspNetRoles.Id=AspNetUserRoles.RoleId
             where AspNetRoles.Name='Member'
             */
            using var context = new DevProjectContext();

            return context.Users.Join
                (context.UserRoles, user => user.Id,
                    userRole => userRole.UserId, (resultUser, resultUserRole) => new
                    {
                        user = resultUser,
                        userRole = resultUserRole
                    }).Join(context.Roles, twoTableResult =>
                    twoTableResult.userRole.RoleId, role =>
                    role.Id, (resultTable, ResultRole) => new
                    {
                        user = resultTable.user,
                        userRoles = resultTable.userRole,
                        roles = ResultRole
                    }).Where(M => M.roles.Name == "Member")
                .Select(M => new AppUser()
                {
                    Id = M.user.Id,
                    Name = M.user.Name,
                    SurName = M.user.SurName,
                    Picture = M.user.Picture,
                    Email = M.user.Email,
                    UserName = M.user.UserName
                }).ToList();
        }

        public List<AppUser> GetListNotAdmin(out int toplamSayfa, string aranacaqKelime, int aktifSayfa = 1)
        {
            using var context = new DevProjectContext();

            var result = context.Users.Join
                (context.UserRoles, user => user.Id,
                    userRole => userRole.UserId, (resultUser, resultUserRole) => new
                    {
                        user = resultUser,
                        userRole = resultUserRole
                    }).Join(context.Roles, twoTableResult =>
                    twoTableResult.userRole.RoleId, role =>
                    role.Id, (resultTable, ResultRole) => new
                    {
                        user = resultTable.user,
                        userRoles = resultTable.userRole,
                        roles = ResultRole
                    }).Where(M => M.roles.Name == "Member")
                .Select(M => new AppUser()
                {
                    Id = M.user.Id,
                    Name = M.user.Name,
                    SurName = M.user.SurName,
                    Picture = M.user.Picture,
                    Email = M.user.Email,
                    UserName = M.user.UserName
                });

            toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);

            if (!string.IsNullOrWhiteSpace(aranacaqKelime))
            {
                result = result.Where(M => M.Name.ToLower()
                    .Contains(aranacaqKelime.ToLower()) || M.SurName.ToLower()
                    .Contains(aranacaqKelime.ToLower()));
                toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);
            }

            result = result.Skip((aktifSayfa - 1) * 3).Take(3);

            return result.ToList();
        }


        public string IscininIsSayi()
        {
            /*
             * select *from AspNetUsers U join dbo.Jobs J on U.JobId=J.Id
             */
            using var context = new DevProjectContext();
            return context.AppUsers.Join(context.Jobs, user => user.JobId, job => job.Id, (Isci, IS) => new
            {
                user = Isci,
                job = IS
            }).Count(m => m.user.JobId == m.job.Id).ToString();
        }

        public List<AppUser> IsUzreIsciSayi(out int toplamSayfa, int jobId, string aranacaqKelime, int aktifSayfa = 1)
        {
            using var context = new DevProjectContext();
            var result = context.Users.Join
                (context.UserRoles, user => user.Id,
                    userRole => userRole.UserId, (resultUser, resultUserRole) => new
                    {
                        user = resultUser,
                        userRole = resultUserRole
                    }).Join(context.Roles, twoTableResult =>
                    twoTableResult.userRole.RoleId, role =>
                    role.Id, (resultTable, ResultRole) => new
                    {
                        user = resultTable.user,
                        userRoles = resultTable.userRole,
                        roles = ResultRole
                    }).Where(M => M.roles.Name == "Member")
                .Where(M => M.user.JobId == jobId)
                .Select(M => new AppUser()
                {
                    Id = M.user.Id,
                    Name = M.user.Name,
                    SurName = M.user.SurName,
                    Picture = M.user.Picture,
                    Email = M.user.Email,
                    UserName = M.user.UserName
                });

            toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);

            if (!string.IsNullOrWhiteSpace(aranacaqKelime))
            {
                result = result.Where(M => M.Name.ToLower()
                    .Contains(aranacaqKelime.ToLower()) || M.SurName.ToLower()
                    .Contains(aranacaqKelime.ToLower()));
                toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);
            }

            result = result.Skip((aktifSayfa - 1) * 3).Take(3);

            return result.ToList();
        }

        public List<DualHelper> EnCoxIsTamamlamisPersonallar()
        {
            using var context = new DevProjectContext();
            return context.Jobs
                .Include(m => m.User).Where(m => m.Status)
                .GroupBy(m => m.User.UserName)
                .OrderByDescending(m => m.Count()).Take(5)
                .Select(m => new DualHelper()
                {
                    Name = m.Key,
                    JobCount = m.Count()
                }).ToList();
        }
        public List<DualHelper> EnCoxIsdeCalisanPersonallar()
        {
            using var context = new DevProjectContext();
            return context.Jobs
                .Include(m => m.User)
                .Where(m => !m.Status && m.PersonalId != null)
                .GroupBy(m => m.User.UserName)
                .OrderByDescending(m => m.Count()).Take(5)
                .Select(m => new DualHelper()
                {
                    Name = m.Key,
                    JobCount = m.Count()
                }).ToList();
        }
    }
}
