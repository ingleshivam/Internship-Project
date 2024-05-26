using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class ShowDocumentsVC : ViewComponent
    {
        IIdeaDocuments IdeaDocumentsRepo;
        public ShowDocumentsVC(IIdeaDocuments _IdeaDocumentsRepo)
        {
            IdeaDocumentsRepo = _IdeaDocumentsRepo;
        }

        public IViewComponentResult Invoke()
        {
            var rec = this.IdeaDocumentsRepo.GetAll();
            return View(rec.ToList());
        }
    }
}