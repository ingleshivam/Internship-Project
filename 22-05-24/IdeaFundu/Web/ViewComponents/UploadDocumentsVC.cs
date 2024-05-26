using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace Web.ViewComponents
{
    public class UploadDocumentsVC: ViewComponent
    {
        IIdeaDocuments IdeaDocumentsRepo;
        IDocumentType DocumentTypeRepo;
        public UploadDocumentsVC(IIdeaDocuments _IdeaDocumentsRepo, IDocumentType _DocumentTypeRepo)
        {
            IdeaDocumentsRepo = _IdeaDocumentsRepo;
            DocumentTypeRepo = _DocumentTypeRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            ViewBag.DocumentTypeID = new SelectList(this.DocumentTypeRepo.GetAll(), "DocumentTypeId", "DocumentTypeName");
            ViewBag.IdeaID = id;
            return View();
        }
    }
}
