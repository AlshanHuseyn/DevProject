using DevProject.Business.Abstract;
using DevProject.Entities.Concrete;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;

namespace DevProject.WebUI.TagHelpers
{
    [HtmlTargetElement("getUserId")]
    public class JobUserIdTagHelper : TagHelper
    {
        private IAppUserService _appUser;
        private IJobService _jobService;

        public JobUserIdTagHelper(IAppUserService appUser, IJobService jobService)
        {
            _appUser = appUser;
            _jobService = jobService;
        }

        public int UserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<Job> jobs = _jobService.GetJobsByUserId(UserId);
            var tamamlananIsSayi = jobs.Where(m => m.Status).Count();
            var calisdigiIsSayi = jobs.Where(m => !m.Status).Count();

            string htmlString = $"<strong>Tamamladigi Is Sayi : </strong>" +
                                $"{tamamlananIsSayi} <br> <strong> Calisdig Is Sayi :" +
                                $"</strong> {calisdigiIsSayi}";
            output.Content.SetHtmlContent(htmlString);

        }
    }
}
