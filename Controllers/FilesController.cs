using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.Controllers;

[Controller]
[Route("api/files")]
public class FilesController : ControllerBase
{

    private readonly FileExtensionContentTypeProvider _contentType;

    public FilesController(FileExtensionContentTypeProvider f)
    {
        _contentType = f ?? throw new ArgumentNullException(nameof(f));
    }
    
    [HttpGet("{fileId}")]
    public ActionResult GetFile(int fileId)
    {
        const string path = "cv.pdf";
        if (!System.IO.File.Exists(path))
            return NotFound();

        if (!_contentType.TryGetContentType(path, out var contentType))
            contentType = "application/octet-stream";
        
        var bytes = System.IO.File.ReadAllBytes(path);
        return File(bytes, contentType, Path.GetFileName(path));
    }
}